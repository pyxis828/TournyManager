﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Tourny2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private TextBox antesEntry;        
        private TextBox gameEntry;
        ObservableCollection<Level> levels = new ObservableCollection<Level>();
        public Window1()
        {
            InitializeComponent();

        
            //levels.Add(new Level() { LevelName = "Level 1", UseAntes = false, SmallBlind = 25, BigBlind = 50, LevelTime = 20, ListGames = false } );
            dataGrid.ItemsSource = levels;
        }        
        private void antesEntry_Loaded(object sender, RoutedEventArgs e)
        {
            antesEntry = (sender as TextBox);            
        }
        private void gameEntry_Loaded(object sender, RoutedEventArgs e)
        {
            gameEntry = (sender as TextBox);
        }
        private void useAntes_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox c = (sender as CheckBox);
            if (c.IsChecked == true)
            {            
                antesEntry.IsEnabled = true;               
            }
        }
        private void listGames_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox c = (sender as CheckBox);
            if (c.IsChecked == true)
            {
                gameEntry.IsEnabled = true;               
            }
        }
        private void useAntes_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox c = (sender as CheckBox);
            if (c.IsChecked == false)
            {
                antesEntry.IsEnabled = false;
            }
        }
        private void listGames_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox c = (sender as CheckBox);
            if (c.IsChecked == false)
            {
                gameEntry.IsEnabled = false;
                
            }
        }
        private void antesEntry_KeyDown(object sender, KeyEventArgs e)          //allow only digits (keyboard and numbers pad)
        {                                                                       //tab and backspace to be entered in antes
            int key = (int)e.Key;
            e.Handled = !(key >= 34 && key <= 43 ||
             key >= 74 && key <= 83 || key == 2);
            if (e.Key == Key.Tab || e.Key == Key.Enter)
            {
                e.Handled = false;
            }
        }
        private void SBEntry_KeyDown(object sender, KeyEventArgs e)          //allow only digits (keyboard and numbers pad)
        {                                                                       //tab and backspace to be entered in SB
            int key = (int)e.Key;
            e.Handled = !(key >= 34 && key <= 43 ||
             key >= 74 && key <= 83 || key == 2);
            if(e.Key == Key.Tab|| e.Key == Key.Enter)
            {
                e.Handled = false;
            }           
        }
        private void BBEntry_KeyDown(object sender, KeyEventArgs e)          //allow only digits (keyboard and numbers pad)
        {                                                                       //tab and backspace to be entered in BB
            int key = (int)e.Key;
            e.Handled = !(key >= 34 && key <= 43 ||
             key >= 74 && key <= 83 || key == 2);
            if (e.Key == Key.Tab || e.Key == Key.Enter)
            {
                e.Handled = false;
            }
        }
        private void levelTime_KeyDown(object sender, KeyEventArgs e)          //allow only digits (keyboard and numbers pad)                                                               
        {                                                                     //tab,and backspace to be entered in Level Time
            int key = (int)e.Key;
            e.Handled = !(key >= 34 && key <= 43 ||
             key >= 74 && key <= 83 || key == 2);
            if (e.Key == Key.Tab||e.Key == Key.Enter)
            {
                e.Handled = false;
            }
        }

        private void saveStructure_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.SelectAllCells();
            dataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.ExcludeHeader;
            ApplicationCommands.Copy.Execute(null, dataGrid);
            dataGrid.UnselectAllCells();
            String result = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            Clipboard.Clear();
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == true)
            {
                using (StreamWriter file = new StreamWriter("..\\TestStructure.csv"))
                {
                    file.WriteLine(result);
                }
            }
         }
        public void addLevel_Click(object sender, RoutedEventArgs e)
        {            
            AddNewRows(levels);            

        }
        private void AddNewRows(ObservableCollection<Level> levels)
        {
           // int rowCount = dataGrid.Items.Count;
            
            levels.Add(new Level());
        }
        private void addBreak_Click(object sender, RoutedEventArgs e)
        {
            AddNewBreak(levels);
        }
        private void AddNewBreak(ObservableCollection<Level> levels)
        {
            levels.Add(new Level() { LevelName = "Break", UseAntes = false, SmallBlind = 0, BigBlind = 0});
        }
        private void loadStructure_Click(object sender, RoutedEventArgs e)
        {            
            using (StreamReader reader = new StreamReader("..\\TestStructure.csv"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    levels.Add(new Level(line));
                }
            }  
            // ... Use ItemsSource.            
           dataGrid.ItemsSource = levels;
           //dataGrid = sender as DataGrid;
        }
    }        
  }

