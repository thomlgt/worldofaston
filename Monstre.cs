using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    class Monstre : AbstractCombattant
    {
        public Monstre() : base()
        {

        }
        public Monstre(string nom, int pointDeVie, int degats) : base(nom, pointDeVie, degats)
        {

        }
    }
}
