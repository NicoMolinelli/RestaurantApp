
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RestaurantAppWPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<UserControlItem> userControlItems;
        IEnumerable<UserControlItem> userControlItemsFilteredBySearchBar;
        private int startingItemsindex;
        private StackPanel firstItemsLine;
        private StackPanel secondItemsLine;
        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            SetAllAtStart();
        }


        public void ChangeListViewIndex(int index)
        {
            ListViewMenu.SelectedIndex = index;

        }

        private void SetAllAtStart()
        {
            ListViewMenu.SelectedIndex = 0;
            ReadJson();
            //firstpanel
            firstItemsLine = new StackPanel();
            firstItemsLine.Orientation = Orientation.Horizontal;
            firstItemsLine.HorizontalAlignment = HorizontalAlignment.Center;
            firstItemsLine.VerticalAlignment = VerticalAlignment.Top;
            firstItemsLine.Margin = new Thickness(5, 5, 15, 5);

            //secondpanel
            secondItemsLine = new StackPanel();
            secondItemsLine.HorizontalAlignment = HorizontalAlignment.Center;
            secondItemsLine.Orientation = Orientation.Horizontal;
            secondItemsLine.VerticalAlignment = VerticalAlignment.Bottom;
            secondItemsLine.Margin = new Thickness(5, 5, 15, 5);
        }

        private void ReadJson()
        {
            string json = File.ReadAllText("..\\..\\jsons\\ProductZ.json");
            userControlItems = JsonConvert.DeserializeObject<List<UserControlItem>>(json);
        }
        

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;

            ChangeCursorGrid(index);
            switch (index)
            {
                case 0:
                    MainGrid.Children.Clear();
                    TextBoxSearchBar.IsEnabled = false;
                    ButtonShowPreviousPage.Visibility = Visibility.Collapsed;
                    ButtonShowNextPage.Visibility = Visibility.Collapsed;
                    //MainGrid.Children.Add(new UserControlHome() { HorizontalAlignment= HorizontalAlignment.Left});
                    MainGrid.Children.Add(new UserControlHome());
                    break;

                case 1:
                    MainGrid.Children.Clear();
                    startingItemsindex = 0;
                    ShowItems(startingItemsindex);
                    TextBoxSearchBar.IsEnabled = true;
                    TextBoxSearchBar.Clear();
                    ButtonShowPreviousPage.Visibility = Visibility.Collapsed;
                    ButtonShowNextPage.Visibility = Visibility.Visible;
                    ButtonShowNextPage.IsEnabled = true;

                    break;

                case 2:
                    MainGrid.Children.Clear();
                    startingItemsindex = 0;
                    ShowItems(startingItemsindex);
                    TextBoxSearchBar.IsEnabled = true;
                    TextBoxSearchBar.Clear();
                    ButtonShowPreviousPage.Visibility = Visibility.Collapsed;
                    ButtonShowNextPage.Visibility = Visibility.Visible;
                    ButtonShowNextPage.IsEnabled = true;

                    break;

                case 3:
                    MainGrid.Children.Clear();
                    startingItemsindex = 0;
                    ShowItems(startingItemsindex);
                    TextBoxSearchBar.IsEnabled = true;
                    TextBoxSearchBar.Clear();
                    ButtonShowPreviousPage.Visibility = Visibility.Collapsed;
                    ButtonShowNextPage.Visibility = Visibility.Visible;
                    ButtonShowNextPage.IsEnabled = true;

                    break;

                case 4:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new UserControlBook());
                    TextBoxSearchBar.IsEnabled = false;
                    ButtonShowPreviousPage.Visibility = Visibility.Collapsed;
                    ButtonShowNextPage.Visibility = Visibility.Collapsed;


                    break;

                case 5:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new UserControlAboutUs());
                    TextBoxSearchBar.IsEnabled = false;
                    ButtonShowPreviousPage.Visibility = Visibility.Collapsed;
                    ButtonShowNextPage.Visibility = Visibility.Collapsed;


                    break;

                default:
                    MainGrid.Children.Clear();
                    break;
            }

        }


        /**
         * Mostra 6 elementi di userControlItems partendo dallo startingIndex
         */
        private void ShowItems(int startingIndex)
        {
            
           

            firstItemsLine.Children.Clear();
            
            secondItemsLine.Children.Clear();

            for (int i = startingIndex; i <  startingIndex+6 && i < userControlItems.Count; i++)
            {
                if (i < startingIndex+3 )
                {
                    firstItemsLine.Children.Add(userControlItems.ElementAt(i));
                }
                else
                    secondItemsLine.Children.Add(userControlItems.ElementAt(i));
            }

            MainGrid.Children.Add(firstItemsLine);
            MainGrid.Children.Add(secondItemsLine);

            

            //Page page1 = new Page();
            //MainGrid.Children.Add(page1);




        }
        /**
         * Mostra 6 elementi di userControlItemsFilteredBySearchBar partendo dallo startingIndex
         */
        private void ShowFilteredItems(int startingIndex)
        {



            firstItemsLine.Children.Clear();

            secondItemsLine.Children.Clear();

            for (int i = startingIndex; i < startingIndex + 6 && i < userControlItemsFilteredBySearchBar.Count(); i++)
            {
                if (i < startingIndex + 3)
                {
                    firstItemsLine.Children.Add(userControlItemsFilteredBySearchBar.ElementAt(i));
                }
                else
                    secondItemsLine.Children.Add(userControlItemsFilteredBySearchBar.ElementAt(i));
            }

            MainGrid.Children.Add(firstItemsLine);
            MainGrid.Children.Add(secondItemsLine);

        }

        private void ChangeCursorGrid(int index)
        {
            TransitioningContentCursor.OnApplyTemplate();
            CursorGrid.Margin = new Thickness(0, 100 + (index * 60), 0, 0);
        }

        private void ButtonDragMove_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonShowButtonsuser_Click(object sender, RoutedEventArgs e)
        {
            ButtonShowButtonsuser.Visibility = Visibility.Hidden;
            StackPanelUserButtons.Visibility = Visibility.Visible;

        }

        private void ButtonArrowUp_Click(object sender, RoutedEventArgs e)
        {
            ButtonShowButtonsuser.Visibility = Visibility.Visible;
        }
        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonArrowLeft.Visibility = Visibility.Visible;
            ButtonMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonArrowLeft_Click(object sender, RoutedEventArgs e)
        {
            ButtonArrowLeft.Visibility = Visibility.Collapsed;
            ButtonMenu.Visibility = Visibility.Visible;
        }

        private void ButtonShowNextPage_Click(object sender, RoutedEventArgs e)
        {

            MainGrid.Children.Clear();
            if (startingItemsindex == 0)
                ButtonShowPreviousPage.Visibility = Visibility.Visible;
            startingItemsindex += 6;
            ShowItems(startingItemsindex);
            if (ButtonShowPreviousPage.IsEnabled == false)
                ButtonShowPreviousPage.IsEnabled = true;
            if (startingItemsindex+6 >= userControlItems.Count)
                ButtonShowNextPage.IsEnabled = false;
        }

        private void ButtonShowPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            startingItemsindex -= 6;
            ShowItems(startingItemsindex);
            if (ButtonShowNextPage.IsEnabled == false)
                ButtonShowNextPage.IsEnabled = true;
            if (startingItemsindex - 6 < 0 )
                ButtonShowPreviousPage.IsEnabled = false;
        }

        private void TextBoxSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            MainGrid.Children.Clear();
            TextBox tb = (TextBox)sender;
            userControlItemsFilteredBySearchBar = from UserControlItem in userControlItems where UserControlItem.ItemName.ToLower().Contains(tb.Text) select UserControlItem;
            ShowFilteredItems(0);
        }

        private void ButtonShutDown_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonSetting_Click(object sender, RoutedEventArgs e)
        {
            GridSettings.Visibility = Visibility.Visible;
            MenuGrid.IsEnabled = false;
        }

        private void ButtonCloseGridSettings_Click(object sender, RoutedEventArgs e)
        {

            
            
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(900);
            timer.Start();
            timer.Tick += delegate
             {
                 timer.Stop();
                 GridSettings.Visibility = Visibility.Collapsed; MenuGrid.IsEnabled = true;
             };
            
        }
    }
}
