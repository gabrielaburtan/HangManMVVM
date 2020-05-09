using HangMan.Model;
using HangMan.Services;
using HangMan.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace HangMan.ViewModels
{
    public class GameWindowViewModel : Base
    {
        private SerializationActions actions = new SerializationActions();
        private ObservableCollection<Button> buttonsCollection = new ObservableCollection<Button>();

        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private int seconds = 59;
        //private int minutes = 1;
        private DateTime deadline;
        private int wordIndex;

        private Words words;
        public ObservableCollection<string> pickedWords = new ObservableCollection<string>();
        private Random rand = new Random();
        User currentUser;
        SignInViewModel signInVM;

        public GameWindowViewModel(int level, string word, Category categoryProperty, int mistakes, int wordIndex, ObservableCollection<string> pickedWordsCollection, int sec, string imagePath)
        {
            currentUser = SignInViewModel.SignedInUser;
            Level = level;
            Word = word;
            CategoryProperty = categoryProperty;
            switch (CategoryProperty)
            {
                case Category.AllCategories:
                    AllCategoryChecked = true;
                    break;
                case Category.Rivers:
                    RiversCategoryChecked = true;
                    break;
                case Category.Cars:
                    CarsCategoryChecked = true;
                    break;
                case Category.Movies:
                    MoviesCategoryChecked = true;
                    break;
                case Category.Flowers:
                    FlowersCategoryChecked = true;
                    break;
                default:
                    break;
            }
            Mistakes = mistakes;
            WordIndex = wordIndex;
            PickedWordsCollection = pickedWordsCollection;
            Seconds = sec;
            StartTimer(Seconds);
            ImagePath = imagePath;
            signInVM = actions.DeserializeUsers("User.xml");
            dispatcherTimer.Tick += new EventHandler(TimerTick);
            words = new Words();
            words = actions.DeserializeWords("Words.xml");
        }
        public GameWindowViewModel()
        {
            currentUser = ChooseGameViewModel.selectedUser;
            words = new Words();
            words = actions.DeserializeWords("Words.xml");
            signInVM = actions.DeserializeUsers("User.xml");
            switch (ChooseGameViewModel.chosenCategory)
            {
                case Category.AllCategories:
                    AllCategoryChecked = true;
                    category = Category.AllCategories;
                    break;
                case Category.Rivers:
                    RiversCategoryChecked = true;
                    category = Category.Rivers;
                    break;
                case Category.Cars:
                    CarsCategoryChecked = true;
                    category = Category.Cars;
                    break;
                case Category.Movies:
                    MoviesCategoryChecked = true;
                    category = Category.Movies;
                    break;
                case Category.Flowers:
                    FlowersCategoryChecked = true;
                    category = Category.Flowers;
                    break;
                default:
                    break;
            }
            PickedWordsCollection = PickWords(category);
            WordIndex = 0;
            ImagePath = "../Images/Mistakes/Default.png";
            Level = 1;
            Word = Codification(pickedWords[0]);
            dispatcherTimer.Tick += new EventHandler(TimerTick);
            StartTimer(Seconds);
        }

        public ObservableCollection<string> PickedWordsCollection
        {
            get
            {
                return pickedWords;
            }
            set
            {
                pickedWords = value;
                OnPropertyChanged("PickedWordsCollection");
            }
        }

        public int WordIndex
        {
            get
            {
                return wordIndex;
            }
            set
            {
                wordIndex = value;
                OnPropertyChanged("WordIndex");
            }
        }
        #region Win and Loose Game
        private void WinGame(Category category)
        {
            switch (category)
            {
                case Category.AllCategories:
                    currentUser.Stats.WonGamesOnAllCategories += 1;
                    break;
                case Category.Rivers:
                    currentUser.Stats.WonGamesOnRivers += 1;
                    break;
                case Category.Cars:
                    currentUser.Stats.WonGamesOnCars += 1;
                    break;
                case Category.Movies:
                    currentUser.Stats.WonGamesOnMovies += 1;
                    break;
                case Category.Flowers:
                    currentUser.Stats.WonGamesOnFlowers++;
                    break;
                default:
                    break;
            }
            currentUser.Stats.TotalWonGames += 1;
            foreach (var savedUser in signInVM.UsersList)
            {
                if (savedUser.Name == currentUser.Name)
                {
                    savedUser.Stats = currentUser.Stats;
                }
            }
            actions.SerializeUsers("User.xml", signInVM);
        }

        private void LooseGame(Category category)
        {
            switch (category)
            {
                case Category.AllCategories:
                    currentUser.Stats.LostGamesOnAllCategories += 1;
                    break;
                case Category.Rivers:
                    currentUser.Stats.LostGamesOnRivers += 1;
                    break;
                case Category.Cars:
                    currentUser.Stats.LostGamesOnCars += 1;
                    break;
                case Category.Movies:
                    currentUser.Stats.LostGamesOnMovies += 1;
                    break;
                case Category.Flowers:
                    currentUser.Stats.LostGamesOnFlowers += 1;
                    break;
                default:
                    break;
            }
            currentUser.Stats.TotalLostGames += 1;
            foreach (var savedUser in signInVM.UsersList)
            {
                if (savedUser.Name == currentUser.Name)
                {
                    savedUser.Stats = currentUser.Stats;
                }
            }
            actions.SerializeUsers("User.xml", signInVM);
        }
        #endregion

        #region Pick Random Word Method
        public ObservableCollection<string> PickWords(Category category)
        {
            int riversCount = words.Rivers.Count;
            int carsCount = words.Cars.Count;
            int moviesCount = words.Movies.Count;
            int flowersCount = words.Flowers.Count;
            switch (category)
            {
                case Category.AllCategories:
                    int count = 4;
                    for (int index = 0; index < 5; ++index)
                    {
                        int categoryIndex = rand.Next(count);
                        switch (categoryIndex)
                        {
                            case 0:
                                PickedWordsCollection.Add(words.Rivers[rand.Next(riversCount)]);
                                break;
                            case 1:
                                PickedWordsCollection.Add(words.Cars[rand.Next(carsCount)]);
                                break;
                            case 2:
                                PickedWordsCollection.Add(words.Movies[rand.Next(moviesCount)]);
                                break;
                            case 3:
                                PickedWordsCollection.Add(words.Flowers[rand.Next(flowersCount)]);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case Category.Rivers:
                    for (int index = 0; index < 5; index++)
                    {
                        PickedWordsCollection.Add(words.Rivers[rand.Next(riversCount)]);
                    }
                    break;
                case Category.Cars:
                    for (int index = 0; index <= 4; index++)
                    {
                        PickedWordsCollection.Add(words.Cars[rand.Next(carsCount)]);
                    }
                    break;
                case Category.Movies:
                    for (int index = 0; index <= 4; index++)
                    {
                        PickedWordsCollection.Add(words.Movies[rand.Next(moviesCount)]);
                    }
                    break;
                case Category.Flowers:
                    for (int index = 0; index <= 4; index++)
                    {
                        PickedWordsCollection.Add(words.Flowers[rand.Next(flowersCount)]);
                    }
                    break;
                default:
                    break;
            }
            return PickedWordsCollection;
        }
        #endregion


        #region WordInformation
        private bool WordState(string wordToBeChanged)
        {
            if (wordToBeChanged.Contains("*"))
            {
                return false;
            }
            return true;
        }

        private string Codification(string word)
        {
            string codifiedWord = new Regex("\\S").Replace(word, "*");
            return codifiedWord;
        }

        private string word;
        public string Word
        {
            get
            {
                return word;
            }
            set
            {
                word = value;
                OnPropertyChanged("Word");
            }
        }
        #endregion

        #region Statistics Command
        private ICommand statsCommand;
        public ICommand StatsCommand
        {
            get
            {
                if (statsCommand == null)
                {
                    statsCommand = new RelayCommand(StatsMethod);
                }
                return statsCommand;
            }
        }
        private void StatsMethod(object param)
        {
            int secondsRemaining = (deadline - DateTime.Now).Seconds;
            StopTimer();
            StatisticsWindow statsWindow = new StatisticsWindow();
            StatisticsViewModel statisticsViewModel = new StatisticsViewModel(currentUser);
            statsWindow.DataContext = statisticsViewModel;
            statsWindow.ShowDialog();
            StartTimer(secondsRemaining);
        }
        #endregion

        #region UserInformation

        public string UserName
        {
            get
            {
                return currentUser.Name;
            }
        }
        public string UserImagePath
        {
            get
            {
                return currentUser.ImagePath;
            }
        }
        private int level;
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
                OnPropertyChanged("Level");
            }
        }
        #endregion

        #region SelectedCategory
        private Category category;
        public Category CategoryProperty
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
                OnPropertyChanged("CategoryProperty");
            }
        }
        #endregion

        #region Mistakes Property and Image of Mistakes
        private int mistakes = 0;
        public int Mistakes
        {
            get
            {
                return mistakes;
            }
            set
            {
                mistakes = value;
                OnPropertyChanged("Mistakes");
            }
        }

        private string imagePath;
        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }
        #endregion

        #region LetterCommand And Reload Method
        private ICommand letterCommand;
        public ICommand LetterCommand
        {
            get
            {
                if (letterCommand == null)
                {
                    letterCommand = new RelayCommand(LetterCommandMethod);
                }
                return letterCommand;
            }
        }

        private void ResetButtons()
        {
            foreach (Button btn in buttonsCollection)
            {
                btn.IsEnabled = true;
                btn.Foreground = Brushes.Black;
            }
        }
        private void Reload()
        {
            WordIndex++;
            if (WordIndex < PickedWordsCollection.Count)
            {
                //minutes = 1;
                StartTimer(Seconds);
                Word = Codification(PickedWordsCollection[WordIndex]);
                ImagePath = "../Images/Mistakes/Default.png";
                Mistakes = 0;
                Level++;
            }
            else
            {
                StopTimer();
                WinGame(CategoryProperty);
                MessageBoxResult messageBoxResult = MessageBox.Show("You won! Do you want to start a new game?", "Win Game", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    ChooseGameWindow chooseGame = new ChooseGameWindow();
                    ChooseGameViewModel.selectedUser = currentUser;
                    App.Current.MainWindow.Close();
                    App.Current.MainWindow = chooseGame;
                    chooseGame.Show();
                }
                else
                {
                    SignIn signIn = new SignIn();
                    App.Current.MainWindow.Close();
                    App.Current.MainWindow = signIn;
                    signIn.Show();
                }
            }
            ResetButtons();
        }

        private void LetterCommandMethod(object param)
        {
            Button button = param as Button;
            buttonsCollection.Add(param as Button);
            (param as Button).IsEnabled = false;
            (param as Button).Foreground = Brushes.Red;
            char buttonContent = button.Content.ToString()[0];
            //string cuvant = "VOLVO";
            bool foundLetter = false;
            for (int index = 0; index < PickedWordsCollection[WordIndex].Length; ++index)
            {
                if (PickedWordsCollection[WordIndex][index] == buttonContent)
                {
                    StringBuilder sb = new StringBuilder(Word);
                    sb[index] = buttonContent;
                    Word = sb.ToString();
                    foundLetter = true;
                }
            }
            if (WordState(Word) == true)
            {
                Reload();
            }
            if (foundLetter == false)
            {
                mistakes++;
                if (mistakes <= 6)
                {
                    Mistakes = mistakes;
                    string path = "../Images/Mistakes/";
                    string imageName = "Mistake" + mistakes.ToString() + ".png";
                    ImagePath = path + imageName;
                }
                if (mistakes == 6)
                {
                    StopTimer();
                    MessageBoxResult messageBoxResult = MessageBox.Show("You lost! Do you want to start a new game?", "Loose Game", MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    { 
                        ChooseGameWindow chooseGame = new ChooseGameWindow();
                        ChooseGameViewModel.selectedUser = currentUser;
                        App.Current.MainWindow.Close();
                        App.Current.MainWindow = chooseGame;
                        chooseGame.Show();
                    }
                    else
                    { 
                        SignIn signIn = new SignIn();
                        App.Current.MainWindow.Close();
                        App.Current.MainWindow = signIn;
                        signIn.Show();
                    }
                    LooseGame(CategoryProperty);
                }
            }
        }
        #endregion

        #region About Command

        private ICommand aboutCommand;
        public ICommand AboutCommand
        {
            get
            {
                if (aboutCommand == null)
                {
                    aboutCommand = new RelayCommand(AboutMethod);
                }
                return aboutCommand;
            }
        }
        private void AboutMethod(object param)
        {
            int secondsRemaining = (deadline - DateTime.Now).Seconds;
            StopTimer();
            StudentWindow studentWindow = new StudentWindow();
            studentWindow.ShowDialog();
            StartTimer(secondsRemaining);
        }

        #endregion
        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                seconds = value;
                OnPropertyChanged("Seconds");
            }
        }

        #region SaveGame
        private void SaveGame(object param)
        {
            Seconds = (deadline - DateTime.Now).Seconds;
            currentUser.GameProperty = new Game(Level, Word, CategoryProperty, Mistakes, WordIndex, PickedWordsCollection, Seconds, ImagePath);
            foreach (var savedUser in signInVM.UsersList)
            {
                if (savedUser.Name == currentUser.Name)
                {
                    savedUser.GameProperty = currentUser.GameProperty;
                    savedUser.IsInGame = true;
                }
            }
            actions.SerializeUsers("User.xml", signInVM);
            StopTimer();
            MessageBoxResult messageBoxResult = MessageBox.Show("Your game was saved successfully!", "Game Saved", MessageBoxButton.OK);
            if (messageBoxResult == MessageBoxResult.OK)
            {
                SignIn signIn = new SignIn();
                App.Current.MainWindow.Close();
                App.Current.MainWindow = signIn;
                signIn.Show();
            }
        }

        private ICommand saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    saveCommand = new RelayCommand(SaveGame);
                }
                return saveCommand;
            }
        }
        #endregion

        #region Timer
        public string timer;
        public string DispatcherTimer
        {
            get
            {
                if ((deadline - DateTime.Now).Seconds < 10)
                {
                    return (deadline - DateTime.Now).Minutes.ToString() + ":0" + (deadline - DateTime.Now).Seconds.ToString();
                }
                return (deadline - DateTime.Now).Minutes.ToString() + ":" + (deadline - DateTime.Now).Seconds.ToString();
            }
            set
            {
                timer = value;
                OnPropertyChanged("DispatcherTimer");
            }
        }
        private void StartTimer(int seconds)
        {
            deadline = DateTime.Now.AddSeconds(Seconds);
            //deadline = DateTime.Now.AddMinutes(minutes);
            dispatcherTimer.Start();
        }
        private void StopTimer()
        {
            dispatcherTimer.Stop();
            Seconds = (deadline - DateTime.Now).Seconds;
            deadline = DateTime.Now.AddSeconds(Seconds);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            int secondsRemaining = (deadline - DateTime.Now).Seconds;
            OnPropertyChanged("DispatcherTimer");
            if (secondsRemaining == 0)
            {
                dispatcherTimer.Stop();
                dispatcherTimer.IsEnabled = false;
                Seconds = 59;
                MessageBoxResult messageBoxResult = MessageBox.Show("Time has expired! You lost! Do you want to start a new game?", "Loose Game", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    ChooseGameWindow chooseGame = new ChooseGameWindow();
                    ChooseGameViewModel.selectedUser = currentUser;
                    App.Current.MainWindow.Close();
                    App.Current.MainWindow = chooseGame;
                    chooseGame.Show();
                }
                else
                {
                    SignIn signIn = new SignIn();
                    App.Current.MainWindow.Close();
                    App.Current.MainWindow = signIn;
                    signIn.Show();
                }
                LooseGame(CategoryProperty);
            }
        }
        #endregion

        #region CheckingCategory 
        private bool allCategoryChecked;
        public bool AllCategoryChecked
        {
            get
            {
                return allCategoryChecked;
            }
            set
            {
                allCategoryChecked = value;
                OnPropertyChanged("AllCategoryChecked");
            }
        }
        private bool riversCategoryChecked;
        public bool RiversCategoryChecked
        {
            get
            {
                return riversCategoryChecked;
            }
            set
            {
                riversCategoryChecked = value;
                OnPropertyChanged("RiversCategoryChecked");
            }
        }
        private bool carsCategoryChecked;
        public bool CarsCategoryChecked
        {
            get
            {
                return carsCategoryChecked;
            }
            set
            {
                carsCategoryChecked = value;
                OnPropertyChanged("CarsCategoryChecked");
            }
        }
        private bool moviesCategoryChecked;
        public bool MoviesCategoryChecked
        {
            get
            {
                return moviesCategoryChecked;
            }
            set
            {
                moviesCategoryChecked = value;
                OnPropertyChanged("MoviesCategoryChecked");
            }
        }

        private bool flowersCategoryChecked;
        public bool FlowersCategoryChecked
        {
            get
            {
                return flowersCategoryChecked;
            }
            set
            {
                flowersCategoryChecked = value;
                OnPropertyChanged("FlowersCategoryChecked");
            }
        }
        #endregion

        #region ChangeCategory
        private ICommand changeCategoryCommand;
        public ICommand ChangeCategoryCommand
        {
            get
            {
                if (changeCategoryCommand == null)
                {
                    changeCategoryCommand = new RelayCommand(ChangeCategory);
                }
                return changeCategoryCommand;
            }
        }

        private void ResetGame()
        {
            ResetButtons();
            Mistakes = 0;
            Level = 1;
            ImagePath = "../Images/Mistakes/Default.png";
            Seconds = 59;
            StartTimer(Seconds);
            PickedWordsCollection.Clear();
            WordIndex = 0;
            PickedWordsCollection = PickWords(CategoryProperty);
            Word = Codification(PickedWordsCollection[WordIndex]);
        }
        private bool canChange;
        public bool CanChangeCategory(object param)
        {
            return canChange == true;
        }
        public ICommand canCheck;
        //public ICommand CanCheck
        //{
        //    get
        //    {
        //        if(canCheck == null)
        //        {
        //            canCheck = new RelayCommand()
        //        }
        //    }
        //}
        private void ChangeCategory(object param)
        {
            int secondsRemaining = (deadline - DateTime.Now).Seconds;
            StopTimer();
            OnPropertyChanged("DispatcherTimer");
            MessageBoxResult messageBoxResult = MessageBox.Show("If you change the category you will lose the game!", "Change category?", MessageBoxButton.OKCancel);
            if (messageBoxResult == MessageBoxResult.OK)
            {
                LooseGame(CategoryProperty);
                switch (param)
                {
                    case "All Categories":
                        CategoryProperty = Category.AllCategories;
                        AllCategoryChecked = true;
                        break;
                    case "Rivers":
                        CategoryProperty = Category.Rivers;
                        RiversCategoryChecked = true;
                        break;
                    case "Cars":
                        CategoryProperty = Category.Cars;
                        CarsCategoryChecked = true;
                        break;
                    case "Movies":
                        CategoryProperty = Category.Movies;
                        MoviesCategoryChecked = true;
                        break;
                    case "Flowers":
                        CategoryProperty = Category.Flowers;
                        FlowersCategoryChecked = true;
                        break;
                    default:
                        break;
                }
                canChange = true;
                ResetGame();
            }
            if (messageBoxResult == MessageBoxResult.Cancel)
            {
                switch (CategoryProperty)
                {
                    case Category.AllCategories:
                        AllCategoryChecked = true;
                        break;
                    case Category.Rivers:
                        RiversCategoryChecked = true;
                        break;
                    case Category.Cars:
                        CarsCategoryChecked = true;
                        break;
                    case Category.Movies:
                        MoviesCategoryChecked = true;
                        break;
                    case Category.Flowers:
                        FlowersCategoryChecked = true;
                        break;
                    default:
                        break;
                }
                Seconds = secondsRemaining;
                StartTimer(Seconds);
            }
        }

        #endregion

        #region BackCommand
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

        private void SaveGame()
        {
            currentUser.GameProperty = new Game(Level, Word, CategoryProperty, Mistakes, WordIndex, PickedWordsCollection, Seconds, ImagePath);
            foreach (var savedUser in signInVM.UsersList)
            {
                if (savedUser.Name == currentUser.Name)
                {
                    savedUser.GameProperty = currentUser.GameProperty;
                    savedUser.IsInGame = true;
                }
            }
            actions.SerializeUsers("User.xml", signInVM);
            MessageBoxResult messageBoxResult = MessageBox.Show("Your game was saved successfully!", "Game Saved", MessageBoxButton.OK);
            if (messageBoxResult == MessageBoxResult.OK)
            {
                SignIn signIn = new SignIn();
                App.Current.MainWindow.Close();
                App.Current.MainWindow = signIn;
                signIn.Show();
            }
        }
        private void BackMethod(object param)
        {
            Seconds = (deadline - DateTime.Now).Seconds;
            StopTimer();
            MessageBoxResult messageBoxResult = MessageBox.Show("Do you want to save your game?", "Save Game", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                SaveGame();
            }
            else
            {
                PickedWordsCollection.Clear();
                SignIn signIn = new SignIn();
                App.Current.MainWindow.Close();
                App.Current.MainWindow = signIn;
                signIn.Show();
            }
        }
        #endregion
    }
}
