namespace ClipGraphTool
{
    partial class GraphForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_imageviewer = new System.Windows.Forms.PictureBox();
            this.numeric_zoomrate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.項目名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.変数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.値DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataset_viewed = new System.Data.DataSet();
            this.StatTable = new System.Data.DataTable();
            this.column_legend = new System.Data.DataColumn();
            this.column_itemname = new System.Data.DataColumn();
            this.column_value = new System.Data.DataColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric_ylower = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_yupper = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_xupper = new System.Windows.Forms.NumericUpDown();
            this.numeric_xlower = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imageviewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_zoomrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_viewed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ylower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_yupper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_xupper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_xlower)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picture_imageviewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 420);
            this.panel1.TabIndex = 0;
            // 
            // picture_imageviewer
            // 
            this.picture_imageviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_imageviewer.Location = new System.Drawing.Point(0, 0);
            this.picture_imageviewer.Margin = new System.Windows.Forms.Padding(5);
            this.picture_imageviewer.Name = "picture_imageviewer";
            this.picture_imageviewer.Size = new System.Drawing.Size(174, 422);
            this.picture_imageviewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_imageviewer.TabIndex = 0;
            this.picture_imageviewer.TabStop = false;
            // 
            // numeric_zoomrate
            // 
            this.numeric_zoomrate.Location = new System.Drawing.Point(114, 0);
            this.numeric_zoomrate.Margin = new System.Windows.Forms.Padding(5);
            this.numeric_zoomrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_zoomrate.Name = "numeric_zoomrate";
            this.numeric_zoomrate.Size = new System.Drawing.Size(66, 28);
            this.numeric_zoomrate.TabIndex = 2;
            this.numeric_zoomrate.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numeric_zoomrate.ValueChanged += new System.EventHandler(this.numeric_zoomrate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "1 /";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zoom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // chart_graph
            // 
            this.chart_graph.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.Title = "Data Number";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 12F);
            chartArea1.AxisX2.LabelStyle.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 12F);
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.Title = "Pitch[mm]";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 12F);
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "chartarea_graphdata";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 85F;
            chartArea1.Position.Width = 95F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 5F;
            this.chart_graph.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Arial", 10F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 8F;
            legend1.Position.Width = 90F;
            legend1.Position.X = 5F;
            legend1.Position.Y = 92F;
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleFont = new System.Drawing.Font("Arial", 12F);
            this.chart_graph.Legends.Add(legend1);
            this.chart_graph.Location = new System.Drawing.Point(16, 32);
            this.chart_graph.Name = "chart_graph";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "chartarea_graphdata";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Arial", 12F);
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "PlotData";
            this.chart_graph.Series.Add(series1);
            this.chart_graph.Size = new System.Drawing.Size(478, 285);
            this.chart_graph.TabIndex = 5;
            this.chart_graph.Text = "chart1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.numeric_ylower);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.numeric_yupper);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.numeric_xupper);
            this.splitContainer1.Panel2.Controls.Add(this.numeric_xlower);
            this.splitContainer1.Panel2.Controls.Add(this.chart_graph);
            this.splitContainer1.Size = new System.Drawing.Size(786, 503);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 52);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numeric_zoomrate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 29);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.項目名DataGridViewTextBoxColumn,
            this.変数DataGridViewTextBoxColumn,
            this.値DataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "StatTable";
            this.dataGridView1.DataSource = this.dataset_viewed;
            this.dataGridView1.Location = new System.Drawing.Point(38, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(385, 109);
            this.dataGridView1.TabIndex = 14;
            // 
            // 項目名DataGridViewTextBoxColumn
            // 
            this.項目名DataGridViewTextBoxColumn.DataPropertyName = "項目名";
            this.項目名DataGridViewTextBoxColumn.FillWeight = 400F;
            this.項目名DataGridViewTextBoxColumn.HeaderText = "項目名";
            this.項目名DataGridViewTextBoxColumn.Name = "項目名DataGridViewTextBoxColumn";
            this.項目名DataGridViewTextBoxColumn.ReadOnly = true;
            this.項目名DataGridViewTextBoxColumn.Width = 150;
            // 
            // 変数DataGridViewTextBoxColumn
            // 
            this.変数DataGridViewTextBoxColumn.DataPropertyName = "変数";
            this.変数DataGridViewTextBoxColumn.HeaderText = "変数";
            this.変数DataGridViewTextBoxColumn.Name = "変数DataGridViewTextBoxColumn";
            this.変数DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 値DataGridViewTextBoxColumn
            // 
            this.値DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.値DataGridViewTextBoxColumn.DataPropertyName = "値";
            this.値DataGridViewTextBoxColumn.HeaderText = "値";
            this.値DataGridViewTextBoxColumn.Name = "値DataGridViewTextBoxColumn";
            this.値DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataset_viewed
            // 
            this.dataset_viewed.DataSetName = "NewDataSet";
            this.dataset_viewed.Tables.AddRange(new System.Data.DataTable[] {
            this.StatTable});
            // 
            // StatTable
            // 
            this.StatTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.column_legend,
            this.column_itemname,
            this.column_value});
            this.StatTable.TableName = "StatTable";
            // 
            // column_legend
            // 
            this.column_legend.Caption = "項目名";
            this.column_legend.ColumnName = "項目名";
            this.column_legend.ReadOnly = true;
            // 
            // column_itemname
            // 
            this.column_itemname.Caption = "変数";
            this.column_itemname.ColumnName = "変数";
            this.column_itemname.ReadOnly = true;
            // 
            // column_value
            // 
            this.column_value.Caption = "値";
            this.column_value.ColumnName = "値";
            this.column_value.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y Min";
            // 
            // numeric_ylower
            // 
            this.numeric_ylower.DecimalPlaces = 2;
            this.numeric_ylower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numeric_ylower.Location = new System.Drawing.Point(489, 219);
            this.numeric_ylower.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_ylower.Name = "numeric_ylower";
            this.numeric_ylower.Size = new System.Drawing.Size(82, 28);
            this.numeric_ylower.TabIndex = 12;
            this.numeric_ylower.ValueChanged += new System.EventHandler(this.numeric_yrange_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y Max";
            // 
            // numeric_yupper
            // 
            this.numeric_yupper.DecimalPlaces = 2;
            this.numeric_yupper.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numeric_yupper.Location = new System.Drawing.Point(489, 55);
            this.numeric_yupper.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_yupper.Name = "numeric_yupper";
            this.numeric_yupper.Size = new System.Drawing.Size(82, 28);
            this.numeric_yupper.TabIndex = 10;
            this.numeric_yupper.ValueChanged += new System.EventHandler(this.numeric_yrange_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "X Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "X Min";
            // 
            // numeric_xupper
            // 
            this.numeric_xupper.Location = new System.Drawing.Point(425, 289);
            this.numeric_xupper.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_xupper.Name = "numeric_xupper";
            this.numeric_xupper.Size = new System.Drawing.Size(82, 28);
            this.numeric_xupper.TabIndex = 7;
            this.numeric_xupper.ValueChanged += new System.EventHandler(this.numeric_xrange_ValueChanged);
            // 
            // numeric_xlower
            // 
            this.numeric_xlower.Location = new System.Drawing.Point(38, 289);
            this.numeric_xlower.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_xlower.Name = "numeric_xlower";
            this.numeric_xlower.Size = new System.Drawing.Size(82, 28);
            this.numeric_xlower.TabIndex = 6;
            this.numeric_xlower.ValueChanged += new System.EventHandler(this.numeric_xrange_ValueChanged);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 503);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imageviewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_zoomrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graph)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_viewed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ylower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_yupper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_xupper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_xlower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_imageviewer;
        private System.Windows.Forms.NumericUpDown numeric_zoomrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graph;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numeric_xupper;
        private System.Windows.Forms.NumericUpDown numeric_xlower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeric_ylower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_yupper;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataset_viewed;
        private System.Data.DataTable StatTable;
        private System.Data.DataColumn column_legend;
        private System.Data.DataColumn column_itemname;
        private System.Data.DataColumn column_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn 項目名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 変数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 値DataGridViewTextBoxColumn;
    }
}