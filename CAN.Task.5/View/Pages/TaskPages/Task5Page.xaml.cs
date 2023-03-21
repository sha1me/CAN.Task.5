using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._5.View.Pages.TaskPages
{
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int A = Convert.ToInt32(TbA.Text);
                int[] N = new int[15];
                int[] M = new int[15];
                Random ran = new Random();
                int k;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(10, 99);
                    M[i] = k;
                    int T = int.Parse(new string(k.ToString().OrderByDescending(x => x).ToArray()));
                    N[i] = T;
                }

                MessageBox.Show($"Исходный массив=\n{string.Join(", ", M)}\nРезультат=\n{string.Join(", ", N)}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
                TbA.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
