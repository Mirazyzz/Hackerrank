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
                    next = new SinglyLinkedListNode(2)
                    {
                        next = new SinglyLinkedListNode(3)
                        {
                            next = new SinglyLinkedListNode(8)
                        }
                    }
                }
            };

            var res = DeleteDuplicateValues.RemoveDuplicates(node);

            while(res != null)
            {
                System.Console.WriteLine(res.data);
                res = res.next;
            }
        }
    }
}