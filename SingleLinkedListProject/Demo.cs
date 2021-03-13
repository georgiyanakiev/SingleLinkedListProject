using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            SingleLinkedList list1 = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();

            list1.CreateList();
            list2.CreateList();

            list1.BubbleSortExData();
            list2.BubbleSortExData();


            Console.WriteLine("First List - "); list1.DisplayList();
            Console.WriteLine("Second List - "); list2.DisplayList();

            SingleLinkedList list3;

            list3 = list1.Merge1(list2);
            Console.WriteLine("Merged List - "); list3.DisplayList();
            Console.WriteLine("First List - "); list1.DisplayList();
            Console.WriteLine("Second List - "); list2.DisplayList();

            list3 = list1.Merge2(list2);
            Console.WriteLine("Merged List - "); list3.DisplayList();

            Console.WriteLine("First List - "); list1.DisplayList();
            Console.WriteLine("Second List - "); list2.DisplayList();
        


            while (true)
            {
                Console.WriteLine("1.Display list");
                Console.WriteLine("2.Count the number of nodes");
                Console.WriteLine("3.Search for an element");
                Console.WriteLine("4.Insert in empty list/insert in beginning of the list");
                Console.WriteLine("5.Insert a node at the end of the list");
                Console.WriteLine("6.Insert a node after a specified node");
                Console.WriteLine("7.Insert a node before a specified node");
                Console.WriteLine("8.Insert a node at a given position");
                Console.WriteLine("9.Delete first node");
                Console.WriteLine("10.Delete last node");
                Console.WriteLine("11.Delete any node"); 
                Console.WriteLine("12.Reverse the list");
                Console.WriteLine("13.Bubble sort by exchanging data");
                Console.WriteLine("14.Bubble sort by exchanging links");
                Console.WriteLine("15.Merge Sort");
                Console.WriteLine("16.Insert Cycle");
                Console.WriteLine("17.Detect Cycle");
                Console.WriteLine("18.Remove cycle");
                Console.WriteLine("19.Quit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;
                switch (choice)
                {
                    case 1:
                        list1.DisplayList();
                        break;
                    case 2:
                        list1.CountNodes();
                        break;
                    case 3:
                        Console.Write("Enter the element to be inserted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list1.Search(data);
                        break;
                    case 4:
                        Console.Write("Enter the element to be inserted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list1.InsertInBeginning(data);
                        break;
                    case 5:
                        Console.Write("Enter the element to be inserted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list1.InsertAtEnd(data);
                        break;
                    case 6:
                        Console.Write("Enter the element to be searched :");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list1.InsertAfter(data, x);
                        break;
                    case 7:
                        Console.Write("Enter the element to be searched :");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list1.InsertBefore(data, x);
                        break;
                    case 8:
                        Console.Write("Enter the element to be searched :");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position at which to insert : ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list1.InsertAtPosition(data, k);
                        break;
                    case 9:
                        list1.DeleteFirstNode();
                        break;
                    case 10:
                        list1.DeleteNode();
                        break;
                    case 11:
                        Console.Write("Enter the element to be deleted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list1.DeleteLastNode(data);
                        break;
                    case 12:
                        list1.ReverseList();
                        break;
                    case 13:
                        list1.BubbleSortExData();
                        break;
                    case 14:
                        list1.BubbleSortExLinks();
                        break;
                    case 15:
                        list1.MergeSort();
                        break;
                    case 16:
                        Console.Write("Enter the element at which the cycle has to be inserted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list1.InsertCycle(data);
                        break;
                    case 17:
                        if (list1.HasCycle())
                            Console.WriteLine("List has a cycle");
                        else
                            Console.WriteLine("List does not have a cycle");
                        break;
                    case 18:
                        list1.RemoveCycle();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");
        }
    }
}
