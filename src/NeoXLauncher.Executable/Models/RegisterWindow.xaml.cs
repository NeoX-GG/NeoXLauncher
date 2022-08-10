using NeoXLauncher.Executable.Helpers;
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
/// Lógica de interacción para RegisterWindow.xaml
/// </summary>
public partial class RegisterWindow : Window
{
    public RegisterWindow()
    {
        InitializeComponent();
        KeyDown += new KeyEventHandler(KeyDownHelper.KeyDown);
    }

    private void RegisterButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        Environment.Exit(1);
    }
}
