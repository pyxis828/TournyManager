using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Media;
using System.Timers;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tourny2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        double levelTime = 2;
        double clockTime;
        Queue<string> times = new Queue<string>();
        public MainWindow()
        {
            InitializeComponent();                       
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            clockTime = levelTime;
            times = TimeConverter(levelTime);
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
           
           
        }
        
        private  void timer_Tick (object sender, EventArgs e)
        {
            Clock.Content = times.Dequeue();           
            if ((string)Clock.Content == "00:00:00")
            {
                SystemSounds.Exclamation.Play();
                timer.Stop();
            }
        }

        private void Clock_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            
            timer.Start();
        }

        private void resetLevel_Click(object sender, RoutedEventArgs e)
        {
            clockTime = levelTime*100;
            Clock.Content = clockTime.ToString("00:00:00");
        }       
        public Queue<string> TimeConverter(double levelTime)
        {
            TimeSpan span1 = TimeSpan.FromMinutes(levelTime);
            TimeSpan span2 = TimeSpan.FromSeconds(1);
            Queue<string> times = new Queue<string>();
            double i = levelTime * 60;
            for (i = i; i >= 0; i--)
            {
                TimeSpan span3 = span1.Subtract(span2);                
                times.Enqueue(span3.ToString());   
                span1 = span3;
            }
            return times;
        }
        }
    }
