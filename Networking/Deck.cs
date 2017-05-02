using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    class Deck
    {
        public LinkedList<Card> CardDeck;
        public LinkedList<Card> DrawnCards;

        public Deck()
        {
            ResetDeck();
        }

        public void ResetDeck()
        {
            CardDeck = new LinkedList<Card>();
            DrawnCards = new LinkedList<Card>();
        }

        public void CreateDeck()
        {
            ResetDeck();

            for (int i = 0; i < Game.TOTAL_SUITS; i++)
                for(int n = 0; n < Game.TOTAL_CARDS; n++)
                    CardDeck.AddValue(new Card((eSuit) i, (eValue) n));    
        }

        public void Shuffle()
        {
            Shuffle<Card> shuffle = new Shuffle<Card>(CardDeck);
        }

        public void Sort()
        {
            Sort sort = new Sort(CardDeck);
        }

        public Card Draw()
        {
            Card Temp = CardDeck.GetValueAt(CardDeck.GetLength());
            CardDeck.RemoveValueAt(CardDeck.GetLength() - 1);
            DrawnCards.AddValue(Temp);

            return Temp;
        }

        public void PrintDeck()
        {
            Console.WriteLine("Deck Cards:");
            CardDeck.PrintValues(true);
            Console.WriteLine();
        }

        public void PrintDrawn()
        {
            Console.WriteLine("Drawn Cards:");
            DrawnCards.PrintValues(true);
            Console.WriteLine();
        }
    }
}
