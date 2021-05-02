namespace DataStructures.Linked_Lists
{
    class PrintReverse
    {
        public static SinglyLinkedListNode Reverse(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode temp = head;
            SinglyLinkedListNode reversed = null;
            SinglyLinkedListNode next = null;

            while (temp != null)
            {
                next = temp.next;
                temp.next = reversed;
                reversed = temp;
                temp = next;
            }

            return reversed;
        }
    }
}
