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
        /// Cette méthode statique permet de créer un nouveau personnage en demandant son nom à l'utilisateur
        /// </summary>
        /// <returns></returns>
        public static Personnage PersonnageFactory()
        {
            Console.WriteLine("Saisissez le nom du personnage :");
            string nom = Console.ReadLine();
            Personnage personnage = new Personnage(nom, 100, 10);
            return personnage;
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
