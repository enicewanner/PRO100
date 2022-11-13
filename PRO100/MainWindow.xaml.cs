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
        Game game = new Game();
        public MainWindow()
        {
            InitializeComponent();
            game.Run(TestCard);


        }

        private void TestCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            game.currentCard1.Function(game.currentCard1);
            game.Damage(Player1Health, game.currentCard1);

            //checks which image was clicked and "removes"
            Image imgSelected = (Image)sender;
            imgSelected.Visibility = Visibility.Hidden;
            
            
        }

        private void TestCard2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Player1Health.Value = Player1Health.Value - 5;
        }
    }

    public class Game
    {
        Card test = new Card(1, 5, "test", "TestFunc", "/correct-icon.png");
        public Card currentCard1 = new Card();
        public void Run(Image card)
        {
            //Future plans: create a list of images, binding a different card to each so they display and function properly without hard-coding each


            currentCard1 = test;
            Uri uri = new Uri(currentCard1.cardImage, UriKind.RelativeOrAbsolute);
            ImageSource imgSource = new BitmapImage(uri);

            card.Source = imgSource;

        }

        public void Damage(ProgressBar health, Card selectedCard)
        {
            health.Value = health.Value + selectedCard.damageValue;
        }



    }

    public class Card
    {
        public int cardID = 0;
        public int damageValue = 0;
        public string name = "default";
        public string cardFunction = "default";
        public string cardImage = "default";

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

        public void Function(Card currentCard)
        {
            if (cardFunction == "TestFunc") currentCard.TestFunc();
        }

        public void TestFunc()
        {
            //damageValue = 0;
        }

    }








}
