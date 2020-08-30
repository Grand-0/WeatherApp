using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WeatherAppWPF.Data.ViewModels;

namespace WeatherAppWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private OneDayViewModel data;

        private void GetWeatherOneDay_Click(object sender, RoutedEventArgs e)
        {
            if (CityName != null)
            {
                data = new OneDayViewModel(CityName.Text);

                YourNameCity.Text = "City name: " + data.GetCityName();
                YourCountryName.Text = "Country name: " + data.GetCountryName();
                CoordianteLongitude.Text = "City longitude: " + data.GetLongitude().ToString();
                CoordinateLatitude.Text = "City latitude: " + data.GetLatitude().ToString();
                Temperature.Text = "Temperature: " + data.GetTempInCelsius().ToString();
                TemperatureFeelLike.Text = "Feel like: " + data.GetTempFeelLike_InCelsius().ToString();
                Pressure.Text = "Pressure: " + data.GetPressure().ToString();
                Humidity.Text = "Humidity: " + data.GetHumidity().ToString();
                WindSpeed.Text = "Wind speed: " + data.GetWindSpeed().ToString();
                Description.Text = "Weather: " + data.GetDescription();
                LongDescription.Text = "Weather description: " + data.GetLongDescription();
            }
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
