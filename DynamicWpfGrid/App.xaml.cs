using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DynamicWpfGrid
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindowViewModel = new MainWindowViewModel
            {
                CustomControls = new ObservableCollection<CustomControl>
                {
                    new CustomControl(new CustomControlViewModel() { Caption = "A", Column = 0, Row = 0 }),
                    new CustomControl(new CustomControlViewModel() { Caption = "B", Column = 1, Row = 1 }),
                    new CustomControl(new CustomControlViewModel() { Caption = "C", Column = 2, Row = 2 })
                }
            };

            var mainWindow = new MainWindow(mainWindowViewModel);
            mainWindow.Show();
        }
    }
}
