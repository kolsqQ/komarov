using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Security;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int asd;

        public MainWindow()
        {
            InitializeComponent();
        }



    
        

        private void Add(object sender, RoutedEventArgs e)
        {
            asd++;
            zxc.Items.Add(asd);
        }


        private void DEL(object sender, RoutedEventArgs e)
        {
            zxc.Items.Remove(zxc.SelectedItem);
        }



        private void CLEAR(object sender, RoutedEventArgs e)
        {
            zxc.Items.Clear();
            asd = 0;
        }

    }
}
