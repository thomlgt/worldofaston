using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    abstract class AbstractCombattant : ICombattant
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
        public override string ToString()
        {
            return $"Nom: {Nom} | Vie: {PointDeVie} | Degats: {Degats}";
        }

        /// <summary>
        /// Cette méthode appelle la méthode Défendre pour infliger des dégats à un adversaire
        /// </summary>
        /// <param name="adversaire"></param>
        public void Attaquer(ICombattant adversaire)
        {
            Console.WriteLine(Nom + " attaque !");
            adversaire.Defendre(Degats);
        }

        /// <summary>
        /// Cette méthode applique les dégats subit par le combattant
        /// </summary>
        /// <param name="degats"></param>
        public void Defendre(int degats)
        {
            Console.WriteLine(Nom + " prend " + degats + " points de dégats");
            PointDeVie -= degats;
            Console.WriteLine(Nom + " a maintenant " + PointDeVie + "pdv");
        }
    }
}
