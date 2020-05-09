using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using HangMan.Model;
using System.Windows.Input;
using HangMan.Services;
using HangMan.Views;
using System.Windows;

namespace HangMan.ViewModels
{
    [Serializable]
    public class SignInViewModel : Base
    {
        private SerializationActions actions = new SerializationActions();
        public static User SignedInUser;

        #region Constructor for first serialization
        //public SignInViewModel()
        //{
        //    //UsersList = new ObservableCollection<User>
        //    //{
        //    //    new User{Name="Gabi", ImagePath="/Images/Avatars/avatar2.png"},
        //    //    new User{Name="Alex", ImagePath="/Images/Avatars/avatar6.png"}
        //    //};
        //}
        #endregion
        public SignInViewModel() 
        {
            SelectedUser = null;
        }

        #region ListOfUsers
        [XmlArray]
        private ObservableCollection<User> usersList;
        public ObservableCollection<User> UsersList
        {
            get
            {
                return usersList;
            }
            set
            {
                usersList = value;
                OnPropertyChanged("UserList");
            }
        }
        #endregion

        #region SelectedUser
        private User selectedUser;
        public User SelectedUser
        {
            get
            {
                return selectedUser;
            }
            set
            {
                selectedUser = value;
                if(selectedUser != null)
                {
                    CanExecuteDeleteCommand = true;
                    CanExecutePlay = true;
                    SignedInUser = selectedUser;
                }
                OnPropertyChanged("SelectedUser");
            }
        }
        #endregion

        #region DeleteUser
        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand(DeleteMethod, param => CanExecuteDeleteCommand);
                }
                return deleteCommand;
            }
        }
        private bool CanExecuteDeleteCommand { get; set; } = false;
        private void DeleteMethod(object param)
        {
            int index = 0;
            foreach (var user in UsersList)
            {
                if (user.Name == selectedUser.Name)
                {
                    UsersList.RemoveAt(index);
                    break;
                }
                ++index;
            }
            SelectedUser = null;
            CanExecuteDeleteCommand = false;
            CanExecutePlay = false;
            actions.SerializeUsers("User.xml", this);
        }
        #endregion

        private ICommand playCommand;
        public ICommand PlayCommand
        {
            get
            {
                if (playCommand == null)
                {
                    playCommand = new RelayCommand(PlayMethod, param => CanExecutePlay);
                }
                return playCommand;
            }
        }
        private void PlayMethod(object param)
        {
            LoadNewGame playGame = new LoadNewGame();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = playGame;
            playGame.Show();
        }

        private bool CanExecutePlay { get; set; } = false;
    }
}
