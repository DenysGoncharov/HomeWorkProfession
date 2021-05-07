using System;

namespace ConsoleApp1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());
            Random rdm = new Random();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rdm.Next(0, 20);
            }
            foreach (var item in array)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*',20)+"\n");
            var collection = MyCollection.SomeMethod(array);
            foreach (var item in collection)
            {
                Console.Write(item.ToString()+" ");
            }
        }
    }
}
