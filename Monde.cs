using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    static class Monde
    {
        private static Dictionary<string, Classe> classes = new Dictionary<string, Classe>();

        /// <summary>
        /// Cette méthode statique permet de créer un nouveau personnage en demandant son nom à l'utilisateur
        /// </summary>
        /// <returns></returns>
        public static Personnage PersonnageFactory()
        {
            // Ajout d'une classe à une liste de classe------------------------------
            List<IAttaque> listAttaques = new List<IAttaque>();
            BasicAttaque basicAttaque = new BasicAttaque("Attaque Basique", "", 10, 0.20);
            listAttaques.Add(basicAttaque);
            Classe classe = new Classe("Mage", listAttaques);
            classes.Add(classe.Nom.ToLower(), classe);
            // Fin d'ajout d'une classe à une liste de classe------------------------

            Console.WriteLine("Saisissez le nom du personnage :");
            string nom = Console.ReadLine();

            bool isFound = false;
            Classe classePerso = new Classe();

            while (!isFound)
            {
                Console.WriteLine("Saisissez la classe du personnage :");
                string nomClasse = Console.ReadLine();
                if (classes.ContainsKey(nomClasse.ToLower()))
                {
                    classePerso = GetClasse(nomClasse.ToLower());
                    isFound = true;
                } else
                {
                    Console.WriteLine("La classe n'a pas été trouvée, recommencez!");
                }
            }
            
            Personnage personnage = new Personnage(nom, 100, 10, classePerso);
            return personnage;
        }

        /// <summary>
        /// Cette méthode statique permet de créer un nouveau personnage en demandant son nom à l'utilisateur
        /// </summary>
        /// <returns></returns>
        public static Monstre MonstreFactory()
        {
            Random random = new Random();
            Monstre monstre = new Monstre(genererNom(), random.Next(70, 130), random.Next(5, 15));
            return monstre;
        }

        /// <summary>
        /// Cette méthode statique permet de faire combattre deux combattants jusqu'à ce que l'un deux n'ait plus de vie
        /// </summary>
        /// <param name="combattant1"></param>
        /// <param name="combattant2"></param>
        public static void Combat(ICombattant combattant1, ICombattant combattant2)
        {
            int tour = 1;
            while (combattant1.PointDeVie > 0 && combattant2.PointDeVie > 0)
            {
                Console.WriteLine($"------- TOUR {tour} -------");
                if (tour % 2 != 0)
                {
                    combattant1.Attaquer(combattant2);
                }
                else
                {
                    combattant2.Attaquer(combattant1);
                }
                Console.ReadLine(); // Pause
                tour++;
            }
            if (combattant1.PointDeVie <= 0)
            {
                Console.WriteLine(combattant2.Nom + " gagne ce combat!");
            }
            else
            {
                Console.WriteLine(combattant1.Nom + " gagne ce combat!");
            }
        }

        /// <summary>
        /// Cette méthode teste si la classe demandée par l'utilisateur existe, et la renvoie
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public static Classe GetClasse(string nom)
        {
            Classe result = new Classe();
            result = classes.GetValueOrDefault(nom);
            return result;
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
