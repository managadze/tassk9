using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassk9
{
    public class Node
    {
        public int data;
        public Node next, last;

        public Node()
        {
            data = 0;
            next = null;
            last = null;
        }

        public Node(int d)
        {
            data = d;
            next = null;
            last = null;
        }

        public override string ToString()
        {
            return data.ToString() + " ";
        }  
    }

    public class BiList
    {
        private Node beg;
        private Node tail;

        public int Count
        {
            get; private set; 
        }

        public Node Add(int el)
        {
            if (beg != null)
            {
                Node temp = new Node(el);
                Node t = beg;
                while (t.next != null) t = t.next;
                t.next = temp;
                temp.last = t;
            }
            else beg = new Node(el);
            Count++;
            return beg;
        }

        public Node Create(int N, int i)
        {
            if (i <= N)
            {
                Node head = beg;
                head = Add(i);
                i++;
                head = Create(N, i++);
                return beg;
            }
            else return beg;
        }

        public void Research(int num, int count)
        {
            Node head = beg;
            this.Researcher(num, count, head);
        }

        void Researcher(int num, int count, Node head)
        {
            if (head != null)
            {
                Node temp = head;
                if (temp.data == num)
                {
                    Console.WriteLine($"Элемент {temp.data} найден на {count+1} месте");
                }
                else if (temp.next != null)
                {
                    count++;
                    temp = temp.next;
                    Researcher(num, count, temp);
                }
                else if (temp.next == null)
                {
                    Console.WriteLine("Элемент не найден");
                }
            }
        }

        public void Delete(int n)
        {
            Node head = beg;
            this.Delete(n, head);
            Count--;
        }

        void Delete(int n, Node head)
        {
            if (head != null)
            {
                Node temp = head;
                Node k = head;
                if ((temp.data == n) && (temp.next != null))
                {
                    k = temp.next;
                    k.last = null;
                    Console.WriteLine("Элемент удален");
                }
                else if ((temp.next != null) && (temp.next.next != null) && (temp.next.data == n))
                {
                    temp = temp.next = temp.next.next;
                    Console.WriteLine("Элемент удален");
                }
                else if ((temp.next != null) && (temp.next.next == null) && (temp.next.data == n))
                {
                    temp.next = null;
                    Console.WriteLine("Элемент удален");
                }
                else
                {
                    if (temp.next != null)
                    {
                        temp = temp.next;
                        Delete(n, temp);
                    }
                }
            }
        }

        public void Show()
        {
            if (beg != null)
            {
                Node temp = beg;
                Console.WriteLine(@"Список:");
                while (temp != null)
                {
                    Console.Write(temp + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Список пуст");
        }
    }
}
