using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Mammifere:Tetrapode
    {
        public Mammifere(int ID_Animal, string Nom_Animal, int Age_Animal): base(ID_Animal, Nom_Animal, Age_Animal) { }
        public Mammifere() { }
    }
}
