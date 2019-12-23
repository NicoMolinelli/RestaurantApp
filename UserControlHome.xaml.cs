using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantAppWPF
{ 
    /// <summary>
    /// Logica di interazione per UserControlHome.xaml
    /// </summary>
    public partial class UserControlHome : UserControl
    {
        

        public UserControlHome()
        {
            InitializeComponent();
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ((MainWindow)System.Windows.Application.Current.MainWindow).ListViewMenu.SelectedIndex = 1;
        }
    }
}
