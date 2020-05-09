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
using HangMan.Services;
using HangMan.Model;

namespace HangMan.Views
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            //SerializationActions actions = new SerializationActions();
            //Words words = new Words();
            //actions.SerializeWords("Words.xml", words);
            InitializeComponent();
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StartClick(object sender, RoutedEventArgs e)
        {
            SignIn signIn = new SignIn();
            App.Current.MainWindow = signIn;
            signIn.Show();
            this.Close();
        }
    }
}
