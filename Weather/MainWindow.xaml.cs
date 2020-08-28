﻿using System;
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
            if(CityName.Text != "")
            {
                data = new OneDayViewModel(CityName.Text);
                WeatherTest.Text = Convert.ToString(data.GetWindSpeed());
            }
        }
    }
}
