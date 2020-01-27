using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DynamicWpfGrid
{
    public class MainWindowViewModel
    {
        public ObservableCollection<CustomControlViewModel> CustomControlModels { get; set; }

        public MainWindowViewModel()
        {
            CustomControlModels = new ObservableCollection<CustomControlViewModel>();
        }
    }
}
