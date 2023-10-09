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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void NumericTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
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
        private void tb_Mass_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           
        }
        private void bt_start_Click(object sender, RoutedEventArgs e)
        {
            
            string input = tb_Mass.Text;
            int[] sequence = input.Split(' ').Select(int.Parse).ToArray();
            int maxLength = 1;
            int maxStartIndex = 0;
            

            for (int i = 0; i < sequence.Length; i++)
            {
                int currentLength = 1;
                int currentStartIndex = i;

                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (sequence[j] % sequence[j - 1] == 0)
                    {
                        currentLength++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = currentStartIndex;
                }


                
            }
            string[] need = new string[maxLength];
            for (int i = maxStartIndex; i < maxStartIndex + maxLength; i++)
            {
                need[i] = sequence[i].ToString();
            }
            input = string.Join(" ", need);
            tb_Mass.Text = input;
        }

        private void tb_Mass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
  }


