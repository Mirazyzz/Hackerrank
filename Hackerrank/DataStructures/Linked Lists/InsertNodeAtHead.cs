namespace DataStructures.Linked_Lists
{
    class InsertNodeAtHead
    {
        public static SinglyLinkedListNode InsertNode(SinglyLinkedListNode node, int data)
        {
            if (node == null) return new SinglyLinkedListNode(data);

            return new SinglyLinkedListNode(data).next = node;
        }
    }
}
