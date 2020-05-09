using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HangMan.ViewModels;
using HangMan.Services;
using HangMan.Model;
using HangMan.Views;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows;

namespace HangMan.ViewModels
{
    public class SignUpViewModel : Base
    { 
        private SignInViewModel signInVM;
        private SerializationActions actions = new SerializationActions();
        private Images images = new Images();

        public SignUpViewModel()
        {
            ImageSource = images.ImagesList.ElementAt(0);
            signInVM = actions.DeserializeUsers("User.xml");
        }

        #region Chosen info about user
        private BitmapImage imageSource;
        public BitmapImage ImageSource
        {
            get
            {
                return imageSource;
            }
            set
            {
                imageSource = value;
                CanExecuteNextImageCommand = Validators.CanExecuteNextImage(ImageSource, images);
                CanExecutePrevImageCommand = Validators.CanExecutePrevImage(ImageSource, images);
                OnPropertyChanged("ImageSource");
            }
        }

        private string nameTextBox;
        public string NameTextBox
        {
            get
            {
                return nameTextBox;
            }
            set
            {
                nameTextBox = value;
                OnPropertyChanged("NameTextBox");
            }
        }
        #endregion

        #region ReadyCommand
        public bool CanExecuteReadyCommand(object param)
        {
            if(String.IsNullOrEmpty(nameTextBox))
            {
                return false;
            }
            int index = 0;
            foreach (var user in signInVM.UsersList)
            {
                if (user.Name == nameTextBox)
                {
                    return false;
                }
                ++index;
            }
            return true;
        }
        private ICommand readyCommand;
        public ICommand ReadyCommand
        {
            get
            {
                if (readyCommand == null)
                {
                    readyCommand = new RelayCommand(AddPlayer, CanExecuteReadyCommand);
                }
                return readyCommand;
            }
        }

        private void AddPlayer(object param)
        {
            signInVM.UsersList.Add(new User(NameTextBox, ImageSource.UriSource.ToString()));
            actions.SerializeUsers("User.xml", signInVM);
            SignIn signIn = new SignIn();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = signIn;
            signIn.Show();
        }
        #endregion

        #region Commands for image selection
        public bool CanExecuteNextImageCommand { get; set; } = false;
        public bool CanExecutePrevImageCommand { get; set; } = false;

        private ICommand previousImageCommand;
        public ICommand PreviousImageCommand
        {
            get
            {
                if(previousImageCommand == null)
                {
                    previousImageCommand = new RelayCommand(PreviousImageMethod, param => CanExecutePrevImageCommand);
                }
                return previousImageCommand;
            }
        }
        
        public void PreviousImageMethod(object param)
        {
            int index = images.ImagesList.IndexOf(ImageSource);
            ImageSource = images.ImagesList[--index];
        }

        private ICommand nextImageCommand;
        public ICommand NextImageCommand
        {
            get
            {
                if (nextImageCommand == null)
                {
                    nextImageCommand = new RelayCommand(NextImageMethod, param => CanExecuteNextImageCommand);
                }
                return nextImageCommand;
            }
        }
        public void NextImageMethod(object param)
        {
            int index = images.ImagesList.IndexOf(ImageSource);
            ImageSource = images.ImagesList[++index];
        }
        #endregion
    }
}
