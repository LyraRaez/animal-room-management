using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Proprietaire:Personne
    {
        Personne personne = new Personne();

        public string TypeLogement { get; set; }
        public string TypeAnimal { get; set; }

        public Proprietaire(int ID_Personne, string Nom_Personne, string Prenom_Personne, string Adr_Personne, int Tel_Personne, string typeLogement, string typeAnimal):base(ID_Personne, Nom_Personne, Prenom_Personne, Adr_Personne, Tel_Personne)
        {
            TypeLogement = typeLogement;
            TypeAnimal = typeAnimal;
        }
        public Proprietaire()
        {
            TypeLogement = "Aucun type";
            TypeAnimal = "Aucun animal";
        }
        public override string ToString()
        {
            return (ID_Personne + ". " + Nom_Personne + Prenom_Personne + ", " + Adr_Personne + ", " + Tel_Personne + ", " + TypeLogement + ", " + TypeAnimal);
        }
    }
}
