using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Sec003_Ex_01
{
    public class ListNode
    {
        // automatic read-only property Data
        public double Data { get; private set; }

        // automatic property Next
        public ListNode Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(double dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(double dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
    public class LinkedList
    {

        public ListNode firstNode;
        public ListNode lastNode;
        private string name; // string like "list" to display

        // construct empty List with specified name
        public LinkedList(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        // construct empty List with "list" as its name 
        public LinkedList() : this("list") { }
        public bool IsEmpty() => firstNode == null;
        public void InsertAtBack(double insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertItem);
            }
        }
        public double RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            double removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem; // return removed data
        }
        public double MaxNumber()
        {
            double max = 0;
            ListNode current = firstNode;
            while (current != null)
            {
                if (current.Data > max)
                    max = current.Data;
                current = current.Next;
            }
            return max;
        }
        public string Display()
        {
            string result = "";
            if (IsEmpty())
            {
                result = $"Empty {name}";
                return result;
            }
            else
            {
                ListNode current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    result += $"{current.Data} ";
                    current = current.Next;
                }
                return result;

            }
        }
    }
}
