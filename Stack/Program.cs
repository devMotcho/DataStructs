using System.Text;

namespace DataStructs;

class Program
{

    public class Stack<T>
    {
        private static readonly int MAX = 1000;
        int top = 0;
        public T[] stack = new T[MAX];

        public Stack()
        {
            top = -1;
        }

        public bool Push(T item)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            
            stack[++top] = item;
            return true;
            
        }

        public bool Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return false;
            }
            T item = stack[top--];
            return true;
        }

        public T? Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return default(T);
            }
            else
            {
                T item = stack[top];
                return item;
            }
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder("");
            s.Append("[ ");
            for (int i = 0; i <= top; i++)
            {
                if (i == top)
                    s.Append(stack[i]);
                else
                    s.Append(stack[i] + ", ");
            }
            s.Append(" ]");
            return s.ToString();
        }
    }

    public static void Main(string[] args)
    {
        Stack<int> stack1 = new();
        stack1.Push(10);
        stack1.Push(20);
        stack1.Push(11);
        stack1.Push(15);
        stack1.Pop();

        Console.WriteLine(stack1);
    }
}