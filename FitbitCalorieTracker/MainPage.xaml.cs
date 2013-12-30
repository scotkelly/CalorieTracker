using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FitbitCalorieTracker.Resources;
using Microsoft.Xna.Framework;


namespace FitbitCalorieTracker
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            SetupLiveTile();
        }

        private void SetupLiveTile()
        {
            var tile = ShellTile.ActiveTiles.First();
            if (tile == null) return;

            var tileData = new IconicTileData()
            {
                BackgroundColor = System.Windows.Media.Colors.Brown,
                Count = 0,
                IconImage = new Uri("/Assets/Tiles/IconicTileMediumLarge.png", UriKind.Relative),
                SmallIconImage = new Uri("/Assets/Tiles/IconicTileSmall.png", UriKind.Relative),
                Title = "492 calories left"
            };
            tile.Update(tileData);
        }

        private void UserNameField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            

        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}