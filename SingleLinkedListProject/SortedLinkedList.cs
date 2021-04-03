using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class SortedLinkedList
    {
        private Node start;

        public SortedLinkedList()
        {
            start = null;
        }

        public void InsertInOrder(int data)
        {
            Node temp = new Node(data);

            // List empty or new node to be inserted before first node
            if (start == null || data < start.info)
            {
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            while (p.link != null && p.link.info <= data)
                p = p.link;

            temp.link = p.link;
            p.link = temp;
        }

        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            Console.Write("Enter the number of nodes : ");
            data = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the net element to be inserted : ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertInOrder(data);
            }

        }

        public void Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null && p.info <= x)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null || p.info != x)
            {
                Console.WriteLine(x + " not found in list");
                
            }
            else
            {
                Console.WriteLine(x + " is at position " + position);
               
            }

        }
    }
}
