using System;
using System.Collections.Generic;
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

namespace RestaurantAppWPF
{
    /// <summary>
    /// Logica di interazione per UserControlBook.xaml
    /// </summary>
    public partial class UserControlBook : UserControl
    {
        public List<string> hours;
        public UserControlBook()
        {
            InitializeComponent();
            CalendarDate.BlackoutDates.AddDatesInPast();

            hours = new List<string>();
            hours.Add("18:30");
            hours.Add("19:00");
            hours.Add("19:30");
            hours.Add("20:00");
            hours.Add("20:30");
            hours.Add("21:00");
            hours.Add("21:30");
            hours.Add("22:00");

            listviewHours.ItemsSource = hours;
            
        }
    }
}
