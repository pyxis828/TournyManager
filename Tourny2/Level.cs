using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Tourny2
{
    class Level : INotifyPropertyChanged
    {
        private string levelName = "";                      //declare some fields
        private int antes = 0;                              
        private int smallBlind = 0;
        private int bigBlind = 0;
        private double levelTime = 0;
        private string currentGame = "";

        public string LevelName                             //create properties for the fields       
        {
            get { return this.levelName; }

            set
            {
                if (this.levelName != value)
                {
                    this.levelName = value;
                    this.NotifyPropertyChanged("LevelName");
                }
            }
        }   
        public int Antes
        {                               
            get { return this.antes; }
            set
            {
                if (this.antes != value)
                {
                    this.antes = value;
                    this.NotifyPropertyChanged(Antes);
                }
            }
        }
        public int SmallBlind
        {
            get { return this.smallBlind; }
            set
            {
                if (this.smallBlind != value)
                {
                    this.smallBlind = value;
                    this.NotifyPropertyChanged(SmallBlind);
                }
            }
        }
        public int BigBlind
        {
            get { return this.bigBlind; }
            set
            {
                if (this.bigBlind != value)
                {
                    this.bigBlind = value;
                    this.NotifyPropertyChanged(SmallBlind);
                }
            }
        }
        public double LevelTime
        {
            get { return this.levelTime; }
            set
            {
                if (this.levelTime != value)
                {
                    this.levelTime = value;
                    this.NotifyPropertyChanged(SmallBlind);
                }
            }
        }
        public string CurrentGame
        {
            get { return this.currentGame; }
            set
            {
                if (this.currentGame != value)
                {
                    this.currentGame = value;
                    this.NotifyPropertyChanged(SmallBlind);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public void NotifyPropertyChanged(int propValue)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propValue.ToString()));
        }
        public void NotifyPropertyChanged(double propValue)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propValue.ToString()));
        }
        public Level()
        {
            this.levelName = levelName;
            this.antes = antes;
            this.smallBlind = smallBlind;
            this.bigBlind = bigBlind;
            this.levelTime = levelTime;
            this.currentGame = currentGame;
        }
        public Level (string levelName, double levelTime)               //create class constructors
        {
            this.levelName = levelName;
            this.levelTime = levelTime;
        }
        public Level (string levelName, int smallBlind, int bigBlind, double levelTime)              
        {
            this.levelName = levelName;
            this.smallBlind = smallBlind;
            this.bigBlind = bigBlind;
            this.levelTime = levelTime;
        }
        public Level (string levelName, int antes, int smallBlind, int bigBlind, double levelTime)
        {
            this.levelName = levelName;
            this.antes = antes;
            this.smallBlind = smallBlind;
            this.bigBlind = bigBlind;
            this.levelTime = levelTime;
        }
        public Level(string levelName, int smallBlind, int bigBlind, double levelTime, string currentGame)
        {
            this.levelName = levelName;
            this.smallBlind = smallBlind;
            this.bigBlind = bigBlind;
            this.levelTime = levelTime;
            this.currentGame = currentGame;
        }
        public Level(string levelName, int antes, int smallBlind, int bigBlind, double levelTime, string currentGame)
        {
            this.levelName = levelName;
            this.antes = antes;
            this.smallBlind = smallBlind;
            this.bigBlind = bigBlind;
            this.levelTime = levelTime;
            this.currentGame = currentGame;
        }
    }
}
