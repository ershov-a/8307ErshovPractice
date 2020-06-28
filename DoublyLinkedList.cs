using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8307Ershov
{
    public class DLinkedList
    {
        private String data;
        private DLinkedList next;
        private DLinkedList prev;
        static int count;

        public DLinkedList()
        {
            data = "";
            next = null;
            prev = null;
            count = 0;
        }

        public DLinkedList(String value)
        {
            data = value;
            next = null;
            prev = null;
            count++;
        }

        public DLinkedList InsertNext(String value)
        {
            DLinkedList node = new DLinkedList(value);

            if (this.next == null)
            {
                // Easy to handle
                node.prev = this;
                node.next = null; // already set in constructor
                this.next = node;
            }

            else
            {
                // Insert in the middle
                DLinkedList temp = this.next;
                node.prev = this;
                node.next = temp;
                this.next = node;
                temp.prev = node;
                // temp.next does not have to be changed
            }
            return node;
        }
        public DLinkedList InsertPrev(String value)
        {
            DLinkedList node = new DLinkedList(value);
            if (this.prev == null)
            {
                node.prev = null; // already set on constructor
                node.next = this;
                this.prev = node;
            }
            else
            {
                // Insert in the middle
                DLinkedList temp = this.prev;
                node.prev = temp;
                node.next = this;
                this.prev = node;
                temp.next = node;
                // temp.prev does not have to be changed
            }
            count++;
            return node;
        }

        public int GetCount()
        {
            return count;
        }
        public String GetData()
        {
            return data;
        }

        public DLinkedList GetNext()
        {
            return this.next;
        }

        public void TraverseFront()
        {
            TraverseFront(this);
        }

        public void TraverseFront(DLinkedList node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("\n\nTraversing in Forward Direction\n\n");
            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }
        public void TraverseBack()
        {
            TraverseBack(this);
        }

        public void TraverseBack(DLinkedList node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("\n\nTraversing in Backward Direction\n\n");
            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.prev;
            }
        }
    }
}