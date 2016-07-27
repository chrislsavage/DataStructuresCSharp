using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice;

            SingleLinkedList list = new SingleLinkedList();
            list.CreateList();


            while (true)
            {
                Console.WriteLine("Enter Number of Nodes:");
                Console.WriteLine("Enter Element to Be inserted:");
                Console.WriteLine("1) Display List");
                Console.WriteLine("2) Count The Number of Nodes");
                Console.WriteLine("3) Search for an element by it's value");
                Console.WriteLine("4) Insert in Empty List/ Insert at beginning of list");
                Console.WriteLine("5) Insert Node at End of List");
                Console.WriteLine("6) Insert a Node after specified Node position");
                Console.WriteLine("7) Insert a node before a specified Node position");
                Console.WriteLine("8) Insert a node at a given posiion");
                Console.WriteLine("9) Delete First Node");
                Console.WriteLine("10) Delete Last Node");
                Console.WriteLine("11) Delete Any Node");
                Console.WriteLine("12) Reverse the List");
                Console.WriteLine("13) Bubble Sort by exchanging data");
                Console.WriteLine("14) Bubble Sort by exchanging links");
                Console.WriteLine("15) Merge Sort");
                Console.WriteLine("16) Insert Cycle");
                Console.WriteLine("17) Detect Cycle");
                Console.WriteLine("18) Remove Cycle");
                Console.WriteLine("19) Quit");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;

                switch(choice)
                {
                    case 1:
                        list.displayList();
                        break;
                    case 2:
                        list.countNodes();
                        break;
                    case 3:
                        list.eleSearch();
                        break;
                    case 4:
                        list.addToBeginning();
                        break;
                    case 5:
                        list.addToEnd();
                        break;
                    case 6:
                        list.insertAfterPostion();
                        break;
                    case 7:
                        list.insertBeforePostion();
                        break;
                    case 8:
                        list.insertAtPosition();
                        break;
                    case 9:
                        list.deleteHead();
                        break;
                    case 10:
                        list.deleteLastNode();
                        break;
                    case 11:
                        list.deleteAnyNode();
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting Program");
            System.Threading.Thread.Sleep(1000);
        }
    }
}