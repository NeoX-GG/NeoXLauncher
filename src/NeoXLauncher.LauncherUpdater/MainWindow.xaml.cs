using NeoXLauncher.LauncherUpdater.Config;
using NeoXLauncher.LauncherUpdater.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeoXLauncher.LauncherUpdater;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void Window_Loaded(object sender, RoutedEventArgs e)
    {
        Start();
        DownloadHelper.webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(FileProgressChanged);
        DownloadHelper.webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(FileCompleted);
        if (ConfigVariables.DownloadActive && !DownloadHelper.SameFiles())
        {
            DownloadHelper.Download();
        }
    }

    private async Task Start()
    {
        UpdateBar.Value = 0;
        while (UpdateBar.Value != 100)
        {
            UpdateBar.Value += 10;
            await Task.Delay(150);
        }
    }

    private void FileCompleted(object? sender, AsyncCompletedEventArgs e)
    {
        if (DownloadHelper.Finished())
        {
            DownloadHelper.Download();
            return;
        }
        StartLauncher();
    }

    private void FileProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
        UpdateBar.Value = e.ProgressPercentage;
    }

    private void StartLauncher()
    {
        ProcessStartInfo Si = new()
        {
            FileName = "NeoXLauncher.exe",
            Verb = "runas",
            UseShellExecute = true
        };
        Process.Start(Si);
        Environment.Exit(1);
    }
}
