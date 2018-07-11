using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Animalerie
{
    [Serializable]
    class Chat:Mammifere

    {
        Animal Animal1 = new Animal();
        
        public string Carac_Cat { set; get; }
        public string Sexe_Cat { set; get; }
        public int IDPereChat { set; get; }
        public string NomPereChat { set; get; }
        public int IDMereChat { set; get; }
        public string NomMereChat { set; get; }

        public Chat(int ID_Animal, string Nom_Animal, int Age_Animal, string sexe_chat, string Carac_Chat, int idPereChat, string nomPereChat, int idMereChat, string nomMereChat ): base (ID_Animal, Nom_Animal, Age_Animal)
        {
            Sexe_Cat = sexe_chat;
            Carac_Cat = Carac_Chat;
            IDPereChat = idPereChat;
            NomPereChat = nomPereChat;
            IDMereChat = idMereChat;
            NomMereChat = nomMereChat;
            
        }
        public Chat()
        {
            Sexe_Cat = "Mâle";
            Carac_Cat = "Aucune race";
            IDPereChat = 0;
            NomPereChat = "aucun nom";
            IDMereChat = 0;
            NomMereChat = "Aucun nom";
   
        }
        public override string ToString()
        {
            return ("ID:" +ID_Pet+" Nom: "+Nom_Pet+" Age: "+Age_Pet+" Sexe:"+Sexe_Cat+" Race: "+Carac_Cat+ " Pere:"+NomPereChat+" Mere:"+NomMereChat);
        }
    }
}
