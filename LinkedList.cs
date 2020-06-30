using System;

namespace _8307Ershov
{
    public class LinkedList
    {
        
        private String data;
        private LinkedList next;
        private int ID;
        public static LinkedList head = null;
        public static LinkedList tail = null;
        public static int count = 0;
        static int maxID=0;

        public LinkedList()
        {
            data = "";
            next = null;
            //count = 0;
            //maxID = 0;
            if (count == 0)
            {
                head = this;
                tail = this;
            }
        }

        public LinkedList(String value)
        {
            ID = maxID + 1;
            data = value;
            next = null;
            if (count == 0)
            {
                head = this;
                tail = this;
            }
            count++;
            maxID++;
        }
        public LinkedList GetByID(LinkedList head, int ID)
        {
            LinkedList temp = head;
            if (temp == null)
                temp = this;
            System.Console.WriteLine("\n\nTraversing in Forward Direction\n\n");
            while (temp != null)
            {
                if (Int16.Parse(temp.GetData().Split(',')[0]) == ID)
                {
                    return temp;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return null;
        }

        public void DeleteByID(int ID)
        {
            LinkedList prev = new LinkedList();
            LinkedList temp = new LinkedList();

            if (head.ID == ID)
            {
                head = head.next;
                count -= 1;
            }
            else
            {
                temp = head;
                while (temp != null && temp.ID != ID)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp != null)
                {
                    prev.next = temp.next;
                    count -= 1;
                    if (temp.next == null)
                    {
                        tail = prev;
                    }
                }
            }
        }

        public LinkedList InsertNext(String value)
        {
            LinkedList node = new LinkedList(value);

            if (this.next == null)
            {
                node.next = null; // already set in constructor
                this.next = node;
                tail = node;
            }

            else
            {
                // Insert in the middle
                LinkedList temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }

        public LinkedList GetByID(int ID)
        {
            LinkedList temp = head;
            while (temp != null)
            {
                if (temp.GetID() == ID)
                {
                    return temp;
                }
                else
                {
                    temp = temp.GetNext();
                }
            }
            return null;
        }

        public int GetCount()
        {
            return count;
        }
        public int GetmaxID()
        {
            return maxID;
        }
        public int GetID()
        {
            return ID;
        }
        public String GetData()
        {
            return this.data;
        }

        public LinkedList GetNext()
        {
            return this.next;
        }

        public LinkedList GetTail()
        {
            return tail;
        }

        public LinkedList GetHead()
        {
            return head;
        }

        public void SetHead(LinkedList newHead)
        {
            head = newHead;
        }

        public void SetNext(LinkedList nextNode)
        {
            this.next = nextNode;
        }

        public void SetData(string newData)
        {
            this.data = newData;
        }

        public void DecrementCount()
        {
            count -= 1;
        }

        public void TraverseFront(LinkedList node)
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
    }
}