using SingleLinkedListProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedListProject
{
    class DemoDoubleLinkedList
    {
        private static int k;

        static void MainDoubleLinkedList(string[] args)
        {
            int choice, data, x;

            DoubleLinkedList list = new DoubleLinkedList();
            list.CreateList();


            while (true)
            {
                Console.WriteLine("1.Display list");
                Console.WriteLine("2.Insert in empty list");
                Console.WriteLine("3.Insert a node in the beginning of the list");
                Console.WriteLine("4.Insert a node at the end of the list");
                Console.WriteLine("5.Insert a node after a specified node");
                Console.WriteLine("6.Insert a node before a specified node");
                Console.WriteLine("7.Delete first node");
                Console.WriteLine("8.Delete last node");
                Console.WriteLine("9.Delete any node"); 
                Console.WriteLine("10.Reverse the list");
                Console.WriteLine("11.Quit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 11)
                    break;
                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertinEmptyList(data);
                        break;
                    case 3:
                        Console.Write("Enter the element to be inserted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;
                    case 4:
                        Console.Write("Enter the element to be inserted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to be inserted :");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 6:
                        Console.Write("Enter the element to be searched :");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 7:
                        Console.Write("Enter the element to be searched :");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 8:
                        Console.Write("Enter the element to be searched :");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position at which to insert : ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteNode();
                        break;
                    case 11:
                        Console.Write("Enter the element to be deleted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteLastNode(data);
                        break;
                    case 12:
                        list.ReverseList();
                        break;
                    case 13:
                        list.BubbleSortExData();
                        break;
                    case 14:
                        list.BubbleSortExLinks();
                        break;
                    case 15:
                        list.MergeSort();
                        break;
                    case 16:
                        Console.Write("Enter the element at which the cycle has to be inserted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(data);
                        break;
                    case 17:
                        if (list.HasCycle())
                            Console.WriteLine("List has a cycle");
                        else
                            Console.WriteLine("List does not have a cycle");
                        break;
                    case 18:
                        list.RemoveCycle();
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
