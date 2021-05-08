namespace DataStructures.Linked_Lists
{
    class GetNodeValue
    {
        public static int GetNode(SinglyLinkedListNode node, int position)
        {
            if (node == null) return 0;

            node = ReverseLL(node);
            int currentPosition = 0;

            while(node != null && currentPosition != position)
            {
                node = node.next;
                currentPosition++;
            }

            return node.data;
        }

        private static SinglyLinkedListNode ReverseLL(SinglyLinkedListNode node)
        {
            SinglyLinkedListNode reversed = null;

            while(node != null)
            {
                var next = node.next;
                node.next = reversed;

                reversed = node;
                node = next;
            }

            return reversed;
        }
    }
}
