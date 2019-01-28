using System;
using System.Collections.Generic;
using System.Text;

namespace TPFermierDu22eSiecle
{
    class Androide : IHumanoide
    {
        public string Nom { get; }
        static public int nbRemede { get; set; }
        static private int charge = 3;

        public Androide(string nom)
        {
            Nom = nom;
        }

        public void PrendreObjet(Objet obj)
        {
            obj.Possesseur = this;
        }
        public void Recolter()
        {
            Matin.Stock.Abricots++;
            Matin.Stock.Choux++;
            Matin.Stock.Cerises++;
            Matin.Stock.Mais++;
        }

        public void Charger()
        {
            charge = 3;
        }

        public static void Decharger()
        {
            charge--;
        }

        public static int Charge
        {
            get { return charge; }
        }

        public void FabRemede()
        {
            if (charge > 0)
            {
                nbRemede++;
            }
        }
    }
}
