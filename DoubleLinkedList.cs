using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._7c
{
    public class DoubleLinkedList
    {
        private Node root = null;
        private Node current = null;
        private int length;

        public Node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(Node node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
                root.Prev = null;
            }
            else
            {
                current.Next = node;
                node.Prev = current;
                current = node;
                length++;
            }
        }

        public Node getCurrent()
        {
            return this.current;
        }

        public Node getRoot()
        {
            current = root;
            return this.root;
        }

        public Node getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }

        public Node getPrev()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                return current;
            }
            else
                return null;
        }

        public int getLengthOfList()
        {
            return this.length;
        }
    }
}
        
