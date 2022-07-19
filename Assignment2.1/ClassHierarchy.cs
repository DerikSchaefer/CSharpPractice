using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    // Create the base class. I'm going to keep this as public because I may invoke it, I'm not sure yet
    public class Cards
    {
        // suit, value, cardsinDeck, count
        public string Suit
        {
            get;
            set;
        }

        public int value
        {
            get;
            set;
        }

        public int CardsInDeck
        {
            get;
            set;
        }

        public int count
        {
            get;
            set;
        }

        // set the value for cards in deck

        const int cardsInDeck = 52;


        // create a quick method for drawing a card & just decrementing the cards in the deck by one
        public int drawCard()
        {
            CardsInDeck -= 1;
            return CardsInDeck;
        }

    }

    // zero cards subclass

    // public int zeroindeck 12

    // quick function, count = count; 
    // decrement the cardsindeck by one
    class zeroCards : Cards
    {
        public int zeroCardsInDeck = 12;
        public int zeroCount()
        {
            count = count;
            return count;
        }

        class Sevens : zeroCards
        {
            public int sevensInDeck = 4;
        }

        class Eights : zeroCards
        {
            public int eightsInDeck = 4;
        }

        class Nines : zeroCards
        {

            public int ninesInDeck = 4;
        }

    }
    // zero cards subclass

    // public int zeroindeck 20

    // quick function, count -= count; 
    // decrement the cardsindeck by one
    class negativeOneCards : Cards
    {
        public int zeroCardsInDeck = 20;
        public int negativeOneCount()
        {
            count -= count;
            return count;
        }

        class Tens : negativeOneCards
        {
            public int tensInDeck = 4;
        }

        class Jacks : negativeOneCards
        {
            public int jacksInDeck = 4;
        }

        class Queens : negativeOneCards
        {
            public int queensInDeck = 4;
        }

        class Kings : negativeOneCards
        {
            public int kingsInDeck = 4;
        }
        class Aces : negativeOneCards
        {
            public int acesInDeck = 4;
        }
    }
  
    
    // zero cards subclass

    // public int zeroindeck 20

    // quick function, count += count; 
    // decrement the cardsindeck by one
    class plusOneCards : Cards
    {
        public int zeroCardsInDeck = 20;
        public int plusOneCount()
        {
            count += count;
            return count;
        }


// Third level sub class
//Twos, twosinDeck = 4; 
        class Twos : plusOneCards
        {
            public int twosInDeck = 4;
        }

        class Threes : plusOneCards
        {
            public int threesInDeck = 4;
        }

        class Fours : plusOneCards
        {

            public int foursInDeck = 4;
        }

        class Fives : plusOneCards
        {
            public int fivesInDeck = 4;
        }

        class Sixes : plusOneCards
        {
            public int sixesInDeck = 4;
        }
    }
}