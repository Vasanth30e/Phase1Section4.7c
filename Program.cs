using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._7c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }

        public static void runApp()
        {
            DoubleLinkedList list = new DoubleLinkedList();
            Node n = new Node();
            n.Data = "root";
            list.add(n);
            for (int i = 0; i < 10; i++)
            {
                Node node = new Node();
                node.Data = Convert.ToString(i);
                list.add(node);
            }

            Console.WriteLine("length of singly linked list=" + list.getLengthOfList());
            Console.WriteLine("Traversing forward..");
            n = list.getRoot();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getNext();
            }


            Console.WriteLine("Traversing backwards..");
            n = list.getPrev();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getPrev();
            }

        }

    }
}
