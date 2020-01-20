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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S2._01.WpfIntro_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        int totalCount;
        int arrowCount;
       
        public MainWindow()
        {
            InitializeComponent();

            // Lower button text/font size
            buttonDown.Content = char.ConvertFromUtf32(0x2193);
            buttonDown.FontSize = 32;

            // Upper button text/font size
            buttonUp.Content = char.ConvertFromUtf32(0x2191);
            buttonUp.FontSize = 32;
        }

        private void buttonUp_Click(object sender, RoutedEventArgs e)
        {
            arrowCount++;
            totalCount++;
            textBlock.Text = "Antal af gange der er i alt trykket på knapperne: " + totalCount;
            textBlock_up.Text = "op/ned: " + arrowCount;
        }

        private void buttonDown_Click(object sender, RoutedEventArgs e)
        {
            arrowCount--;
            totalCount++;
            textBlock.Text = "Antal af gange der er i alt trykket på knapperne: " + totalCount;
            textBlock_up.Text = "op/ned: " + arrowCount;
        }


    }
}
