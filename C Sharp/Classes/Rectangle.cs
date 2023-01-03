using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Classes
{
    internal class Rectangle
    {
        float largeur;
        float hauteur;


        public float Aire() 
        {
            return largeur *= hauteur;

        }
        public float Perimetre()
        {
            return ((largeur += hauteur) / 2);
        }


    }
}
