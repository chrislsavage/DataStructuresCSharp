using System;

namespace LinkedList { 
    class SingleLinkedList
    {
        private Node head;

        public SingleLinkedList()
        {
            this.head = null;
        }

        public void insertAfterPostion()
        {
            Console.WriteLine("What index position would you like your node after?");
            int position = getNumberInput();
            Node newNode = createNode();
            bool boolean = false;

            int counter = 0;
            if (head != null)
            {
                Node temp = head;

                while (temp != null)
                {
                    if (counter == position)
                    {
                        if (temp.next != null)
                        {
                            newNode.next = temp.next;
                        }
                        temp.next = newNode;
                        boolean = true;
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                        counter++;
                    }
                }
            }
            if (boolean == false)
            { Console.WriteLine("Node is shorter than input number"); }
            else
            {
                Console.WriteLine("Node Inserted");
            }
        }

        public void insertAtPosition()
        {
            Console.WriteLine("What index position would you like your node located?");
            int position = getNumberInput();
            Node newNode = createNode();
            bool boolean = false;

            int counter = 0;
            if (head != null)
            {
                Node temp = head;
                if (position == counter)
                {
                    newNode.next = head;
                    head = newNode;
                    temp = head.next;
                    boolean = true;
                }

                while (temp.next != null)
                {
                    if (counter + 1 == position)
                    {

                        newNode.next = temp.next;
                        temp.next = newNode;
                        boolean = true;
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                        counter++;
                    }
                }
            }
            if (boolean == false)
            {
                Console.WriteLine("Linked list is too short");
            }
            else
            {
                Console.WriteLine("Node Inserted");
            }
        }

        public void deleteAnyNode()
        {
            Console.WriteLine("What index position would you like your node deleted?");
            int position = getNumberInput();
            if (position == 0)
            {
                deleteHead();
            }
            else
            {
                int counter = 0;
                Node temp = head;
                while (temp.next != null || position != counter + 1)
                {
                    temp = temp.next;
                    counter++;
                }
                if (temp.next.next != null)
                {
                    Node temp2 = temp.next.next;
                    temp.next = null;
                    temp.next = temp2;
                }
                else
                {
                    temp.next = null;
                }
            }
            Console.WriteLine("node deleted");
        }

        public void deleteLastNode()
        {
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp = null;
            }
        }

        public void deleteHead()
        {
            if (head.next != null)
            {
                Node temp = head.next;
                head = null;
                head = temp;
            }
            else
            {
                head = null;
            }
        }

        public void insertBeforePostion()
        {
            Console.WriteLine("What index position would you like your node before?");
            int position = getNumberInput();
            Node newNode = createNode();
            bool boolean = false;

            if (position == 0)
            {
                Console.WriteLine("You can't place node before the head of the list.");
            }
            else
            {
                int counter = 0;
                if (head != null)
                {
                    Node temp = head;

                    while (temp.next != null)
                    {
                        if (counter + 1 == position)
                        {

                            newNode.next = temp.next;
                            temp.next = newNode;
                            boolean = true;
                            break;
                        }
                        else
                        {
                            temp = temp.next;
                            counter++;
                        }
                    }
                }
                if (boolean == false)
                {
                    Console.WriteLine("Linked list is too short");
                }
                else
                {
                    Console.WriteLine("Node Inserted");
                }
            }
        }

        public void CreateList()
        {
            Console.WriteLine("How many nodes would you like to have in your linked list?");
            int numNodes = getNumberInput();
            Node current = null;

            while (numNodes > 0)
            {
                Console.WriteLine("What value would you like to place in the Node?");
                if (this.head == null)
                {
                    this.head = new Node(Convert.ToInt32(Console.ReadLine()));
                    current = this.head;
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

        public void displayList()
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

        public void eleSearch()  //need to fix
        {
            Console.WriteLine("What node value do you want to look for?");
            int searchVal = getNumberInput();
            int nodeNumber = 1;
            if (head != null)
            {
                Node temp = new Node(3);
                temp = this.head;
                    
                while (temp != null || temp.info != searchVal)
                {
                    temp = temp.next;
                    nodeNumber++;
                }
                if (temp != null)
                {
                    Console.WriteLine($"The node with the value:{searchVal} is node number {nodeNumber}.");
                }
                else
                {
                    Console.WriteLine("There is not a node with the requested value. Try another?");
                }
            }
        }

        public void addToBeginning()
        {
            Node node = createNode();
            if (head.next != null)
            {
                node.next = head;
            }
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
        public void addToEnd()
        {
            Node node = createNode();
            if (head == null)
            {
                addToBeginning();
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

        public Node createNode()
        {
            Console.WriteLine("What value would you like your node to have?");
            Node node = new Node(Convert.ToInt32(Console.ReadLine()));
            return node;
        }

        public int getNumberInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

