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

namespace WpfApp6
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }

        private void radiobtn1_Checked(object sender, RoutedEventArgs e)
        {
            
            Application.Current.Resources["MyImageSource"] = new BitmapImage(new Uri(@"C:\Users\user\Downloads\image0.jpg"));
        }

        private void radiobtn2_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["MyImageSource"] = new BitmapImage(new Uri(@"C:\Users\user\Downloads\cat2.jpg"));

        }

        private void radiobtn3_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["MyImageSource"] = new BitmapImage(new Uri(@"C:\Users\user\Downloads\i.webp"));

        }
    }
}
