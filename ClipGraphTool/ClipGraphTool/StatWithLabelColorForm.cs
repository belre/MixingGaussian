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
    public partial class StatWithLabelColorForm : Form
    {
        private readonly int BMP_MAX_WIDTH = 5000;
        private readonly int BMP_MAX_HEIGHT = 5000;
        private int _resamplerate = 1;
        


        public Recipe.GraphToolData[] Data
        {
            get;
            private set;
        }


        public Recipe.GraphToolData SelectedData
        {
            get
            {
                return ((Recipe.GraphToolData)comboBox_imageselect.SelectedItem);
            }
        }

        public Recipe.GraphToolData[] DependentData
        {
            get
            {
                if (Data != null && Data.Length <= 1)
                {
                    return null;
                }
                else
                {
                    List<Recipe.GraphToolData> listtool = new List<Recipe.GraphToolData>();
                    listtool = Data.ToList();
                    listtool.RemoveAt(0);
                    return listtool.ToArray();
                }
            }
        }



        private List<StatWithLabelColor.DataStructure> _internal_data;
        private List<StatWithLabelColor.DataStructure> InternalData
        {
            get
            {
                if (_internal_data == null)
                {
                    List<StatWithLabelColor.DataStructure> datalist = new List<StatWithLabelColor.DataStructure>();

                    var xobj = SelectedData.CsvData.ResultDecimal["X"];
                    var yobj = SelectedData.CsvData.ResultDecimal["Y"];
                    var areaobj = SelectedData.CsvData.ResultDecimal["面積"];
                    var areammobj = SelectedData.CsvData.ResultDecimal["実効面積"];

                    for (int i = 0; i < areaobj.Count; i++)
                    {
                        // ノイズ除去
                        if (xobj[i].Status == 0 && areammobj[i].Result <= (decimal)0.1)
                        {
                            continue;
                        }

                        var data = new StatWithLabelColor.DataStructure()
                        {
                            X = (float)xobj[i].Result,
                            Y = (float)yobj[i].Result,
                            Area = (double)areaobj[i].Result,
                            Areamm = (double)areammobj[i].Result,
                            Status = xobj[i].Status
                        };

                        datalist.Add(data);
                    }

                    _internal_data = datalist;
                }

                return _internal_data;
            }
        }

        private List<StatWithLabelColor.DataStructure> ROIData
        {
            get;
            set;
        }


        private Bitmap _original_image;
        private Bitmap _doublebuffered_image;


        public StatWithLabelColorForm()
        {
            InitializeComponent();
        }


        public StatWithLabelColorForm(Recipe.GraphToolData[] dataobj)
            : this()
        {
            Data = dataobj;

            Recipe.GraphToolData coupled_data = new Recipe.GraphToolData();
            foreach (var data in Data)
            {
                comboBox_imageselect.Items.Add(data);
                coupled_data.Bind(data);
            }
            if (coupled_data.IsBound)
            {
                comboBox_imageselect.Items.Insert(0, coupled_data);
            }

            comboBox_imageselect.SelectedIndex = 0;
            this.Text = SelectedData.Summary.ToString();


            ReferImage();
            UpdateImage();
        }

        private void ReferImage()
        {
            if (Data != null && SelectedData.Summary.ImagePath.Length != 0)
            {
                Bitmap bitmap = new Bitmap(SelectedData.Summary.ImagePath[0]);

                int orgwidth = bitmap.Width;
                int orgheight = bitmap.Height;

                int resamplerate = 1;
                if( orgwidth > orgheight) {
                    resamplerate = orgwidth / BMP_MAX_WIDTH + 1;
                } else {
                    resamplerate = orgheight / BMP_MAX_HEIGHT + 1;
                }

                // resample rateを演算
                // 2のべき乗になるように設定
                int pow = 0;
                for( int p = 1; p < 16; p ++ ) {
                    if( resamplerate >> p == 0 ) {
                        pow = p - 1;
                        break;
                    }
                }
                _resamplerate = 0x01 << pow;


                _original_image = new Bitmap(orgwidth / _resamplerate, orgheight / _resamplerate);
                Graphics g = Graphics.FromImage(_original_image);

                g.DrawImage(bitmap, 0, 0, orgwidth / _resamplerate, orgheight / _resamplerate);

                g.Dispose();
            }
        }


        private void UpdateImage()
        {
            if (_original_image != null)
            {
                Bitmap view = new Bitmap((int)(_original_image.Width / numeric_zoomrate.Value), (int)(_original_image.Height / numeric_zoomrate.Value));
                Graphics g = Graphics.FromImage(view);
                g.DrawImage(_original_image, 0, 0, (int)(_original_image.Width / numeric_zoomrate.Value), (int)(_original_image.Height / numeric_zoomrate.Value));
                
                // ブラシなどもここに追加する
                var internaldata = InternalData;
                foreach (var datum in internaldata)
                {
                    Color color = Color.FromArgb(200, Color.Salmon);

                    if ( ROIData != null && ROIData.Contains(datum))
                    {
                        color = Color.FromArgb(200, Color.Green);
                    }

                    float radius = (float)Math.Sqrt(datum.Area / Math.PI) / (_resamplerate * (float)numeric_zoomrate.Value);
                    g.FillEllipse(new SolidBrush(color), 
                        datum.X / (_resamplerate * (float)numeric_zoomrate.Value) - radius, 
                        datum.Y / (_resamplerate * (float)numeric_zoomrate.Value) - radius,  radius * 2, radius * 2);
                }

                // 領域描画
                g.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.Aquamarine)), _current_dragarea);



                g.Dispose();


                _doublebuffered_image = view;
                picture_imageviewer.Image = view;
            }
        }

        private void UpdateROITable()
        {
            datagrid_roitable.DataSource = null;
            
            dataset_viewed.Tables["ROITable"].Rows.Clear();


            foreach (var roi in ROIData)
            {
                dataset_viewed.Tables["ROITable"].Rows.Add(new object[] { roi.X, roi.Y, roi.Areamm, roi.Status });
            }
            datagrid_roitable.DataSource = dataset_viewed.Tables["ROITable"];

            AnalyzeParticles();
        }

        private void numeric_zoomrate_ValueChanged(object sender, EventArgs e)
        {
            _current_dragarea = new RectangleF();
            UpdateImage();
        }

        private void picture_imageviewer_MouseClick(object sender, MouseEventArgs e)
        {
            float mouseX = e.X * (float)numeric_zoomrate.Value * _resamplerate;
            float mouseY = e.Y * (float)numeric_zoomrate.Value * _resamplerate;

            float dragarea_LT_X = _current_dragarea.X * (float)numeric_zoomrate.Value * _resamplerate;
            float dragarea_LT_Y = _current_dragarea.Y * (float)numeric_zoomrate.Value * _resamplerate;
            float dragarea_RT_X = (_current_dragarea.X + _current_dragarea.Width) * (float)numeric_zoomrate.Value * _resamplerate;
            float dragarea_RT_Y = dragarea_LT_Y ;
            float dragarea_LB_X = dragarea_LT_X ;
            float dragarea_LB_Y = (_current_dragarea.Y + _current_dragarea.Height) * (float)numeric_zoomrate.Value * _resamplerate;
            float dragarea_RB_X = dragarea_RT_X ;
            float dragarea_RB_Y = dragarea_LB_Y ;

            // とりあえず最も率直な方法を使用する
            var internaldata = InternalData;

            List<StatWithLabelColor.DataStructure> targetlist = new List<StatWithLabelColor.DataStructure>();
            foreach (var datum in internaldata)
            {
                double distance = Math.Sqrt((mouseX - datum.X) * (mouseX - datum.X) + (mouseY - datum.Y) * (mouseY - datum.Y));

                double targetX = datum.X;
                double targetY = datum.Y;
                double targetR = (float)Math.Sqrt(datum.Area / Math.PI) ;

                bool istargetlist = false;


                if (distance < targetR)
                {
                    istargetlist = true;
                } 
                else if( targetX >= dragarea_LT_X - targetR && targetY >= dragarea_LT_Y - targetR && targetX <= dragarea_RB_X + targetR && targetY <= dragarea_RB_Y + targetR)
                {
                    istargetlist = true;
                }

                if (!targetlist.Contains(datum) && istargetlist)
                {
                    targetlist.Add(datum);
                }

            }

            if (_iscontrolkey_pressed && ROIData != null)
            {
                ROIData.AddRange(targetlist);
            }
            else
            {
                ROIData = targetlist;
            }

            UpdateImage();
            UpdateROITable();
        }


        MouseEventArgs _pushbefore = null;
        RectangleF _current_dragarea = new RectangleF();
        bool _iscontrolkey_pressed = false;

        private void picture_imageviewer_MouseDown(object sender, MouseEventArgs e)
        {
            _pushbefore = e;
        }

        private void picture_imageviewer_MouseMove(object sender, MouseEventArgs e)
        {
            if (_pushbefore != null)
            {
                float beforemouseX = _pushbefore.X ;
                float beforemouseY = _pushbefore.Y ;
                float mouseX = e.X ;
                float mouseY = e.Y ;

                _current_dragarea.X = beforemouseX > mouseX ? mouseX : beforemouseX;
                _current_dragarea.Y = beforemouseY > mouseY ? mouseY : beforemouseY;
                _current_dragarea.Width = Math.Abs(beforemouseX - mouseX);
                _current_dragarea.Height = Math.Abs(beforemouseY - mouseY);

                UpdateImage();
            }
        }

        private void picture_imageviewer_MouseUp(object sender, MouseEventArgs e)
        {
            _pushbefore = null;
        }

        private void StatWithLabelColorForm_MouseUp(object sender, MouseEventArgs e)
        {


        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void picture_imageviewer_MouseLeave(object sender, EventArgs e)
        {
            _pushbefore = null;
            _current_dragarea = new RectangleF();

            UpdateImage();
        }

        private void StatWithLabelColorForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void StatWithLabelColorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                _iscontrolkey_pressed = true;
            }
        }

        private void StatWithLabelColorForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                _iscontrolkey_pressed = false;
            }
        }

        private void btn_resetsort_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataset_viewed.Tables["RoiTable"];
            bs.Sort = "";
            datagrid_roitable.DataSource = bs;
        }

        private void StatWithLabelColorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btn_selectall_Click(object sender, EventArgs e)
        {
            ROIData = new List<StatWithLabelColor.DataStructure>();
            ROIData.AddRange(InternalData);

            UpdateImage();
            UpdateROITable();
        }

        private void comboBox_imageselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            _internal_data = null;
            ReferImage();
            UpdateImage();
        }

        private void AnalyzeParticles()
        {
            List<StatWithLabelColor.DataStructure> data_trim_0 = ROIData.Where(obj => { return obj.Status == 0; }).ToList();
            List<StatWithLabelColor.DataStructure> data_trim_1 = ROIData.Where(obj => { return obj.Status == 1; }).ToList();

            // EMアルゴリズム
            StatWithLabelColor.EM1dim algo = new StatWithLabelColor.EM1dim(data_trim_0);
            algo.Calculate();

            dataset_viewed.Tables["StatTable"].Rows.Clear();
            if (data_trim_1.Count != 0)
            {
                dataset_viewed.Tables["StatTable"].Rows.Add(new object[] { "潰れ-粒子数", data_trim_1.Count });
            }


            int outnum = 2;
            if (algo.DistResult.Length == 0)
            {
                outnum = 0;
            }
            else if (algo.DistResult[0].Average < algo.DistResult[1].Average + 3 * algo.DistResult[1].Variation &&
                algo.DistResult[0].Average > algo.DistResult[1].Average - 3 * algo.DistResult[1].Variation)
            {
                outnum = 1;
            }

            for (int i = 0; i < outnum; i++)
            {
                dataset_viewed.Tables["StatTable"].Rows.Add(new object[] { string.Format("粒子{0}-粒子数", i + 1), algo.DistResult[i].Number });
            }
            for (int i = 0; i < outnum; i++)
            {
                dataset_viewed.Tables["StatTable"].Rows.Add(new object[] { string.Format("粒子{0}-直径", i + 1), string.Format("{0:F2}", algo.DistResult[i].Average) });
            }
            for (int i = 0; i < outnum; i++)
            {
                dataset_viewed.Tables["StatTable"].Rows.Add(new object[] { string.Format("粒子{0}-6σ", i + 1), string.Format("{0:F2}", Math.Sqrt(algo.DistResult[i].Variation) * 6) });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

    }
}
