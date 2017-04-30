using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BollywoodCinema
{
    public class LinkedList : LinkedListADT
    {
        public override void DeletePos(int position)
        {
            Node temp = null;
            Node postemp = Head;

            int i = 1;

            while (postemp != null)
            {
                if (position == i)
                {
                    temp = postemp.Next;
                    postemp = null;
                    postemp = temp;

                    break;
                }
                postemp = postemp.Next;
                i++;
            }

        }

        public override Node GetElement(int position)
        {
            Node returnNode = null;

            Node tempNode = Head;
            int count = 0;

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

        public override void InsertFirst(int value)
        {
            Node tmpHead = new Node { Data = value };

            if (Head == null) { Head = tmpHead; }          //Head boş(NULL) ise iteratöre atar
            else { tmpHead.Next = Head; Head = tmpHead; }  //tmpHead in next i Head i göstermeli. Yeni Head tmpHead olmuştur.

            Size++; // Listedeki Eleman sayısı 
        }

        public override void InsertPos(int value, int position)
        {
            Node newNode = new Node { Data = value };

            int i = 1;
            if (Head == null) { InsertFirst(value); }
            else
            {
                Node posNode = Head;
                Node tempNext = null;

                while (posNode != null)
                {
                    if (position == i)
                    {
                        tempNext = posNode.Next;
                        newNode.Next = tempNext;
                        posNode.Next = newNode;

                        break;
                    }
                    posNode = posNode.Next;
                    i++;
                }
            }
        }
    }
}
