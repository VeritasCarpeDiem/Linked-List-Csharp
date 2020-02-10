using System;
using System.Collections;
using System.Collections.Generic;//lets me use generic variables

namespace Linked_List_C_Sharp
{
    class Node
    {
        public string item;
        public Node next;

        public Node()
        {

        }
        public Node(string item)
        {
            this.item = item;
        }


    }
   public class LinkedList:IEnumerable<string>
    {
        private Node head;
        private Node tail;
        public int count; //item iterator
        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        #region => operator
        //public int Count =>count
        #endregion
        public int Count
        {
            get;
            private set;
        }
        

        public void displayList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.item);

                temp = temp.next;
            }
        }
        public void addLast(string item)
        {

            Node temp = new Node(item);
            if (head == null)
            {
                head = temp;
                tail = temp;
            }
            else
            {
                tail.next = temp;
                tail = temp;
            }
            count++;
        }
        public bool removeItem(string item)
        {
            Console.Write("Enter name of item to delete: ");
            item = Console.ReadLine();


            Node current = head.next;
            Node previous = head;

            if (head.item == item)//if item you want to delete is the 1st item
            {
                removeFirst();
                return true;
            }

            while (current != null) //loop through list
            {
                if (current.item.Equals(item))
                {
                    previous.next = current.next;
                    count--;
                    return true;
                }
                previous = current;
                current = current.next;
            }


            // current is the  node before
            // get the node after next
            // connect current to the node after next

            return false;

        }

        public bool removeLast()
        {
            Node current = new Node();

            if (head == tail)//if there us only 1 item in list
            {
                head = null;
                tail = null;
                count = 0;
                return true;
            }
            current = head;

            while (current != null)
            {
                if (current.next == tail)
                {
                    tail = current;
                    current.next = null;
                    count--;
                    return true;
                }
                current = current.next;
            }
            return false;
        }
        public void removeFirst()
        {
            if (isEmpty())
            {
                Node temp = head;
                head = temp.next;
                count--;
            }

        }
        public bool isEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            var current = head;
            while(current != null)
            {
                yield return current.item;
                current = current.next;
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string tempItem = "";
            char reply = 'n';

            Node myNode = new Node(tempItem);
            var myList = new LinkedList();


            myList.addLast("apple");
            myList.addLast("orange");
            myList.addLast("banana");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myList.count);
            myList.displayList();

            Console.WriteLine(myList.removeLast());
            myList.displayList();
            Console.WriteLine(myList.count);

            #region static vs non static functions
            //for static functions
            //NameofClass.functionName

            //for non static functions
            //NameofClassObject.functionName
            #endregion
            #region main
            //do
            //{
            //    myList.addItem(tempItem);
            //    if (myList.count > 1)
            //    {
            //        Console.WriteLine("Delete item?(Y/N)");
            //        reply = char.Parse(Console.ReadLine());
            //    }
            //    if (reply == 'y' || reply == 'Y')
            //    {
            //        myList.removeItem(tempItem);
            //    }
            //    myList.displayList();

            //    Console.WriteLine("Add another item?(Y/N)");

            //    reply = char.Parse(Console.ReadLine());

            //} while (reply == 'y' || reply == 'Y');

            #endregion
        }
    }

}
