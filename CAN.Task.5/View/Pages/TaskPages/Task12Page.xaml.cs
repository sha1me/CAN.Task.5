using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._5.View.Pages.TaskPages
{
    public partial class Task12Page : Page
    {
        public Task12Page()
        {
            InitializeComponent();
        }

        private void BtnTask12_Click(object sender, RoutedEventArgs e)
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
                string T = Convert.ToString(S, 2);

                MessageBox.Show($"{string.Join(", ", N)}\n Сумма={T}", "Системное сообщение",
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
