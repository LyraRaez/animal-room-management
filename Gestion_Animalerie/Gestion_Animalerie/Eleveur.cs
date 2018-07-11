using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Eleveur:Personne
    {
        Personne personne = new Personne();

        public string Adr_Pro { get; set; }
        public long Tel_Pro { get; set; }
        public string Siret { get; set; }
        public string Nom_Elevage { get; set; }

        public Eleveur(int ID_Personne, string Nom_Personne, string Prenom_Personne, string Adr_Personne, int Tel_Personne, string adr_pro, long tel_pro, string siret, string nom_elevage): base(ID_Personne, Nom_Personne, Prenom_Personne, Adr_Personne, Tel_Personne  ) 
        {
            Adr_Pro = adr_pro;
            Tel_Pro = tel_pro;
            Siret = siret;
            Nom_Elevage = nom_elevage;
        }
        public Eleveur()
        {
            Adr_Pro = "Pas d'adresse";
            Tel_Pro = 0626255421;
            Siret = "FR1234567890";
            Nom_Elevage = "Aucun nom";
        }
        public override string ToString()
        {
            return (ID_Personne + ". " + Nom_Personne + Prenom_Personne + ", " + Adr_Personne + ", "+ Tel_Personne+ ", Pro: "+Nom_Elevage+", "+Adr_Pro+", "+Tel_Pro+", "+Siret);
        }
    }
}
