using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.ViewModel
{
    public class BasicVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        // List can be global if left here
        public static ObservableCollection<BasicVM> ObservableColl { get; set; } = new ObservableCollection<BasicVM>();
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChangedEventHandler? handler = PropertyChanged;

            if (handler != null) handler(this, new PropertyChangedEventArgs(property));
        }
    }
}
