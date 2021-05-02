namespace DataStructures.Linked_Lists
{
    class InsertNodeAtTail
    {
        public static SinglyLinkedListNode InsertNodeTail(SinglyLinkedListNode head, int data)
        {
            if (head == null) return new SinglyLinkedListNode(data);

            var temp = head;
            var newNode = new SinglyLinkedListNode(data);

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;

            return head;
        }
    }
}
