using System;

namespace SocialProtectionDepartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensioner petrovich = new Pensioner("Ivan", "Petrovich");
            Pensioner vasiilich = new Pensioner("stepan", "Vasilich");
            Pensioner sergeich = new Pensioner("ernest", "sergeich");



            Student vasya = new Student("Vasya","Ivanov");
            Student fedya = new Student("Teodor", "Red`ko");
            Student sanya = new Student("Sanya", "Pupkov");

            Worker klim = new Worker("Klim", "Voroshilov");
            Worker eldar = new Worker("Eldar", "petrolov");
            Worker petr = new Worker("Klim", "Gorunov");

            MyCollection sbor = new MyCollection();


            //sbor.Add(klim);
            //sbor.Add(vasya);
            sbor.Add(petrovich);
           // sbor.Add(fedya);
           // sbor.Add(eldar);
            sbor.Add(vasiilich);
            //sbor.Add(petr);
            //sbor.Add(sanya);
            sbor.Add(sergeich);



            Console.WriteLine(sbor);


            Console.ReadKey();

        }
    }
}
