using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class HeaderLinkedList
    {
        private Node head;

        public HeaderLinkedList()
        {
            head = new Node(0);
        }

        public void DisplayList()
        {
            if (head.link == null )
            {
                Console.WriteLine("List is empty\n");
                return;
            }
            Node p = head.link;
            Console.Write("List is :\n");
            while (p != null )
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}
