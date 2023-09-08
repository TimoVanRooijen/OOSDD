using AnimalFarm.Models;
using System;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new ("Bert", 4, -1);
            Console.WriteLine($"Succelfull new lion created! Name: {lion.Name}");
        
        }
    }   
}
