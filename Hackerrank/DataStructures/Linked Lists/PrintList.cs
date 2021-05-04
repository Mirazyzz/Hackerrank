﻿using System;

namespace DataStructures.Linked_Lists
{
    class PrintList
    {
        public static void PrintLinkedList(SinglyLLNode head)
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
    }
}
