using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Renamer
{

    public class RenameGridItem
    {
        public FileInfo current_file { get; set; }
        public string current_file_name => current_file.Name;
        public bool IsDirectory
        {
            get
            {
                if (current_file.Attributes.HasFlag(FileAttributes.Directory))
                    return true;
                else
                    return false;
            }
        }

        public string preview_new_name
        {
            get
            {
                if (MainWindowObject.rename_Func == null)
                    return "";

                if (IsDirectory || MainWindowObject.Global_IncludeExtension.IsChecked == true)
                {
                    return MainWindowObject.rename_Func(current_file_name);
                }
                else
                {
                    var name = get_name_without_extension(current_file.Name);
                    return MainWindowObject.rename_Func(name) + current_file.Extension;
                }
            }
        }

        public string extension
        {
            get
            {
                if (IsDirectory)
                {
                    return "";
                }
                else
                {
                    return current_file.Extension;
                }
            }
        }

        public static string get_name_without_extension(string name)
        {
            var index = name.LastIndexOf(".");
            if (index == -1)
                return name;
            return name.Substring(0, index);
        }

        public string full_new_name => current_file.Directory + "\\" + preview_new_name;

        public string result { get; set; }

        MainWindow MainWindowObject = null;

        public RenameGridItem(MainWindow mainWindow, string file)
        {
            MainWindowObject = mainWindow;
            current_file = new FileInfo(file);
        }

        public void fill_with_result()
        {

        }

        public static string MD5_File_Enconding(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("MD5_File_Enconding() fail,error:" + ex.Message);
            }
        }

        public bool? do_conflict(ref string new_file, string old_file)
        {
            if (MainWindowObject.Global_AutoFixSameFile.IsChecked == true)
            {
                var new_md5 = MD5_File_Enconding(new_file);
                var old_md5 = MD5_File_Enconding(old_file);
                if (new_md5 == old_md5)
                {
                    File.Delete(old_file);
                    return true;
                }
            }
            if (MainWindowObject.Global_AutoFixFileConflict.SelectedItem is ComboBoxItem item)
            {
                if (item.Tag.ToString() == "AddRFlag")
                {
                    new_file = (IsDirectory ? preview_new_name : get_name_without_extension(preview_new_name)) + "_R" + extension;
                    return true;
                }
                else if (item.Tag.ToString() == "ShowMessage")
                {
                    throw new Exception("尚未实现");
                    /*var res = MessageBox.Show($"将 {old_file} 重命名为 {new_file} 时冲突，请确认是否替换。\r\n“是”将删除现有文件，并将新文件重命名为现有文件\r\n“否”将删除新文件\r\n取消将停止转换过程", "提示信息", MessageBoxButton.YesNoCancel);
                    if( res == MessageBoxResult.Yes)
                    {
                        File.Delete(old_file);
                    }
                    else if ( res == MessageBoxResult.No )
                    {

                    }*/
                }
                else if (item.Tag.ToString() == "Replace")
                {
                    throw new Exception("尚未实现");
                }
                else if (item.Tag.ToString() == "Skip")
                {
                    throw new Exception("尚未实现");
                }
                else
                {
                    throw new Exception("Global_AutoFixFileConflict.SelectItem.Tag 未匹配异常");
                }
            }
            return false;
        }

        public bool MergeTwoDirectory(string res_dir, string merge_dir)
        {
            var files = Directory.GetFiles(merge_dir);
            var files2 = Directory.GetFiles(res_dir);
            List<string> conflicts = new List<string>();
            foreach (var i in files)
            {
                if (files2.Any((f) => f == i))
                {
                    conflicts.Add(i);
                }
            }

            if (conflicts.Count > 0)
            {

            }


            return false;
        }

        public bool? do_directory_conflict(ref string new_directory)
        {
            if (MainWindowObject.Global_AutoFixFolderConflict.SelectedItem is ComboBoxItem item)
            {
                if (item.Tag.ToString() == "Merge")
                {

                }
                else if (item.Tag.ToString() == "AddRFlag")
                {
                    new_directory = preview_new_name + "_R";
                    return true;
                }
                else if (item.Tag.ToString() == "ShowMessage")
                {
                    throw new Exception("尚未实现");
                }
                else if (item.Tag.ToString() == "Replace")
                {
                    throw new Exception("尚未实现");
                }
                else if (item.Tag.ToString() == "Skip")
                {
                    throw new Exception("尚未实现");
                }
                else
                {
                    throw new Exception("Global_AutoFixFolderConflict.SelectItem.Tag 未匹配异常");
                }
            }

            return false;
        }


        public bool? do_rename()
        {
            if (MainWindowObject.rename_Func == null)
                return false;

            string new_name = current_file.Directory + "\\" + preview_new_name;

            try
            {
                if (IsDirectory)
                {
                    if (Directory.Exists(new_name))
                    {
                        if (do_directory_conflict(ref new_name) != true)
                        {
                            result = "冲突解决失败";
                            return false;
                        }
                    }
                }
                else
                {
                    while (File.Exists(new_name))
                    {
                        if (do_conflict(ref new_name, current_file.FullName) != true)
                        {
                            result = "冲突解决失败";
                            return false;
                        }
                    }
                }


            }
            catch (Exception e)
            {
                result = e.Message;
                return false;
            }

            try
            {
                if (IsDirectory)
                {
                    Directory.Move(current_file.FullName, new_name);
                    result = "成功";
                    return true;
                }
                else
                {
                    File.Move(current_file.FullName, new_name);
                    result = "成功";
                    return true;
                }

            }
            catch (Exception e)
            {
                result = "失败";
                return false;
            }
        }
    }
}
