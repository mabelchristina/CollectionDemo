using System;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           Collections collections = new Collections();
            Console.WriteLine("ListDemo");
            collections.ListDemo();
            Console.WriteLine("----------");
            Console.WriteLine("Stackdemo");
            collections.Stackdemo();
            Console.WriteLine("----------");
            Console.WriteLine("Queuedemo");
            collections.QueueDemo();
            Console.WriteLine("------------");
            Console.WriteLine("Dictionary Demo");
            collections.DictionaryDemo();

            Console.ReadKey();
        }
    }
}
