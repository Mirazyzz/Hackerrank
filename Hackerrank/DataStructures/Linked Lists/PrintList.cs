using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linked_Lists
{
    class PrintList
    {
        static void PrintLinkedList(SinglyLinkedListNode head)
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
    }
}
