using HangMan.Model;
using HangMan.Services;
using HangMan.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime;
using System.Windows;

namespace HangMan.ViewModels
{
    class ChooseGameViewModel : Base
    {
        public ObservableCollection<bool> categories { get; set; } = new ObservableCollection<bool>();
        public static User selectedUser = SignInViewModel.SignedInUser;
        private bool allCategories;
        public ChooseGameViewModel()
        {
            categories.Add(AllCategories);
            categories.Add(RiversCategory);
            categories.Add(CarsCategory);
            categories.Add(MoviesCategory);
            categories.Add(FlowersCategory);
        }
        

        #region CategoryChecked
        public static Category chosenCategory;
        public bool AllCategories
        {
            get
            {
                return allCategories;
            }
            set
            {
                allCategories = value;
                CanExecuteStartCommand = true;
                if (allCategories == true)
                {
                    chosenCategory = Category.AllCategories;
                }
                OnPropertyChanged("AllCategories");
            }
        }
        private bool riversCategory;
        public bool RiversCategory
        {
            get
            {
                return riversCategory;
            }
            set
            {
                riversCategory = value;
                CanExecuteStartCommand = true;
                if (riversCategory == true)
                {
                    chosenCategory = Category.Rivers;
                }
                OnPropertyChanged("RiversCategory");
            }
        }
        private bool carsCategory;
        public bool CarsCategory
        {
            get
            {
                return carsCategory;
            }
            set
            {
                carsCategory = value;
                CanExecuteStartCommand = true;
                if (carsCategory == true)
                {
                    chosenCategory = Category.Cars;
                }
                OnPropertyChanged("CarsCategory");
            }
        }
        private bool moviesCategory;
        public bool MoviesCategory
        {
            get
            {
                return moviesCategory;
            }
            set
            {
                moviesCategory = value;
                CanExecuteStartCommand = true;
                if (moviesCategory == true)
                {
                    chosenCategory = Category.Movies;
                }
                OnPropertyChanged("MoviesCategory");
            }
        }
        private bool flowersCategory;
        public bool FlowersCategory
        {
            get
            {
                return flowersCategory;
            }
            set
            {
                flowersCategory = value;
                CanExecuteStartCommand = true;
                if(flowersCategory == true)
                {
                    chosenCategory = Category.Flowers;
                }
                OnPropertyChanged("FlowersCategory");
            }
        }
        #endregion

        #region Command for Play Button
        public bool CanExecuteStartCommand { get; set; } = false;

        private ICommand startGameCommand;
        public ICommand StartGameCommand
        {
            get
            {
                if (startGameCommand == null)
                {
                    startGameCommand = new RelayCommand(StartMethod, param => CanExecuteStartCommand);
                }
                return startGameCommand;
            }
        }
        private void StartMethod(object param)
        {
            GameWindowViewModel gameVM = new GameWindowViewModel();
            GameWindow gameWindow = new GameWindow(gameVM);
            App.Current.MainWindow.Close();
            App.Current.MainWindow = gameWindow;
            gameWindow.Show();
        }

        private ICommand backCommand;
        public ICommand BackCommand
        {
            get
            {
                if (backCommand == null)
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
    #endregion
}
