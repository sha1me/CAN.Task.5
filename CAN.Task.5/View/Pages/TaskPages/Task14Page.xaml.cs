using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._5.View.Pages.TaskPages
{
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
        }

        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(TbN.Text);
                string[] A = new string[N];
                Random ran = new Random();
                int k, max = 0, min = 21;
                for (int i = 0; i < A.Length; i++)
                {
                    k = ran.Next(1, 20);
                    if(k > max)
                    {
                        max = k;
                    }
                    if (k < min)
                    {
                        min = k;
                    }
                    string B = Convert.ToString(k, 2);
                    A[i] = B;
                }
                string S = Convert.ToString(max, 2);
                string L = Convert.ToString(min, 2);

                MessageBox.Show($"{string.Join(", ", A)}\n max ={S}, min ={L}", "Системное сообщение",
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
