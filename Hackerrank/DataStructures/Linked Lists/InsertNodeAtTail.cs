namespace DataStructures.Linked_Lists
{
    class InsertNodeAtTail
    {
        public static SinglyLLNode InsertNodeTail(SinglyLLNode node, int data)
        {
            if (node == null) return new SinglyLLNode(data);

            var temp = node;
            var newNode = new SinglyLLNode(data);

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;

            return node;
        }
    }
}
