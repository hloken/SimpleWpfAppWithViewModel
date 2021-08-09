using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new MainWindow();
            var viewModel = new MainWindowViewModel();
            viewModel.Text1 = "Rupert";
            viewModel.Text2 = "Banana";
            mainWindow.DataContext = viewModel;
            mainWindow.Show();
        }
    }
}
