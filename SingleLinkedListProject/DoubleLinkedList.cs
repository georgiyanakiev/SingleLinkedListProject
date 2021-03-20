﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class DoubleLinkedList
    {
        private Node start;

        public DoubleLinkedList()
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

            p = start;
            Console.Write("List is : ");
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.next = start;
            start.prev = temp;
            start = temp;

        }

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);

            Node p = start;
            while (p.next != null)
                p = p.next;
            p.next = temp;
            temp.prev = p;
        }

        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the number of nodes : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            Console.Write("Enter the first element to be inserted : ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (i = 2; i <= n; i++)
            {
                Console.Write("Enter the next element to be inserted : ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        private void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            start = temp;
        }

        public void InsertAfter(int data, int x)
        {
            Node temp = new Node(data);

            Node p = start;
            while (p != null )
            {
                if (p.info == x)
                    break;
                p = p.next;
            }
            if (p == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                temp.prev = p;
                temp.next = p.next;
                if (p.next != null)
                    p.next.prev = temp;
                p.next = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            if (start == null )
            {
                Console.WriteLine("List is empty");
                    return;
            }
            if (start.info == x )
            {
                Node temp = new Node(data);
                temp.next = start;
                start.prev = temp;
                start = temp;
                return;
            }

            Node p = start;
            while (p != null )
            {
                if (p.info == x)
                    break;
                p = p.next;
            }

            if (p == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                Node temp = new Node(data);
                temp.prev = p.prev;
                temp.next = p;
                p.prev.next = temp;
                p.prev = temp;
            }



        }


       
    }
}
