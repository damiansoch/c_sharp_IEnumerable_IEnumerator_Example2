using System;
using System.Collections.Generic;

namespace IEnumerable_IEnumerator_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //creating a generic IEnumebable variable, that takes any collection 


            IEnumerable<int> unknownCollection;

            unknownCollection = GetCollection(1);
            Console.WriteLine("This was a List<int>");
            foreach (int i in unknownCollection)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");

            unknownCollection = GetCollection(2);
            Console.WriteLine("This was a Queue<int>");
            foreach (int i in unknownCollection)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");


            unknownCollection = GetCollection(3);
            Console.WriteLine("This was a []int");
            foreach (int i in unknownCollection)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");


        }
        static IEnumerable<int> GetCollection(int option)
        {

            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if(option == 1) 
            {
                return numbersList;
            }else if(option == 2){
                return numbersQueue;
            }
            else
            {
                return new int[] {11,12,13,14,15};
            }

            
        }
    }
}
