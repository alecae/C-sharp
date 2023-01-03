using C_Sharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Chat : IAnimal
    {
        public string nom;

        public void Description()
        {
            Console.WriteLine($"Je suis un chat de nom {nom}");
        }

        public void Crier()
        {
            Console.WriteLine($"Cri");
        }
    }
}