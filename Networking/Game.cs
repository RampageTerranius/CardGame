using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    class Game
    {
        public Deck deck;
        public Player player;//the user of the application
        public Player competitor;//either ai or connected player

        public const int TOTAL_SUITS = 4;//how many of different suits there is
        public const int TOTAL_CARDS = 13;//how many cards there is in one suit
        public const int SPACES_BETWEEN_VALUES = 16;//the total spaces requested between each valeu when showing hand/deck

        public Game()
        {
            Reset();
        }

        public void Reset()
        {
            deck = new Deck();
            player = new Player();
            competitor = new Player();
            deck.ResetDeck();

            //card related
            deck.CreateDeck();
            deck.Shuffle();
            deck.Shuffle();
            deck.Shuffle();
            deck.Shuffle();
            deck.Shuffle();
        }

        public void Start()
        {
            Console.WriteLine("Card thingy");
            Console.WriteLine("Enter help for help...");
            string input = "";
            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter Input...");
                input = Console.ReadLine();
                switch(input.ToLower())
                {
                    case "exit":
                        run = false;
                        break;

                    case "draw":
                        player.Draw(deck);
                        Console.WriteLine("Card was drawn to hand");
                        break;

                    case "reset":
                        Reset();
                        deck.CreateDeck();
                        Console.WriteLine("Deck has been reset");
                        break;

                    case "shuffle":
                        deck.Shuffle();
                        Console.WriteLine("Deck has been shuffled");
                        break;

                    case "shuffle deck":
                        deck.Shuffle();
                        Console.WriteLine("Deck has been shuffled");
                        break;

                    case "shuffle hand":
                        player.Shuffle();
                        Console.WriteLine("Player hand has been shuffled");
                        break;

                    case "sort":
                        deck.Sort();
                        Console.WriteLine("deck has been sorted:");
                        break;

                    case "sort deck":
                        deck.Sort();
                        Console.WriteLine("deck has been sorted:");
                        break;

                    case "sort hand":
                        player.Sort();
                        Console.WriteLine("Player hand has been sorted:");
                        break;

                    case "show":
                        player.PrintHand();
                        deck.PrintDeck();
                        break;

                    case "show hand":
                        player.PrintHand();
                        break;

                    case "show deck":
                        deck.PrintDeck();
                        break;

                    case "drop":
                        player.Drop(deck);
                        Console.WriteLine("dropped players top card onto deck");
                        break;

                    case "help":
                        Console.WriteLine("Commands:");
                        Console.WriteLine("draw: draws a card");
                        Console.WriteLine("drop: drops players top card onto of the deck");
                        Console.WriteLine("show: shows your hand");
                        Console.WriteLine("reset: resets your hand and the deck");
                        Console.WriteLine("shuffle: shuffles the deck");
                        Console.WriteLine("shuffle hand: shuffles the players hand");
                        Console.WriteLine("sort: sorts the deck");
                        Console.WriteLine("sort hand: sorts the players hand");
                        Console.WriteLine("exit: exits the program");
                        break;
                }
            }
        }
    }
}
