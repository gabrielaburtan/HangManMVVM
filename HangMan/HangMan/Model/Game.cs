using HangMan.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HangMan.Model
{
    public enum Category
    {
        AllCategories,
        Rivers,
        Cars,
        Movies,
        Flowers
    }
    [Serializable]
    public class Game : INotifyPropertyChanged
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
        private int level = 0;
        [XmlAttribute]
        private string word = "";
        [XmlAttribute]
        private Category category;
        [XmlAttribute]
        private int seconds;
        [XmlAttribute]
        private int mistakes;
        [XmlAttribute]
        private int wordIndex;
        [XmlAttribute]
        private ObservableCollection<string> wordsCollection;
        [XmlAnyAttribute]
        private string imagePath;
        
        public Game(int level, string word, Category category, int mistakes, int wordIndex, ObservableCollection<string> wordsCollection, int seconds, string imagePath)
        {
            Level = level;
            Word = word;
            CategoryProperty = category;
            Mistakes = mistakes;
            WordIndex = wordIndex;
            WordsCollection = wordsCollection;
            Seconds = seconds;
            ImagePath = imagePath;
        }
        public Game() { }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
                NotifyPropertyChanged("Level");
            }
        }

        public string Word
        {
            get
            {
                return word;
            }
            set
            {
                word = value;
                NotifyPropertyChanged("Word");
            }
        }

        public Category CategoryProperty
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
                NotifyPropertyChanged("Category");
            }
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                seconds = value;
                NotifyPropertyChanged("Timer");
            }
        }

        public int Mistakes
        {
            get
            {
                return mistakes;
            }
            set
            {
                mistakes = value;
                NotifyPropertyChanged("Mistakes");
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
                NotifyPropertyChanged("WordIndex");
            }
        }

        public ObservableCollection<string> WordsCollection
        {
            get
            {
                return wordsCollection;
            }
            set
            {
                wordsCollection = value;
                NotifyPropertyChanged("WordsCollection");
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
    }
}
