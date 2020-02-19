using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    abstract class AbstractCombattant
    {
        public string Nom { get; set; }
        public int PointDeVie { get; set; }
        public int Degats { get; set; }

        public AbstractCombattant()
        {

        }

        public AbstractCombattant(string nom, int pointDeVie, int degats)
        {
            Nom = nom;
            PointDeVie = pointDeVie;
            Degats = degats;
        }

        /// <summary>
        /// Cette méthode surcharge la méthode ToString pour afficher un personnage
        /// </summary>
        /// <returns></returns>
        public virtual string ToString()
        {
            return $"Nom: {Nom} | Vie: {PointDeVie} | Degats: {Degats}";
        }
    }
}
