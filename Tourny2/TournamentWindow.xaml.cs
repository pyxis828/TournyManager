using System;
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
using Tourny2.View;
using System.Windows.Shapes;

namespace Tourny2
{
    /// <summary>
    /// Interaction logic for TournamentWindow.xaml
    /// </summary>
    public partial class TournamentWindow : Window
    {
        public TournamentWindow()
        {
            InitializeComponent();
            TimerControl view = new TimerControl();
            grid.Children.Add(view);
            Grid.SetRow(view, 0);
            Grid.SetColumn(view, 2);
        }
    }
}
