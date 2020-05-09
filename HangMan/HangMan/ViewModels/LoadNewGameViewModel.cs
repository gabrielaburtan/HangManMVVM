using HangMan.Model;
using HangMan.Services;
using HangMan.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HangMan.ViewModels
{
    public class LoadNewGameViewModel:Base
    {
        User user = SignInViewModel.SignedInUser;
     
        private ICommand newGameCommand;
        public ICommand NewGameCommand
        {
            get
            {
                if(newGameCommand==null)
                {
                    newGameCommand = new RelayCommand(NewGameMethod);
                }
                return newGameCommand;
            }
        }
        private void NewGameMethod(object param)
        {
            //GameWindowViewModel gameVM = new GameWindowViewModel();
            ChooseGameWindow chooseGame = new ChooseGameWindow();
            // chooseGame.DataContext = gameVM;
            ChooseGameViewModel.selectedUser = SignInViewModel.SignedInUser;
            App.Current.MainWindow.Close();
            App.Current.MainWindow = chooseGame;
            chooseGame.Show();
        }
        public bool CanExecuteLoadGame
        {
            get
            {
                return user.IsInGame == true;
            }
        }
        private ICommand loadGameCommand;
        public ICommand LoadGameCommand
        {
            get
            {
                if (loadGameCommand == null)
                {
                    loadGameCommand = new RelayCommand(LoadGameMethod, param => CanExecuteLoadGame);
                }
                return loadGameCommand;
            }
        }
        private void LoadGameMethod(object param)
        {
            GameWindowViewModel gameVM = new GameWindowViewModel(SignInViewModel.SignedInUser.GameProperty.Level, SignInViewModel.SignedInUser.GameProperty.Word, SignInViewModel.SignedInUser.GameProperty.CategoryProperty, SignInViewModel.SignedInUser.GameProperty.Mistakes, SignInViewModel.SignedInUser.GameProperty.WordIndex, SignInViewModel.SignedInUser.GameProperty.WordsCollection, SignInViewModel.SignedInUser.GameProperty.Seconds, SignInViewModel.SignedInUser.GameProperty.ImagePath);
            GameWindow gameWindow = new GameWindow(gameVM);
            ChooseGameViewModel.selectedUser = SignInViewModel.SignedInUser;
            App.Current.MainWindow.Close();
            App.Current.MainWindow = gameWindow;
            gameWindow.Show();
        }

        private ICommand backCommand;
        public ICommand BackCommand
        {
            get
            {
                if(backCommand == null)
                {
                    backCommand = new RelayCommand(BackMethod);
                }
                return backCommand;
            }
        }
        private void BackMethod(object param)
        {
            SignIn signIn = new SignIn();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = signIn;
            signIn.Show();
        }
    }
}
