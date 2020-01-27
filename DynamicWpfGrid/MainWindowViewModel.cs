using System.Collections.ObjectModel;
using System.Linq;

namespace DynamicWpfGrid
{
    public class MainWindowViewModel
    {
        public ObservableCollection<CustomControl> CustomControls { get; set; }

        public int Rows => CustomControls.Max(c => (c.DataContext as CustomControlViewModel).Row + 1);
        public int Columns => CustomControls.Max(c => (c.DataContext as CustomControlViewModel).Column + 1);

        public MainWindowViewModel()
        {
            CustomControls = new ObservableCollection<CustomControl>();
        }
    }
}
