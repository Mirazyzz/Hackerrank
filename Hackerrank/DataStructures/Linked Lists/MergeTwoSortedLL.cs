namespace DataStructures.Linked_Lists
{
    class MergeTwoSortedLL
    {
        public static SinglyLinkedListNode Merge(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            if (head1 == null && head2 == null) return null;
            else if (head1 == null) return head2;
            else if (head2 == null) return head1;

            SinglyLinkedListNode smallerNode;

            if(head1.data < head2.data)
            {
                smallerNode = head1;
                smallerNode.next = Merge(head1.next, head2);
            }
            else
            {
                smallerNode = head2;
                smallerNode.next = Merge(head1, head2.next);
            }

            return smallerNode;
        }
    }
}
