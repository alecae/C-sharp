using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Classes
{
    public class Voiture
    {
        string marque;
        string modele;
        int nbPortes;
        string couleur;


        public string Description()
        {
            return $"La voiture est une {marque} {modele} avec {nbPortes} portes de couleur {couleur}";
        }

    }
}
