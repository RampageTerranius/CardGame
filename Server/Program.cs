using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum GAMETYPE
{
    Twenty_One
}

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            /*GAMETYPE gameType = 0;
            bool loop = true;

            //get the game type first before we check for connections
            while (loop)
            {
                Console.WriteLine("Please enter game type:");
                Console.WriteLine("0 = 21");

                //attempt to get the game type from server input
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 0:
                            gameType = GAMETYPE.Twenty_One;
                            loop = false;
                            break;

                        default:
                            Console.WriteLine("Unknown game type\n");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: only numbers are accepted as game type");
                }
            }

            Console.WriteLine("Game type is: " + gameType);*/

            Server.AsynchronousSocketListener.StartListening();
        }
    }
}
