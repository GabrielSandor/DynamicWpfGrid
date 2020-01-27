using System.Windows.Controls;

namespace DynamicWpfGrid
{
    /// <summary>
    /// Interaction logic for CustomControl.xaml
    /// </summary>
    public partial class CustomControl : UserControl
    {
        public CustomControl(CustomControlViewModel model)
        {
            DataContext = model;

            InitializeComponent();
        }
    }
}
