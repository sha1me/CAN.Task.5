using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._5.View.Pages.TaskPages
{
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }

        private void BtnTask13_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(TbA.Text);
                string[] N = new string[A];
                Random ran = new Random();
                int k, S = 0;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(1, 20);
                    S += k;
                    string B = Convert.ToString(k, 2);
                    N[i] = B;
                }
                S /= A;
                string T = Convert.ToString(S, 2);

                MessageBox.Show($"{string.Join(", ", N)}\n Среднее значение={T}", "Системное сообщение",
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
