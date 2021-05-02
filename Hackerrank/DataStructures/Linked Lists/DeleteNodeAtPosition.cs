namespace DataStructures.Linked_Lists
{
    class DeleteNodeAtPosition
    {
        public static SinglyLinkedListNode DeleteNode(SinglyLinkedListNode head, int position)
        {
            int currentPosition = 1;
            var temp = head;

            while(temp != null && position != currentPosition)
            {
                temp = temp.next;
                currentPosition++;
            }
            
            if(temp.next != null)
            {
                temp.next = temp.next.next;
            }

            return head;
        }
    }
}
