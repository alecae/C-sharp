﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class BaseAlgo
    {
        public BaseAlgo() { }
        public void Menu()
        {
            Console.WriteLine("1.Plus grand des deux nombres");
            Console.WriteLine("2.Note examen");
            Console.WriteLine("3.Nombre aleatoire");

            var choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Exo1();
                    break;

                case 2:
                    Exo2();
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
            else{
                Console.WriteLine($"Le nombre le plus grand est {nombre2}\n");
            }
           Menu();
        }


        public void Exo2()
        {
            Console.WriteLine("Entrer votre note d'examen");
            var nombre1 = Convert.ToInt32(Console.ReadLine());

            if (nombre1 >= 60 && nombre1<=100)
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
    }
}