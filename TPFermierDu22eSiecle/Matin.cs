using System;
using System.Collections.Generic;
using System.Text;

namespace TPFermierDu22eSiecle
{
    static class Matin
    {

        public static int nbJours = 1;

        public struct Stock
        {
            public static int Choux { get; set; }
            public static int Abricots { get; set; }
            public static int Cerises { get; set; }
            public static int Mais { get; set; }
        }

        private enum Jours {Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche}
        private static int jSem;


        public static void InfosDuMatin()
        {
            Matin.nbJours++;

            jSem++;
            if (jSem > 7) jSem = 0;

            Androide.Decharger();

            Console.WriteLine("═════════════════════════════════════════════════════════════════════");

            Console.WriteLine("Bzzt! Voici les infos du matin:");

            Console.WriteLine("Nous sommes {0} aujourd'hui, {1} après le début de votre aventure!", Enum.GetName(typeof(Jours), jSem), nbJours);

            Console.WriteLine("Voici les infos du stocks:");
            Console.Write("\tChoux    :" + Stock.Choux + "\n" +
                          "\tAbricots :" + Stock.Abricots + "\n" +
                          "\tCerises  :" + Stock.Cerises + "\n" +
                          "\tMais     :" + Stock.Mais + "\n" +
                          "\tRemèdes  :" + Androide.nbRemede + "\n");

            Console.Write("\t┌───┐  \n" +
                          "\t│■ ■│POWER : " + Androide.Charge +"\n"+
                          "\t└═══┘  \n");

            Console.WriteLine("═════════════════════════════════════════════════════════════════════");
        }

    }
}
