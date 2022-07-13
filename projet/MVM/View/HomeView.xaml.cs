using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Maps.MapControl.WPF;
using ApiControler;

namespace projet.MVM.View
{


    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            MainWindow mw = (MainWindow)Application.Current.MainWindow;

            Mymap.Focus();
        }

        private void MapWithPushpins_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            e.Handled = true;
            MainWindow mw = (MainWindow)Application.Current.MainWindow;

            Point mousePosition = e.GetPosition(this);
            Location pinLocation = Mymap.ViewportPointToLocation(mousePosition);

            Pushpin pin = new Pushpin();
            pin.Location = pinLocation;


            var p = new APIcontrol();
            p.GetCity(pinLocation.Latitude.ToString(), pinLocation.Longitude.ToString());
            mw.searchbar.Text = p.objectRes.name;
           




        }


    }
}

public class MyTileSource : Microsoft.Maps.MapControl.WPF.TileSource
{
    public override Uri GetUri(int x, int y, int zoomLevel)
    {
        return new Uri(UriFormat.
            Replace("{x}", x.ToString()).
            Replace("{y}", y.ToString()).
            Replace("{z}", zoomLevel.ToString()));
    }
}

public class MyTileLayer : Microsoft.Maps.MapControl.WPF.MapTileLayer
{
    public MyTileLayer()
    {
        TileSource = new MyTileSource();
    }

    public string UriFormat
    {
        get { return TileSource.UriFormat; }
        set { TileSource.UriFormat = value; }
    }

  
}

