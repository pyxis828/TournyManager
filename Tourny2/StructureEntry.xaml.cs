﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tourny2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        int currentColumn = 0;                                      //declare some fields 
        int currentRow = 1;
        int timesCalled = 1;
        Level newLevel = new Level();        
       
        public int CurrentColumn                                    //create properties for the fields
        {
            get { return this.currentColumn; }
            set { this.currentColumn = value; }
        }
        public int CurrentRow
        {
            get { return this.currentRow; }
            set { this.currentRow = value; }
        }
        public int TimesCalled
        {
            get  { return this.timesCalled; }
            set  { this.timesCalled = value; }
        }       

        public Window2()
        {
            InitializeComponent();
        }       

        private void AntesBox_Checked(object sender, RoutedEventArgs e)     //checking antes checkbox enables antes entry box
        {
           EnterAntes.IsEnabled = true;
        }
        private void AntesBox_Unchecked(object sender, RoutedEventArgs e)   //unchecking antes checkbox disables antes entry box
        {
            EnterAntes.IsEnabled = false;
        }

        private void ListGamesBox_Checked(object sender, RoutedEventArgs e)      //checking list games checkbox enables  
        {                                                                        //current game entry box
            GamesEntry.IsEnabled = true;
        }
        private void ListGamesBox_Unchecked(object sender, RoutedEventArgs e)    //unchecking list games checkbox disables
        {                                                                        //current game entry box
            GamesEntry.IsEnabled = false;
        }

        private void EnterAntes_KeyDown(object sender, KeyEventArgs e)          //allow only digits (keyboard and numbers pad)
        {                                                                       //and backspace to be entered in antes
            int key = (int)e.Key;
            e.Handled = !(key >= 34 && key <= 43 ||
             key >= 74 && key <= 83 || key == 2);
        }

        private void SBEntry_KeyDown(object sender, KeyEventArgs e)             //allow only digits (keyboard and numbers pad)
        {                                                                       //and backspace to be entered in small blind
            int key = (int)e.Key;
            e.Handled = !(key >= 34 && key <= 43 ||
             key >= 74 && key <= 83 || key == 2);
        }

        private void BBEntry_KeyDown(object sender, KeyEventArgs e)             //allow only digits (keyboard and numbers pad)
        {                                                                       //and backspace to be entered in big blind
            int key = (int)e.Key;
            e.Handled = !(key >= 34 && key <= 43 ||
             key >= 74 && key <= 83 || key == 2);
        }

        private void TimeEntry_KeyDown(object sender, KeyEventArgs e)           //allow only digits (keyboard and numbers pad)
        {                                                                       //and backspace to be entered in levell time
            int key = (int)e.Key;
            e.Handled = !(key >= 34 && key <= 43 ||
             key >= 74 && key <= 83 || key == 2);
        }

        private void AddLevelButton_Click(object sender, RoutedEventArgs e)         //add level button
        {
            string level = this.Level.Content.ToString();                           //create name for level label
            string[] splitLevel = level.Split(' ');
            int levelNum = int.Parse(splitLevel[1]);
            levelNum = timesCalled + 1;            
            int nextRow = currentRow + 1;           
            int nextColumn = currentColumn + 1;
            Label levelLabel = new Label();
            levelLabel.Content = "Level " + levelNum.ToString();                    //add level label
            newLevel.LevelName = levelLabel.Content.ToString();
            Grid.SetRow(levelLabel, nextRow);
            Grid.SetColumn(levelLabel, currentColumn);
            FlowGrid.Children.Add(levelLabel);
            currentColumn++;
            CheckBox antesBox = new CheckBox();                                     //add antes checkbox
            AntesBox.Name = "AntesBox";
            AntesBox.VerticalAlignment = VerticalAlignment.Bottom;
            AntesBox.HorizontalAlignment = HorizontalAlignment.Right;
            AntesBox.FontSize = 16;
            AntesBox.Width = 20;
            AntesBox.Height = 20;
            AntesBox.Checked += AntesBox_Checked;
            AntesBox.Unchecked += AntesBox_Unchecked;
            Grid.SetRow(AntesBox, nextRow);
            Grid.SetColumn(AntesBox, currentColumn);
            FlowGrid.Children.Add(AntesBox);
            nextColumn = ++currentColumn;
            TextBox EnterAntes = new TextBox();                                     //add antes text entry box
            EnterAntes.Name = "EnterAntes";
            EnterAntes.Margin = new Thickness(5, 0, 5, 0);
            EnterAntes.FontSize = 16;
            EnterAntes.FontFamily = new FontFamily("Verdana");
            EnterAntes.IsEnabled = false;       
            EnterAntes.KeyDown += EnterAntes_KeyDown;
            Grid.SetRow(EnterAntes, nextRow);
            Grid.SetColumn(EnterAntes, nextColumn);
            FlowGrid.Children.Add(EnterAntes);
            nextColumn = ++currentColumn;
            TextBox SBEntry = new TextBox();                                        //add small blind text entry box
            SBEntry.Name = "EnterSB";
            SBEntry.Margin = new Thickness(5, 0, 5, 0);
            SBEntry.FontSize = 16;
            SBEntry.FontFamily = new FontFamily("Verdana");            
            SBEntry.KeyDown += SBEntry_KeyDown;
            Grid.SetRow(SBEntry, nextRow);
            Grid.SetColumn(SBEntry, nextColumn);
            FlowGrid.Children.Add(SBEntry);
            nextColumn = ++currentColumn;
            TextBox BBEntry = new TextBox();                                        //add big blind text entry box
            BBEntry.Name = "EnterBB";
            BBEntry.Margin = new Thickness(5, 0, 5, 0);
            BBEntry.FontSize = 16;
            BBEntry.FontFamily = new FontFamily("Verdana");
            BBEntry.KeyDown += BBEntry_KeyDown;
            Grid.SetRow(BBEntry, nextRow);
            Grid.SetColumn(BBEntry, nextColumn);
            FlowGrid.Children.Add(BBEntry);
            nextColumn = ++currentColumn;
            TextBox timeEntry = new TextBox();                                      //add level tiem text entry box
            TimeEntry.Name = "EnterTime";
            TimeEntry.Margin = new Thickness(5, 0, 5, 0);
            TimeEntry.FontSize = 16;
            TimeEntry.FontFamily = new FontFamily("Verdana");
            TimeEntry.KeyDown += TimeEntry_KeyDown;
            Grid.SetRow(TimeEntry, nextRow);
            Grid.SetColumn(TimeEntry, nextColumn);
            FlowGrid.Children.Add(TimeEntry);
            nextColumn = ++currentColumn;
            CheckBox listGamesBox = new CheckBox();                                 //add list games check box
            ListGamesBox.Name = "ListGamesBox";
            ListGamesBox.VerticalAlignment = VerticalAlignment.Bottom;
            ListGamesBox.HorizontalAlignment = HorizontalAlignment.Right;
            ListGamesBox.FontSize = 16;
            ListGamesBox.Width = 20;
            ListGamesBox.Height = 20;
            ListGamesBox.Checked += ListGamesBox_Checked;
            ListGamesBox.Unchecked += ListGamesBox_Unchecked;
            Grid.SetRow(ListGamesBox, nextRow);
            Grid.SetColumn(ListGamesBox, currentColumn);
            FlowGrid.Children.Add(ListGamesBox);
            nextColumn = ++currentColumn;
            TextBox GamesEntry = new TextBox();                                     //add current game text entry box
            GamesEntry.Name = "EnterGames";
            GamesEntry.Margin = new Thickness(5, 0, 5, 0);
            GamesEntry.FontSize = 16;
            GamesEntry.FontFamily = new FontFamily("Verdana");
            GamesEntry.IsEnabled = false;
            Grid.SetRow(GamesEntry, nextRow);
            Grid.SetColumn(GamesEntry, nextColumn);
            FlowGrid.Children.Add(GamesEntry);
            nextColumn = ++currentColumn;
            this.CurrentRow = nextRow;                                              //set values for next time event occurs
            this.TimesCalled += 1;
            this.CurrentColumn = 0;
        }            

        private void button_Click(object sender, RoutedEventArgs e)                 //add break button clicked
        {
            int nextRow = ++currentRow;
            Label breakLabel = new Label();                                         //add break label
            breakLabel.Content = "Break";
            Grid.SetRow(breakLabel, nextRow);
            Grid.SetColumn(breakLabel, currentColumn);
            FlowGrid.Children.Add(breakLabel);
            TextBox timeEntry = new TextBox();                                      //add time text entry box
            TimeEntry.Name = "EnterTime";
            TimeEntry.Margin = new Thickness(5, 0, 5, 0);
            TimeEntry.FontSize = 16;
            TimeEntry.FontFamily = new FontFamily("Verdana");
            TimeEntry.KeyDown += TimeEntry_KeyDown;
            Grid.SetRow(TimeEntry, nextRow);
            Grid.SetColumn(TimeEntry, 5);
            FlowGrid.Children.Add(TimeEntry);
        }

        private void EnterAntes_TextChanged(object sender, TextChangedEventArgs e)
        {
            newLevel.Antes = int.Parse(EnterAntes.Text);
        }

        private void SBEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            newLevel.SmallBlind = int.Parse(SBEntry.Text);
        }

        private void BBEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            newLevel.BigBlind = int.Parse(BBEntry.Text);
        }

        private void TimeEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            newLevel.LevelTime = double.Parse(TimeEntry.Text);
        }

        private void GamesEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            newLevel.CurrentGame = GamesEntry.Text;
        }
    }
}
