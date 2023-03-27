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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyClass myc { get; set; } = new MyClass();
        private static ObservableCollection<Data> List = new ObservableCollection<Data>();
        public MainWindow()
        {
            InitializeComponent();
            myc.mytext = "数据一";
           
            Data2.DataContext = myc;

            DateName.ItemsSource = List;
            List.Add(new Data() { Id = 1, Name = "zaaa", Sex = 25, Height = 4500 });


        }
       

    public class MyClass : INotifyPropertyChanged
    {
            public MyClass()
            {
                this.PropertyChanged += MyClass_PropertyChanged;
            }

            private void MyClass_PropertyChanged(object sender, PropertyChangedEventArgs e)
            {
                var asssq =0;
            }

            public event PropertyChangedEventHandler PropertyChanged;
            private string _mytext;
            public string mytext
            {
                get
                { return _mytext; }
                set
                {
                    _mytext = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("mytext"));
                }
            }
         
           

    }
        //定义一个Data数据类并继承于INotifyPropertyChanged 
        public class Data : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            public Data()
            {
                _id = Id;
                _name = Name;
                _sex = Sex;
                _pone = Pone;
            }

            private int _id;
            public int Id
            {
                get { return _id; }
                set
                {
                    if (_id != value) ;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
                }
            }
            private string _name;
            public string Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
            private int _sex;
            public int Sex
            {
                get { return _sex; }
                set
                {
                    _sex = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sex"));
                }
            }
            private string _pone;
            public string Pone
            {
                get { return _pone; }
                set
                {
                    _pone = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pone"));
                }
            }
            private double _height;
            public double Height
            {
                get { return _height; }
                set { _height = value;PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height")); }
            }
        }

        private void DateName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
