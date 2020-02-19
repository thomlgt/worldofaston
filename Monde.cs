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

        /// <summary>
        /// Cette méthode statique permet de créer un nouveau personnage en demandant son nom à l'utilisateur
        /// </summary>
        /// <returns></returns>
        public static Monstre MonstreFactory()
        {
            Random random = new Random();
            Monstre monstre = new Monstre(genererNom(), random.Next(70,130), random.Next(5, 15));
            return monstre;
        }

        /// <summary>
        /// Cette méthode statique permet de faire combattre deux combattants jusqu'à ce que l'un deux n'ait plus de vie
        /// </summary>
        /// <param name="personnage"></param>
        /// <param name="monstre"></param>
        public static void Combat(Personnage personnage, Monstre monstre)
        {
            int tour = 1;
            while (personnage.PointDeVie > 0 && monstre.PointDeVie > 0)
            {
                Console.WriteLine("------- TOUR " + tour + "-------");
                if (tour % 2 != 0)
                {
                    monstre.PointDeVie -= personnage.Degats;
                }
                else
                {
                    personnage.PointDeVie -= monstre.Degats;
                }
                Console.ReadLine(); // Pause
                tour++;
            }
            if (personnage.PointDeVie <= 0)
            {
                Console.WriteLine(monstre.Nom + " gagne ce combat!");
            }
            else
            {
                Console.WriteLine(personnage.Nom + " gagne ce combat!");
            }
        }

        /// <summary>
        /// Cette méthode statique génère un nom aléatoire pour un monstre
        /// </summary>
        /// <returns></returns>
        public static string genererNom()
        {
            string[] animaux = { "Chien", "Ours", "Lion", "Sanglier", "Taureau" };
            string[] dark = { "Méchant", "Atroce", "Affreux", "Diabolique", "Vilain" };

            Random aleatoire = new Random();
            int entierDark = aleatoire.Next(4);
            int entierAnimal = aleatoire.Next(4);

            string result = animaux[entierAnimal] + " " + dark[entierDark];

            return result;
        }
    }
}
