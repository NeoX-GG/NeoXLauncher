using NeoXLauncher.Executable.Models.SubModels;
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

namespace NeoXLauncher.Executable.Models;

/// <summary>
/// Lógica de interacción para MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        HomeButton_MouseLeftButtonDown(null, null);
    }

    private void HomeButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        HomeWindow window = new();
        WindowStackPanel.Children.Clear();

        object content = window.Content;
        window.Content = null;
        window.Close();
        WindowStackPanel.Children.Add(content as UIElement);
    }

    private void NewsButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
#if DEBUG
        NewsWindow window = new();
        WindowStackPanel.Children.Clear();

        object content = window.Content;
        window.Content = null;
        window.Close();
        WindowStackPanel.Children.Add(content as UIElement);
        return;
#endif
        MessageBox.Show("In development");
    }

    private void AccountButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {

    }

    private void GiftButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {

    }
}
