using DataStructures.Linked_Lists;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new SinglyLinkedListNode(1)
            {
                next = new SinglyLinkedListNode(2)
                {
                    next = new SinglyLinkedListNode(3)
                }
            };

            var head2 = new SinglyLinkedListNode(1)
            {
                next = new SinglyLinkedListNode(3)
                {
                    next = new SinglyLinkedListNode(4)
                }
            };

            var node = MergeTwoSortedLL.Merge(head, head2);

            while(node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }
}
