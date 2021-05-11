using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// <summary>
    /// Interaction logic for ModelList.xaml
    /// </summary>
    public partial class ModelList : UserControl, INotifyPropertyChanged
    {
        #region Models DependencyProperty 
        public ObservableCollection<Model> Models
        {
            get { return (ObservableCollection<Model>)GetValue(ModelsProperty); }
            set { SetValue(ModelsProperty, value); }
        }

        public static readonly DependencyProperty ModelsProperty =
            DependencyProperty.Register(
                "Models",
                typeof(ObservableCollection<Model>),
                typeof(ModelList),
                new PropertyMetadata(
                    new ObservableCollection<Model>(),
                    (sender, evt) => { ((ModelList)sender).OnNotifyPropertyChanged("Models"); }
                )
            );
        #endregion

        #region SelectedModel DependencyProperty 

        public Model SelectedModel
        {
            get { return (Model)GetValue(SelectedModelProperty); }
            set { SetValue(SelectedModelProperty, value); }
        }

        public static readonly DependencyProperty SelectedModelProperty =
            DependencyProperty.Register(
                "SelectedModel",
                typeof(Model),
                typeof(ModelList),
                new PropertyMetadata(
                    null,
                    (sender, evt) => { ((ModelList)sender).OnNotifyPropertyChanged("SelectedModel"); }
                )
            );

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnNotifyPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public ModelList()
        {
            InitializeComponent();
        }
    }
}
