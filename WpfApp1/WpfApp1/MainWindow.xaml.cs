using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }    public static readonly string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            public const string ImageFolderName = "Image";
            public static readonly string ImageFolderFullName = System.IO.Path.Combine(BaseDirectory, ImageFolderName);
        //public class SomeClass
        //{
        

        //    public void SomeMethod()
        //    {
        //        OpenFileDialog fileDialog = new OpenFileDialog();
        //        if (fileDialog.ShowDialog() == true)
        //        {
        //            if (!Directory.Exists(ImageFolderFullName))
        //            {
        //                Directory.CreateDirectory(ImageFolderFullName);
        //            }
        //            string savepath = System.IO.Path.Combine(ImageFolderFullName, fileDialog.SafeFileName);
        //            File.Copy(fileDialog.FileName, savepath);
        //        }
        //    }
        //}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == true)
            {
                if (!Directory.Exists(ImageFolderFullName))
                {
                    Directory.CreateDirectory(ImageFolderFullName);
                }
                string savepath = System.IO.Path.Combine(ImageFolderFullName, fileDialog.SafeFileName);
                File.Copy(fileDialog.FileName, savepath);
            }
        }
    }
    }

