namespace DataStructures.Linked_Lists
{
    class ReverseLL
    {
        public static SinglyLLNode Reverse(SinglyLLNode head)
        {
            var temp = head;
            SinglyLLNode reversed = null;

            while(temp != null)
            {
                SinglyLLNode next = temp.next;
                temp.next = reversed;
                reversed = temp;
                temp = next;
            }

            return reversed;
        }
    }
}
