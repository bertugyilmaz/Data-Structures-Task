using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BollywoodCinema
{
    public class LinkedList : LinkedListADT
    {
        public override void CreatePos(object value)
        {
            Node tempHead = new Node { Data = value };

            if (Head == null) { Head = tempHead; }
            else
            {
                tempHead.Next = Head;
                Head = tempHead;
            }
            Size++; //LinkedList in boyutu aynı zamanda toplam koltuk sayısıda denebilir.
        }

        public override void DeletePos(int position)
        {
            Node postemp = Head;

            int i = 1;
            while (postemp != null)
            {
                if (position == i)
                {
                    postemp.Data = null;
                    break;
                }
                postemp = postemp.Next;
                i++;
            }
        }

        public override object GetElement(int position)
        {
            Node returnNode = null;

            Node tempNode = Head;
            int count = 1;

            while (tempNode != null)
            {
                if (count == position)
                {
                    returnNode = tempNode;
                    break;
                }
                tempNode = tempNode.Next;
                count++;
            }
            return returnNode;
        }

        public override void InsertPos(object value, int position)
        {
            Node newNode = Head;

            int i = 1;
            while (i <= 60)
            {
                if (position == i && Size <= 60)
                {
                    newNode.Data = value;
                    break;
                }
                newNode = newNode.Next;
                i++;
            }
        }
    }
}
