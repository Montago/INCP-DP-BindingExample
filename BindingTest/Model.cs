using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Model;

namespace BindingTest
{

    [NotifyPropertyChanged]
    public class Model
    {
        public string Name { get; set; }

        public bool prop1 { get; set; }

        public bool prop2 { get; set; }

    }
}
