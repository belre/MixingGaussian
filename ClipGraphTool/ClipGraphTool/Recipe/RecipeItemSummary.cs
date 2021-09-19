using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using System.Text.RegularExpressions;

namespace ClipGraphTool.Recipe
{
    public class RecipeItemSummary
    {
        public int Index
        {
            get;
            protected set;
        }

        public string AliasName
        {
            get;
            protected set;
        }

        public string FilePath
        {
            get;
            protected set;
        }

        public string[] ImagePath
        {
            get;
            protected set;
        }

        protected RecipeItemSummary()
        {

        }

        public static RecipeItemSummary Create(string filepath)
        {
            var filename = Path.GetFileName(filepath);
            MatchCollection matchitems = Regex.Matches(filename, @"^\d{8}_\d{6}_(\d{3})_(\w+).csv$");

            if (matchitems.Count != 0)
            {
                RecipeItemSummary obj = new RecipeItemSummary();
                obj.Index = int.Parse(Path.GetFileName(matchitems[0].Groups[1].Value));
                obj.AliasName = Path.GetFileName(matchitems[0].Groups[2].Value);
                obj.FilePath = filepath;

                // 画像ファイルパス取得
                List<string> imagepathlist = new List<string>();
                var bmpfiles = Directory.GetFiles(Path.GetDirectoryName(filepath), "*.bmp");
                var basetext = Path.GetFileNameWithoutExtension(filepath);
                foreach (var bmpfile in bmpfiles)
                {
                    if (bmpfile.Contains(basetext))
                    {
                        imagepathlist.Add(bmpfile);
                    }
                }
                obj.ImagePath = imagepathlist.ToArray();
                
                
                return obj;
            }
            else
            {
                return null;
            }
        }

        public static RecipeItemSummary Bind(RecipeItemSummary org1, RecipeItemSummary org2)
        {
            RecipeItemSummary dest = new RecipeItemSummary()
            {
                Index = -1,
                AliasName = "<Mixed>",
                FilePath = null,
                ImagePath = new string[org1.ImagePath.Length + org2.ImagePath.Length] 
            };

            for( int i = 0 ; i < dest.ImagePath.Length; i++ ) {
                if (i < org1.ImagePath.Length)
                {
                    dest.ImagePath[i] = org1.ImagePath[i];
                }
                else
                {
                    dest.ImagePath[i] = org2.ImagePath[i - org1.ImagePath.Length];
                }
            }

            return dest;
        }

        public Recipe.GraphToolData GetGraphToolData()
        {
            var csvdata = CsvData.Read(FilePath);
            if(csvdata.DataType == CsvData.ECsvDataType.INVALID)
            {
                return null;
            }

            Recipe.GraphToolData obj = new GraphToolData();
            obj.ParseData(this, csvdata);

            return obj;
        }

        public override string ToString()
        {
            return string.Format("{0:000} {1}", Index, AliasName);
        }


    }
}
