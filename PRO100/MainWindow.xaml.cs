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
    /// 



    public partial class MainWindow : Window
    {
        //Game game = new Game();
        List<Image> Cards = new List<Image>();

        public MainWindow()
        {
            InitializeComponent();
            Cards.Add(TestCard);
            Cards.Add(TestCard2);
            Cards.Add(TestCard3);
            Cards.Add(TestCard4);
            Cards.Add(TestCard5);
            GameCont.game.CreatePlayerCards(Cards, GameCont.player1.playerDeck);
        }

        private void TestCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image imgSelected = (Image)sender;




            



            //checks which image was clicked and "removes"
            //Image imgSelected = (Image)sender;
            //imgSelected.Visibility = Visibility.Hidden;

            if (GameCont.game.currentPlayer == 1)
            {
                //GameCont.player1.playerDeck.Remove(GameCont.game.currentCard);
                GameCont.game.currentCard = GameCont.game.GetSelectCard(imgSelected, Cards, GameCont.player1.playerDeck);

                GameCont.game.CalculateDamage(GameCont.player1, GameCont.player2, GameCont.game.currentCard);
                GameCont.game.currentCard.Function(GameCont.game.currentCard);
                //GameCont.game.Damage(Player1Health, GameCont.game.currentCard);

                GameCont.game.currentCard.used = true;
                GameCont.game.CreatePlayerCards(Cards, GameCont.player2.playerDeck);
                GameCont.game.currentPlayer = 2;
            }
            else if (GameCont.game.currentPlayer == 2)
            {

                //GameCont.player2.playerDeck.Remove(GameCont.game.currentCard);
                GameCont.game.currentCard = GameCont.game.GetSelectCard(imgSelected, Cards, GameCont.player2.playerDeck);

                GameCont.game.CalculateDamage(GameCont.player2, GameCont.player1, GameCont.game.currentCard);
                GameCont.game.currentCard.Function(GameCont.game.currentCard);
                GameCont.game.Damage(Player1Health, GameCont.game.currentCard, GameCont.player1, GameCont.player2);
                //GameCont.game.Damage(Player1Health, GameCont.game.currentCard);

                GameCont.game.currentCard.used = true;
                GameCont.game.CreatePlayerCards(Cards, GameCont.player1.playerDeck);
                GameCont.game.currentPlayer = 1;

                GameCont.game.turnsPassed++;
            }




            if (GameCont.game.turnsPassed >= 5)
            {
                //this.Close();
            }
        }


    }












}
