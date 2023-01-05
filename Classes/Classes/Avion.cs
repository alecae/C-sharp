using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Classes
{
    internal class Avion : Oiseau, IVolant
    {
        int nbMoteurs;
        string nom = "";

        public string Description()
        {
            return $"je suis un avion avec {nbMoteurs} de nom {nom}";
        }
    }
}
