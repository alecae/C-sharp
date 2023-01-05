using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class BaseAlgo
    {
        public BaseAlgo() { }
        public void Menu()
        {
            Console.WriteLine("Base Algo");
            Console.WriteLine("1.Plus grand des deux nombres");
            Console.WriteLine("2.Note examen");
            Console.WriteLine("3.Nombre aleatoire");
            Console.WriteLine("4.Table de multiplication");
            Console.WriteLine("5.Produit de nombre\n");
            Console.WriteLine(@$"{@$"@${"bonjour"}"}");

            Console.WriteLine("Loops Array ");
            Console.WriteLine("6.Creation tableau ");
            Console.WriteLine("7.Affiche 10 nombres \n");


            Console.WriteLine("Enum Constantes");
            Console.WriteLine("8.Jour de la semaines ");
            Console.WriteLine("9.Jour vécu \n");

            Console.WriteLine("Programmes");
            Console.WriteLine("10.Annee jusqu'a 100 ans ");



            var choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {

                case 1:
                    Exo1();
                    break;

                case 2:
                    Exo2();
                    break;

                case 3:
                    Exo3();
                    break;

                case 4:
                    Exo4();
                    break;

                case 5:
                    Exo5();
                    break;

                case 6:
                    Exo6();
                    break;

                case 7:
                    Exo7();
                    break;

                case 8:
                    Exo8();
                    break;

                case 9:
                    Exo9();
                    break;


            }

        }

        public void Exo1()
        {
            Console.WriteLine("Entrer le 1er nombre");
            var nombre1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer le 2eme nombre");
            var nombre2 = Convert.ToInt32(Console.ReadLine());

            if (nombre1 > nombre2)
            {
                Console.WriteLine($"Le nombre le plus grand est {nombre1}\n");
            }
            else
            {
                Console.WriteLine($"Le nombre le plus grand est {nombre2}\n");
            }
            Menu();
        }


        public void Exo2()
        {
            Console.WriteLine("Entrer votre note d'examen");
            var nombre1 = Convert.ToInt32(Console.ReadLine());

            if (nombre1 >= 60 && nombre1 <= 100)
            {
                Console.WriteLine("Pass\n");
            }

            else
            {
                Console.WriteLine("Fail\n");
            }
            Menu();
        }

        public void Exo3()
        {
            Random aleatoire = new Random();
            int Nombrealeatoire = aleatoire.Next(101);

            Console.WriteLine("Entrer un nombre");
            var nombre1 = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (nombre1 != Nombrealeatoire)
                {
                    Console.WriteLine("Incorrect, try again.\n");
                    Console.WriteLine("Entrer un nombre\n");
                    nombre1 = Convert.ToInt32(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine("Correct!\n");
                }
            }
            while (nombre1 != Nombrealeatoire);
            Console.WriteLine("Correct!\n");

            Menu();
        }

        public void Exo4()
        {

            Console.Write("Choisi un nombre: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= 12; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
        }

        public void Exo5()
        {
            Console.WriteLine("Entrer le 1er nombre");
            var nombre1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer le 2eme nombre");
            var nombre2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                int nombre3 = nombre1 * nombre2;
                Console.WriteLine(nombre3);
                if (nombre3 <= 1000)
                {
                    Console.WriteLine("Produit inferieur a 1000!\n");
                    Console.WriteLine("Entrer le 1er nombre\n");
                    nombre1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entrer le 2eme nombre\n");
                    nombre2 = Convert.ToInt32(Console.ReadLine());

                }

            }
            while (nombre1 * nombre2 < 1000);
            Console.WriteLine("Produit superieur a 1000\n");

            Menu();

        }

        public void Exo6()
        {
            int[] Tableau = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            foreach (var i in Tableau)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();
            Menu();
        }

        public void Exo7()
        {
            int[] Tableau = { };

            var nombre = Convert.ToInt32(Console.ReadLine());

            foreach (var i in Tableau)
            {
                Tableau.Append<int>(nombre);
                nombre = Convert.ToInt32(Console.ReadLine());

                if (Tableau.Length == 10)
                {
                    Console.WriteLine(Tableau[i]);
                }

            }
            Console.WriteLine();
            Menu();
        }

        public void Exo8()
        {

            Console.WriteLine("Entrer un nombre entre 1 et 7");
            var nombre1 = Convert.ToInt32(Console.ReadLine());

            switch (nombre1)
            {
                case 1:
                    Console.WriteLine($"{Jour.Lundi}\n");
                    break;

                case 2:
                    Console.WriteLine($"{Jour.Mardi}\n");
                    break;

                case 3:
                    Console.WriteLine($"{Jour.Mercredi}\n");
                    break;

                case 4:
                    Console.WriteLine($"{Jour.Jeudi}\n");
                    break;

                case 5:
                    Console.WriteLine($"{Jour.Vendredi}\n");
                    break;

                case 6:
                    Console.WriteLine($"{Jour.Samedi}\n");
                    break;

                case 7:
                    Console.WriteLine($"{Jour.Dimanche}\n");
                    break;
            }

            Menu();

        }
        enum Jour
        {
            Lundi = 1,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        public void Exo9()
        {
            const int annee = 365;

            Console.WriteLine("Entrer votre age ");
            var nombre1 = Convert.ToInt32(Console.ReadLine());

            int jourvecu = nombre1 * annee;
            Console.WriteLine($"Vous avez vécu {jourvecu} jours\n");

            Menu();
        }
    }
}
