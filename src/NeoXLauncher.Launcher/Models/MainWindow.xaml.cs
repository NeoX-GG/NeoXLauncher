using System;
using System.Windows;
using System.Windows.Input;

namespace NeoXLauncher.Launcher.Models;

/// <summary>
/// Lógica de interacción para MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        Environment.Exit(1);
    }

    private void HomeButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        LibraryStackPanel.Visibility = Visibility.Collapsed;
        LibraryButton.Opacity = 0.8;
        HomeStackPanel.Visibility = Visibility.Visible;
        HomeButton.Opacity = 1;
    }

    private void LibraryButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        HomeStackPanel.Visibility = Visibility.Collapsed;
        HomeButton.Opacity = 0.8;
        LibraryStackPanel.Visibility = Visibility.Visible;
        LibraryButton.Opacity = 1;
    }
}
