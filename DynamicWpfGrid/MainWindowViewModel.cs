using System.Collections.ObjectModel;

namespace DynamicWpfGrid
{
    public class MainWindowViewModel
    {
        public ObservableCollection<CustomControl> CustomControls { get; set; }

        public MainWindowViewModel()
        {
            CustomControls = new ObservableCollection<CustomControl>();
        }
    }
}
