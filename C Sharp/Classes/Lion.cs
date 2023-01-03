using C_Sharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Lion : Chat, IAnimal
    {
        public float poids;

        public void Description()
        {
            Console.WriteLine($"Je suis un lion de nom {nom} et de poids {poids}");

        }
    }
}