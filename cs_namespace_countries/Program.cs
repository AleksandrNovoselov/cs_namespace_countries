using China;
using India;
using Russia;
using System;
using System.Linq;

namespace cs_namespace_countries
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Moskov moskov = new Moskov();
            Beijing beijing = new Beijing();
            NewDelhi newDelhi = new NewDelhi();

            int[] cyties = new int[] { moskov.Population, beijing.Population, newDelhi.Population };

            Console.WriteLine("Наибольшее население " + cyties.Max());
            Console.WriteLine("Наименьшее население " + cyties.Min());
        }
    }
}