using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Chien:Mammifere
    {
        Animal Animal2 = new Animal();
        public string RaceDog { set; get; }
        public string SexeDog { set; get; }
        public int IDPereChien { set; get; }
        public string NomPereChien { set; get; }
        public int IDMereChien { set; get; }
        public string NomMereChien { set; get; }

        public Chien(int ID_Animal, string Nom_Animal, int Age_Animal, string sexe_chien, string Carac_Chien, int idPereChien, string nomPereChien, int idMereChien, string nomMereChien ): base (ID_Animal, Nom_Animal, Age_Animal)
        {
            SexeDog = sexe_chien;
            RaceDog = Carac_Chien;
            IDPereChien = idPereChien;
            NomPereChien = nomPereChien;
            IDMereChien = idMereChien;
            NomMereChien = nomMereChien;
       
        }
        public Chien()
        {
            SexeDog = "Mâle";
            RaceDog = "Aucune race";
            IDPereChien = 0;
            NomPereChien = "Aucun nom";
            IDMereChien = 0;
            NomMereChien = "Aucun nom";
        }

        public override string ToString()
        {
            return ("ID: "+ID_Pet+" Nom:"+ Nom_Pet+" Age:"+Age_Pet+" Sexe:"+SexeDog+" Race: "+RaceDog+" Père:"+NomPereChien+" Mère:"+NomMereChien);
        }
    }
}
