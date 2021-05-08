namespace DataStructures.Linked_Lists
{
    class ReverseLL
    {
        public static SinglyLinkedListNode Reverse(SinglyLinkedListNode head)
        {
            var temp = head;
            SinglyLinkedListNode reversed = null;

            while(temp != null)
            {
                SinglyLinkedListNode next = temp.next;
                temp.next = reversed;
                reversed = temp;
                temp = next;
            }

            return reversed;
        }
    }
}
