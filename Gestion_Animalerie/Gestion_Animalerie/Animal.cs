using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Animal:EtreVivant
    {
        public int ID_Pet { get; set; }
        public string Nom_Pet { get; set; }
        public int Age_Pet { get; set; }

        public Animal (int ID_Animal, string Nom_Animal, int Age_Animal)
        {
            ID_Pet = ID_Animal;
            Nom_Pet = Nom_Animal;
            Age_Pet = Age_Animal;
        }
        public Animal(): this(0, "Aucun Nom", 0)
        {
            
        }
        public override string ToString() 
        {
            return ("ID" + ID_Pet + "Nom= " + Nom_Pet + " Age= " + Age_Pet);
        }
    }
}
