using System;
using System.Collections.Generic;
using System.Text;

namespace TPFermierDu22eSiecle
{
    class Plante : EtreVivant, IPlante
    {
        private string _statut = "Pousse";

        public Plante(string nom) : base(nom)
        {
            
        }

        public void Pousser()
        {
            Console.WriteLine("{0} à poussé aujourd'hui!", _nom);
            _statut = "Pousse";
        }
        public void Fleurir()
        {
            Console.WriteLine("{0} est en fleurs!", _nom);
            _statut = "Fleuri";
        }
        public void Produire()
        {
            Console.WriteLine("{0} est prête à la récolte!", _nom);
            _statut = "Pret";
        }

        public string Statut
        {
            get
            {
                return _statut;
            }
        }

    }
}
