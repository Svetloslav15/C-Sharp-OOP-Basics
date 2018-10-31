using CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();
            List<int> first = new List<int>();
            List<int> second = new List<int>();
            List<int> third = new List<int>();
            string[] items = Console.ReadLine().Split();
            foreach (var item in items)
            {
                first.Add(addCollection.Add(item));
                second.Add(addRemoveCollection.Add(item));
                third.Add(myList.Add(item));
            }
            int amountOfRemoveOperations = int.Parse(Console.ReadLine());
            List<string> addRemoveColRemovedEls = new List<string>();
            List<string> myListRemovedEls = new List<string>();
            for (int i = 0; i < amountOfRemoveOperations; i++)
            {
                addRemoveColRemovedEls.Add(addRemoveCollection.Remove());
                myListRemovedEls.Add(myList.Remove());
            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
            Console.WriteLine(string.Join(" ", third));
            Console.WriteLine(string.Join(" ", addRemoveColRemovedEls));
            Console.WriteLine(string.Join(" ", myListRemovedEls));
        }
    }
}
