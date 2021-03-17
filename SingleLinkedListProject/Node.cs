using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class Node
    {
        public Node prev;
        public Node next;
        public int info;
        public Node link;

        public Node(int i)
        {
            info = i;
            link = null;
            prev = null;
            next = null;
        }
    }
}
