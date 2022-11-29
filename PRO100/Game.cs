using System;
using System.Collections.Generic;
using System.Collections;
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


    public class Game
    {
        Card Drunk = new Card(1, 5, "test", "RandomDmg", "/Drunken Fists.png");
        Card CheapShot = new Card(1, -5, "test", "TestFunc2", "/CheapShot.png");
        Card Attack = new Card(1, 0, "test", "TestFunc1", "/Attack.png");
        Card Kindness = new Card(1, 0, "test", "RandomDmg", "/Malicious Kindness.png");
        Card Mirror = new Card(1, 0, "test", "RandomDmg", "/Mirror Attack.png");
        Card Mystery = new Card(1, 0, "test", "RandomDmg", "/Mystery.png");
        Card Overkill = new Card(1, 0, "test", "RandomDmg", "/Overkill.png");
        Card Shield = new Card(1, 0, "test", "RandomDmg", "/Shield Bash.png");
        Card Assault = new Card(1, 0, "test", "RandomDmg", "/Violent Assault.png");
        Card WhiteFlag = new Card(1, 0, "test", "RandomDmg", "/WhiteFlag.png");


        public Card currentCard = new Card();
        public Card currentCard1 = new Card();
        public ArrayList SelectedCards = new ArrayList();
        public ArrayList SelectedCardsP2 = new ArrayList();
        public ArrayList AllCards = new ArrayList();

        public int currentPlayer = 1;

        int turnsPassed = 0;




        public void CreateAllCardsList(ArrayList AllCards)
        {
            AllCards.Add(Attack);
            AllCards.Add(Drunk);
            AllCards.Add(CheapShot);
            AllCards.Add(Kindness);
            AllCards.Add(Mirror);
            AllCards.Add(Mystery);
            AllCards.Add(Overkill);
            AllCards.Add(Shield);
            AllCards.Add(Assault);
            AllCards.Add(WhiteFlag);
        }

        public void CreateSelectedCardList(List<Border> Selected, ArrayList SelectedCards, Player currentPlayer)
        {
            SelectedCards.Clear();
            for (int i = 0; i < Selected.Count; i++)
            {
                if (Selected[i].Visibility == Visibility.Visible)
                {
                    SelectedCards.Add(AllCards[i]);

                }
            }
            currentPlayer.playerDeck = SelectedCards;
            for (int i = 0; i < Selected.Count; i++)
            {
                Selected[i].Visibility = Visibility.Hidden;
            }
        }



        //public void Run(Image card)
        public void CreatePlayerCards(List<Image> Cards, ArrayList SelectedCards)
        {
            //Future plans: create a list of images, binding a different card to each so they display and function properly without hard-coding each
            //GameCont.game.SelectedCards.Add(test);
            //GameCont.game.SelectedCards.Add(test2);
            //GameCont.game.SelectedCards.Add(testRand);




            for (int i = 0; i < SelectedCards.Count; i++)
            {
                currentCard = (Card)SelectedCards[i];
                Uri uri = new Uri(currentCard.cardImage, UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                Cards[i].Source = imgSource;
            }
        }

        public void UpdatePlayerCards(List<Image> Cards, ArrayList SelectedCardsU, Player currentPlayer)
        {
            //Future plans: create a list of images, binding a different card to each so they display and function properly without hard-coding each
            for (int i = 0; i < SelectedCards.Count; i++)
            {
                currentCard = (Card)SelectedCardsU[i];
                Uri uri = new Uri(currentCard.cardImage, UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                Cards[i].Source = imgSource;
            }
        }

        public void Damage(ProgressBar health, Card selectedCard)
        {
            health.Value = health.Value + selectedCard.damageValue;
        }

        public Card GetSelectCard(Image senderImage, List<Image> images, ArrayList cards)
        {
            Card selectedCard = new Card();

            for (int i = 0; i < images.Count; i++)
            {
                if (images[i] == senderImage)
                {
                    selectedCard = (Card)cards[i];
                }
            }


            return selectedCard;
        }



    }
    //Allows use of a "Global Variable" for game
    static class GameCont
    {
        public static Game game = new Game();
        public static Player player1 = new Player();
        public static Player player2 = new Player();
    }

}
