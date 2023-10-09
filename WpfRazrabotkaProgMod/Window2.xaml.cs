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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RPB_Mass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = tb_reverse.Text;
            text = text.Replace("  ", " ");
            string[] textMass = text.Split(' ');
            //string Vremenno = "";
            //for (int i = 0; i < ((textMass.Length - 1) / 2); i++)
            //{
            //    Vremenno = textMass[i];
            //    textMass[i] = textMass[(textMass.Length - 1) - i];
            //    textMass[(textMass.Length - 1) - i] = Vremenno;

            //}
            Array.Reverse(textMass);
            text = string.Join(" ", textMass);
            //RPB_Mass.AppendText(text);
            tb_reverse.Text = text;


        }

        private void tb_reverse_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
