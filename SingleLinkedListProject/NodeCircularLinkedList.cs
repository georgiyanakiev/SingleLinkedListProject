using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListProject
{
    class NodeCircularLinkedList
    {
        public int info;
        public NodeCircularLinkedList link;

        public NodeCircularLinkedList(int i)
        {
            info = i;
            link = null;
        }
    }
}
