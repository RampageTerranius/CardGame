using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//enums for use with card class
public enum eSuit
{
    SPADES,
    CLUBS,
    DIAMONDS,
    HEARTS
}

public enum eValue
{
    ACE,
    TWO,
    THREE,
    FOUR,
    FIVE,
    SIX,
    SEVEN,
    EIGHT,
    NINE,
    TEN,
    JACK,
    QUEEN,
    KING
}

//base card class used by player and deck
namespace Server
{    
    class Card
    {
        private eSuit suit;
        private eValue val;

        public eSuit Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public eValue Value
        {
            get { return val; }
            set { val = value; }
        }

        public Card (eSuit Suit, eValue Value)
        {
            this.Suit = Suit;
            this.Value = Value;
        }
    }
}
