using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinkedList
    {
        public Node head; // head of list
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public void AddAtBeg(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }

        public void AddAtPos(Node prevNode, int nodeData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Previous node cannot be null");
                return;
            }

            Node newNode = new Node(nodeData);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        public void AddAtEnd(int nodeData)
        {
            Node newNode = new Node(nodeData);

            if (head == null)
            {
                head = new Node(nodeData);
                return;
            }

            newNode.next = null;

            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }

            last.next = newNode;
        }

        public void PrintList()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }
    }
    class LinkedListBasics
    {
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();

            llist.AddAtEnd(6);

            llist.AddAtBeg(7);

            llist.AddAtBeg(1);

            llist.AddAtEnd(4);

            llist.AddAtPos(llist.head.next, 8);

            Console.Write("Created Linked list is: ");
            llist.PrintList();
            Console.ReadLine();
        }
    }
}
