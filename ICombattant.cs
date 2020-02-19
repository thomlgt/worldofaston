using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    interface ICombattant
    {
        public string Nom { get; set; }
        public int PointDeVie { get; set; }
        public int Degats { get; set; }

        public void Attaquer(ICombattant adversaire);
        public void Defendre(int degats);
    }
}
