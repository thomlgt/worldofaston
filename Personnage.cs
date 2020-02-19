using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    class Personnage
    {
        public string Nom { get; set; }
        public int PointDeVie { get; set; }
        public int Degats { get; set; }

        public Personnage()
        {

        }

        public Personnage(string nom, int pointDeVie, int degats)
        {
            Nom = nom;
            PointDeVie = pointDeVie;
            Degats = degats;
        }

        /// <summary>
        /// Cette méthode surcharge la méthode ToString pour afficher un personnage
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"nom:{Nom}, points de vie:{PointDeVie}, degats:{Degats}";
        }
    }
}
