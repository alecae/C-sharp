using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Classes
{
    public class Etudiant
    {
        // propriétés de la classe
        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }

        // constructeur de la classe
        public Etudiant(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        // méthode qui retourne le nom complet de l'étudiant
        public string NomComplet()
        {
            return prenom + " " + nom;
        }

        // méthode qui retourne true si l'étudiant est majeur, false sinon
        public bool EstMajeur()
        {
            return age >= 18;
        }
    }
}

