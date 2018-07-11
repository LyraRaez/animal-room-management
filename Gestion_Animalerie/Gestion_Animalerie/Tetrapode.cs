
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Tetrapode:Animal
    {
        public Tetrapode(int ID_Animal, string Nom_Animal, int Age_Animal): base(ID_Animal, Nom_Animal, Age_Animal) { }
        public Tetrapode() { }
    }
}
