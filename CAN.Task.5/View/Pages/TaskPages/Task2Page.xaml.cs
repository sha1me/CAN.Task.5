using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._5.View.Pages.TaskPages
{
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string A = (TbA.Text);
                double DecimalNumber = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[A.Length - i - 1] == '0') continue;
                    DecimalNumber += (double)Math.Pow(2, i);
                }
                MessageBox.Show($"{DecimalNumber}", "Системное сообщение",
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
