using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Oiseau:Tetrapode
    {
        public int ID_Oiseau { get; set; }
        public string Nom_Oiseau { get; set; }
        public int Age_Oiseau { get; set; }

        public Oiseau(int ID_Piaf, string Nom_Piaf, int Age_Piaf)
        {
            ID_Oiseau = ID_Piaf;
            Nom_Oiseau = Nom_Piaf;
            Age_Oiseau = Age_Piaf;
        }
        public Oiseau(): this(0, "Aucun Nom", 0)
        {

        }
        public override string ToString()
        {
            return ("ID" + ID_Oiseau+ "Nom= " + Nom_Oiseau + " Age= " + Age_Oiseau);
        }
    }
}
