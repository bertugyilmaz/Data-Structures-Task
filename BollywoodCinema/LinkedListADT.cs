using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BollywoodCinema
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;

        public abstract void InsertFirst(int value);
        public abstract void InsertPos(int value, int position);
        public abstract void DeletePos(int position);
        public abstract Node GetElement(int position);
    }
}
