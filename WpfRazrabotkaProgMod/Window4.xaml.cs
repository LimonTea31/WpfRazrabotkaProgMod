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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        private void NumericInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
        private void bt_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tb_Mass_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        public static void PartitionArray(int[] arr, int b)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                while (arr[left] <= b && left < right)
                {
                    left++;
                }

                while (arr[right] >= b && left < right)
                {
                    right--;
                }

                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
            }
        }

        private void bt_start_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int b = int.Parse(tb_b.Text);


                string input = tb_Mass.Text;
                int[] Mass = input.Split(' ').Select(int.Parse).ToArray();
                //
                int[] arr = { 4, 2, 7, 1, 5, 9, 3 };

                PartitionArray(Mass, b);

                // Вывод отсортированного массива
                foreach (int num in Mass)
                {
                    input = string.Join(" ", Mass);
                    tb_Mass.Text = input;
                }
                //

            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели не верное значение! Пожалуйста,повторите попытку!");
            }
        }
    }
}
