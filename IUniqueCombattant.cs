using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    interface IUniqueCombattant : ICombattant
    {
        public string Nom { get; set; }
        public int PointDeVie { get; set; }
        public int Degats { get; set; }
    }
}
