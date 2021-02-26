using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
           
            if (start == null)
            {
                Console.WriteLine("List is empty");
                
                return;
            }
            Console.Write("List is : ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CreateList()
        {
            
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + " not found in list");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is at position " + position);
                return true;
            }
         
        }

        public void InsertInBeginning(int data)
        {
            throw new NotImplementedException();
        }

        public void InsertAtEnd(int data)
        {
            throw new NotImplementedException();
        }

        public void InsertAfter(int data, int x)
        {
            throw new NotImplementedException();
        }

        public void InsertBefore(int data, int x)
        {
            throw new NotImplementedException();
        }

        public void InsertAtPosition(int data, int k)
        {
            throw new NotImplementedException();
        }

        public void DeleteFirstNode()
        {
            throw new NotImplementedException();
        }

        public void DeleteNode(int data)
        {
            throw new NotImplementedException();
        }

        public void ReverseLIst()
        {
            throw new NotImplementedException();
        }

        public void BubbleSortExData()
        {
            throw new NotImplementedException();
        }

        public void BubbleSortExLinks()
        {
            throw new NotImplementedException();
        }

        public void MergeSort()
        {
            throw new NotImplementedException();
        }

        public void InsertCycle(int data)
        {
            throw new NotImplementedException();
        }

        public bool HasCycle()
        {
            throw new NotImplementedException();
        }

        public void RemoveCycle()
        {
            throw new NotImplementedException();
        }

        public void DeleteLastNode()
        {
            throw new NotImplementedException();
        }
    }
}
