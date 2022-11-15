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
        Card test = new Card(1, 5, "test", "TestFunc", "/correct-icon.png");
        Card test2 = new Card(1, -5, "test", "TestFunc2", "/TestCard.PNG");
        Card testRand = new Card(1, 0, "test", "RandomDmg", "/TestCard.PNG");

        public Card currentCard = new Card();
        public Card currentCard1 = new Card();
        public ArrayList SelectedCards = new ArrayList();
        public ArrayList AllCards = new ArrayList();
        
        



        //public void Run(Image card)
        public void CreatePlayerCards(List<Image> Cards, ArrayList SelectedCards)
        {
            //Future plans: create a list of images, binding a different card to each so they display and function properly without hard-coding each
            SelectedCards.Add(test);
            SelectedCards.Add(test2);
            SelectedCards.Add(testRand);
            AllCards.Add(test);
            AllCards.Add(test2);
            


            for (int i = 0; i < Cards.Count; i++)
            {
                currentCard1 = (Card)SelectedCards[i];
                Uri uri = new Uri(currentCard1.cardImage, UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                Cards[i].Source = imgSource;
            }
        }

        public void UpdatePlayerCards(List<Image> Cards, ArrayList SelectedCards)
        {
            //Future plans: create a list of images, binding a different card to each so they display and function properly without hard-coding each
            for (int i = 0; i < Cards.Count; i++)
            {
                currentCard1 = (Card)SelectedCards[i];
                Uri uri = new Uri(currentCard1.cardImage, UriKind.RelativeOrAbsolute);
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
            public static Game game;
        }
}
