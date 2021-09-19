using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipGraphTool
{
    public partial class GraphForm : Form
    {

        public Recipe.GraphToolData Data
        {
            get;
            private set;
        }

        private Bitmap _original_image;
        private Bitmap _doublebuffered_image;


        public GraphForm()
        {
            InitializeComponent();
        }

        public GraphForm(Recipe.GraphToolData dataobj)
            : this()
        {
            Data = dataobj;

            this.Text = Data.Summary.ToString();

            ReferImage();
            UpdateImage();
            UpdateGraph();
            UpdateStatTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {

#if false
            if (Data != null && Data.Summary.ImagePath.Length != 0)
            {
                Bitmap bitmap = new Bitmap(Data.Summary.ImagePath[0]);

                Bitmap view = new Bitmap( (int)(bitmap.Width / numeric_zoomrate.Value), (int)(bitmap.Height / numeric_zoomrate.Value));
                Graphics g = Graphics.FromImage(view);
                g.DrawImage(bitmap, 0, 0, (int)(bitmap.Width / numeric_zoomrate.Value), (int)(bitmap.Height / numeric_zoomrate.Value));
                g.Dispose();

                picture_imageviewer.Image = view;

            }
#endif            
        }

        private void ReferImage()
        {
            if (Data != null && Data.Summary.ImagePath.Length != 0)
            {
                Bitmap bitmap = new Bitmap(Data.Summary.ImagePath[0]);
                _original_image = bitmap;
            }
        }

        private void UpdateImage()
        {
            if (_original_image != null)
            {
                Bitmap view = new Bitmap((int)(_original_image.Width / numeric_zoomrate.Value), (int)(_original_image.Height / numeric_zoomrate.Value));
                Graphics g = Graphics.FromImage(view);
                g.DrawImage(_original_image, 0, 0, (int)(_original_image.Width / numeric_zoomrate.Value), (int)(_original_image.Height / numeric_zoomrate.Value));
                g.Dispose();

                // ブラシなどもここに追加する

                _doublebuffered_image = view;
                picture_imageviewer.Image = view;
            }
        }

        private System.Windows.Forms.DataVisualization.Charting.ChartArea CurrentChartArea
        {
            get
            {
                return chart_graph.ChartAreas[0];
            }
        }

        private void UpdateGraph()
        {
            chart_graph.Series.Clear();
            foreach( var alllist in Data.CsvData.ResultDecimal) {
                chart_graph.Series.Add(alllist.Key);
                chart_graph.Series[alllist.Key].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for( int i = 0 ; i < alllist.Value.Count; i ++) {
                    chart_graph.Series[alllist.Key].Points.AddXY(i+1, alllist.Value[i].Result);
                }

                numeric_xlower.Value = 0;
                numeric_xupper.Value = (int)((1 + alllist.Value.Count / 50) * 50);
                numeric_ylower.Value = 0;
                numeric_yupper.Value = new decimal(1);

                CurrentChartArea.AxisX.ScaleView.Zoomable = true;
            }
        }

        private void UpdateStatTable()
        {

            dataset_viewed.Tables["StatTable"].Clear();

            foreach (var alllist in Data.CsvData.ResultDecimal)
            {
                List<decimal> resultvalue = new List<decimal>();
                for (int i = 0; i < alllist.Value.Count; i++)
                {
                    resultvalue.Add(alllist.Value[i].Result);
                }


                decimal average = resultvalue.Average();
                dataset_viewed.Tables["StatTable"].Rows.Add(new string[] { alllist.Key, "平均", average.ToString("F2") });

                decimal min = resultvalue.Min();
                dataset_viewed.Tables["StatTable"].Rows.Add(new string[] { alllist.Key, "最小", min.ToString("F2") });

                decimal max = resultvalue.Max();
                dataset_viewed.Tables["StatTable"].Rows.Add(new string[] { alllist.Key, "最大", max.ToString("F2") });               
            }



        }




        private void numeric_zoomrate_ValueChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }





        private void numeric_xrange_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown concrete_sender = (NumericUpDown)sender;
                       
            if (numeric_xlower.Value > numeric_xupper.Value)
            {
                MessageBox.Show("レンジ範囲外エラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (concrete_sender == numeric_xlower)
                {
                    CurrentChartArea.AxisX.Minimum = (double)numeric_xlower.Value;
                }
                else if (concrete_sender == numeric_xupper)
                {
                    CurrentChartArea.AxisX.Maximum = (double)numeric_xupper.Value;
                }
            }
        }

        private void numeric_yrange_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown concrete_sender = (NumericUpDown)sender;

            if (numeric_ylower.Value > numeric_yupper.Value)
            {
                MessageBox.Show("レンジ範囲外エラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (concrete_sender == numeric_ylower)
                {
                    CurrentChartArea.AxisY.Minimum = (double)numeric_ylower.Value;
                }
                else if (concrete_sender == numeric_yupper)
                {
                    CurrentChartArea.AxisY.Maximum = (double)numeric_yupper.Value;
                }

                //CurrentChartArea.AxisY.MinorGrid.Interval = (int)((numeric_yupper.Value - numeric_ylower.Value) / new decimal(0.01)) * (0.01 / CurrentChartArea.AxisY.ScaleView.Size);
                CurrentChartArea.AxisY.Interval = (int)((numeric_yupper.Value - numeric_ylower.Value) / new decimal(0.01)) * (0.01 / CurrentChartArea.AxisY.ScaleView.Size);
            }
        }


    }
}
