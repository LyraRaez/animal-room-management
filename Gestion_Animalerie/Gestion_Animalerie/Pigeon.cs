using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Pigeon:Oiseau
    {
        public string Type_Pigeon { set; get; }
        public string Sexe_Pigeon { set; get; }
        public int IDPerePigeon { set; get; }
        public string NomPerePigeon { set; get; }
        public int IDMerePigeon { set; get; }
        public string NomMerePigeon { set; get; }

        public Pigeon(int ID_Oiseau, string Nom_Oiseau, int Age_Oiseau, string sexe_fanboy, string type_fanboy,int idPere, string nomPere, int idMere, string nomMere): base (ID_Oiseau, Nom_Oiseau, Age_Oiseau)
        {
            Sexe_Pigeon = sexe_fanboy;
           Type_Pigeon = type_fanboy;
            IDPerePigeon = idPere;
            NomPerePigeon = nomPere;
            IDMerePigeon = idMere;
            NomMerePigeon = nomMere;
        }
        public Pigeon()
        {
            Sexe_Pigeon = "Mâle";
            Type_Pigeon = "fanboy d'apple";
            IDPerePigeon = 0;
            NomPerePigeon = "Aucun nom";
            IDMerePigeon = 0;
            NomMerePigeon = "Aucun nom";

        }
        public override string ToString()
        {
            return ("ID:" + ID_Oiseau + " Nom: " + Nom_Oiseau + " Age: " + Age_Oiseau + " Sexe:" + Sexe_Pigeon + " Race: " + Type_Pigeon+" Père:"+NomPerePigeon+" Mère:"+NomMerePigeon);
        }
    }
}
