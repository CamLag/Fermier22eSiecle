using System;
using System.Collections.Generic;
using System.Text;

namespace TPFermierDu22eSiecle
{
    class Humain : EtreVivant, IHumanoide, IAnimal
    {
        private static int compteur = 0;

        public Humain(string nom) : base(nom)
        {
            compteur++;
        }

        ~Humain()
        {
            compteur--;
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

        virtual public void Manger()
        {
            Console.WriteLine("{0} mange un morceau", _nom);
        }

        virtual public void Dormir()
        {
            Console.WriteLine("{0} va se coucher", _nom);
        }

        public static int Compteur
        {
            get { return compteur; }
        }
    }
}
