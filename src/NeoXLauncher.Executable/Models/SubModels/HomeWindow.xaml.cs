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

namespace NeoXLauncher.Executable.Models.SubModels
{
    /// <summary>
    /// Lógica de interacción para HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public string NewImage1 = "https://png.pngtree.com/element_our/png/20180928/beautiful-hologram-water-color-frame-png_119551.jpg";
        public string NewImage2 = "https://png.pngtree.com/element_our/png/20180928/beautiful-hologram-water-color-frame-png_119551.jpg";
        public string NewImage3 = "https://png.pngtree.com/element_our/png/20180928/beautiful-hologram-water-color-frame-png_119551.jpg";
        public string NewImage4 = "https://png.pngtree.com/element_our/png/20180928/beautiful-hologram-water-color-frame-png_119551.jpg";
        public string NewImage5 = "https://png.pngtree.com/element_our/png/20180928/beautiful-hologram-water-color-frame-png_119551.jpg";
        public string NewImage6 = "https://png.pngtree.com/element_our/png/20180928/beautiful-hologram-water-color-frame-png_119551.jpg";
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(1);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
