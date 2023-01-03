using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Classes
{
    public class Formation
    {
        public List<Etudiant?> etudiants { get; set; }


        public Formation()
        {
            etudiants = new List<Etudiant?>();
        }

        public double MoyenneAge()
        {
            var somme = etudiants.Aggregate<Etudiant?, double>(0, (current, etudiant) => current + etudiant.age);

            return somme / etudiants.Count;
        }

        public Etudiant? TrouverEtudiant(string nom)
        {
            return etudiants.FirstOrDefault(etudiant => etudiant?.nom == nom);
        }

        public Etudiant? TrouverEtudiant(string nom, string prenom)
        {
            return etudiants.FirstOrDefault(etudiant => etudiant?.nom == nom && etudiant.prenom == prenom);
        }

    }
}