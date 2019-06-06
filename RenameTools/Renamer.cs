using SLOONG.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameTools
{
    public partial class Renamer : Form
    {
        private delegate void SetPos(int pos);
        private bool bIsStop = true;
        private int nMaxCount = 0;
        List<RenameFileInfo> FileList = new List<RenameFileInfo>();
        List<RenameFileInfo> WorkList = new List<RenameFileInfo>();
        private int ExistOperation { get; set; }

        public string AssemblyFileVersion
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyFileVersionAttribute)attributes[0]).Version;
            }
        }

        public Renamer()
        {
            InitializeComponent();
            this.labelVersion.Text = string.Format("Version:{0}", AssemblyFileVersion);
            this.dataGridViewFileList.AutoGenerateColumns = false;
        }

        private void SetTextMessage(int ipos)
        {
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMessage);
                this.Invoke(setpos, new object[] { ipos });
            }
            else
            {
                this.labelProcessValue.Text = string.Format("{0}/{1}",ipos+1, nMaxCount);
                this.labelProcessValue.Refresh();
                this.progressBar1.Value = ipos+1;
                this.progressBar1.Refresh();

                Color clr = Color.White;
                switch(WorkList[ipos].ProcessStatus)
                {
                    case ProcessStatusType.Failed:
                        clr = Color.Red;
                        break;
                    case ProcessStatusType.Succeeded:
                        clr = Color.Green;
                        break;
                    case ProcessStatusType.Ignore:
                        clr = Color.Blue;
                        break;
                    case ProcessStatusType.Wait:
                        clr = Color.Gray;
                        break;
                }
                this.dataGridViewFileList.Rows[ipos].DefaultCellStyle.BackColor = clr;
                this.dataGridViewFileList.CurrentCell = this.dataGridViewFileList.Rows[ipos].Cells[0];
                this.dataGridViewFileList.Refresh();
            }
        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (DialogResult.OK == folderDlg.ShowDialog())
            {
                textBoxPath.Text = folderDlg.SelectedPath;
                textBoxPath_Leave(sender, null);
            }
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPath.Text))
                return;

            this.progressBar1.Maximum = WorkList.Count;
            this.nMaxCount = WorkList.Count;

            bIsStop = false;
            ExistOperation = comboBoxExistOperation.SelectedIndex;

            Thread thread = new Thread(() => RenameFile());
            thread.Start();
        }

        private void RenameFile()
        {
            foreach (RenameFileInfo item in WorkList)
            {
                if (bIsStop == true)
                {
                    break;
                }

                try
                {
                    if (item.OrgFullPath == item.NewFullPath)
                    {
                        item.ProcessStatus = ProcessStatusType.Ignore;
                    }
                    else
                    {
                        try
                        {
                            File.Move(item.OrgFullPath, item.NewFullPath);
                        }
                        catch(IOException e)
                        {
                            if (ExistOperation == 0)
                            {
                                throw e;
                            }
                            else if (ExistOperation == 1)
                            {
                                File.Delete(item.NewFullPath);
                                File.Move(item.OrgFullPath, item.NewFullPath);
                            }
                            else if (ExistOperation == 2)
                            {
                                item.ProcessStatus = ProcessStatusType.Ignore;
                                continue;
                            }
                        }
                        item.ProcessStatus = ProcessStatusType.Succeeded;
                    }
                }
                catch (Exception e)
                {
                    item.ProcessStatus = ProcessStatusType.Failed;
                    Console.WriteLine(e.Message);
                }

                SetTextMessage(WorkList.IndexOf(item));
            }

//             int index = path.LastIndexOf("_", path.Length);
//             int index2 = path.LastIndexOf("\\", index);
//             int index3 = path.LastIndexOf("\\", index2 - 1);
//             int index4 = path.LastIndexOf("\\", index3 - 1);
//             string parent1 = path.Substring(index4 + 1, index3 - index4 - 1);
//             string parent2 = path.Substring(index3 + 1, index2 - index3 - 1);
//             string name = path.Substring(index + 1);
//             string basePath = path.Substring(0, index4);
//             newName = string.Format("{0}\\{1}_{2}_{3}", basePath, parent1, parent2, name);
        }

        private void GetAll(DirectoryInfo dir, ref List<RenameFileInfo> arr)
        {
            FileInfo[] allFile = dir.GetFiles();
            foreach (FileInfo fi in allFile)
            {
                RenameFileInfo temp = new RenameFileInfo();
                temp.OrgName = fi.Name.Substring(0, fi.Name.Length-fi.Extension.Length);
                temp.OrgExt = fi.Extension;
                temp.OrgPath = fi.DirectoryName;
                temp.ProcessStatus = ProcessStatusType.Wait;
                temp.NewExt = temp.OrgExt;
                temp.NewName = temp.OrgName;
                temp.NewPath = temp.OrgPath;
                temp.ProcessStatus = ProcessStatusType.Wait;
                arr.Add(temp);

                if( -1 == this.comboBoxExt.Items.IndexOf(temp.OrgExt))
                {
                    this.comboBoxExt.Items.Add(temp.OrgExt);
                }
            }

            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach (DirectoryInfo d in allDir)
            {
                GetAll(d,ref arr);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            bIsStop = true;
        }

        private void dataGridViewFileList_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if( e.ColumnIndex == 0 )
            {
                e.ToolTipText = WorkList[e.RowIndex].OrgPath + "\\" + WorkList[e.RowIndex].OrgFileName;
            }
            else
            {
                e.ToolTipText = WorkList[e.RowIndex].NewPath + "\\" + WorkList[e.RowIndex].NewFileName;
            }
            
        }

        private void textBoxPath_Leave(object sender, EventArgs e)
        {
            WorkList.Clear();
            FileList.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(textBoxPath.Text);

            this.comboBoxExt.Items.Clear();
            this.comboBoxExt.Items.Add("");
            GetAll(dirInfo, ref FileList);
            WorkList.AddRange(FileList);

            UpdateFileListView();
        }


        private void UpdateFileListView()
        {
            dataGridViewFileList.DataSource = new BindingCollection<RenameFileInfo>(WorkList);
            dataGridViewFileList.Refresh();
        }

        private void comboBoxExt_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkList.Clear();
            foreach( RenameFileInfo item in FileList )
            {
                if( item.OrgExt == comboBoxExt.Text || string.IsNullOrEmpty(comboBoxExt.Text))
                {
                    WorkList.Add(item);
                }
            }
            UpdateFileListView();
        }

        private void textBoxExt_TextChanged(object sender, EventArgs e)
        {
            string newExt = textBoxExt.Text;
            if( -1 ==  newExt.IndexOf('.'))
            {
                newExt = "."+newExt;
            }
            foreach( RenameFileInfo item in WorkList )
            {
                item.NewExt = newExt;
            }
            UpdateFileListView();
        }

        private void checkBoxRenameFolder_CheckedChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(textBoxPath.Text);

            this.comboBoxExt.Items.Clear();
           
            GetAll(dirInfo, ref FileList);
            WorkList.AddRange(FileList);

            UpdateFileListView();
        }
     
        private void dataGridViewFileList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        
        }

        private void dataGridViewFileList_DragEnter(object sender, DragEventArgs e)
        {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
            string a = filePath[0];
            //if (a.Substring(a.Length - 3, 3) == "jpg")
                //pictureBox1.ImageLocation = a;
        }
    }

    public enum ProcessStatusType
    {
        Wait,
        Succeeded,
        Failed,
        Ignore,
    }
    public class RenameFileInfo
    {
        public string OrgPath { get; set; }
        public string NewPath { get; set; }
        public string OrgName { get; set; }
        public string NewName { get; set; }
        public string OrgExt { get; set; }
        public string NewExt { get; set; }
        public ProcessStatusType ProcessStatus { get; set; }
        public string OrgFileName 
        {
            get 
            {
                return OrgName + OrgExt;
            }
            private set { }
        }
        public string NewFileName 
        { 
            get
            {
                return NewName + NewExt;
            }
            private set { } 
        }

        public string OrgFullPath
        {
            get
            {
                return OrgPath + "\\" + OrgFileName;
            }
            private set { }
        }
        public string NewFullPath
        {
            get
            {
                return NewPath + "\\" + NewFileName;
            }
            private set { }
        }
    }

}
