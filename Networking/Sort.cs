using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    class Sort
    {
        public Sort(LinkedList<Card> Data)
        {
            Sorter(Data);
        }

        private void Sorter(LinkedList<Card> Data)
        {
            bool lLoop = true;
            while (lLoop)
            {
                lLoop = false;
                for (int i = 0; i < Data.GetLength() - 1; i++)
                {
                    if (Data.GetValueAt(i).Suit > Data.GetValueAt(i + 1).Suit)
                    {
                        Card Temp = Data.GetValueAt(i);
                        Data.ModifyValueAt(i, Data.GetValueAt(i + 1));
                        Data.ModifyValueAt(i + 1, Temp);
                        lLoop = true;                        
                        break;                        
                    }
                    else 
                    if (Data.GetValueAt(i).Suit == Data.GetValueAt(i + 1).Suit)
                        if (Data.GetValueAt(i).Value > Data.GetValueAt(i + 1).Value)
                        {
                            Card Temp = Data.GetValueAt(i);
                            Data.ModifyValueAt(i, Data.GetValueAt(i + 1));
                            Data.ModifyValueAt(i + 1, Temp);
                            lLoop = true;
                            break;
                        }
                }
            }
        }
    }
}
