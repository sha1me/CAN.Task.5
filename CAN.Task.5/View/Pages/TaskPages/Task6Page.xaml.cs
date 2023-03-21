using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._5.View.Pages.TaskPages
{
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] N = new int[9];
                string[] M = new string[9];
                Random ran = new Random();
                int k;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(10, 99);
                    string B = Convert.ToString(k, 8);
                    M[i] = B;
                    N[i] = k;
                }

                MessageBox.Show($"Исходный массив=\n{string.Join(", ", M)}\nРезультат=\n{string.Join(", ", N)}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
