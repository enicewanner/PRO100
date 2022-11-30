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
            if (cardFunction == "TestFunc") currentCard.TestFunc();
            if (cardFunction == "TestFunc2") currentCard.TestFunc2();
            if (cardFunction == "EmptyFunc") currentCard.EmptyFunc();
            if (cardFunction == "RandomDmg") currentCard.RandomDmg();
        }

        public void TestFunc()
        {
            //damageValue = 0;
        }

        public void TestFunc2()
        {
            //this.damageValue = 0;
        }

        public void EmptyFunc()
        {

        }

        public void RandomDmg()
        {
            var rand = new Random();
            this.damageValue = rand.Next(1, 11);
        }



    }



}
