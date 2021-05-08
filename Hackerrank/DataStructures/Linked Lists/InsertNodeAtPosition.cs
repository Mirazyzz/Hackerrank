namespace DataStructures.Linked_Lists
{
    class InsertNodeAtPosition
    {
        public static SinglyLinkedListNode InsertNode(SinglyLinkedListNode head, int data, int position)
        {
            if (head == null) return new SinglyLinkedListNode(data);

            int currentPosition = 1;
            var temp = head;

            while (temp != null && currentPosition != position)
            {
                temp = temp.next;
                currentPosition++;
            }

            var newNode = new SinglyLinkedListNode(data);
            newNode.next = temp.next;
            temp.next = newNode;

            return head;
        }
    }
}
