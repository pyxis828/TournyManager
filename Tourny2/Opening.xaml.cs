using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using Tourny2.View;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Tourny2
{
    /// <summary>
    /// Interaction logic for Opening.xaml
    /// </summary>
    public partial class Opening : Window
    {
        public Opening()
        {
            InitializeComponent();
        }

        SaveFileDialog save = new SaveFileDialog();                     

        private void MenuItem_Click(object sender, RoutedEventArgs e)                  //click timer button
        {
           TournamentWindow timer = new TournamentWindow();
           timer.Show();
        }

        private void Blinds_Click(object sender, RoutedEventArgs e)                     //click blinds button
        {
            Window2 blinds = new Window2();
            blinds.Show();
        }

        private void StrructureEntryButton_Click(object sender, RoutedEventArgs e)      //click structure entry button
        {
            Window1 structure = new Window1();
            structure.Show();
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)             //click open image button
        {            
            BitmapImage myBitmapImage = new BitmapImage();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpeg;*.jpg;*.bmp;*.gif;*.ico;*.wdp;*.tiff)|*.png;*.jpeg;*.jpg;*.bmp;*.gif;*.ico;*.wdp;*.tiff|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {                                                                       //needs work, idea is to allow user to save images
                myBitmapImage.BeginInit();                                          //into game/file to set as background for opening
                myBitmapImage.UriSource = new Uri(dialog.FileName);                 //screen and possibly tournament window background.
                myBitmapImage.EndInit();                                            //will need try/catch blocks
                image.Source = myBitmapImage;
                image.Stretch = Stretch.Fill;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)                     //click save image button
        {                                                                               //see above
            ImageSource myImage = image.Source;
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage = myImage as BitmapImage;
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == true)
            {
                using (FileStream stream = new FileStream("..\\PokerPics.jpeg", FileMode.Append))
                {
                    JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(myBitmapImage));
                    encoder.Save(stream);
                }
            }           
        }       
    }
}
