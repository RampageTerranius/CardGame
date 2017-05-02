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
namespace Networking
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

        /*public override string ToString()
        {
            string convSuit = "";
            string convVal = "";

            switch (suit)
            {
                case eSuit.SUIT_SPADES:
                    convSuit = "Spades";
                    break;
                case eSuit.SUIT_CLUBS:
                    convSuit = "Clubs";
                    break;
                case eSuit.SUIT_DIAMONDS:
                    convSuit = "Diamonds";
                    break;
                case eSuit.SUIT_HEARTS:
                    convSuit = "Hearts";
                    break;
            } 

            switch(Value)
            {
                case eValue.VALUE_ACE:
                    convVal = "Ace";
                    break;
                case eValue.VALUE_2:
                    convVal = "2";
                    break;
                case eValue.VALUE_3:
                    convVal = "3";
                    break;
                case eValue.VALUE_4:
                    convVal = "4";
                    break;
                case eValue.VALUE_5:
                    convVal = "5";
                    break;
                case eValue.VALUE_6:
                    convVal = "6";
                    break;
                case eValue.VALUE_7:
                    convVal = "7";
                    break;
                case eValue.VALUE_8:
                    convVal = "8";
                    break;
                case eValue.VALUE_9:
                    convVal = "9";
                    break;
                case eValue.VALUE_10:
                    convVal = "10";
                    break;
                case eValue.VALUE_JACK:
                    convVal = "Jack";
                    break;
                case eValue.VALUE_QUEEN:
                    convVal = "Queen";
                    break;
                case eValue.VALUE_KING:
                    convVal = "King";
                    break;
            }

            string write = "Suit: " + convSuit;

            while (write.Length < Game.SPACES_BETWEEN_VALUES - 1)
                write += " ";

            write += " Value: " + convVal;

            Console.WriteLine(write);
            return "";
        }*/
    }
}
