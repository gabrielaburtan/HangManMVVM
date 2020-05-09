using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Windows.Media.Imaging;

namespace HangMan.Model
{
    [Serializable]
    public class User: INotifyPropertyChanged
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

        [XmlAttribute]
        private string name;

        [XmlAttribute]
        private string imagePath;

        [XmlAttribute]
        private Game game;

        [XmlAttribute]
        private Statistics stats;

        [XmlAttribute]
        private bool isInGame;

        public User() { }

        public User(string name, string imagePath)
        {
            Name = name;
            ImagePath = imagePath;
            Stats = new Statistics();
        }
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
                NotifyPropertyChanged("ImagePath");
            }
        }
        
        public Game GameProperty
        {
            get
            {
                return game;
            }
            set
            {
                game = value;
                NotifyPropertyChanged("Game");
            }
        }

        public Statistics Stats
        {
            get
            {
                return stats;
            }
            set
            {
                stats = value;
                NotifyPropertyChanged("Stats");
            }
        }

        public bool IsInGame
        {
            get
            {
                return isInGame;
            }
            set
            {
                isInGame = value;
                NotifyPropertyChanged("IsInGame");
            }
        }
    }
}
