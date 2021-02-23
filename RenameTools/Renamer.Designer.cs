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
            this.buttonBrowser = new System.Windows.Forms.Button();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(168, 675);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(75, 23);
            this.buttonRename.TabIndex = 0;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Location = new System.Drawing.Point(38, 421);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowser.TabIndex = 3;
            this.buttonBrowser.Text = "Browser";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(276, 675);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxExt
            // 
            this.textBoxExt.Location = new System.Drawing.Point(265, 47);
            this.textBoxExt.Name = "textBoxExt";
            this.textBoxExt.Size = new System.Drawing.Size(100, 21);
            this.textBoxExt.TabIndex = 9;
            this.textBoxExt.TextChanged += new System.EventHandler(this.textBoxExt_TextChanged);
            // 
            // labelExname
            // 
            this.labelExname.AutoSize = true;
            this.labelExname.Location = new System.Drawing.Point(35, 51);
            this.labelExname.Name = "labelExname";
            this.labelExname.Size = new System.Drawing.Size(53, 12);
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
            this.dataGridViewFileList.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewFileList.MultiSelect = false;
            this.dataGridViewFileList.Name = "dataGridViewFileList";
            this.dataGridViewFileList.RowHeadersVisible = false;
            this.dataGridViewFileList.RowTemplate.Height = 23;
            this.dataGridViewFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFileList.Size = new System.Drawing.Size(688, 346);
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
            this.labelVersion.Location = new System.Drawing.Point(12, 675);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(53, 12);
            this.labelVersion.TabIndex = 13;
            this.labelVersion.Text = "Version:";
            // 
            // comboBoxExt
            // 
            this.comboBoxExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExt.FormattingEnabled = true;
            this.comboBoxExt.Location = new System.Drawing.Point(97, 47);
            this.comboBoxExt.Name = "comboBoxExt";
            this.comboBoxExt.Size = new System.Drawing.Size(121, 20);
            this.comboBoxExt.TabIndex = 14;
            this.comboBoxExt.SelectedIndexChanged += new System.EventHandler(this.comboBoxExt_SelectedIndexChanged);
            // 
            // labelChangeTo
            // 
            this.labelChangeTo.AutoSize = true;
            this.labelChangeTo.Location = new System.Drawing.Point(227, 51);
            this.labelChangeTo.Name = "labelChangeTo";
            this.labelChangeTo.Size = new System.Drawing.Size(29, 12);
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
            this.comboBoxExistOperation.Location = new System.Drawing.Point(167, 91);
            this.comboBoxExistOperation.Name = "comboBoxExistOperation";
            this.comboBoxExistOperation.Size = new System.Drawing.Size(121, 20);
            this.comboBoxExistOperation.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "当文件已经存在时：";
            // 
            // checkBoxRenameFolder
            // 
            this.checkBoxRenameFolder.AutoSize = true;
            this.checkBoxRenameFolder.Location = new System.Drawing.Point(405, 52);
            this.checkBoxRenameFolder.Name = "checkBoxRenameFolder";
            this.checkBoxRenameFolder.Size = new System.Drawing.Size(102, 16);
            this.checkBoxRenameFolder.TabIndex = 18;
            this.checkBoxRenameFolder.Text = "Rename Folder";
            this.checkBoxRenameFolder.UseVisualStyleBackColor = true;
            this.checkBoxRenameFolder.CheckedChanged += new System.EventHandler(this.checkBoxRenameFolder_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "保留原文件名中的";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "保留前";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 21;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 544);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "重新排序";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "替换";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(513, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "添加/删除";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(122, 399);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "保留原文件名中的";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "保留原文件名中的";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "保留原文件名中的";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrowser);
            this.groupBox1.Controls.Add(this.dataGridViewFileList);
            this.groupBox1.Location = new System.Drawing.Point(548, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 458);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxExt);
            this.groupBox2.Controls.Add(this.labelExname);
            this.groupBox2.Controls.Add(this.comboBoxExt);
            this.groupBox2.Controls.Add(this.labelChangeTo);
            this.groupBox2.Controls.Add(this.comboBoxExistOperation);
            this.groupBox2.Controls.Add(this.checkBoxRenameFolder);
            this.groupBox2.Location = new System.Drawing.Point(554, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 202);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "全局设置";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(125, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "保留原文件名中的";
            // 
            // Renamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 716);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.labelVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Renamer";
            this.Text = "Renamer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonBrowser;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
    }
}

