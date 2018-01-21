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

namespace hw23_WPF_Documents
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

        private void MenuItemClick(object sender, RoutedEventArgs e)
        {
            webBrowser.Navigate("https://www.google.kz");
        }

        private void MenuItemClick1(object sender, RoutedEventArgs e)
        {
            webBrowser.Navigate("https://www.mail.ru");
        }

        private void MenuItemClick2(object sender, RoutedEventArgs e)
        {
            webBrowser.Navigate("https://www.youtube.ru");
        }

        private void MenuItemClick3(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
