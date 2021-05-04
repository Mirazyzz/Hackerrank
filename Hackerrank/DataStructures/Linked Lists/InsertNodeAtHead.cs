namespace DataStructures.Linked_Lists
{
    class InsertNodeAtHead
    {
        public static SinglyLLNode InsertNode(SinglyLLNode node, int data)
        {
            if (node == null) return new SinglyLLNode(data);

            return new SinglyLLNode(data).next = node;
        }
    }
}
