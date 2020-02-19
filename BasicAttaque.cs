using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    class BasicAttaque : IAttaque
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public int Degats { get; set; }
        public double Rater { get; set; }

        public BasicAttaque()
        {

        }

        public BasicAttaque(string nom, string description, int degats, double rater)
        {
            Nom = nom;
            Description = description;
            Degats = degats;
            Rater = rater;
        }

        /// <summary>
        /// Cette méthode renvoie un montant de dégats
        /// </summary>
        /// <param name="lanceur"></param>
        /// <param name="cible"></param>
        /// <returns></returns>
        public int LancerAttaque(ICombattant lanceur, ICombattant cible)
        {
            Random random = new Random();
            if(random.NextDouble() < Rater)
            {
                Console.WriteLine("L'attaque a échouée....");
                return 0;
            }
            return Degats;
        }
    }
}
