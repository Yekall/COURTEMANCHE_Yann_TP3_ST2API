using System;
using System.Globalization;
using System.Printing;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using projet.MVM.ViewWodel;
using ApiControler;

namespace projet.MVM.View
{
    public partial class CityView : UserControl
    {
        public CityView()
        
        {
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(ShowMetric));
            
                t.Start();

          

        }

        public async void ShowMetric()
        {
            
            
           
            this.Dispatcher.BeginInvoke(new Action(() =>  
            {  
                MainWindow mw = (MainWindow) Application.Current.MainWindow;
         
                var p = new APIcontrol();
                
                try
                {
                    p.GetInfo2(mw.Searchstr);

                }
                catch (Exception e)
                {
                    p.GetInfo2("paris");
                    
                }
                
                title.Text =  p.objectRes.name;
                mw.city.Content = p.objectRes.name;


                type.Text = p.objectRes.weather[0].description;
                wind.Text = "Wind : " + p.objectRes.wind.speed+ "m//s";
                temp.Text =  "Temp : " + p.objectRes.main.temp + "C°";
                Uri uri = new Uri ( "http://openweathermap.org/img/wn/"+p.objectRes.weather[0].icon+"@4x.png");
                ImageSource imgSource = new BitmapImage(uri);
                Imageweather.Source = imgSource;

                testj1.Text = UnixTimeStampToday(p.objectRes2.list[8].dt);
                testj2.Text = UnixTimeStampToday(p.objectRes2.list[16].dt);
                testj3.Text = UnixTimeStampToday(p.objectRes2.list[24].dt);
                testj4.Text = UnixTimeStampToday(p.objectRes2.list[32].dt);
                
                tempweather1.Text = p.objectRes2.list[8].main.temp + "C°";
                tempweather2.Text = p.objectRes2.list[16].main.temp + "C°";
                tempweather3.Text = p.objectRes2.list[24].main.temp + "C°";
                tempweather4.Text = p.objectRes2.list[32].main.temp + "C°";
                
                
                 uri = new Uri ( "http://openweathermap.org/img/wn/"+p.objectRes2.list[8].weather[0].icon+"@2x.png");
                 imgSource = new BitmapImage(uri);
                 Imageweather1.Source = imgSource;

                 uri = new Uri ( "http://openweathermap.org/img/wn/"+p.objectRes2.list[16].weather[0].icon+"@2x.png");
                 imgSource = new BitmapImage(uri);
                 Imageweather2.Source = imgSource;
                 
                 uri = new Uri ( "http://openweathermap.org/img/wn/"+p.objectRes2.list[24].weather[0].icon+"@2x.png");
                 imgSource = new BitmapImage(uri);
                 Imageweather3.Source = imgSource;
                 
                 uri = new Uri ( "http://openweathermap.org/img/wn/"+p.objectRes2.list[32].weather[0].icon+"@2x.png");
                 imgSource = new BitmapImage(uri);
                 Imageweather4.Source = imgSource;
            })); 
           
           
            

        }
        public static string UnixTimeStampToday( double unixTimeStamp )
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
            
            return dateTime.ToString("dddd", new CultureInfo("en-US"));
        }
    }
}