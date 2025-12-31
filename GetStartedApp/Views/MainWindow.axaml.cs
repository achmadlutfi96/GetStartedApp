using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;

namespace GetStartedApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonOnClick(object? sender, RoutedEventArgs e)
    {
        // Debug.WriteLine($"Click! Celcius={Celcius.Text}");
        if(double.TryParse(Celcius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            Fahrenheit.Text = "0";
            Celcius.Text = "0";
        }
    }
}