namespace DataStructures.Linked_Lists
{
    class DeleteNodeAtPosition
    {
        public static SinglyLinkedListNode DeleteNode(SinglyLinkedListNode head, int position)
        {
            if (position == 0) return head.next;

            int currentPosition = 1;
            var temp = head;

            while (temp != null && position != currentPosition)
            {
                temp = temp.next;
                currentPosition++;
            }

            if (temp.next != null)
            {
                temp.next = temp.next.next;
            }

            var temp2 = head;

            while (temp2 != null)
            {
                temp2 = temp2.next;
            }

            return head;
        }
    }
}
