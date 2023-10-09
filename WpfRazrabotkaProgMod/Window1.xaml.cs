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
using System.Windows.Shapes;

namespace WpfRazrabotkaProgMod
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_find_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n.Text != "" && int.Parse(tb_n.Text) < 100) 
            {
                try
                {
                    int Znach = 1;
                    int N = int.Parse(tb_n.Text);
                    for(int i=1; N>=i; i++)
                    {
                        Znach = Znach * i;
                    }
                    Znach = Znach*2;
                    tb_znachN.Text = Znach.ToString();

                }
                catch(FormatException)
                {
                    MessageBox.Show("Вы ввели не верное значение! Пожалуйста,повторите попытку!");
                }
            }
        }
    }
}
