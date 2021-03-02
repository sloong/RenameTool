namespace RenameTools
{
    partial class Renamer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renamer));
            this.buttonRename = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProcessValue = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxExt = new System.Windows.Forms.TextBox();
            this.labelExname = new System.Windows.Forms.Label();
            this.dataGridViewFileList = new System.Windows.Forms.DataGridView();
            this.OrgFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelVersion = new System.Windows.Forms.Label();
            this.comboBoxExt = new System.Windows.Forms.ComboBox();
            this.labelChangeTo = new System.Windows.Forms.Label();
            this.comboBoxExistOperation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRenameFolder = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(105, 337);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(75, 25);
            this.buttonRename.TabIndex = 0;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(37, 31);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(419, 20);
            this.textBoxPath.TabIndex = 2;
            this.textBoxPath.Leave += new System.EventHandler(this.textBoxPath_Leave);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Location = new System.Drawing.Point(477, 29);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(75, 25);
            this.buttonBrowser.TabIndex = 3;
            this.buttonBrowser.Text = "Browser";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(37, 228);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 25);
            this.progressBar1.TabIndex = 6;
            // 
            // labelProcessValue
            // 
            this.labelProcessValue.AutoSize = true;
            this.labelProcessValue.Location = new System.Drawing.Point(274, 256);
            this.labelProcessValue.Name = "labelProcessValue";
            this.labelProcessValue.Size = new System.Drawing.Size(24, 13);
            this.labelProcessValue.TabIndex = 7;
            this.labelProcessValue.Text = "0/0";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(367, 337);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 25);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxExt
            // 
            this.textBoxExt.Location = new System.Drawing.Point(265, 74);
            this.textBoxExt.Name = "textBoxExt";
            this.textBoxExt.Size = new System.Drawing.Size(100, 20);
            this.textBoxExt.TabIndex = 9;
            this.textBoxExt.TextChanged += new System.EventHandler(this.textBoxExt_TextChanged);
            // 
            // labelExname
            // 
            this.labelExname.AutoSize = true;
            this.labelExname.Location = new System.Drawing.Point(35, 78);
            this.labelExname.Name = "labelExname";
            this.labelExname.Size = new System.Drawing.Size(55, 13);
            this.labelExname.TabIndex = 10;
            this.labelExname.Text = "扩展名：";
            // 
            // dataGridViewFileList
            // 
            this.dataGridViewFileList.AllowDrop = true;
            this.dataGridViewFileList.AllowUserToDeleteRows = false;
            this.dataGridViewFileList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewFileList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFileList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrgFileName,
            this.NewFileName});
            this.dataGridViewFileList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFileList.Location = new System.Drawing.Point(582, 13);
            this.dataGridViewFileList.MultiSelect = false;
            this.dataGridViewFileList.Name = "dataGridViewFileList";
            this.dataGridViewFileList.RowHeadersVisible = false;
            this.dataGridViewFileList.RowTemplate.Height = 23;
            this.dataGridViewFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFileList.Size = new System.Drawing.Size(400, 375);
            this.dataGridViewFileList.TabIndex = 12;
            this.dataGridViewFileList.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dataGridViewFileList_CellToolTipTextNeeded);
            this.dataGridViewFileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewFileList_DragDrop);
            this.dataGridViewFileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewFileList_DragEnter);
            // 
            // OrgFileName
            // 
            this.OrgFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrgFileName.DataPropertyName = "OrgFileName";
            this.OrgFileName.HeaderText = "原文件名";
            this.OrgFileName.Name = "OrgFileName";
            // 
            // NewFileName
            // 
            this.NewFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NewFileName.DataPropertyName = "NewFileName";
            this.NewFileName.HeaderText = "新文件名";
            this.NewFileName.Name = "NewFileName";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(12, 375);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(45, 13);
            this.labelVersion.TabIndex = 13;
            this.labelVersion.Text = "Version:";
            // 
            // comboBoxExt
            // 
            this.comboBoxExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExt.FormattingEnabled = true;
            this.comboBoxExt.Location = new System.Drawing.Point(97, 74);
            this.comboBoxExt.Name = "comboBoxExt";
            this.comboBoxExt.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExt.TabIndex = 14;
            this.comboBoxExt.SelectedIndexChanged += new System.EventHandler(this.comboBoxExt_SelectedIndexChanged);
            // 
            // labelChangeTo
            // 
            this.labelChangeTo.AutoSize = true;
            this.labelChangeTo.Location = new System.Drawing.Point(227, 78);
            this.labelChangeTo.Name = "labelChangeTo";
            this.labelChangeTo.Size = new System.Drawing.Size(31, 13);
            this.labelChangeTo.TabIndex = 15;
            this.labelChangeTo.Text = "改为";
            // 
            // comboBoxExistOperation
            // 
            this.comboBoxExistOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExistOperation.FormattingEnabled = true;
            this.comboBoxExistOperation.Items.AddRange(new object[] {
            "停止",
            "覆盖",
            "跳过"});
            this.comboBoxExistOperation.Location = new System.Drawing.Point(167, 121);
            this.comboBoxExistOperation.Name = "comboBoxExistOperation";
            this.comboBoxExistOperation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExistOperation.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "当文件已经存在时：";
            // 
            // checkBoxRenameFolder
            // 
            this.checkBoxRenameFolder.AutoSize = true;
            this.checkBoxRenameFolder.Location = new System.Drawing.Point(457, 78);
            this.checkBoxRenameFolder.Name = "checkBoxRenameFolder";
            this.checkBoxRenameFolder.Size = new System.Drawing.Size(98, 17);
            this.checkBoxRenameFolder.TabIndex = 18;
            this.checkBoxRenameFolder.Text = "Rename Folder";
            this.checkBoxRenameFolder.UseVisualStyleBackColor = true;
            this.checkBoxRenameFolder.CheckedChanged += new System.EventHandler(this.checkBoxRenameFolder_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "保留原文件名中的";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "保留前";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(383, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // Renamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxRenameFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxExistOperation);
            this.Controls.Add(this.labelChangeTo);
            this.Controls.Add(this.comboBoxExt);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.dataGridViewFileList);
            this.Controls.Add(this.labelExname);
            this.Controls.Add(this.textBoxExt);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelProcessValue);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonBrowser);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonRename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Renamer";
            this.Text = "Renamer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProcessValue;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxExt;
        private System.Windows.Forms.Label labelExname;
        private System.Windows.Forms.DataGridView dataGridViewFileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewFileName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.ComboBox comboBoxExt;
        private System.Windows.Forms.Label labelChangeTo;
        private System.Windows.Forms.ComboBox comboBoxExistOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxRenameFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

