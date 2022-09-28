using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Russia;
using China;
using India;


namespace cs_namespace_countries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moskov moskov = new Moskov();
            Beijing beijing= new Beijing();
            NewDelhi newDelhi= new NewDelhi();

            int[] cyties = new int[] { moskov.Population, beijing.Population, newDelhi.Population};

            Console.WriteLine("Наибольшее население "+ cyties.Max());
            Console.WriteLine("Наименьшее население "+ cyties.Min()); 
        }
    }
}
