namespace DataStructures.Linked_Lists
{
    class CompareTwoLinkedLists
    {
        public static bool Compare(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            while(head1 != null && head2 != null)
            {
                if (head1.data != head2.data) return false;
            }

            if (head1 != null || head2 != null) return false;

            return true;
        }
    }
}
