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
