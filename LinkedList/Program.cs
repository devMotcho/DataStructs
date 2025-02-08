using System.Text;

namespace DataStructs;

class Program
{
    public class LinkedListNode<T>
    {
        public T Value;
        public LinkedListNode<T>? Next;

        public LinkedListNode(T value, LinkedListNode<T>? next = null)
        {
            Value = value;
            Next = next;
        }
    }

    public class LinkedList<T>
    {
        public int count;
        LinkedListNode<T>? head;
        LinkedListNode<T>? tail;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFront(T value)
        {
            if (head == null) // first item to be added
            {
                AddFirstNode(value);
                return;
            }

            LinkedListNode<T> node = new LinkedListNode<T>(value, head);
            head = node;
            count++;
        }

        public void AddEnd(T value)
        {
            if (tail == null) // first item to be added
            {
                AddFirstNode(value);
                return;
            }

            LinkedListNode<T> node = new LinkedListNode<T>(value);
            tail.Next = node;
            tail = node;
            count++;
        }

        public void PrintLinkedList()
        {
            StringBuilder sb = new StringBuilder("");

            while (head != null)
            {
                LinkedListNode<T> runner = head;

                sb.Append(head.Value.ToString());
                string connector = runner.Next is not null ? "->" : ".";
                sb.Append(connector);
                
                head = runner.Next;
            }
            Console.WriteLine(sb.ToString());
        }

        private void AddFirstNode(T value)
        {
            var first = new LinkedListNode<T>(value);
            tail = first;
            head = first;
            count++;
        }
    }
    static void Main(string[] args)
    {
        LinkedList<string> l = new LinkedList<string>();
        l.AddEnd("Hello");
        l.AddFront("My");
        l.AddFront("Friend");
        l.AddFront("Welcome");
        l.AddEnd("To");
        l.AddEnd("My");
        l.AddFront("Linked List");
        l.AddEnd("Implementation");
        Console.WriteLine(l.count);
        l.PrintLinkedList();


    }
}