using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Tourny2
{
     public class Level : INotifyPropertyChanged
    {
        private string levelName;                      //declare some fields
        private bool useAntes;
        private int antes;                              
        private int smallBlind;
        private int bigBlind;
        private double levelTime;
        private bool listGames;
        private string currentGame;

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
        public bool UseAntes
        {
            get { return this.useAntes; }
            set
            {
                if (this.useAntes != value)
                {
                    this.useAntes = value;
                    this.NotifyPropertyChanged("UseAntes");
                }
            }
        }
        public int Antes
        {                               
            get { return (int)antes; }
            set
            {
                if (this.antes != value)
                {
                    this.antes = value;
                    this.NotifyPropertyChanged("Antes");
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
                    this.NotifyPropertyChanged("SmallBlind");
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
                    this.NotifyPropertyChanged("BigBlind");
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
                    this.NotifyPropertyChanged("LevelTime");
                }
            }
        }
        public bool ListGames
        {
            get { return this.listGames; }
            set
            {
                if (this.listGames != value)
                {
                    this.listGames = value;
                    this.NotifyPropertyChanged("ListGames");
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
                    this.NotifyPropertyChanged("CurrentGame");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;                   //deleggate and eventhandler for proprty changed

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }       
        public Level()                                                              //level constructor for creating levels
        {
            this.levelName = levelName;
            this.useAntes = useAntes;
            this.antes = antes;
            this.smallBlind = smallBlind;
            this.bigBlind = bigBlind;
            this.levelTime = levelTime;
            this.listGames = listGames;
            this.currentGame = currentGame;
        }
       public Level(string line)                                                    //this one is for loading structures
        {
            string[] parts = line.Split(',');
            levelName = parts[0];
            useAntes =Convert.ToBoolean(parts[1]);
            antes = Convert.ToInt32(parts[2]);
            smallBlind = Convert.ToInt32(parts[3]);
            bigBlind = Convert.ToInt32(parts[4]);
            levelTime = Convert.ToDouble(parts[5]);
            listGames = Convert.ToBoolean(parts[6]);
            currentGame = parts[7];
        }
    }
}
