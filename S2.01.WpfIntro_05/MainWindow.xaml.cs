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
        int i;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void buttonToClick_Click(object sender, RoutedEventArgs e)
        {
            Random rndNum = new Random();

            double leftPosition = rndNum.Next(20, 20);
           
           
            Thickness position = buttonToClick.Margin;

         
            position.Left = leftPosition;
         
         


            

        }


    }
}
