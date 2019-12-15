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

namespace TetrisGame
{
    /// <summary>
    /// Interaction logic for MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            Left = 600;
            Top = 150;
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            MainMenuwindow.Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e) => MainMenuwindow.Close();
    }
}
