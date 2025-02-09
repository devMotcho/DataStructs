using System.Security;
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
        public LinkedListNode<T>? head;
        public LinkedListNode<T>? tail;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFront(T value)
        {
            if (head == null)
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
            if (tail == null)
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
            LinkedListNode<T>? current = head;

            while (current is not null)
            {
                sb.Append(current.Value.ToString());
                string connector = current.Next is not null ? "->" : ".";
                sb.Append(connector);

                current = current.Next;
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


    public static LinkedList<int> AddTwoLinkedLists(LinkedList<int> l1, LinkedList<int> l2)
    {

        var result = new LinkedList<int>();
        var reminder = 0;
        var currentl1 = l1.head;
        var currentl2 = l2.head;

        while (currentl1 != null || currentl2 != null)
        {
            int val1 = currentl1?.Value ?? 0;
            int val2 = currentl2?.Value ?? 0;

            var sum = val1 + val2 + reminder;

            result.AddEnd(sum % 10);
            reminder = sum / 10;

            if (currentl1 != null) currentl1 = currentl1.Next;
            if (currentl2 != null) currentl2 = currentl2.Next;
        }

        // If there is a remaining carry, add it as a new node
        if (reminder > 0)
        {
            result.AddEnd(reminder);
        }

        return result;

    }
    static void Main(string[] args)
    {
        LinkedList<int> l = new LinkedList<int>();
        l.AddFront(5);
        l.AddFront(6);
        l.AddFront(6);
        l.AddFront(6);
        l.PrintLinkedList();

        LinkedList<int> l1 = new LinkedList<int>();
        l1.AddFront(2);
        l1.AddFront(5);
        l1.AddFront(3);
        l1.PrintLinkedList();

        LinkedList<int> result = AddTwoLinkedLists(l, l1);
        result.PrintLinkedList();


    }
}