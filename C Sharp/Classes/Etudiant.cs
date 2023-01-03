using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Classes
{
    public class Etudiant
    {
        string Nom ;
        string prenom ;
        int age;

        public string Saluer()
        {
            return $"Bonjour, je m'appelle {Nom} {prenom} et j'ai {age}";

        }
    }
}

