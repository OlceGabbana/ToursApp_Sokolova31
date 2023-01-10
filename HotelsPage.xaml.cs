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

namespace ToursApp_Sokolova31
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page1());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page2());
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page3());
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page4());
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page5());
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page6());
        }
    }
}
