using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfAston
{
    interface ICombattant
    {
        public void Attaquer(IUniqueCombattant adversaire);
        public void Defendre(int degats);
    }
}
