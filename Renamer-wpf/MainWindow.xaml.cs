using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System;

namespace Renamer_wpf
{

    public delegate string rename_func(string old);
    public delegate bool? folder_mode();

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<datagrid_item> _FileList = new List<datagrid_item>();
        static public rename_func rename_Func = null;
        static public folder_mode get_folder_mode = null;
        Regex regex = new Regex("[^0-9]+");

        public MainWindow()
        {
            InitializeComponent();
            Filelist.ItemsSource = _FileList;
            get_folder_mode = () => Global_FolderMode?.IsChecked.Value;
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            
        }

        void AddFile( datagrid_item item)
        {
            _FileList.Add(item);
            Filelist.Items.Refresh();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                var ls = openFileDialog.FileNames;
                ls.All((f) => {
                    AddFile(new datagrid_item(f)); 
                    return true; 
                });
            }
        }

        private void Button_Remove_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        rename_func GetRenameFunc()
        {
            try
            {
                if (RenameOptionTab == null) return null;
                if (RenameOptionTab.SelectedItem is TabItem item)
                {
                    if (item.Tag.ToString() == "Reindex")
                    {
                        return null;
                    }
                    else if (item.Tag.ToString() == "Replace")
                    {
                        if (Replace_EnabelRegular.IsChecked == true)
                        {
                            Regex r = new Regex(Replace_From.Text);
                            return (old) => r.Replace(old, Replace_To.Text, 1);
                        }
                        else
                        {
                            if (Replace_From.Text.Length == 0) return null;
                            return (old) => old.Replace(Replace_From.Text, Replace_To.Text);
                        }

                    }
                    else if (item.Tag.ToString() == "Add")
                    {
                        if (Add_EnableExtend.IsChecked == true)
                        {
                            return (old) => old.Insert(Convert.ToInt32(Add_Extend_Index.Text), Add_Extend_AddString.Text);
                        }
                        else
                        {
                            return (old) => Add_First.Text + old + Add_Last.Text;
                        }
                    }
                    else if (item.Tag.ToString() == "Delete")
                    {
                        if (Delete_EnableExtend.IsChecked == true)
                        {
                            return (old) => old.Remove(Convert.ToInt32(Delete_Extend_Index.Text), Convert.ToInt32(Delete_Extend_DelCount.Text));
                        }
                        else
                        {
                            return (old) => old.Replace(Delete_DelString.Text, "");
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }

        void Preview_Rename()
        {
            rename_Func = GetRenameFunc();
            Filelist.Items.Refresh();
        }

        private void TextChanged(object sender, object e)
        {
            Preview_Rename();
        }


        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Preview_Rename();
        }

        private void CheckBoxClick(object sender, RoutedEventArgs e)
        {
            Preview_Rename();
        }

        private void TextBoxPreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = regex.IsMatch(e.Text);
        }
    }


    public class datagrid_item
    {
        public FileInfo current_file { get; set; }
        public string current_file_name => current_file.Name;

        public string preview_new_name
        {
            get
            {
                if (MainWindow.rename_Func == null)
                    return "";

                if (MainWindow.get_folder_mode() == true)
                {
                    return MainWindow.rename_Func(current_file_name);
                }
                else
                {
                    var name = current_file.Name.Substring(0, current_file.Name.LastIndexOf("."));
                    return MainWindow.rename_Func(name) + current_file.Extension;
                }
            }
        }

        public string result { get; set; }

        public datagrid_item(string file)
        {
            current_file = new FileInfo(file);
        }

        public void do_rename()
        {
            if (MainWindow.rename_Func == null)
                return;

            string new_name = current_file.Directory + "\\" + preview_new_name;
            try
            {
                File.Move(current_file.FullName, new_name);
                result =  "成功";
            }
            catch(Exception e)
            {
                result =  "失败";
            }
        }
    }
}
