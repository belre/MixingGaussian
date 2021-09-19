namespace ClipGraphTool
{
    partial class dlg_mainform
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_updaterecent = new System.Windows.Forms.Button();
            this.listbox_recipe = new System.Windows.Forms.ListBox();
            this.btn_getdata = new System.Windows.Forms.Button();
            this.btn_updatefromfolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_updaterecent
            // 
            this.btn_updaterecent.Font = new System.Drawing.Font("Meiryo UI", 14F);
            this.btn_updaterecent.Location = new System.Drawing.Point(8, 115);
            this.btn_updaterecent.Margin = new System.Windows.Forms.Padding(6);
            this.btn_updaterecent.Name = "btn_updaterecent";
            this.btn_updaterecent.Size = new System.Drawing.Size(117, 32);
            this.btn_updaterecent.TabIndex = 0;
            this.btn_updaterecent.Text = "更新";
            this.btn_updaterecent.UseVisualStyleBackColor = true;
            this.btn_updaterecent.Click += new System.EventHandler(this.btn_referfolder_Click);
            // 
            // listbox_recipe
            // 
            this.listbox_recipe.FormattingEnabled = true;
            this.listbox_recipe.ItemHeight = 24;
            this.listbox_recipe.Location = new System.Drawing.Point(8, 7);
            this.listbox_recipe.Margin = new System.Windows.Forms.Padding(2);
            this.listbox_recipe.Name = "listbox_recipe";
            this.listbox_recipe.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listbox_recipe.Size = new System.Drawing.Size(236, 100);
            this.listbox_recipe.TabIndex = 1;
            // 
            // btn_getdata
            // 
            this.btn_getdata.Font = new System.Drawing.Font("Meiryo UI", 14F);
            this.btn_getdata.Location = new System.Drawing.Point(127, 115);
            this.btn_getdata.Margin = new System.Windows.Forms.Padding(6);
            this.btn_getdata.Name = "btn_getdata";
            this.btn_getdata.Size = new System.Drawing.Size(117, 32);
            this.btn_getdata.TabIndex = 2;
            this.btn_getdata.Text = "データ表示";
            this.btn_getdata.UseVisualStyleBackColor = true;
            this.btn_getdata.Click += new System.EventHandler(this.btn_getdata_Click);
            // 
            // btn_updatefromfolder
            // 
            this.btn_updatefromfolder.Font = new System.Drawing.Font("Meiryo UI", 14F);
            this.btn_updatefromfolder.Location = new System.Drawing.Point(8, 149);
            this.btn_updatefromfolder.Margin = new System.Windows.Forms.Padding(6);
            this.btn_updatefromfolder.Name = "btn_updatefromfolder";
            this.btn_updatefromfolder.Size = new System.Drawing.Size(117, 32);
            this.btn_updatefromfolder.TabIndex = 3;
            this.btn_updatefromfolder.Text = "ファイル参照";
            this.btn_updatefromfolder.UseVisualStyleBackColor = true;
            this.btn_updatefromfolder.Click += new System.EventHandler(this.btn_updatefromfolder_Click);
            // 
            // dlg_mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 186);
            this.Controls.Add(this.btn_updatefromfolder);
            this.Controls.Add(this.btn_getdata);
            this.Controls.Add(this.listbox_recipe);
            this.Controls.Add(this.btn_updaterecent);
            this.Font = new System.Drawing.Font("Meiryo UI", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlg_mainform";
            this.Text = "Graph Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_updaterecent;
        private System.Windows.Forms.ListBox listbox_recipe;
        private System.Windows.Forms.Button btn_getdata;
        private System.Windows.Forms.Button btn_updatefromfolder;

    }
}

