using System;
using System.Collections.Generic;
using System.Text;

namespace TPFermierDu22eSiecle
{
    class Animal : EtreVivant, IAnimal
    {
        private string _race;

        public string Race
        {
            get
            {
                return _race;
            }
        }

        public Animal(string nom, string race) : base(nom)
        {
            _race = race;
        }

        public void Manger()
        {
            Console.WriteLine("{0} mange",_nom);
        }

        public void Dormir()
        {
            Console.WriteLine("{0} va se coucher", _nom);
        }


    }
}
