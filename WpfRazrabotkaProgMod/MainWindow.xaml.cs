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

namespace WpfRazrabotkaProgMod
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zadanie1_Click(object sender, RoutedEventArgs e)
        {
            Window1 WorkWind1 = new Window1();
            WorkWind1.Show();
        }

        private void Zadanie2_Click(object sender, RoutedEventArgs e)
        {
            Window2 WorkWind2 = new Window2();
            WorkWind2.Show();
        }

        private void Zadanie3_Click(object sender, RoutedEventArgs e)
        {
            Window3 WorkWind3 = new Window3();
            WorkWind3.Show();
        }

        private void Zadanie4_Click(object sender, RoutedEventArgs e)
        {
            Window4 WorkWind4 = new Window4();
            WorkWind4.Show();
        }

        private void Zadanie5_Click(object sender, RoutedEventArgs e)
        {
            Window5 WorkWind5 = new Window5();
            WorkWind5.Show();
        }
    }
}
