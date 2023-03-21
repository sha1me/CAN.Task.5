using System.Windows;

namespace CAN.Task._5
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}
