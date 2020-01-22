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

namespace S2._01.WpfIntro_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        string[] validUsernames = new string[] { " Ole", "Brian" };
        string[] validPasswords = new string[] { "MinHundErSød", "Lastbil2006$Rød" };
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            // Make login button visible when login is correct

            if(validUsernames.Contains(textBoxUsername.Text) && validPasswords.Contains(textBoxPassword.Text))
            {
                if(hasLoggedIn.Visibility != System.Windows.Visibility.Hidden)
                    hasLoggedIn.Visibility = System.Windows.Visibility.Hidden;
                else
                    hasLoggedIn.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
