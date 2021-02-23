using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Renamer_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Remove_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        void Preview_Rename()
        {
            if (RenameOptionTab == null) return;
            if (RenameOptionTab.SelectedItem is TabItem item)
            {
                if (item.Tag.ToString() == "Reindex")
                {

                }
                else if (item.Tag.ToString() == "Replace")
                {

                }
                else if (item.Tag.ToString() == "Add")
                {

                }
                else if (item.Tag.ToString() == "Delete")
                {
                    //Delete_DelString.Text
                }
            }
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
    }
}
