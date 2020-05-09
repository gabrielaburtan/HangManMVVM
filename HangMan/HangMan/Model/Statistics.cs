using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Model 
{
    public class Statistics : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        private int totalWonGames;
        private int totalLostGames;
        private int wonGamesOnAllCategories;
        private int lostGamesOnAllCategories;
        private int wonGamesOnRivers;
        private int lostGamesOnRivers;
        private int wonGamesOnCars;
        private int lostGamesOnCars;
        private int wonGamesOnMovies;
        private int lostGamesOnMovies;
        private int wonGamesOnFlowers;
        private int lostGamesOnFlowers;

        public Statistics()
        {

        }

        public int TotalWonGames
        {
            get
            {
                return totalWonGames;
            }
            set
            {
                totalWonGames = value;
                NotifyPropertyChanged("TotalWonGames");
            }
        }

        public int TotalLostGames
        {
            get
            {
                return totalLostGames;
            }
            set
            {
                totalLostGames = value;
                NotifyPropertyChanged("TotalLostGames");
            }
        }

        public int WonGamesOnAllCategories
        {
            get
            {
                return wonGamesOnAllCategories;
            }
            set
            {
                wonGamesOnAllCategories = value;
                NotifyPropertyChanged("WonGamesOnAllCategories");
            }
        }

        public int LostGamesOnAllCategories
        {
            get
            {
                return lostGamesOnAllCategories;
            }
            set
            {
                lostGamesOnAllCategories = value;
                NotifyPropertyChanged("LostGamesOnAllCategories");
            }
        }

        public int WonGamesOnRivers
        {
            get
            {
                return wonGamesOnRivers;
            }
            set
            {
                wonGamesOnRivers = value;
                NotifyPropertyChanged("WonGamesOnRivers");
            }
        }

        public int LostGamesOnRivers
        {
            get
            {
                return lostGamesOnRivers;
            }
            set
            {
                lostGamesOnRivers = value;
                NotifyPropertyChanged("LostGamesOnRivers");
            }
        }

        public int WonGamesOnCars
        {
            get
            {
                return wonGamesOnCars;
            }
            set
            {
                wonGamesOnCars = value;
                NotifyPropertyChanged("WonGamesOnCars");
            }
        }

        public int LostGamesOnCars
        {
            get
            {
                return lostGamesOnCars;
            }
            set
            {
                lostGamesOnCars = value;
                NotifyPropertyChanged("LostGamesOnCars");
            }
        }

        public int WonGamesOnMovies
        {
            get
            {
                return wonGamesOnMovies;
            }
            set
            {
                wonGamesOnMovies = value;
                NotifyPropertyChanged("WonGamesOnMovies");
            }
        }

        public int LostGamesOnMovies
        {
            get
            {
                return lostGamesOnMovies;
            }
            set
            {
                lostGamesOnMovies = value;
                NotifyPropertyChanged("LostGamesOnMovies");
            }
        }

        public int WonGamesOnFlowers
        {
            get
            {
                return wonGamesOnFlowers;
            }
            set
            {
                wonGamesOnFlowers = value;
                NotifyPropertyChanged("WonGamesOnFlowers");
            }
        }

        public int LostGamesOnFlowers
        {
            get
            {
                return lostGamesOnFlowers;
            }
            set
            {
                lostGamesOnFlowers = value;
                NotifyPropertyChanged("LostGamesOnFlowers");
            }
        }
    }
}
