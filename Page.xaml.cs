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
    /// Logica di interazione per Page.xaml
    /// </summary>
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            ColumnDefinition col0 = new ColumnDefinition();
            col0.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinition col1 = new ColumnDefinition();
            col1.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinition col2 = new ColumnDefinition();
            col2.Width = new GridLength(1, GridUnitType.Star);
            RowDefinition row0 = new RowDefinition();
            row0.Height = new GridLength(1, GridUnitType.Star);
            RowDefinition row1 = new RowDefinition();
            row1.Height = new GridLength(1, GridUnitType.Star);
            //Grid grid = new Grid() { Margin = new Thickness(10) };
            GridPage.RowDefinitions.Add(row0);
            GridPage.RowDefinitions.Add(row1);
            GridPage.ColumnDefinitions.Add(col0);
            GridPage.ColumnDefinitions.Add(col1);
            GridPage.ColumnDefinitions.Add(col2);

            UserControlItem item00 = new UserControlItem() { ItemName = "Carbonara", Price = "12,00", Ingredients = "La mamma di giuseppe" };
            GridPage.Children.Add(item00);
            Grid.SetRow(item00, 0);
            Grid.SetColumn(item00, 0);

            UserControlItem item01 = new UserControlItem() { ItemName = "Amatri" };
            GridPage.Children.Add(item01);
            Grid.SetRow(item01, 0);
            Grid.SetColumn(item01, 1);

            UserControlItem item02 = new UserControlItem() { ItemName = "as" };
            GridPage.Children.Add(item02);
            Grid.SetRow(item02, 0);
            Grid.SetColumn(item02, 2);

            UserControlItem item10 = new UserControlItem() { ItemName = "fdsfdfdsf" };
            GridPage.Children.Add(item10);
            Grid.SetRow(item10, 1);
            Grid.SetColumn(item10, 0);

            UserControlItem item11 = new UserControlItem() { ItemName = "54tfg" };
            GridPage.Children.Add(item11);
            Grid.SetRow(item11, 1);
            Grid.SetColumn(item11, 1);

            UserControlItem item12 = new UserControlItem() { ItemName = "frvgdre5" };
            GridPage.Children.Add(item12);
            Grid.SetRow(item12, 1);
            Grid.SetColumn(item12, 2);
;
        }
    }
}
