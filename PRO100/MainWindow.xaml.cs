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
        List<Image> Cards = new List<Image>();
        public MainWindow()
        {
            InitializeComponent();
            Cards.Add(TestCard);
            Cards.Add(TestCard3);
            game.Run(Cards, game.SelectedCards);
        }

        private void TestCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image imgSelected = (Image)sender;


            game.currentCard = game.GetSelectCard(imgSelected, Cards, game.SelectedCards);
            
            game.currentCard.Function(game.currentCard);
            game.Damage(Player1Health, game.currentCard);

            //checks which image was clicked and "removes"
            Image imgSelected = (Image)sender;
            imgSelected.Visibility = Visibility.Hidden;
            
            
        }


    }

    public class Game
    {
        Card test = new Card(1, 5, "test", "TestFunc", "/correct-icon.png");
        Card test2 = new Card(1, -5, "test", "TestFunc2", "/TestCard.PNG");

        public Card currentCard = new Card();
        public Card currentCard1 = new Card();
        public List<Card> SelectedCards = new List<Card>();

        

        //public void Run(Image card)
        public void Run(List<Image> Cards, List<Card> SelectedCards)
        {
            //Future plans: create a list of images, binding a different card to each so they display and function properly without hard-coding each
            SelectedCards.Add(test);
            SelectedCards.Add(test2);


            for (int i = 0; i < Cards.Count(); i++)
            { 
                currentCard1 = SelectedCards[i];
                Uri uri = new Uri(currentCard1.cardImage, UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                Cards[i].Source = imgSource;
            }
        }

        public void Damage(ProgressBar health, Card selectedCard)
        {
            health.Value = health.Value + selectedCard.damageValue;
        }

        public Card GetSelectCard(Image senderImage, List<Image> images, List<Card> cards)
        {
            Card selectedCard = new Card();

            for (int i = 0; i < images.Count; i++)
            {
                if (images[i] == senderImage)
                {
                    selectedCard = cards[i];
                }
            }


            return selectedCard;
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
            if (cardFunction == "TestFunc2") currentCard.TestFunc2();
        }

        public void TestFunc()
        {
            //damageValue = 0;
        }

        public void TestFunc2()
        {
            //this.damageValue = 0;
        }

    }








}
