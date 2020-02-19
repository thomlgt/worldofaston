using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    class Personnage : AbstractCombattant
    {
        public Classe Classe { get; set; }

        public Personnage() : base()
        {

        }
        public Personnage(string nom, int pointDeVie, int degats, Classe classe) : base(nom, pointDeVie, degats)
        {
            Classe = classe;
        }

        /// <summary>
        /// Cette méthode appelle la méthode Défendre pour infliger des dégats à un adversaire
        /// </summary>
        /// <param name="adversaire"></param>
        public override void Attaquer(IUniqueCombattant adversaire)
        {
            Console.WriteLine($"{Nom} attaque!");
            adversaire.Defendre(Classe.GetAttaque().LancerAttaque(this, adversaire));
        }
    }
}
