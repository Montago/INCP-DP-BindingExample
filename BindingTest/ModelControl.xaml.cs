using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingTest
{
    public partial class ModelControl : UserControl, INotifyPropertyChanged
    {
        #region ActiveModel DependencyProperty 

        public Model ActiveModel
        {
            get { return (Model)GetValue(ActiveModelProperty); }
            set { SetValue(ActiveModelProperty, value); }
        }

        public static readonly DependencyProperty ActiveModelProperty =
            DependencyProperty.Register(
                "ActiveModel",
                typeof(Model),
                typeof(ModelControl),
                new PropertyMetadata(
                    null,
                    (sender, evt) => { ((ModelControl)sender).OnNotifyPropertyChanged("ActiveModel"); }
                )
            );

        #endregion

        #region Header DependencyProperty 

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register(
                "Header",
                typeof(string),
                typeof(ModelControl),
                new PropertyMetadata(
                    "",
                    (sender, evt) => { ((ModelControl)sender).OnNotifyPropertyChanged("Header"); }
                )
            );

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnNotifyPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


        public ModelControl()
        {
            InitializeComponent();
        }
    }
}
