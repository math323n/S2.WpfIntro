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

namespace S2._01.WpfIntro_05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        int counter;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void buttonToClick_Click(object sender, RoutedEventArgs e)
        {
            int positionLeft;
            int positionTop;


            Random rndNumGen = new Random();


            positionLeft = rndNumGen.Next(40, 1500);
            positionTop = rndNumGen.Next(40, 700);


            buttonToClick.Margin = new Thickness(positionLeft, positionTop, 0, 0);


            counter++;
            points.Text = counter.ToString();



        }


    }
}
