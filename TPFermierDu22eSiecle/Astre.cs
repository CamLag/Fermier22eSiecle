using System;
using System.Collections.Generic;
using System.Text;

namespace TPFermierDu22eSiecle
{
    class Astre
    {
        private string _nom { get; }
        private bool estLeve = false;

        public Astre(string nom)
        {
            _nom = nom;
        }

        public void SeLever()
        {
            Console.WriteLine("{0} se lève", _nom);
            estLeve = true;
        }

        public void SeCoucher()
        {
            Console.WriteLine("{0} se couche", _nom);
            estLeve = false;
        }

        public bool EstLeve
        {
            get
            {
                return estLeve;
            }
        }
    }
}
