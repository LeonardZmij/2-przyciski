using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drugi
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void czesc(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        private void enter(object sender, RoutedEventArgs e)
        {
            DateTime data = DateTime.Now;
            Czas.Content = data.ToString("T");
        }

        private void leave(object sender, RoutedEventArgs e)
        {
            Czas.Content = "Czas";
        }

    }
}
