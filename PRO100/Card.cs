using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO100
{
    public class Card
    {
        public int cardID = 0;
        public int damageValue = 0;
        public string name = "default";
        public string cardFunction = "default";
        public string cardImage = "default";
        public bool used = false;

        public Card()
        {

        }

        public Card(int cardID, int damageValue, string name, string cardFunction, string cardImage, bool used = false)
        {
            this.cardID = cardID;
            this.damageValue = damageValue;
            this.name = name;
            this.cardFunction = cardFunction;
            this.cardImage = cardImage;
            this.used = used;
        }

        public void Function(Card currentCard)
        {
            if (cardFunction == "EmptyFunc") currentCard.EmptyFunc();
            if (cardFunction == "RandomDmg") currentCard.RandomDmg();
            if (cardFunction == "WhiteFlag") currentCard.WhiteFlag();
            if (cardFunction == "Mystery") currentCard.Mystery();
            if (cardFunction == "CheapShot") currentCard.CheapShot();
            if (cardFunction == "Kindness") currentCard.Kindness();
            if (cardFunction == "Mirror") currentCard.Mirror();
            if (cardFunction == "Overkill") currentCard.Overkill();
            if (cardFunction == "Shield") currentCard.Shield();
            if (cardFunction == "Assault") currentCard.Assault();
        }

        public void EmptyFunc()
        {

        }

        public void RandomDmg()
        {
            var rand = new Random();
            this.damageValue = rand.Next(1, 10);
        }

        public void WhiteFlag()
        {
            if(GameCont.game.currentPlayer == 1)
            {
                GameCont.player1.incomingDamage = 0;
            }
            else
            {
                GameCont.player2.incomingDamage = 0;
            }
        }

        public void Mystery()
        {
            
        }

        public void CheapShot()
        {

        }

        public void Kindness()
        {

        }

        public void Mirror()
        {

        }

        public void Overkill()
        {

        }

        public void Shield()
        {

        }

        public void Assault()
        {

        }
    }
}
