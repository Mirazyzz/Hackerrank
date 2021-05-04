using System;

namespace DataStructures.Linked_Lists
{
    class PrintReverse
    {
        public static void Print(SinglyLinkedListNode head)
        {
            if (head == null) return;

            Print(head.next);

            Console.WriteLine(head.data);
        }
    }
}
