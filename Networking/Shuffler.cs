using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    class Shuffle<T>
    {
        Random r = new Random();

        public Shuffle(LinkedList<T> Data)
        {
            for (int i = Data.GetLength() - 1; i > 0; i--)
            {
                int n = r.Next(0, i);

                T Temp = Data.GetValueAt(n);
                Data.ModifyValueAt(n, Data.GetValueAt(i));
                Data.ModifyValueAt(i, Temp);
            }
        }
    }
}
