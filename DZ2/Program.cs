using System.Collections;
using System.Diagnostics;

namespace DZ2
{
    internal class Program
    {
        private static void PrintList<T>(List<T> list, string Name = "")
        {
            if (Name != string.Empty)
            {
                Console.Write($"{Name}=");
            }
            Console.Write("[");
            for (var i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}, ");
            }
            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            var list = new List<int>();
            var WatchList = new Stopwatch();
            WatchList.Start();
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(i);
            }
            WatchList.Stop();
            Console.WriteLine("List time = " + WatchList.ElapsedMilliseconds);


            var arrayList = new ArrayList();
            var WatchArrayList = new Stopwatch();
            WatchArrayList.Start();
            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add(i);
            }
            WatchArrayList.Stop();
            Console.WriteLine("ArrayList time = " + WatchArrayList.ElapsedMilliseconds);


            var linkedList = new LinkedList<int>();
            var WatchLinkedList = new Stopwatch();
            WatchLinkedList.Start();
            for (int i = 0; i < 1000000; i++)
            {
                linkedList.AddLast(i);
            }
            WatchLinkedList.Stop();
            Console.WriteLine("LinkedList time = " + WatchLinkedList.ElapsedMilliseconds);

            var WatchList1 = new Stopwatch();
            WatchList1.Start();
            var a=list[496753];
            WatchList1.Stop();
            Console.WriteLine("Find 496753 element of List time = " + WatchList1.ElapsedMilliseconds);

            var WatchArrayList1 = new Stopwatch();
            WatchArrayList1.Start();
            var b =arrayList[496753];
            WatchArrayList1.Stop();
            Console.WriteLine("Find 496753 element of ArrayList time = " + WatchArrayList1.ElapsedMilliseconds);

            var WatchLinkedList1 = new Stopwatch();
            WatchLinkedList1.Start();
            var c = linkedList.ElementAt(496753);
            WatchLinkedList1.Stop();
            Console.WriteLine("Find 496753 element of LinkedList time = " + WatchLinkedList1.ElapsedMilliseconds);

            var WatchList2 = new Stopwatch();
            WatchList2.Start();
            PrintList(list.FindAll(x => x % 777 == 0));
            WatchList2.Stop();
            Console.WriteLine("Find elements in List time = " + WatchList2.ElapsedMilliseconds);

            var WatchArrayList2 = new Stopwatch();
            WatchArrayList2.Start();
            Console.Write("[");
            for (var i = 0; i < arrayList.Count; i++)
            {
                if((int)arrayList[i] % 777 == 0) Console.Write($"{list[i]}, ");
            }
            Console.WriteLine("]");
            WatchArrayList2.Stop();
            Console.WriteLine("Find elements in ArrayList time = " + WatchArrayList2.ElapsedMilliseconds);

            var WatchLinkedList2 = new Stopwatch();
            WatchLinkedList2.Start();
            PrintList(linkedList.Where(x => x % 777 == 0).ToList());
            WatchLinkedList2.Stop();
            Console.WriteLine("Find elements in LinkedList time = " + WatchLinkedList2.ElapsedMilliseconds);

        }
    }
}