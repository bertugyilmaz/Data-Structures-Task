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
        public abstract void InsertPos(object value, int position);
        public abstract void CreatePos(object value);
        public abstract void DeletePos(int position);
        public abstract object GetElement(int position);
    }
}
