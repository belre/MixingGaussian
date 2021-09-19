using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Text.RegularExpressions;

namespace ClipGraphTool
{
    public partial class dlg_mainform : Form
    {     
        public dlg_mainform()
        {
            InitializeComponent();
        }


        private void ui_getdata_Click(object sender, EventArgs e)
        {


        }

        private void btn_referfolder_Click(object sender, EventArgs e)
        {
            string datapath = System.IO.Directory.GetCurrentDirectory() + @"\Export\";

            if (!Directory.Exists(datapath))
            {
                MessageBox.Show("データフォルダが見つかりませんでした");
                return;
            }

            // フォルダはyyyyMMdd_HHmmSSの形式で保存される
            // 正規表現を使用して文字列表現検索を行い、
            // もしも一致していたら、その中で最も最新のフォルダかを判定する
            string[] dirs = Directory.GetDirectories(datapath);
            DateTime dt_recent = DateTime.MinValue;
            string target = null;
            string attribute = "";

            foreach (var dir in dirs)
            {
                var foldername = Path.GetFileName(dir);
                MatchCollection matchitems = Regex.Matches(foldername, @"^(\d{4})(\d{2})(\d{2})_(\d{2})(\d{2})(\d{2})_?(\w+)?$");

                if (matchitems.Count != 0)
                {
                    if (matchitems[0].Groups.Count == 8)
                    {
                        DateTime dt = new DateTime(int.Parse(matchitems[0].Groups[1].Value),
                                                    int.Parse(matchitems[0].Groups[2].Value),
                                                    int.Parse(matchitems[0].Groups[3].Value),
                                                    int.Parse(matchitems[0].Groups[4].Value),
                                                    int.Parse(matchitems[0].Groups[5].Value),
                                                    int.Parse(matchitems[0].Groups[6].Value)
                                                    );

                        if (dt > dt_recent && matchitems[0].Groups[7].Value == attribute)
                        {
                            dt_recent = dt;
                            target = dir;
                        }
                    }
                 }
            }

            ReferFromPath(target);
        }

        private void ReferFromPath(string target)
        {
            // モードレスウインドウの破棄のため、
            // ファイル読込時にGCを実行しておく
            GC.Collect();

            // targetで指定されたファイルの一覧取得
            List<Recipe.RecipeItemSummary> lists = new List<Recipe.RecipeItemSummary>();
            string[] files = Directory.GetFiles(target, "*.csv");
            listbox_recipe.Items.Clear();
            foreach (var file in files)
            {
                var obj = Recipe.RecipeItemSummary.Create(file);

                if (obj != null)
                {
                    lists.Add(obj);
                }
            }

            // 番号順ソート
            lists.Sort((a, b) => (a.Index - b.Index));

            // 表示
            listbox_recipe.Items.Clear();
            foreach (var obj in lists)
            {
                listbox_recipe.Items.Add(obj);
            }
        }

        private void btn_getdata_Click(object sender, EventArgs e)
        {
            if (listbox_recipe.SelectedItems != null)
            {
                List<Recipe.GraphToolData> particledata = new List<Recipe.GraphToolData>();

                foreach (var item in listbox_recipe.SelectedItems)
                {
                    var concreteitem = (Recipe.RecipeItemSummary)item;
                    Recipe.GraphToolData dataobj = concreteitem.GetGraphToolData();


                    if (dataobj != null)
                    {
                        if (dataobj.CsvData.DataType == Recipe.CsvData.ECsvDataType.GRAPH)
                        {
                            GraphForm graphform = new GraphForm(dataobj);
                            graphform.Show();
                        }
                        else if (dataobj.CsvData.DataType == Recipe.CsvData.ECsvDataType.STATWITHLABELDATA)
                        {
                            particledata.Add(dataobj);
                        }
                    }
                }

                if (particledata.Count != 0)
                {
                    StatWithLabelColorForm statform = new StatWithLabelColorForm(particledata.ToArray());
                    statform.Show();
                }
            }
        }

        private void btn_updatefromfolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Properties.Settings.Default.DataPath;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ReferFromPath( Path.GetDirectoryName(dialog.FileName));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
