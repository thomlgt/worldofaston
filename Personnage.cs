using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    class Personnage : AbstractCombattant
    {
        public Personnage() : base()
        {

        }
        public Personnage(string nom, int pointDeVie, int degats) : base(nom, pointDeVie, degats)
        {

        }
    }
}
