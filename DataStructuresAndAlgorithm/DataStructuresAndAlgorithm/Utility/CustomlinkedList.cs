using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithm
{
    class LinkedList<T> where T : IComparable
    {
        internal Node<T> head;
        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted into linked list", node.data);
        }
        public string Updated()
        {
            string Text = "";
            Node<T> cur = head;
            if (head != null)
            {
                Text += cur.data;
                cur = cur.next;
                while (cur != null)
                {
                    Text = Text + "," + cur.data;
                    cur = cur.next;

                }
                return Text;
            }
            else
            {
                Console.WriteLine("Empty!!!");
                return default;
            }
        }
        internal void AddInReverseOrder(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        internal Node<T> InsertAtParticularPosition(int position, T data)
        {
            Node<T> newestNode = new Node<T>(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }
        internal Node<T> RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node<T> RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node<T> NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
        internal int Search(string value)
        {
            Node<T> node = this.head;
            int count = 0;
            while (node != null)
            {

                if (node.data.Equals(value))
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node<T> temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node<T> next = temp.next.next;
            temp.next = next;
            Size();
        }
        internal void Size()
        {
            Node<T> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of LinkedList is :-" + " " + count);
        }
        public void Delete(T data)
        {
            Node<T> temp = head;
            Node<T> prev = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else if (temp.data.Equals(data))
            {
                head = temp.next;
                return;
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data.Equals(data))
                    {
                        prev.next = temp.next;
                        Console.WriteLine("Deleted " + temp.data);
                        return;
                    }
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("Empty");
                }
            }
        }
    }

}