using System;

namespace CreateLinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    class LinkedList
    {
        public Node head;
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.PushNodeAtTheEnd(1);
            lList.PushNodeAtTheEnd(2);
            lList.PushNodeAtTheEnd(3);
            lList.PushNodeAtTheEnd(4);
            lList.PushNodeAtTheEnd(5);

            Console.WriteLine("Linked List is:");
            lList.PrintLinkedList(lList.head);

            Console.ReadKey();
        }

        // Attach node at the ned of the Linked List
        public void PushNodeAtTheEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            } 
            else 
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                return;
            }
        }

        // Print Linked List
        public void PrintLinkedList(Node node)
        {
            Node temp = node;
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
