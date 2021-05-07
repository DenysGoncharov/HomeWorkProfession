using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace FourSeasons
{
    class Program
    {
        
        
    static void Main(string[] args)
        {
            var year = new MonthCollection<Month>();

            year[0]  = new Month(1, "January", 31);
            year[1]  = new Month(2, "Fabruary", 28);
            year[2]  = new Month(3, "Marth", 31);
            year[3]  = new Month(4, "April", 30);
            year[4]  = new Month(5, "May", 31);
            year[5]  = new Month(6, "June", 30);
            year[6]  = new Month(7, "July", 31);
            year[7]  = new Month(8, "August", 31);
            year[8]  = new Month(9, "September", 30);
            year[9]  = new Month(10, "Octobr", 31);
            year[10] = new Month(11, "November", 30);
            year[11] = new Month(12, "Decembr", 31);

            foreach (Month item in year)
            {
                Console.WriteLine($" {item.ID} {item.Name} {item.Days}");
            }
            Console.WriteLine(new string ('~',20));

            Console.WriteLine("number of id: ");
            int noo = int.Parse(Console.ReadLine());
             
            for (int i = 0; i < 12; i++)
            {
                if (year[i].ID == noo)
                {
                    Console.WriteLine($" {year[i].ID} {year[i].Name} {year[i].Days}");
                    
                }
            }
            Console.WriteLine(new string('~', 20)+"\n");

            Console.WriteLine("number of days: ");
            int nod = int.Parse(Console.ReadLine());
            for (int i = 0; i < 12; i++)
            {
                if (year[i].Days == nod)
                {
                    Console.WriteLine($" {year[i].ID} {year[i].Name} {year[i].Days}");
                    
                }
            }


            Console.ReadKey();
        }
    }
}
