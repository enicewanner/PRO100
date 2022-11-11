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

namespace PRO100
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TestCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Player1Health.Value = Player1Health.Value + 5;
        }

        private void TestCard2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Player1Health.Value = Player1Health.Value - 5;
        }
    }

    public class Game
    {
        Card test = new Card(1, 1, "test", "test", "test");
    }

    public class Card
    {
        int cardID = 0;
        int damageValue = 0;
        string name = "default";
        string cardFunction = "default";
        string cardImage = "default";

        public Card()
        {

        }

        public Card(int cardID, int damageValue, string name, string cardFunction, string cardImage)
        {
            this.cardID = cardID;
            this.damageValue = damageValue;
            this.name = name;
            this.cardFunction = cardFunction;
            this.cardImage = cardImage;
        }
    }

}
