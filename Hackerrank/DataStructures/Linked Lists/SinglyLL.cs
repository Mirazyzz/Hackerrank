namespace DataStructures.Linked_Lists
{
    class SinglyLL
    {
        public SinglyLLNode head;
        public SinglyLLNode tail;

        public SinglyLL()
        {
            head = null;
            tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLLNode node = new SinglyLLNode(nodeData);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }

            tail = node;
        }
    }
}
