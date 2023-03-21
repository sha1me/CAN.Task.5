using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._5.View.Pages.TaskPages
{
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }

        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] N = new int[12];
                string[] M = new string[12];
                Random ran = new Random();
                int k;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(1, 299);
                    string B = Convert.ToString(k, 2);
                    M[i] = B;
                }

                MessageBox.Show($"{string.Join(", ", M)}", "Системное сообщение",
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
