using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PieMenuExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PieMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Console.WriteLine("{0} clicked", (sender as PieInTheSky.PieMenuItem).Header);
        }

        private void MainWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // The goal is to be able to come up with a way to move the window given it has windowstyle=none (which is required for transparency).

            // DragMove is the way to instantiate a move, but the only time I can get DragMove() to work is from primary mouse button down.
            // without the if statement on the control key, the window will eat the mouse clicks, and the pie menu clicks will not occur.
            // Surprisingly, C-Click only works if i'm within the window but not on a pie menu.

            base.OnMouseLeftButtonDown(e);
            if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
            {
                this.DragMove();
            }
        }
    }
}
