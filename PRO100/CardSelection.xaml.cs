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
        int playerHasSelected = 0;
        List<Image> images = new List<Image>();
        List<Border> borders = new List<Border>();



        public Window1()
        {
            InitializeComponent();

            GameCont.game.CreateAllCardsList(GameCont.game.AllCards);

            images.Add(Card1);
            images.Add(Card2);
            images.Add(Card3);
            images.Add(Card4);
            images.Add(Card5);
            images.Add(Card6);
            images.Add(Card7);
            images.Add(Card8);
            images.Add(Card9);
            images.Add(Card10);

            borders.Add(CardBorder1);
            borders.Add(CardBorder2);
            borders.Add(CardBorder3);
            borders.Add(CardBorder4);
            borders.Add(CardBorder5);
            borders.Add(CardBorder6);
            borders.Add(CardBorder7);
            borders.Add(CardBorder8);
            borders.Add(CardBorder9);
            borders.Add(CardBorder10);

            GameCont.game.CreatePlayerCards(images, GameCont.game.AllCards);

        }

        private void Card1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < images.Count; i++)
            {
                if (images[i] == (Image)sender)
                {



                    if (borders[i].Visibility == Visibility.Hidden)
                    {
                        borders[i].Visibility = Visibility.Visible;
                        CardsSelected++;

                    }
                    else
                    {
                        borders[i].Visibility = Visibility.Hidden;
                        CardsSelected--;
                    }
                }
            }
            //if (CardBorder1.Visibility == Visibility.Hidden)
            //{
            //    CardBorder1.Visibility = Visibility.Visible;
            //    CardsSelected++;
            //}
            //else
            //{
            //    CardBorder1.Visibility = Visibility.Hidden;
            //    CardsSelected--;
            //}
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            if (CardsSelected == 5)
            {
                if (playerHasSelected == 0)
                {
                    GameCont.game.CreateSelectedCardList(borders, GameCont.player1.playerDeck, GameCont.player1);
                    playerHasSelected = 1;
                    CardsSelected = 0;
                }
                else if (playerHasSelected == 1)
                {
                    GameCont.game.CreateSelectedCardList(borders, GameCont.player2.playerDeck, GameCont.player2);
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Must Select 5 Cards");
            }
        }
    }
}
