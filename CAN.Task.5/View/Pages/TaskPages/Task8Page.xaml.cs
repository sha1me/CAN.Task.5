using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._5.View.Pages.TaskPages
{
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }

        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] N = new int[7];
                int[] M = new int[9];
                int[] L = new int[16];
                Random ran = new Random();
                int k, p;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(10, 50);
                    N[i] = k;
                }
                for (int i = 0; i < M.Length; i++)
                {
                    p = ran.Next(51, 99);
                    M[i] = p;
                }
                for (int i = 0; i < N.Length; i++)
                {
                    L[i] = N[i];
                }
                for (int i = 7; i < L.Length; i++)
                {
                    L[i] = M[i];
                }
                MessageBox.Show($"Исходный массив=\n{string.Join(", ", M)}\n{string.Join(", ", N)}\nРезультат =\n{string.Join(", ", L)}", "Системное сообщение",
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
