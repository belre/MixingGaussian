namespace ClipGraphTool
{
    partial class StatWithLabelColorForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_imageviewer = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_selectall = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_imageselect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_zoomrate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataset_viewed = new System.Data.DataSet();
            this.RoiTable = new System.Data.DataTable();
            this.column_X = new System.Data.DataColumn();
            this.column_Y = new System.Data.DataColumn();
            this.column_Area = new System.Data.DataColumn();
            this.column_status = new System.Data.DataColumn();
            this.dataTable1 = new System.Data.DataTable();
            this.column_name = new System.Data.DataColumn();
            this.column_result = new System.Data.DataColumn();
            this.btn_resetsort = new System.Windows.Forms.Button();
            this.datagrid_roitable = new System.Windows.Forms.DataGridView();
            this.xmmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ymmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areamm2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imageviewer)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_zoomrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_viewed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoiTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_roitable)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
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
            this.splitContainer1.Panel2.Controls.Add(this.btn_resetsort);
            this.splitContainer1.Panel2.Controls.Add(this.datagrid_roitable);
            this.splitContainer1.Size = new System.Drawing.Size(926, 463);
            this.splitContainer1.SplitterDistance = 560;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyDown);
            this.splitContainer1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picture_imageviewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 360);
            this.panel1.TabIndex = 0;
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // picture_imageviewer
            // 
            this.picture_imageviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_imageviewer.Location = new System.Drawing.Point(0, 0);
            this.picture_imageviewer.Margin = new System.Windows.Forms.Padding(8);
            this.picture_imageviewer.Name = "picture_imageviewer";
            this.picture_imageviewer.Size = new System.Drawing.Size(50, 50);
            this.picture_imageviewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_imageviewer.TabIndex = 0;
            this.picture_imageviewer.TabStop = false;
            this.picture_imageviewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_imageviewer_MouseClick);
            this.picture_imageviewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_imageviewer_MouseDown);
            this.picture_imageviewer.MouseLeave += new System.EventHandler(this.picture_imageviewer_MouseLeave);
            this.picture_imageviewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_imageviewer_MouseMove);
            this.picture_imageviewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_imageviewer_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_selectall);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 410);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 51);
            this.panel3.TabIndex = 2;
            // 
            // btn_selectall
            // 
            this.btn_selectall.Location = new System.Drawing.Point(17, 11);
            this.btn_selectall.Name = "btn_selectall";
            this.btn_selectall.Size = new System.Drawing.Size(117, 29);
            this.btn_selectall.TabIndex = 0;
            this.btn_selectall.Text = "Select All";
            this.btn_selectall.UseVisualStyleBackColor = true;
            this.btn_selectall.Click += new System.EventHandler(this.btn_selectall_Click);
            this.btn_selectall.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyDown);
            this.btn_selectall.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_imageselect);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numeric_zoomrate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 50);
            this.panel2.TabIndex = 1;
            // 
            // comboBox_imageselect
            // 
            this.comboBox_imageselect.FormattingEnabled = true;
            this.comboBox_imageselect.Location = new System.Drawing.Point(308, 11);
            this.comboBox_imageselect.Name = "comboBox_imageselect";
            this.comboBox_imageselect.Size = new System.Drawing.Size(152, 28);
            this.comboBox_imageselect.TabIndex = 5;
            this.comboBox_imageselect.SelectedIndexChanged += new System.EventHandler(this.comboBox_imageselect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zoom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "1 /";
            // 
            // numeric_zoomrate
            // 
            this.numeric_zoomrate.Location = new System.Drawing.Point(136, 12);
            this.numeric_zoomrate.Margin = new System.Windows.Forms.Padding(8);
            this.numeric_zoomrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_zoomrate.Name = "numeric_zoomrate";
            this.numeric_zoomrate.Size = new System.Drawing.Size(55, 28);
            this.numeric_zoomrate.TabIndex = 2;
            this.numeric_zoomrate.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numeric_zoomrate.ValueChanged += new System.EventHandler(this.numeric_zoomrate_ValueChanged);
            this.numeric_zoomrate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyDown);
            this.numeric_zoomrate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
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
            this.nameDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "StatTable";
            this.dataGridView1.DataSource = this.dataset_viewed;
            this.dataGridView1.Location = new System.Drawing.Point(7, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(334, 178);
            this.dataGridView1.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 79;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // dataset_viewed
            // 
            this.dataset_viewed.DataSetName = "NewDataSet";
            this.dataset_viewed.Tables.AddRange(new System.Data.DataTable[] {
            this.RoiTable,
            this.dataTable1});
            // 
            // RoiTable
            // 
            this.RoiTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.column_X,
            this.column_Y,
            this.column_Area,
            this.column_status});
            this.RoiTable.TableName = "RoiTable";
            // 
            // column_X
            // 
            this.column_X.Caption = "X [mm]";
            this.column_X.ColumnName = "X [mm]";
            this.column_X.DataType = typeof(double);
            // 
            // column_Y
            // 
            this.column_Y.Caption = "Y [mm]";
            this.column_Y.ColumnName = "Y [mm]";
            this.column_Y.DataType = typeof(double);
            // 
            // column_Area
            // 
            this.column_Area.Caption = "Area [mm2]";
            this.column_Area.ColumnName = "Area [mm2]";
            this.column_Area.DataType = typeof(double);
            // 
            // column_status
            // 
            this.column_status.ColumnName = "Status";
            this.column_status.DataType = typeof(int);
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.column_name,
            this.column_result});
            this.dataTable1.TableName = "StatTable";
            // 
            // column_name
            // 
            this.column_name.ColumnName = "Name";
            // 
            // column_result
            // 
            this.column_result.ColumnName = "Result";
            this.column_result.DataType = typeof(double);
            // 
            // btn_resetsort
            // 
            this.btn_resetsort.Location = new System.Drawing.Point(7, 10);
            this.btn_resetsort.Name = "btn_resetsort";
            this.btn_resetsort.Size = new System.Drawing.Size(120, 29);
            this.btn_resetsort.TabIndex = 1;
            this.btn_resetsort.Text = "Reset Sort";
            this.btn_resetsort.UseVisualStyleBackColor = true;
            this.btn_resetsort.Click += new System.EventHandler(this.btn_resetsort_Click);
            this.btn_resetsort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyDown);
            this.btn_resetsort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyUp);
            // 
            // datagrid_roitable
            // 
            this.datagrid_roitable.AllowUserToAddRows = false;
            this.datagrid_roitable.AllowUserToDeleteRows = false;
            this.datagrid_roitable.AllowUserToResizeColumns = false;
            this.datagrid_roitable.AllowUserToResizeRows = false;
            this.datagrid_roitable.AutoGenerateColumns = false;
            this.datagrid_roitable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_roitable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xmmDataGridViewTextBoxColumn,
            this.ymmDataGridViewTextBoxColumn,
            this.areamm2DataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.datagrid_roitable.DataMember = "RoiTable";
            this.datagrid_roitable.DataSource = this.dataset_viewed;
            this.datagrid_roitable.Location = new System.Drawing.Point(7, 50);
            this.datagrid_roitable.Name = "datagrid_roitable";
            this.datagrid_roitable.RowHeadersVisible = false;
            this.datagrid_roitable.RowTemplate.Height = 21;
            this.datagrid_roitable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_roitable.Size = new System.Drawing.Size(334, 196);
            this.datagrid_roitable.TabIndex = 0;
            this.datagrid_roitable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyDown);
            this.datagrid_roitable.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyUp);
            // 
            // xmmDataGridViewTextBoxColumn
            // 
            this.xmmDataGridViewTextBoxColumn.DataPropertyName = "X [mm]";
            this.xmmDataGridViewTextBoxColumn.HeaderText = "X [mm]";
            this.xmmDataGridViewTextBoxColumn.Name = "xmmDataGridViewTextBoxColumn";
            // 
            // ymmDataGridViewTextBoxColumn
            // 
            this.ymmDataGridViewTextBoxColumn.DataPropertyName = "Y [mm]";
            this.ymmDataGridViewTextBoxColumn.HeaderText = "Y [mm]";
            this.ymmDataGridViewTextBoxColumn.Name = "ymmDataGridViewTextBoxColumn";
            // 
            // areamm2DataGridViewTextBoxColumn
            // 
            this.areamm2DataGridViewTextBoxColumn.DataPropertyName = "Area [mm2]";
            this.areamm2DataGridViewTextBoxColumn.HeaderText = "Area [mm2]";
            this.areamm2DataGridViewTextBoxColumn.Name = "areamm2DataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // StatWithLabelColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 463);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StatWithLabelColorForm";
            this.Text = "StatWithLabelColorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatWithLabelColorForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StatWithLabelColorForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StatWithLabelColorForm_KeyUp);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StatWithLabelColorForm_MouseUp);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imageviewer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_zoomrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_viewed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoiTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_roitable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_zoomrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_imageviewer;
        private System.Data.DataSet dataset_viewed;
        private System.Windows.Forms.DataGridView datagrid_roitable;
        private System.Data.DataTable RoiTable;
        private System.Data.DataColumn column_X;
        private System.Data.DataColumn column_Y;
        private System.Data.DataColumn column_Area;
        private System.Windows.Forms.Button btn_resetsort;
        private System.Windows.Forms.Button btn_selectall;
        private System.Windows.Forms.ComboBox comboBox_imageselect;
        private System.Data.DataColumn column_status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn column_name;
        private System.Data.DataColumn column_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ymmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areamm2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}