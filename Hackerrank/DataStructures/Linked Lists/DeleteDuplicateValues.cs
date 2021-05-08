namespace DataStructures.Linked_Lists
{
    class DeleteDuplicateValues
    {
        public static SinglyLinkedListNode RemoveDuplicates(SinglyLinkedListNode node)
        {
            var temp = node;

            while(temp?.next != null)
            {
                if (temp.data == temp.next.data) temp.next = temp.next.next;
                temp = temp.next;
            }

            return node;
        }
    }
}
