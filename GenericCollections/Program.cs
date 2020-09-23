using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {


            static List<int> GetMyList()
            {
                List<int> mylist = new List<int>(5);

                foreach (int integers in new int[] { 5, 6, 7, 8, 9 })
                {
                    mylist.Add(integers);
                }

                return mylist;
            }

            Console.WriteLine("Using a List<T>:");
            foreach (var item in GetMyList())
            {
                Console.WriteLine(item);
            }



            static LinkedList<int> GetMyLinkedList()
            {
                LinkedList<int> numbers = new LinkedList<int>();

                foreach (int number in new int[] { 23, 84, 47, 44, 6 })
                {
                    numbers.AddFirst(number);
                }
                return numbers;
            }

            Console.WriteLine();
            Console.WriteLine("Using a LinkedList:");
            foreach (var item in GetMyLinkedList())
            {
                Console.WriteLine(item);
            }



            static Queue<int> GetMyQue()
            {
                Queue<int> numbers = new Queue<int>();

                foreach (int number in new int[] { 1, 2, 3, 4, 5 })
                {
                    numbers.Enqueue(number);
                }
                return numbers;

            }

            Console.WriteLine();
            Console.WriteLine("Using a Queue:");
            foreach (var item in GetMyQue())
            {
                Console.WriteLine(item);
            }





            static Stack<int> GetMyStack()
            {
                Stack<int> numbers = new Stack<int>();
                foreach (int number in new int[] { 1, 42, 3, 12, 85 })
                {
                    numbers.Push(number);
                }
                return numbers;
            }

            Console.WriteLine();
            Console.WriteLine("Using a Stack:");
            foreach (var item in GetMyStack())
            {
                Console.WriteLine(item);
            }





            static Dictionary<string, string> GetMyDictionary()
            {
                Dictionary<string, string> mssa = new Dictionary<string, string>();

                mssa.Add("Dan", "Teacher");
                mssa.Add("Gus", "Student");
                mssa.Add("Carolyn", "Boss Lady");
                mssa.Add("Tyron", "Cool guy");

                return mssa;
            }

            Console.WriteLine();
            Console.WriteLine("Using a Dictionary:");
            foreach (var item in GetMyDictionary())
            {
                Console.WriteLine(item);
            }




            static SortedList<string, int> GetMySortedCars()
            {
                SortedList<string, int> cars = new SortedList<string, int>();

                cars.Add("Camaro", 1);
                cars.Add("Mustang", 2);
                cars.Add("Charger", 3);
                cars.Add("Pinto", 4);

                return cars;
            }

            Console.WriteLine();
            Console.WriteLine("Using a Sorted List:");
            foreach (var item in GetMySortedCars())
            {
                Console.WriteLine(item);
            }



            static HashSet<int> GetMyHashTable()
            {
                HashSet<int> numbers = new HashSet<int>(new int[] { 45, 28, 81, 14, 52 });

                return numbers;
            }

            Console.WriteLine();
            Console.WriteLine("With HashSet:");
            foreach (var item in GetMyHashTable())
            {
                Console.WriteLine(item);
            }
        }
    }
}

