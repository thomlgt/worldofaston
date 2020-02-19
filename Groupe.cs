using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    class Groupe : ICombattant
    {
        List<IUniqueCombattant> combattants = new List<IUniqueCombattant>();

        /// <summary>
        /// Cette méthode appelle la méthode Défendre pour qu'un combattant choisit inflige des dégats à un adversaire
        /// </summary>
        /// <param name="adversaire"></param>
        public void Attaquer(IUniqueCombattant adversaire)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cette méthode applique les dégats subit par un combattant choisit
        /// </summary>
        /// <param name="degats"></param>
        public void Defendre(int degats)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cette méthode retourne un combattant aléatoire parmis la liste des combattants
        /// </summary>
        /// <returns></returns>
        public IUniqueCombattant GetUniqueCombattant()
        {
            Random random = new Random();
            IUniqueCombattant combattant = combattants[random.Next(combattants.Count)];
            return combattant;
        }

        /// <summary>
        /// Cette méthode ajoute un combattant à la liste des combattants
        /// </summary>
        public void AjouterCombattant(IUniqueCombattant combattant)
        {
            combattants.Add(combattant);
        }
    }
}
