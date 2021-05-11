using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Model;

namespace BindingTest
{
    [NotifyPropertyChanged]
    public class ViewModel
    {
        public static ViewModel Instance { get; private set; } = new ViewModel();

        public ObservableCollection<Model> Models { get; set; } = new ObservableCollection<Model>();

        public Model SelectedModel { get; set; }

        private ViewModel()
        {
            Models.Add(new Model { Name = "First", prop1 = true });
            Models.Add(new Model { Name = "Second", prop2 = true });
            Models.Add(new Model { Name = "Third" });
            Models.Add(new Model { Name = "Fourth" });
        }
    }
}
