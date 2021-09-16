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

        public void AddAtPos(int nodeData, int position)
        {
            Node node = new Node(nodeData);
            //node.data = nodeData;
            //node.next = null;

            if (head == null)
            {
                //if head is null and position is zero then exit.
                if (position != 0)
                {
                    return;
                }
                else
                { //node set to the head.
                    this.head = node;
                }
            }

            if (head != null && position == 0)
            {
                node.next = head;
                this.head = node;
                return;
            }

            Node current = head;
            Node previous = null;

            int i = 0;

            while (i < position)
            {
                previous = current;
                current = current.next;

                if (current == null)
                {
                    break;
                }

                i++;
            }

            node.next = current;
            previous.next = node;
            //if (prevNode == null)
            //{
            //    Console.WriteLine("Previous node cannot be null");
            //    return;
            //}

            //Node newNode = new Node(nodeData);
            //newNode.next = prevNode.next;
            //prevNode.next = newNode;
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
        public void DeleteBeg()
        {
            if (head == null)
            {
                return;
            }

            head = head.next;
        }

        public void DeleteEnd()
        {
            if (head == null)
            {
                return;
            }

            if (head.next == null)
            {
                return;
            }

            Node secondLast = head;
            while (secondLast.next.next != null)
            {
                secondLast = secondLast.next;
            }

            secondLast.next = null;
        }

        public void DeleteAtPos(int position)
        {
            int count = 1;
            Node ptr = head;
            Node prev = head;
            if (head == null)
            {
                return;
            }
            if (position == 1)
            {
                head = head.next;
            }
            else 
            {
                while (ptr != null && (count < position))
                {
                    count++;
                    prev = ptr;
                    ptr = ptr.next;
                }
                prev.next = ptr.next;
            }
        }

        public void PrintList()
        {
            Node node = head;
            Console.Write("Linked list is : ");
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }

    class LinkedListInsertDelete
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            Console.WriteLine("1. Insert at beginning");
            Console.WriteLine("2. Insert at end");
            Console.WriteLine("3. Insert at position");
            Console.WriteLine("4. Delete at beginning");
            Console.WriteLine("5. Delete at end");
            Console.WriteLine("6. Delete at position");
            Console.WriteLine("7. Print linked list");

            do
            {
                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                int data, pos;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter data");
                        data = Convert.ToInt32(Console.ReadLine());
                        linkedList.AddAtBeg(data);
                        break;
                    case 2:
                        Console.WriteLine("Enter data");
                        data = Convert.ToInt32(Console.ReadLine());
                        linkedList.AddAtEnd(data);
                        break;
                    case 3:
                        Console.WriteLine("Enter data");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter pos");
                        pos = Convert.ToInt32(Console.ReadLine());
                        linkedList.AddAtPos(data, pos);
                        break;
                    case 4:
                        linkedList.DeleteBeg();
                        break;
                    case 5:
                        linkedList.DeleteEnd();
                        break;
                    case 6:
                        Console.WriteLine("Enter pos");
                        pos = Convert.ToInt32(Console.ReadLine());
                        linkedList.DeleteAtPos(pos);
                        break;
                    case 7:
                        linkedList.PrintList();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                
                
            } while (true);
            
            Console.ReadLine();
        }
    }
}
