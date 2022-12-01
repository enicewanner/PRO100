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
        Card Drunk = new Card(1, 5, "test", "RandomDmg", "CardImages/Drunken Fists.png");
        Card CheapShot = new Card(1, 5, "test", "TestFunc2", "CardImages/CheapShot.png");
        Card Attack = new Card(1, 50, "test", "TestFunc1", "CardImages/Attack.png");
        Card Kindness = new Card(1, 0, "test", "RandomDmg", "CardImages/Malicious Kindness.png");
        Card Mirror = new Card(1, 0, "test", "RandomDmg", "CardImages/Mirror Attack.png");
        Card Mystery = new Card(1, 0, "test", "RandomDmg", "CardImages/Mystery.png");
        Card Overkill = new Card(1, 0, "test", "RandomDmg", "CardImages/Overkill.png");
        Card Shield = new Card(1, 0, "test", "RandomDmg", "CardImages/Shield Bash.png");
        Card Assault = new Card(1, 0, "test", "RandomDmg", "CardImages/Violent Assault.png");
        Card WhiteFlag = new Card(1, 0, "test", "RandomDmg", "CardImages/WhiteFlag.png");
        public Card Blank = new Card(0, 0, "blank", "EmptyFunc", "CardImages/correct-icon.png");
        


        public Card currentCard = new Card();
        public Card currentCard1 = new Card();
        public ArrayList SelectedCards = new ArrayList();
        public ArrayList SelectedCardsP2 = new ArrayList();
        public ArrayList AllCards = new ArrayList();

        public int currentPlayer = 1;

        public int turnsPassed = 0;




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

                if (currentCard.used == true)
                {
                   Cards[i].Visibility = Visibility.Hidden;
                }
                else
                {
                    Cards[i].Visibility = Visibility.Visible;
                }
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

        public void CalculateDamage(Player playerAttacking, Player playerDefending, Card SelectedCard)
        {
            playerAttacking.outgoingDamage = SelectedCard.damageValue;
            playerDefending.incomingDamage = playerAttacking.outgoingDamage;
        }

        public void Damage(ProgressBar health, Card selectedCard, Player player1, Player player2)
        {
            health.Value = health.Value + (-(player1.incomingDamage)) + (player2.incomingDamage);

            //health.Value = health.Value + selectedCard.damageValue;


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
