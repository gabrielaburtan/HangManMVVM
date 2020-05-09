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

namespace HangMan.Views
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class ChooseGameWindow : Window
    {
        public ChooseGameWindow()
        {
            InitializeComponent();
        }

        //private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    GameWindow gameWindow = new GameWindow();
        //    App.Current.MainWindow = gameWindow;
        //    gameWindow.Show();
        //    this.Close();
        //}
    }
}
