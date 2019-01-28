using System;
using System.Collections.Generic;
using System.Text;

namespace TPFermierDu22eSiecle
{
    abstract class EtreVivant
    {
        protected string _nom;
        protected bool _estVivant = true;

        public EtreVivant(string nom)
        {
            _nom = nom;
        }

        virtual public void Mourir()
        {
            Console.WriteLine("{0} est mort", _nom);
            _estVivant = false;
        }

        public string Nom
        {
            get { return _nom; }
        }
    }
}
