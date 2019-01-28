using System;
using System.Collections.Generic;
using System.Text;

namespace TPFermierDu22eSiecle
{
    class Objet
    {
        private string _nom { get; }
        private IHumanoide _possesseur;

        public Objet(string nom)
        {
            _nom = nom;
        }

        public IHumanoide Possesseur
        {
            get
            {
                return _possesseur;
            }
            set
            {
                _possesseur = value;
            }
        }
    }
}
