using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Comparison
{
    public static class CompareService
    {
        public static void CompareArrayListVsLinkedList()
        {
            Console.WriteLine("Manipulating with 10 000 items\n\n");
            //a.	Листы (ArrayList vs LinkedList);
            Console.WriteLine("********Lists (ArrayList vs LinkedList);********");
            ArrayList arrayL = new ArrayList();
            LinkedList<int> linkedL = new LinkedList<int>();
            int k = 10000;


            //1.1) Add elements to the end"
            TimeSpan startArray = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                arrayL.Add(1);
            }
            TimeSpan finishArray = DateTime.Now.TimeOfDay;
            TimeSpan timeArray = finishArray - startArray;

            TimeSpan startList = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                linkedL.AddLast(1);
            }
            TimeSpan finishList = DateTime.Now.TimeOfDay;
            TimeSpan timeList = finishList - startList;

            Console.WriteLine("1.1) Add elements to the end");
            Console.WriteLine("ArrayList, {0} ms", timeArray.Milliseconds);//O(1),  could be O (n) if element count will be reached beyond initial capacity after insertion
            Console.WriteLine("LinkedList, {0} ms", timeList.Milliseconds);//O(1)
            string faster = timeArray < timeList ? "ArrayList" : "LinkedList";
            Console.WriteLine("{0} is faster", faster); //LinkedList is faster

            Console.ReadKey();


            //1.2) Insert elements to the middle"
            startArray = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                arrayL.Insert(k / 2, 500);
            }
            finishArray = DateTime.Now.TimeOfDay;
            timeArray = finishArray - startArray;

            startList = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                LinkedListNode<int> middle = linkedL.getNodeAt(501);
                linkedL.AddBefore(middle, 500);
            }
            finishList = DateTime.Now.TimeOfDay;
            timeList = finishList - startList;
            
            Console.WriteLine("\n1.2) Add elements to the middle");
            Console.WriteLine("ArrayList, {0} ms", timeArray.Milliseconds);//O(n)
            Console.WriteLine("LinkedList, {0} ms", timeList.Milliseconds);//O(n)
            faster = timeArray < timeList ? "ArrayList" : "LinkedList";
            Console.WriteLine("{0} is faster", faster);

            Console.ReadKey();


            //1.3) Insert elements to the start"
            startArray = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                arrayL.Insert(0, 0);
            }
            finishArray = DateTime.Now.TimeOfDay;
            timeArray = finishArray - startArray;

            startList = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                linkedL.AddFirst(0);
            }
            finishList = DateTime.Now.TimeOfDay;
            timeList = finishList - startList;

            Console.WriteLine("\n1.3) Add elements to the start");
            Console.WriteLine("ArrayList, {0} ms", timeArray.Milliseconds);//O(n)
            Console.WriteLine("LinkedList, {0} ms", timeList.Milliseconds);//O(1)
            faster = timeArray < timeList ? "ArrayList" : "LinkedList";
            Console.WriteLine("{0} is faster", faster); //LinkedList is faster

            Console.ReadKey();



            //2) Search element
            startArray = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                var searchedItemA = arrayL[500];
            }
            finishArray = DateTime.Now.TimeOfDay;
            timeArray = finishArray - startArray;

            startList = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                var searchedItemL = linkedL.ElementAt(500);
            }
            finishList = DateTime.Now.TimeOfDay;
            timeList = finishList - startList;

            Console.WriteLine("\n2) Search element");
            Console.WriteLine("ArrayList, {0} ms", timeArray.Milliseconds);//O(1)
            Console.WriteLine("LinkedList, {0} ms", timeList.Milliseconds);//O(n)
            faster = timeArray < timeList ? "ArrayList" : "LinkedList";
            Console.WriteLine("{0} is faster", faster); //ArrayList is faster

            Console.ReadKey();



            //3.1) Delete element at end
            startArray = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                arrayL.RemoveAt(arrayL.Count - 1);
            }
            finishArray = DateTime.Now.TimeOfDay;
            timeArray = finishArray - startArray;

            startList = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                linkedL.RemoveLast();
            }
            finishList = DateTime.Now.TimeOfDay;
            timeList = finishList - startList;

            Console.WriteLine("\n3.1) Delete element at end");
            Console.WriteLine("ArrayList, {0} ms", timeArray.Milliseconds);//O(1)
            Console.WriteLine("LinkedList, {0} ms", timeList.Milliseconds);//O(1)
            faster = timeArray < timeList ? "ArrayList" : "LinkedList";
            Console.WriteLine("{0} is faster", faster);

            Console.ReadKey();


            //3.2) Delete element in the middle
            startArray = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                arrayL.RemoveAt(9999);
            }
            finishArray = DateTime.Now.TimeOfDay;
            timeArray = finishArray - startArray;

            startList = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                LinkedListNode<int> middle = linkedL.getNodeAt(9999);
                linkedL.Remove(middle);
            }
            finishList = DateTime.Now.TimeOfDay;
            timeList = finishList - startList;


            Console.WriteLine("\n3.2) Delete element in the middle");
            Console.WriteLine("ArrayList, {0} ms", timeArray.Milliseconds);//O(n)
            Console.WriteLine("LinkedList, {0} ms", timeList.Milliseconds);//O(n)
            faster = timeArray < timeList ? "ArrayList" : "LinkedList";
            Console.WriteLine("{0} is faster", faster);

            Console.ReadKey();


            //3.3) Delete element at start
            startArray = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                arrayL.RemoveAt(0);
            }
            finishArray = DateTime.Now.TimeOfDay;
            timeArray = finishArray - startArray;

            startList = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                linkedL.RemoveFirst();
            }
            finishList = DateTime.Now.TimeOfDay;
            timeList = finishList - startList;


            Console.WriteLine("\n3.3) Delete element at start");
            Console.WriteLine("ArrayList, {0} ms", timeArray.Milliseconds);//O(n)
            Console.WriteLine("LinkedList, {0} ms", timeList.Milliseconds);//O(1)
            faster = timeArray < timeList ? "ArrayList" : "LinkedList";
            Console.WriteLine("{0} is faster", faster);//LinkedList is faster

            Console.ReadKey();
        }




        public static void CompareStackVsQueue()
        {
            //b.	Списки (Stack vs Queue);
            Console.WriteLine("\n\n********Stack vs Queue********");
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();

            int k = 10000;

            //1) Add elements
            TimeSpan startStack = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                stack.Push(i);//добавляет в начало
            }
            TimeSpan finishStack = DateTime.Now.TimeOfDay;
            TimeSpan timeStack = finishStack - startStack;

          
            TimeSpan startQueue = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                queue.Enqueue(i);//добавляет в конец
            }
            TimeSpan finishQueue = DateTime.Now.TimeOfDay;
            TimeSpan timeQueue = finishQueue - startQueue;

            Console.WriteLine("1) Add elements: Stack - at start, Queue - at end");
            Console.WriteLine("Stack, {0} ms", timeStack.Milliseconds);
            Console.WriteLine("Queue, {0} ms", timeQueue.Milliseconds);
            string faster = timeStack < timeQueue ? "Stack" : "Queue";
            Console.WriteLine("{0} is faster", faster); 

            Console.ReadKey();


            //2) Search elements
             startStack = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                stack.ElementAt(500);
            }
             finishStack = DateTime.Now.TimeOfDay;
             timeStack = finishStack - startStack;
            
             startQueue = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                queue.ElementAt(500);
            }
             finishQueue = DateTime.Now.TimeOfDay;
             timeQueue = finishQueue - startQueue;
            
            Console.WriteLine("\n2) Search elements");
            Console.WriteLine("Stack, {0} ms", timeStack.Milliseconds);
            Console.WriteLine("Queue, {0} ms", timeQueue.Milliseconds);
             faster = timeStack < timeQueue ? "Stack" : "Queue";
            Console.WriteLine("{0} is faster", faster);

            Console.ReadKey();


            //3) Delete elements
            startStack = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                stack.Pop();//удаляет с начала
            }
            finishStack = DateTime.Now.TimeOfDay;
            timeStack = finishStack - startStack;

            startQueue = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                queue.Dequeue();//удаляет с начала
            }
            finishQueue = DateTime.Now.TimeOfDay;
            timeQueue = finishQueue - startQueue;

            Console.WriteLine("\n3) Delete elements");
            Console.WriteLine("Stack, {0} ms", timeStack.Milliseconds);
            Console.WriteLine("Queue, {0} ms", timeQueue.Milliseconds);
            faster = timeStack < timeQueue ? "Stack" : "Queue";
            Console.WriteLine("{0} is faster", faster);

            Console.ReadKey();
        }




        public static void CompareHashTableVsDictionary()
        {
            //c.	словари (HashTable vs Dictionary);
            Console.WriteLine("\n\n********HashTable vs Dictionary********");
            Hashtable hashTable = new Hashtable();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            int k = 10000;

            //1) Add elements
            TimeSpan startHashTable = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                hashTable.Add(i, i.ToString());
            }
            TimeSpan finishHashTable = DateTime.Now.TimeOfDay;
            TimeSpan timeHashTable = finishHashTable - startHashTable;

            TimeSpan startDict = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                dictionary.Add(i, i.ToString());
            }
            TimeSpan finishDict = DateTime.Now.TimeOfDay;
            TimeSpan timeDict = finishDict - startDict;

            Console.WriteLine("1) Add elements");
            Console.WriteLine("HashTable, {0} ms", timeHashTable.Milliseconds);
            Console.WriteLine("Dictionary, {0} ms", timeDict.Milliseconds);
            string faster = timeHashTable < timeDict ? "HashTable" : "Dictionary";
            Console.WriteLine("{0} is faster", faster);

            Console.ReadKey();


            //2) Search elements
             startHashTable = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                var searchedHT=hashTable[500];
            }
             finishHashTable = DateTime.Now.TimeOfDay;
             timeHashTable = finishHashTable - startHashTable;
            
             startDict = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                var searchedD = dictionary[500];
            }
             finishDict = DateTime.Now.TimeOfDay;
             timeDict = finishDict - startDict;
            
            Console.WriteLine("\n2) Search elements");
            Console.WriteLine("HashTable, {0} ms", timeHashTable.Milliseconds);
            Console.WriteLine("Dictionary, {0} ms", timeDict.Milliseconds);
             faster = timeHashTable < timeDict ? "HashTable" : "Dictionary";
            Console.WriteLine("{0} is faster", faster);

            Console.ReadKey();

            //3) Delete elements
            startHashTable = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                hashTable.Remove(i);
            }
            finishHashTable = DateTime.Now.TimeOfDay;
            timeHashTable = finishHashTable - startHashTable;

            startDict = DateTime.Now.TimeOfDay;
            for (int i = 0; i < k; i++)
            {
                //операция .add .insert. remove. get .set с начала середины, и конца списка
                //k - кол-во операций
                dictionary.Remove(i);
            }
            finishDict = DateTime.Now.TimeOfDay;
            timeDict = finishDict - startDict;

            Console.WriteLine("\n3) Delete elements");
            Console.WriteLine("HashTable, {0} ms", timeHashTable.Milliseconds);
            Console.WriteLine("Dictionary, {0} ms", timeDict.Milliseconds);
            faster = timeHashTable < timeDict ? "HashTable" : "Dictionary";
            Console.WriteLine("{0} is faster", faster);

            Console.ReadKey();
        }
        }
        public static class ExtensionMethod
    {
        public static LinkedListNode<T> getNodeAt<T>(this LinkedList<T> _list, int position)
        {
            LinkedListNode<T> mark = _list.First;
            int i = 0;
            while (i < position)
            {
                mark = mark.Next;
                i++;
            }
            return mark;
        }
    }
}
