using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Renamer
{

    public delegate string rename_func(string old);

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RenameGridItem> _FileList = new List<RenameGridItem>();
        public rename_func rename_Func = null;
        Regex regex = new Regex("[^0-9]+");

        public MainWindow()
        {
            InitializeComponent();
            Filelist.ItemsSource = _FileList;
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            int renamed = 0;
            int skiped = 0;
            foreach(var item in  _FileList )
            {
                var res = item.do_rename();
                if (!res.HasValue)
                    return;

                if (res.Value==true)
                    renamed++;
                else
                    skiped++;
            }
            MessageBox.Show($"操作完成\r\n已处理：{renamed}\r\n未处理：{skiped}\r\n");

            if( Global_AutoFillResult.IsChecked == true )
            {
                _FileList.ForEach((i) => i.fill_with_result());
                Filelist.Items.Refresh();
            }
        }

        void AddFile( RenameGridItem item)
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
                    AddFile( new RenameGridItem(this, f)); 
                    return true; 
                });
            }
        }

        private void Button_Remove_Click(object sender, RoutedEventArgs e)
        {
            if (Filelist.SelectedItems.Count > 0 )
            {
                foreach( var item in Filelist.SelectedItems.Cast<RenameGridItem>())
                {
                    _FileList.Remove(item);
                }
                Filelist.Items.Refresh();
            }
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            _FileList.Clear();
            Filelist.Items.Refresh();
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
                            try
                            {
                                Regex r = new Regex(Replace_From.Text);
                                return (old) => r.Replace(old, Replace_To.Text, 1);
                            }
                            catch(Exception)
                            {

                            }
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

        rename_func GetRenameFuncWithOption()
        {
            var func = GetRenameFunc();
            if (Global_ToggleCase?.SelectedItem is ComboBoxItem item)
            {
                if (item.Tag.ToString() == "ToCaptial")
                {
                    return (old) => func(old).ToUpper();
                }
                else if (item.Tag.ToString() == "ToLower")
                {
                    return (old) => func(old).ToLower();
                }
            }
            return func;
        }

        void Preview_Rename()
        {
            rename_Func = GetRenameFuncWithOption();
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

        private void Filelist_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effects = DragDropEffects.Link;
            else e.Effects = DragDropEffects.None;
        }

        private void Filelist_Drop(object sender, DragEventArgs e)
        {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
            filePath.All((f) => {
                AddFile(new RenameGridItem(this, f));
                return true;
            });
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

    }


}
