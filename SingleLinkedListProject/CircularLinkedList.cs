using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
            
        }

        public void DisplayList()
        {
            if(last == null)
            {
                Console.WriteLine("List is empy\n");
                return;
            }

            Node p = last.link;
            do
            {
                Console.Write(p.info + "");
                p = p.link;
            }
            while (p != last.link);
            Console.WriteLine();
        }

        internal void CreateList()
        {
            throw new NotImplementedException();
        }

        internal void InsertInEmptyList(int data)
        {
            throw new NotImplementedException();
        }

        internal void InsertInBeginning(int data)
        {
            throw new NotImplementedException();
        }

        internal void InsertAtEnd(int data)
        {
            throw new NotImplementedException();
        }

        internal void InsertAfter(int data, int x)
        {
            throw new NotImplementedException();
        }

        internal void DeleteFirstNode()
        {
            throw new NotImplementedException();
        }

        internal void DeleteLastNode()
        {
            throw new NotImplementedException();
        }

        internal void DeleteNode(int data)
        {
            throw new NotImplementedException();
        }
    }
}
