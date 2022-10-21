using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Collections
    {
        /// <summary>
        /// ArrayList -> class -> using System.Collections;
        /// It is not type specific
        /// </summary>
        public static void ArrayList_Demo()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2.23);
            arrayList.Add("John");
            arrayList.Add('a');
            Console.WriteLine("ARRAYLIST");
            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            arrayList.Reverse();
            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            arrayList.RemoveAt(0);
            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            arrayList.Clear();
            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

        }
        /// <summary>
        /// List<> Generic class -> using System.Collections.Generic;
        /// Type specific
        /// </summary>
        public static void List_Demo()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.RemoveAt(2);
            Console.WriteLine("LIST GENERIC");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
        }
        /// <summary>
        /// SortedList ->Generic ->key-value pair-> using System.Collections.Generic;
        /// </summary>
        public static void SortedList_Demo()
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(3, "C#");
            list.Add(1, "SQL");
            list.Add(2, "Angular");
            Console.WriteLine("SORTEDLIST GENERIC");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }

        }
        /// <summary>
        /// STACK-LIFO ->generic->using System.Collections.Generic;
        /// push and pop
        /// </summary>
        public static void Stack_Demo()
        {
            Stack<int> vs = new Stack<int>();
            vs.Push(1);//Add
            vs.Push(2);
            vs.Push(3);
            vs.Push(4);
            Console.WriteLine("STACK");
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"Top Element:{vs.Peek()}");
            Console.WriteLine("-----------------------------------------");
            vs.Pop();//Removes the top element
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"Top Element:{vs.Peek()}");
        }
        /// <summary>
        /// QUEUE - FIFO ->generic->using System.Collections.Generic;
        /// enqueue and dequeue 
        /// </summary>
        public static void Queue_Demo()
        {
            Queue<int> vs = new Queue<int>();
            vs.Enqueue(1);
            vs.Enqueue(2);
            vs.Enqueue(3);
            Console.WriteLine("QUEUE");
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"Top Element:{vs.Peek()}");
            Console.WriteLine("-----------------------------------------");
            vs.Dequeue();
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"Top Element:{vs.Peek()}");
        }
        /// <summary>
        /// LinkedList - > Node ->  generic->using System.Collections.Generic;
        /// Singly ->     Node1->Node2->Node3
        /// Doubly ->      <- Node1-> <- Node2 -> <- Node3 ->
        /// Circular ->   Node3 <- Node1-> <- Node2 -> <- Node3 -> Node1
        /// </summary>
        public static void LinkedList_Demo()
        {
            LinkedList<int> vs = new LinkedList<int>();
            vs.AddLast(1);
            vs.AddLast(2);
            vs.AddFirst(0);
            Console.WriteLine("LINKEDLIST");
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
        }
        /// <summary>
        /// Dictionary - generic->using System.Collections.Generic;
        /// key-value pair
        /// </summary>

        public static void Dictionary_Demo()
        {
            Dictionary<int, string> vs = new Dictionary<int, string>();
            vs.Add(1, "C#");
            vs.Add(2, "SQL");
            vs.Add(3, "Angular");
            Console.WriteLine("DICTIONARY");
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var key = new List<int>(vs.Keys);
            foreach (var obj in key)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var values = new List<string>(vs.Values);
            foreach (var obj in values)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Key: {vs[1]}");
            //Console.WriteLine($"Key: {vs[0]}");//If the key is not found -> raise an exception

        }
        /// <summary>
        /// Hashtable -> class -> using System.Collections;
        /// not type specific
        /// key-value pair
        /// </summary>

        public static void Hashtable_Demo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "C#");
            ht.Add(2, 123);
            ht.Add(3, "C#456");
            ht.Add(4, 1234);
            ht.Add(5, "C#123");
            ht.Add(6, 1235);
            Console.WriteLine("HASHTABLE");
            //ICollection Interface
            ICollection key = ht.Keys;
            foreach (var obj in key)
            {
                Console.WriteLine(ht[obj]);
            }
            Console.WriteLine($"Key: {ht[1]}");
            Console.WriteLine($"Key: {ht[3]}");//If the key is not found -> null value
        }

        public static void Main()
        {
            ArrayList_Demo();
            Console.WriteLine("-----------------------------------------");
            List_Demo();
            Console.WriteLine("-----------------------------------------");
            SortedList_Demo();
            Console.WriteLine("-----------------------------------------");
            Stack_Demo();
            Console.WriteLine("-----------------------------------------");
            Queue_Demo();
            Console.WriteLine("-----------------------------------------");
            LinkedList_Demo();
            Console.WriteLine("-----------------------------------------");
            Dictionary_Demo();
            Console.WriteLine("-----------------------------------------");
            Hashtable_Demo();
        }

    }
}
