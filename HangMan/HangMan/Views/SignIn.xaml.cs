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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HangMan.Model;
using HangMan.ViewModels;
using HangMan.Services;

namespace HangMan.Views
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    partial class SignIn : Window
    {
        SerializationActions actions = new SerializationActions();
        public SignIn()
        {
            InitializeComponent();
            DataContext = actions.DeserializeUsers("User.xml");
        }

        private void NewUserClick(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            App.Current.MainWindow = signUp;
            signUp.Show();
            this.Close();
        }

        //private void PlayClick(object sender, RoutedEventArgs e)
        //{
        //    if (UserList.SelectedItem != null)
        //    {
        //        SignInViewModel.SignedInUser = (DataContext as SignInViewModel).SelectedUser;
        //        LoadNewGame loadNewGame= new LoadNewGame();
        //        App.Current.MainWindow = loadNewGame;
        //        loadNewGame.Show();
        //        this.Close();
        //    }
        //}

        private void BackClick(object sender, RoutedEventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            App.Current.MainWindow = startWindow;
            startWindow.Show();
            this.Close();
        }
    }
}
