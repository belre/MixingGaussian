using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ClipGraphTool.Recipe
{
    public class CsvResultData
    {
        public int Status
        {
            get;
            private set;
        }
        public decimal Result
        {
            get;
            private set;
        }

        public CsvResultData(int status, decimal result)
        {
            Status = status;
            Result = result;
        }
    }

    public class CsvData
    {
        public enum ECsvDataType{
            INVALID,
            GRAPH,
            STATWITHLABELDATA
        }

        public Dictionary<string, List<CsvResultData>> ResultDecimal
        {
            get;
            protected set;
        }

        public ECsvDataType DataType {
            get
            {
                if (ResultDecimal == null || ResultDecimal.Count == 0)
                {
                    return ECsvDataType.INVALID;
                }

                if (ResultDecimal.Keys.Contains("X") && ResultDecimal.Keys.Contains("Y"))
                {
                    return ECsvDataType.STATWITHLABELDATA;
                }
                else
                {
                    return ECsvDataType.GRAPH;
                }
            }
        }


        protected CsvData()
        {

        }




        public static CsvData Read(string path)
        {
            CsvData data = new CsvData();

            Dictionary<string, List<CsvResultData>> dict_result = new Dictionary<string, List<CsvResultData>>();
            using (var stream = new StreamReader(path, Encoding.GetEncoding("Shift-jis")))
            {
                string text = null;
                int status = -1;
                while ( (text=stream.ReadLine()) != null)
                {
                    string[] resultarray = text.Split(new char[] { ',' });


                    if (resultarray.Length >= 1)
                    {
                        string key = resultarray[0];
                        List<CsvResultData> vallist = new List<CsvResultData>();

                        if (key == "Status")
                        {
                            status = int.Parse(resultarray[1]);
                        } 
                        else
                        {
                            for (int i = 1; i < resultarray.Length; i++)
                            {
                                string valstr = resultarray[i];
                                decimal val;
                                if (decimal.TryParse(valstr, out val))
                                {
                                    vallist.Add(new CsvResultData(status, val));
                                }
                            }

                            dict_result[key] = vallist;
                        }
                    }                   
                }
            }

            data.ResultDecimal = dict_result;
            return data;
        }

        public static CsvData Bind(CsvData org1, CsvData org2)
        {
            CsvData dest = new CsvData()
            {
                ResultDecimal = new Dictionary<string, List<CsvResultData>>()
            };

            foreach (var key in org1.ResultDecimal.Keys)
            {
                List<CsvResultData> result = new List<CsvResultData>();
                result.AddRange(org1.ResultDecimal[key]);
                result.AddRange(org2.ResultDecimal[key]);
                dest.ResultDecimal[key] = result;
            }

            return dest;
        }




    }
}
