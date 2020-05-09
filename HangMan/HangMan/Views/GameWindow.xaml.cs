using HangMan.ViewModels;
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
using System.Windows.Threading;

namespace HangMan.Views
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        //DispatcherTimer dispatcherTimer = new DispatcherTimer();
        //private int seconds = 30;
        //private DateTime deadline;

        public GameWindow(GameWindowViewModel gameVM)
        {
            InitializeComponent();
            DataContext = gameVM;
        }
    }
}
