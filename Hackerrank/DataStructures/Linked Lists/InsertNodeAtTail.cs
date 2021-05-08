namespace DataStructures.Linked_Lists
{
    class InsertNodeAtTail
    {
        public static SinglyLinkedListNode InsertNodeTail(SinglyLinkedListNode node, int data)
        {
            if (node == null) return new SinglyLinkedListNode(data);

            var temp = node;
            var newNode = new SinglyLinkedListNode(data);

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;

            return node;
        }
    }
}
