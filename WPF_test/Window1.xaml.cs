using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_test
{
    public partial class Window1 : Window
    {
        public ObservableCollection<string> MyValues { get; private set; }

        public Window1()
        {
            MyValues = new ObservableCollection<string>();
            MyValues.Add("array");
            MyValues.Add("element");
            MyValues.Add("bindings");
            //use the ObservableCollection<string> MyValues  as
            //the DataContext for the Window
            this.DataContext = MyValues;
            InitializeComponent();
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            MyValues.Clear();
            MyValues.Add("bindings");
            MyValues.Add("element");
            MyValues.Add("array");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyValues.Clear();
            MyValues.Add("element");
            MyValues.Add("bindings");
            MyValues.Add("array");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyValues.Clear();
            MyValues.Add("array");
            MyValues.Add("bindings");
            MyValues.Add("element");
        }
    }
}
