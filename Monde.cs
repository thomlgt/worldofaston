using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    static class Monde
    {
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
    }
}
