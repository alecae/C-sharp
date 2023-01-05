
//using System;



//namespace C_Sharp
//{
//    internal class Class1
//    {
//        public static void Main(string[] args)
//        {
//            int[,] Tableau = new int[1, 2];
//            int[,,] Tableau2 = new int[5, 2, 3];

//            foreach (var i in Tableau)
//            {
//                Console.WriteLine(i);
//            }
//            //on affiche le premier tableau qui fait apparaitre un zero pour chaque valeur disponible 

//            foreach (var i in Tableau2)
//            {
//                Console.WriteLine(i);
//            }
//            //on affiche le deuxieme tableau qui fait exactement comme la premier mais avec plus de valeur  


//            int[][] Tableau3 = new int[3][];
//            Tableau3[0] =  new int[] {45,2};
//            Tableau3[1] = new int[] { 34, 34, 4, 67 };

//            foreach (var i in Tableau3[0])
//            {
//                Console.WriteLine(i);
//            }
//            //on affiche le premier tableau avec ces differentes valeurs (45 et 2)

//            foreach (var i in Tableau3[1])
//            {
//                Console.WriteLine(i);
//            }
//            //on affiche le deuxieme tableau avec ces differentes valeurs 

//        }
//    }
//}

using C_Sharp.Classes;
using TP2;

namespace C_Sharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var lion = new Lion();
            lion.nom = "Mufasa";
            lion.poids = 325.0f;
            lion.Description();

            var chat = new Chat();
            chat.nom = "Miaouss";
            chat.Description();
        }

    }
}
