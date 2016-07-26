using System;

namespace LinkedList { 
    class SingleLinkedList
    {
        private Node head;

        public SingleLinkedList()
        {
            this.head = null;
        }

        public bool insertAtPostion(int position, Node newNode)
        {
            int counter = 0;
            if (head != null)
            {
                Node temp = head;

                while (temp != null)
                {
                    if (counter == position)
                    {
                        newNode.next = temp;
                        temp = newNode;
                        return true;
                    }
                }
            }
            Console.WriteLine("Node Inserted");
            return false;
        }

        internal void CreateList()
        {
            Console.WriteLine("How Many Nodes Do You Wish to Create?");
            int numNodes = Convert.ToInt32(Console.ReadLine());
            Node current = null;

            while (numNodes > 0)
            {
                Console.WriteLine("What value would you like to place in the Node?");
                if (head == null)
                {
                    head = new Node(Convert.ToInt32(Console.ReadLine()));
                    current = head;
                    numNodes--;
                }
                else
                {
                    Node temp = new Node(Convert.ToInt32(Console.ReadLine()));
                    current.next = temp;
                    current = temp;
                    numNodes--;
                }
            }
        }

        internal void displayList()
        {
            int nodeNum = 1;
            Node current = head;
            Console.WriteLine();

            while (current != null)
            {
                Console.WriteLine($"The value for node {nodeNum} is {current.info}");
                nodeNum++;
                current = current.next;
            }
            System.Threading.Thread.Sleep(1500);
        }

        public void addHead(Node node)
        {
            head = node;
        }

        public void addToBeginning(Node node)
        {
            node.next = head;
            head = node;
        }

        public void countNodes()
        {
            int counter = 0;
            if (head != null)
            {
                counter = 1;
                Node current = head.next;
                while (current != null)
                {
                    counter = counter + 1;
                    current = current.next;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"There are {counter} nodes in your List");
            System.Threading.Thread.Sleep(1500);
        }
        public void addToEnd(Node node)
        {
            if (head == null)
            {
                addHead(node);
            }
            else
            {
                var temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
    }
}

