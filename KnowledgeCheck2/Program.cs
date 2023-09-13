using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Cat>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var pet = new Cat();

                Console.WriteLine("Enter the name of your pet");
                pet.Name = Console.ReadLine();
                
                Console.WriteLine("Enter the breed for your pet");
                pet.Breed = Console.ReadLine();
                
                Console.WriteLine("Enter the age in years for your pet");
                pet.Age = int.Parse(Console.ReadLine());

                recordList.Add(pet);
                Console.WriteLine("Pet has been added.");
                Console.WriteLine();

            }

            // Print out the list of records using Console.WriteLine()

            Console.WriteLine("Your pet information");
            foreach (var pet in recordList)
            {
                Console.WriteLine(pet.Name + ", the " + pet.Breed + ", is a good " + pet.Age + " year old cat");
            }


            // Included exit key event to show results before exiting console
            
            ConsoleKey continueKey = ConsoleKey.Q;
            Console.Write($"Press [{continueKey}] to quit...");
            while (Console.ReadKey(true).Key != continueKey)
            {
                // do nothing until specified key is pressed
            }

        }
    }
}
