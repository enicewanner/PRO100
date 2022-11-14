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
}
