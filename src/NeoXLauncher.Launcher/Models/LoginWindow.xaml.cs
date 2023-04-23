using NeoXLauncher.Launcher.Helpers;
using System;
using System.Windows;
using System.Windows.Input;

namespace NeoXLauncher.Launcher.Models;

/// <summary>
/// Lógica de interacción para LoginWindow.xaml
/// </summary>
public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
        KeyDown += new KeyEventHandler(KeyDownHelper.KeyDown);
    }

    public void LoginButton_Click(object sender, RoutedEventArgs e)
    {
    }

    private void DontHaveAccount_Click(object sender, RoutedEventArgs e)
    {
        new RegisterWindow().Show();
        Hide();
    }

    private void ForgottenPassword_Click(object sender, RoutedEventArgs e)
    {

    }

    private void CloseButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        Environment.Exit(1);
    }
}
