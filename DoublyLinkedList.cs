using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class DoublyLinkedList<T>
    {
        private class Node<T>
        {
            public T Value;
            public Node<T> Prev;
            public Node<T> Next;

            public Node(T value)
            {
                Value = value;
            }
        }


        private Node<T> head;
        private Node<T> tail;
        private int size;


        public int Size
        {
            get { return size; }
        }

        public T GetFirst
        {
            get
            {
                if (head == null)
                {
                    throw new Exception();
                }
                return head.Value;
            }
        }

        public T GetLast
        {
            get
            {
                if (tail == null)
                {
                    throw new Exception();
                }
                return tail.Value;
            }
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
            size++;
        }

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Prev = tail;
                tail.Next = newNode;
                tail = newNode;
            }
            size++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> node = head;
            while (node != null)
            {
                sb.Append(node.Value);
                if (node.Next != null)
                {
                    sb.Append(" ");
                }
                node = node.Next;
            }
            return sb.ToString();
        }
    }

}



