using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Classes
{
    public class Etudiant
    {

        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }


        public Etudiant(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }


        public string NomComplet()
        {
            return prenom + " " + nom;
        }

        public bool EstMajeur()
        {
            return age >= 18;
        }
    }
}

