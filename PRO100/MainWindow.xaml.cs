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
            GameCont.game.CreatePlayerCards(Cards, GameCont.game.SelectedCards);
        }

        private void TestCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image imgSelected = (Image)sender;


            GameCont.game.currentCard = GameCont.game.GetSelectCard(imgSelected, Cards, GameCont.game.SelectedCards);

            GameCont.game.currentCard.Function(GameCont.game.currentCard);
            GameCont.game.Damage(Player1Health, GameCont.game.currentCard);

            //checks which image was clicked and "removes"
            //Image imgSelected = (Image)sender;
            //imgSelected.Visibility = Visibility.Hidden;
            
            
        }


    }

   

   








}
