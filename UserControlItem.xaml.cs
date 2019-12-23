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
    /// Logica di interazione per UserControlItem.xaml
    /// </summary>
    public partial class UserControlItem : UserControl
    {


        public string ItemName
        {
            get { return (string)GetValue(ItemNameProperty); }
            set { SetValue(ItemNameProperty, value); }
        }

        public string Ingredients
        {
            get { return (string)GetValue(IngredientsProperty); }
            set { SetValue(IngredientsProperty, value); }
        }

        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        public string ItemImage
        {
            get { return (string)GetValue(ItemImageProperty); }
            set { SetValue(ItemImageProperty, value); }
        }



        



        public static readonly DependencyProperty ItemImageProperty =
            DependencyProperty.Register("ItemImage", typeof(string), typeof(UserControlItem));

        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(string), typeof(UserControlItem), new PropertyMetadata(""));

        public static readonly DependencyProperty ItemNameProperty =
            DependencyProperty.Register("ItemName", typeof(string), typeof(UserControlItem), new PropertyMetadata(""));

        public static readonly DependencyProperty IngredientsProperty =
            DependencyProperty.Register("Ingredients", typeof(string), typeof(UserControlItem), new PropertyMetadata(""));




        public UserControlItem()
        {
            InitializeComponent();
        }
    }
}
