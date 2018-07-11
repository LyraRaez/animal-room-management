using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Personne:Humain
    {
        public int ID_Personne { get; set; }
        public string Nom_Personne { get; set; }
        public string Prenom_Personne { get; set; }
        public string Adr_Personne { get; set; }
        public long Tel_Personne { get; set; }

        public Personne(int id_perso, string nom_perso, string prenom_perso, string adr_perso, long tel_perso)
        {
            ID_Personne = id_perso;
            Nom_Personne = nom_perso;
            Prenom_Personne = prenom_perso;
            Adr_Personne = adr_perso;
            Tel_Personne = tel_perso;
        }
        public Personne(): this(0, "Aucun Nom", "Aucun Prénom", "Aucune adresse", 0788661064) { }
        
        public override string ToString()
        {
            return ("ID:" + ID_Personne + " Nom-Prénom: " + Nom_Personne + Prenom_Personne + " Adresse: " + Adr_Personne + " Tel:" + Tel_Personne);
        }
    }
}
