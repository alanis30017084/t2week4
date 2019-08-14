using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cows
            Cows c1 = new Cows();
            c1.Name = "Bessie";
            c1.Id = 1234;
            c1.Age = 10;
            c1.MyBreed = Cows.Breeds[0];

            c1.vetChecks.Add(new Checkup("15/08/2019", "Anne", "Animal is ill..."));
            c1.vetChecks.Add(new Checkup("18/08/2019", "Janice", "Animal is healthy..."));

            Console.WriteLine($"Name: {c1.Name}\nAge: {c1.Age}\nBreed: {c1.MyBreed}");
            Console.WriteLine("Vet check details...");
            foreach(Checkup x in c1.vetChecks)
                Console.WriteLine($"Date: {x.Date}\nVet: {x.Vet}\nNotes: {x.Notes}");

            // Pigs
            Pigs p1 = new Pigs();
            p1.Name = "Charlotte";
            p1.Id = 9999;
            p1.Age = 6;
            p1.MyBreed = Pigs.Breeds[1];

            p1.vetChecks.Add(new Checkup("15/08/2019", "Anne", "Animal is ill..."));
            p1.vetChecks.Add(new Checkup("18/08/2019", "Janice", "Animal is healthy..."));

            Console.WriteLine($"Name: {p1.Name}\nAge: {p1.Age}\nBreed: {p1.MyBreed}");
            Console.WriteLine("Vet check details...");
            foreach (Checkup x in p1.vetChecks)
                Console.WriteLine($"Date: {x.Date}\nVet: {x.Vet}\nNotes: {x.Notes}");

            // Sheep
            Sheep s1 = new Sheep();
            s1.Name = "Shawn";
            s1.Id = 4747;
            s1.Age = 7;
            s1.MyBreed = Sheep.Breeds[1];

            s1.vetChecks.Add(new Checkup("15/08/2019", "Anne", "Animal is ill..."));
            s1.vetChecks.Add(new Checkup("18/08/2019", "Janice", "Animal is healthy..."));

            Console.WriteLine($"Name: {s1.Name}\nAge: {s1.Age}\nBreed: {s1.MyBreed}");
            Console.WriteLine("Vet check details...");
            foreach (Checkup x in s1.vetChecks)
                Console.WriteLine($"Date: {x.Date}\nVet: {x.Vet}\nNotes: {x.Notes}");
            Console.ReadLine();

        }
    }
    
}
