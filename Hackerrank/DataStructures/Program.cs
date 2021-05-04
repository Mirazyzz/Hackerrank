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
                    {
                        next = new SinglyLinkedListNode(4)
                        {
                            next = new SinglyLinkedListNode(5)
                        }
                    }
                }
            };

            PrintReverse.Print(head);
        }
    }
}
