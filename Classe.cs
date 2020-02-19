using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    class Classe
    {
        public string Nom { get; set; }
        public List<IAttaque> attaques = new List<IAttaque>();

        public Classe()
        {

        }

        public Classe(string nom, List<IAttaque> attaques)
        {
            Nom = nom;
            this.attaques = attaques;
        }

        /// <summary>
        /// Cette méthode renvoie une attaque aléatoire parmi une liste d'attaques
        /// </summary>
        /// <returns></returns>
        public IAttaque GetAttaque()
        {
            Random random = new Random();
            return this.attaques[random.Next(this.attaques.Count)];
        }
    }
}
