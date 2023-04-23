using NeoXLauncher.Launcher.Enums;
using NeoXLauncher.Launcher.Models.SubModels;
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
using System.Windows.Shapes;

namespace NeoXLauncher.Launcher.Models;

/// <summary>
/// Lógica de interacción para MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    MainSubWindowType SubWindowType;

    public MainWindow()
    {
        InitializeComponent();
        HomeButton_MouseLeftButtonDown(null, null);
    }

    private void HomeButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        WindowStackPanel.Children.Clear();

        HomeWindow window = new();
        object content = window.Content;
        window.Content = null;
        window.Close();
        WindowStackPanel.Children.Add(content as UIElement);
        ChangeButtonHover(MainSubWindowType.Home);
    }

    private void NewsButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
#if DEBUG
        WindowStackPanel.Children.Clear();

        NewsWindow window = new();
        object content = window.Content;
        window.Content = null;
        window.Close();
        WindowStackPanel.Children.Add(content as UIElement);
        ChangeButtonHover(MainSubWindowType.News);
        return;
#endif
        MessageBox.Show("In development");
    }

    private void GiftButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
#if DEBUG
        MessageBox.Show("In development");
        return;
#endif
        MessageBox.Show("In development");
    }

    private void ConfigButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
#if DEBUG
        MessageBox.Show("In development");
        return;
#endif
        MessageBox.Show("In development");
    }

    private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        Environment.Exit(1);
    }

    void ChangeButtonHover(MainSubWindowType NewType)
    {
        if (SubWindowType == NewType)
        {
            return;
        }

        switch(SubWindowType)
        {
            case MainSubWindowType.Home:
                HomeButton.Source = new BitmapImage(new Uri(@"../Images/Home.png", UriKind.Relative));
                break;
            case MainSubWindowType.News:
                NewsButton.Source = new BitmapImage(new Uri(@"../Images/News.png", UriKind.Relative));
                break;
            case MainSubWindowType.Gift:
                GiftButton.Source = new BitmapImage(new Uri(@"../Images/Gift.png", UriKind.Relative));
                break;
            case MainSubWindowType.Config:
                ConfigButton.Source = new BitmapImage(new Uri(@"../Images/Config.png", UriKind.Relative));
                break;
        }

        SubWindowType = NewType;

        switch (SubWindowType)
        {
            case MainSubWindowType.Home:
                HomeButton.Source = new BitmapImage(new Uri(@"../Images/HomeHover.png", UriKind.Relative));
                break;
            case MainSubWindowType.News:
                NewsButton.Source = new BitmapImage(new Uri(@"../Images/NewsHover.png", UriKind.Relative));
                break;
            case MainSubWindowType.Gift:
                GiftButton.Source = new BitmapImage(new Uri(@"../Images/GiftHover.png", UriKind.Relative));
                break;
            case MainSubWindowType.Config:
                ConfigButton.Source = new BitmapImage(new Uri(@"../Images/ConfigHover.png", UriKind.Relative));
                break;
        }
    }
}
