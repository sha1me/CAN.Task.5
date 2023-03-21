using CAN.Task._5.Core;
using System.Windows;
using CAN.Task._5.View.Pages.TaskPages;
using CAN.Task._5.View.Pages;

namespace CAN.Task._5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
        private void BtnTask101_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task7Page());
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task1Page());
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task2Page());
        }

        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task8Page());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task3Page());
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task4Page());
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task5Page());
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task6Page());
        }

        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task9Page());
        }

        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task10Page());
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task11Page());
        }

        private void BtnTask12_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task12Page());
        }

        private void BtnTask13_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task13Page());
        }

        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task14Page());
        }

        private void BtnTask0_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
    }
}