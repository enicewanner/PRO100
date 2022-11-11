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
using System.Windows.Shapes;

namespace PRO100
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int CardsSelected = 0;

        public Window1()
        {
            InitializeComponent();
        }

        private void Card1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(CardBorder1.Visibility == Visibility.Hidden)
            {
                CardBorder1.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder1.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }
        private void Card2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CardBorder2.Visibility == Visibility.Hidden)
            {
                CardBorder2.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder2.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }
        private void Card3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CardBorder3.Visibility == Visibility.Hidden)
            {
                CardBorder3.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder3.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }
        private void Card4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CardBorder4.Visibility == Visibility.Hidden)
            {
                CardBorder4.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder4.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }
        private void Card5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CardBorder5.Visibility == Visibility.Hidden)
            {
                CardBorder5.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder5.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }
        private void Card6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CardBorder6.Visibility == Visibility.Hidden)
            {
                CardBorder6.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder6.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }
        private void Card7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CardBorder7.Visibility == Visibility.Hidden)
            {
                CardBorder7.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder7.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }
        private void Card8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CardBorder8.Visibility == Visibility.Hidden)
            {
                CardBorder8.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder8.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }
        private void Card9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CardBorder9.Visibility == Visibility.Hidden)
            {
                CardBorder9.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder9.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }
        private void Card10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CardBorder10.Visibility == Visibility.Hidden)
            {
                CardBorder10.Visibility = Visibility.Visible;
                CardsSelected++;
            }
            else
            {
                CardBorder10.Visibility = Visibility.Hidden;
                CardsSelected--;
            }
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            if(CardsSelected == 5)
            {
                this.Hide();
                MainWindow main = new MainWindow();
                main.Show();
            }
            else
            {
                MessageBox.Show("Must Select 5 Cards");
            }
        }
    }
}
