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

        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the number of nodes : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            Console.Write("Enter the element to be inserted : ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (i = 2; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted : ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            last = temp;
            last.link = last;
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
            last = temp;
        }

        public void InsertAfter(int data, int x)
        {
            Node p = last.link;
            do
            {
                if (p.info == x)
                    break;
                p = p.link;
            }
            while (p != last.link);

            if (p == last.link && p.info != x)
                Console.WriteLine(x + " not present in the list");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
                if (p == last)
                    last = temp;

            }
        }

        public void DeleteFirstNode()
        {
            throw new NotImplementedException();
        }

        public void DeleteLastNode()
        {
            throw new NotImplementedException();
        }

        public void DeleteNode(int data)
        {
            throw new NotImplementedException();
        }
    }
}
