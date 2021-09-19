using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipGraphTool.Recipe
{
    public class GraphToolData
    {
        public bool IsBound
        {
            get;
            protected set;
        }

        public RecipeItemSummary Summary
        {
            get;
            protected set;
        }

        public CsvData CsvData
        {
            get;
            protected set;
        }

        public bool ParseData(RecipeItemSummary summary, CsvData csvdata)
        {
            Summary = summary;
            CsvData = csvdata;

            return true;
        }

        public override string ToString()
        {
            return Summary.AliasName;
        }

        public void Bind(GraphToolData obj ) {
            if (Summary == null)
            {
                Summary = obj.Summary;
                CsvData = obj.CsvData;
                IsBound = false;
            }
            else
            {
                Summary = RecipeItemSummary.Bind(Summary, obj.Summary);              
                CsvData = CsvData.Bind(CsvData, obj.CsvData);
                IsBound = true;
            }
        }
    }
}
