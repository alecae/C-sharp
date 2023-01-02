
using System;

namespace ConsoleApp
{
    enum Mois
    {
        Janvier,
        Fevrier,
        Mars,
        Avril,
        Mai,
        Juin,
        Juillet,
        Aout,
        Septembre,
        Octobre,
        Novembre,
        Decembre,
    }
    internal static class Program
    {
        public static void Main(string[] args )
        {
            Console.WriteLine("Hello, World!");

            Mois Aujourdhui = Mois.Janvier;
            Mois AujourdhuiB = 0; 

            Console.WriteLine(Aujourdhui);
            Console.WriteLine(AujourdhuiB);
        }


    }
}

