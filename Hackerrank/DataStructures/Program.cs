using DataStructures.Linked_Lists;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new SinglyLinkedListNode(1)
            {
                next = new SinglyLinkedListNode(2)
                {
                    next = new SinglyLinkedListNode(3)
                    {
                        next = new SinglyLinkedListNode(5)
                        {
                            next = new SinglyLinkedListNode(8)
                        }
                    }
                }
            };

            var res = GetNodeValue.GetNode(node, 3);
            System.Console.WriteLine(res);
        }
    }
}