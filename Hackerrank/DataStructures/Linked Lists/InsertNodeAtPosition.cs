namespace DataStructures.Linked_Lists
{
    class InsertNodeAtPosition
    {
        public static SinglyLLNode InsertNode(SinglyLLNode head, int data, int position)
        {
            if (head == null) return new SinglyLLNode(data);

            int currentPosition = 1;
            var temp = head;

            while (temp != null && currentPosition != position)
            {
                temp = temp.next;
                currentPosition++;
            }

            var newNode = new SinglyLLNode(data);
            newNode.next = temp.next;
            temp.next = newNode;

            return head;
        }
    }
}
