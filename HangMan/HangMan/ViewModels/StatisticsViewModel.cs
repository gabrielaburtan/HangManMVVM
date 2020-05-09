using HangMan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.ViewModels
{
    public class StatisticsViewModel
    {
        private User user;
        public StatisticsViewModel(User user)
        {
            this.user = user;
        }

        public string UserImage
        {
            get
            {
                return user.ImagePath;
            }
        }
        public string UserName
        {
            get
            {
                return user.Name;
            }
        }
        public int TotalWonGames
        {
            get
            {
                return user.Stats.TotalWonGames;
            }
        }

        public int TotalLostGames
        {
            get
            {
                return user.Stats.TotalLostGames;
            }
        }

        public int WonGamesOnAllCategories
        {
            get
            {
                return user.Stats.WonGamesOnAllCategories;
            }
        }

        public int LostGamesOnAllCategories
        {
            get
            {
                return user.Stats.LostGamesOnAllCategories;
            }
        }

        public int WonGamesOnRivers
        {
            get
            {
                return user.Stats.WonGamesOnRivers;
            }
        }

        public int LostGamesOnRivers
        {
            get
            {
                return user.Stats.LostGamesOnRivers;
            }
        }

        public int WonGamesOnCars
        {
            get
            {
                return user.Stats.WonGamesOnCars;
            }
        }

        public int LostGamesOnCars
        {
            get
            {
                return user.Stats.LostGamesOnCars;
            }
        }

        public int WonGamesOnMovies
        {
            get
            {
                return user.Stats.WonGamesOnMovies;
            }
        }

        public int LostGamesOnMovies
        {
            get
            {
                return user.Stats.LostGamesOnMovies;
            }
        }

        public int WonGamesOnFlowers
        {
            get
            {
                return user.Stats.WonGamesOnFlowers;
            }
        }

        public int LostGamesOnFlowers
        {
            get
            {
                return user.Stats.LostGamesOnFlowers;
            }
        }
    }
}
