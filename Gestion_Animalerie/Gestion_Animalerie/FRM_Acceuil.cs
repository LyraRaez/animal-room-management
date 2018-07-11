using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestion_Animalerie
{
    public partial class FRM_Acceuil : Form
    {
        public static string chemin= ("K:/Antoine/Cours/DEV2/DEV/Projet Gestion d'une animalerie/");
        ArrayList Chat = new ArrayList();
        ArrayList Chien = new ArrayList();
        ArrayList Pigeon = new ArrayList();
        ArrayList Eleveur = new ArrayList();
        ArrayList Proprio = new ArrayList();
        public FRM_Acceuil() { InitializeComponent(); }
        private void FRM_Acceuil_Load(object sender, EventArgs e) {
            
        }
        /// <summary>
        /// Ajout, Sélection, Modifiication
        /// </summary>
        //Rempir les listbox
        private void RemplirLB_Chat(Chat chat) { LBX_Chat.Items.Add(chat); }
        private void RemplirLB_Chien(Chien Chien) { LBX_Chien.Items.Add(Chien); }
        private void RemplirLB_Pigeon(Pigeon pigeon) { LBX_Pigeon.Items.Add(pigeon); }
        private void RemplirLB_Eleveur(Eleveur eleveur) { LBX_Eleveur.Items.Add(eleveur); }
        private void RemplirLB_Proprio(Proprietaire proprio) { LBX_Proprio.Items.Add(proprio); }

        //Sélection dans les listbox
        private void RemplirLBL_Chat(Chat chat) { CBX_TypeAnimal.Text = "Chat"; TBX_IDAnimal.Text = chat.ID_Pet.ToString(); TBX_NomAnimal.Text = chat.Nom_Pet; TBX_AgeAnimal.Text = chat.Age_Pet.ToString(); CBX_SexeAnimal.Text = chat.Sexe_Cat;  TBX_Race.Text = chat.Carac_Cat; }
        private void RemplirLBL_Chien(Chien chien) { CBX_TypeAnimal.Text = "Chien"; TBX_IDAnimal.Text = chien.ID_Pet.ToString(); TBX_NomAnimal.Text = chien.Nom_Pet.ToString(); TBX_AgeAnimal.Text = chien.Age_Pet.ToString();CBX_SexeAnimal.Text = chien.SexeDog; TBX_Race.Text =chien.RaceDog.ToString(); }
        private void RemplirLBL_Pigeon(Pigeon pigeon) { CBX_TypeAnimal.Text = "Pigeon"; TBX_IDAnimal.Text = pigeon.ID_Oiseau.ToString(); TBX_NomAnimal.Text = pigeon.Nom_Oiseau.ToString();TBX_AgeAnimal.Text = pigeon.Age_Oiseau.ToString();CBX_SexeAnimal.Text = pigeon.Sexe_Pigeon.ToString(); TBX_Race.Text = pigeon.Type_Pigeon.ToString();  }
        private void RemplirLBL_Eleveur(Eleveur eleveur) { TBX_IDPerso.Text = eleveur.ID_Personne.ToString(); TBX_NomPersonne.Text = eleveur.Nom_Personne.ToString();TBX_PrenomPersonne.Text = eleveur.Prenom_Personne.ToString();TBX_AdrPer.Text = eleveur.Adr_Personne.ToString();TBX_TelPer.Text = eleveur.Tel_Personne.ToString();TBX_NomElevage.Text = eleveur.Nom_Elevage.ToString();TBX_AdrPro.Text = eleveur.Adr_Pro.ToString(); TBX_TelPro.Text = eleveur.Tel_Pro.ToString(); TBX_Siret.Text = eleveur.Siret.ToString(); }
        private void RemplirLBL_Proprio(Proprietaire proprio) { TBX_IDPerso.Text = proprio.ID_Personne.ToString(); TBX_NomPersonne.Text = proprio.Nom_Personne.ToString(); TBX_PrenomPersonne.Text = proprio.Prenom_Personne.ToString(); TBX_AdrPer.Text = proprio.Adr_Personne.ToString(); TBX_TelPer.Text = proprio.Tel_Personne.ToString();TBX_TypeLogement.Text = proprio.TypeLogement.ToString(); TBX_AnimalProprio.Text = proprio.TypeAnimal.ToString(); }
        
        //Modification
        private void ModifLBL_Chat(Chat chat) { chat.Nom_Pet = TBX_NomAnimal.Text; chat.Age_Pet = Convert.ToInt32(TBX_AgeAnimal.Text); chat.Sexe_Cat = CBX_SexeAnimal.Text; chat.Carac_Cat = TBX_Race.Text; }
        private void ModifLBL_Chien(Chien chien) { chien.Nom_Pet = TBX_NomAnimal.Text; chien.Age_Pet = Convert.ToInt32(TBX_AgeAnimal.Text); chien.SexeDog = CBX_SexeAnimal.Text; chien.RaceDog = TBX_Race.Text; }
        private void ModifLBL_Pigeon(Pigeon pigeon) { pigeon.Nom_Oiseau = TBX_NomAnimal.Text; pigeon.Age_Oiseau = Convert.ToInt32(TBX_AgeAnimal.Text); pigeon.Sexe_Pigeon = CBX_SexeAnimal.Text; pigeon.Type_Pigeon = TBX_Race.Text; }
        private void ModifLBL_Eleveur(Eleveur eleveur) { eleveur.Nom_Personne = TBX_NomPersonne.Text; eleveur.Prenom_Personne = TBX_PrenomPersonne.Text; eleveur.Adr_Personne = TBX_AdrPer.Text; eleveur.Tel_Personne = Convert.ToInt32(TBX_TelPer.Text);eleveur.Nom_Elevage = TBX_NomElevage.Text;eleveur.Adr_Pro = TBX_AdrPro.Text; eleveur.Tel_Pro = Convert.ToInt32(TBX_TelPro.Text);eleveur.Siret = TBX_Siret.Text; }
        private void ModifLBL_Proprio(Proprietaire proprio) { proprio.Nom_Personne = TBX_NomPersonne.Text; proprio.Prenom_Personne = TBX_PrenomPersonne.Text; proprio.Adr_Personne = TBX_AdrPer.Text; proprio.Tel_Personne = Convert.ToInt32(TBX_TelPer.Text);proprio.TypeLogement = TBX_TypeLogement.Text; proprio.TypeAnimal = TBX_AnimalProprio.Text; }
        //Update listbox
        private void UpdateLBL_Chat(Chat chat) {  LBX_Chat.Items.Add(chat); LBX_Chat.Items.Remove(LBX_Chat.SelectedItem); }
        private void UpdateLBL_Chien(Chien chien) {  LBX_Chien.Items.Add(chien);LBX_Chien.Items.Remove(LBX_Chien.SelectedItem); }
        private void UpdateLBL_Pigeon(Pigeon pigeon) { LBX_Pigeon.Items.Add(pigeon);LBX_Pigeon.Items.Remove(LBX_Pigeon.SelectedItem); }
        private void UpdateLBL_Eleveur(Eleveur eleveur) { LBX_Eleveur.Items.Add(eleveur); LBX_Eleveur.Items.Remove(LBX_Eleveur.SelectedItem); }
        private void UpdateLBL_Proprio(Proprietaire proprio) { LBX_Proprio.Items.Add(proprio);LBX_Proprio.Items.Remove(LBX_Proprio.SelectedItem); }
        
        ///<summary>
        ///Sauvegarde
        ///</summary>
        ///
        
        //Animal
        private void CopieLBChat()
        {
            Chat.Clear(); ;
            foreach (object element in LBX_Chat.Items) { Chat.Add(element); }
        }
        private void CopieLBChien()
        {
            Chien.Clear();
            foreach (object element in LBX_Chien.Items) { Chien.Add(element); }
        }
        private void CopieLBPigeon()
        {
            Pigeon.Clear();
            foreach(object element in LBX_Pigeon.Items) { Pigeon.Add(element); }
        }
        private void EcritFichierAnimaux()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(chemin + "Animaux", FileMode.OpenOrCreate, FileAccess.Write);
            CopieLBChat();
            CopieLBChien();
            CopieLBPigeon();
            try
            {
                formatter.Serialize(fs, Chien);
                formatter.Serialize(fs, Chat);
                formatter.Serialize(fs, Pigeon);
            }
            catch (SerializationException e) { MessageBox.Show("" + e.Message); }
            fs.Close();
        }
        //Humain
        private void CopieLBeleveur()
        {
            Eleveur.Clear();
            foreach (object element in LBX_Eleveur.Items) { Eleveur.Add(element); }
        }
        private void CopieLBProprio()
        {
            Proprio.Clear();
            foreach(object element in LBX_Proprio.Items) { Proprio.Add(element); }
        }
        private void EcritFichierH()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(chemin + "Humanity", FileMode.OpenOrCreate, FileAccess.Write);
            CopieLBeleveur();
            CopieLBProprio();
            try
            {
                formatter.Serialize(fs, Eleveur);
                formatter.Serialize(fs, Proprio);
            }
            catch (SerializationException e) { MessageBox.Show("" + e.Message); }
            fs.Close();
        }
        /// <summary>
        /// Ouvrir
        /// </summary>
        /// 
        //Animaux
        private void CopieChatVersLB()
        {
            LBX_Chat.Items.Clear();
            foreach (object element in Chat){ LBX_Chat.Items.Add(element); }
        }
        private void CopieChienVersLB()
        {
            LBX_Chien.Items.Clear();
            foreach(object element in Chien) { LBX_Chien.Items.Add(element); }
        }
        private void CopiePigeonVersLB()
        {
            LBX_Pigeon.Items.Clear();
            foreach(object element in Pigeon) { LBX_Pigeon.Items.Add(element); }
        }
        private void LireFichierPet()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(chemin + "Animaux", FileMode.Open, FileAccess.Read);
            try
            { 
                Chien = (ArrayList)formatter.Deserialize(fs);
                CopieChienVersLB();

                Chat = (ArrayList)formatter.Deserialize(fs);
                CopieChatVersLB();
                
                Pigeon = (ArrayList)formatter.Deserialize(fs);
                CopiePigeonVersLB();

            }
            catch (SerializationException e) { MessageBox.Show("" + e.Message); }
            fs.Close();
        }
        //Humain
        private void CopieEleveurVersLB()
        {
            LBX_Eleveur.Items.Clear();
            foreach(object element in Eleveur) { LBX_Eleveur.Items.Add(element); }
        }
        private void CopieProprioVersLB()
        {
            LBX_Proprio.Items.Clear();
            foreach(object element in Proprio) { LBX_Proprio.Items.Add(element); }
        }
        private void LireFichierHumain()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(chemin + "Humanity", FileMode.Open, FileAccess.Read);
            try
            {
                Eleveur = (ArrayList)formatter.Deserialize(fs);
                CopieEleveurVersLB();
                Proprio = (ArrayList)formatter.Deserialize(fs);
                CopieProprioVersLB();
            }
            catch(SerializationException e) { MessageBox.Show("Erreur: " + e.Message); }
            fs.Close();
        }




        /// <summary>
        /// Elément visible sur l'interface
        /// </summary>
            //SELECTION
        private void LBX_Chat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_Chat.Text.Length != 0){Chat chat = (Chat)LBX_Chat.SelectedItem;RemplirLBL_Chat(chat);}
        }

        private void LBX_Chien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_Chien.Text.Length != 0){Chien chien = (Chien)LBX_Chien.SelectedItem;RemplirLBL_Chien(chien);}
        }

        private void LBX_Eleveur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_Eleveur.Text.Length != 0) { Eleveur eleveur = (Eleveur)LBX_Eleveur.SelectedItem; RemplirLBL_Eleveur(eleveur); }
        }

        private void LBX_Proprio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_Proprio.Text.Length != 0){Proprietaire proprietaire = (Proprietaire)LBX_Proprio.SelectedItem;RemplirLBL_Proprio(proprietaire);}
        }
        private void LBX_Pigeon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_Pigeon.Text.Length != 0) { Pigeon pigeon = (Pigeon)LBX_Pigeon.SelectedItem; RemplirLBL_Pigeon(pigeon); }
        }
        //Affichage
        private void TLB_Humain_Click(object sender, EventArgs e){GBX_Personne.Visible = true; GBX_Animal.Visible = false; }

        private void TLB_Pet_Click(object sender, EventArgs e){GBX_Animal.Visible = true; GBX_Personne.Visible = false; }

        private void TLB_Parente_Click(object sender, EventArgs e)
        {
            FRM_Parente ecran2 = new FRM_Parente();
            ecran2.Owner = this;
            ecran2.Show();
            this.Hide();
        }
        
        
        //Commande animaux
        private void TSB_Add_Click(object sender, EventArgs e)
        {
            if (CBX_TypeAnimal.Text == "Chat")
            {
                Chat chat = new Chat(int.Parse(TBX_IDAnimal.Text), TBX_NomAnimal.Text, int.Parse(TBX_AgeAnimal.Text), CBX_SexeAnimal.Text, TBX_Race.Text, 0, "Aucun nom", 0, "Aucun nom");
                RemplirLB_Chat(chat);
            }
            else if (CBX_TypeAnimal.Text == "Chien")
            {
                Chien chien = new Chien(int.Parse(TBX_IDAnimal.Text), TBX_NomAnimal.Text, int.Parse(TBX_AgeAnimal.Text), CBX_SexeAnimal.Text, TBX_Race.Text, 0, "aucun nom", 0, "aucun nom");
                RemplirLB_Chien(chien);
            }
            else if (CBX_TypeAnimal.Text == "Pigeon")
            {
                Pigeon pigeon = new Pigeon(int.Parse(TBX_IDAnimal.Text), TBX_NomAnimal.Text, int.Parse(TBX_AgeAnimal.Text), CBX_SexeAnimal.Text, TBX_Race.Text, 0, "Aucun nom", 0, "Aucun nom");
                RemplirLB_Pigeon(pigeon);
            }
        }

        private void TLS_ModifierAnimaux_Click(object sender, EventArgs e)
        {
            if (CBX_TypeAnimal.Text == "Chat") { Chat chat = (Chat)LBX_Chat.SelectedItem; ModifLBL_Chat(chat); UpdateLBL_Chat(chat); }
            else if (CBX_TypeAnimal.Text == "Chien") { Chien chien = (Chien)LBX_Chien.SelectedItem; ModifLBL_Chien(chien); UpdateLBL_Chien(chien); }
            else if (CBX_TypeAnimal.Text == "Pigeon") { Pigeon pigeon = (Pigeon)LBX_Pigeon.SelectedItem; ModifLBL_Pigeon(pigeon); UpdateLBL_Pigeon(pigeon); }
        }

        private void TLB_Supprimer_Click(object sender, EventArgs e)
        {
            if (CBX_TypeAnimal.Text == "Chat")
            { if (LBX_Chat.Text.Length != 0) { LBX_Chat.Items.Remove(LBX_Chat.SelectedItem); } }
            if (CBX_TypeAnimal.Text == "Chien") { if (LBX_Chien.Text.Length != 0) { LBX_Chien.Items.Remove(LBX_Chien.SelectedItem); } }
            if (CBX_TypeAnimal.Text == "Pigeon") { if (LBX_Pigeon.Text.Length != 0) { LBX_Chien.Items.Remove(LBX_Chien.SelectedItem); } }
        }

        private void TLB_SavePet_Click(object sender, EventArgs e) { EcritFichierAnimaux(); MessageBox.Show("Fichier sauvegardé"); }

        private void TLB_Open_Click(object sender, EventArgs e){LireFichierPet();}



        //Commande Humain
        private void TLB_Eleveur_Click(object sender, EventArgs e){ GBX_Pro.Visible = true; GBX_Proprio.Visible = false;}

        private void TLB_Proprio_Click(object sender, EventArgs e){GBX_Proprio.Visible = true; GBX_Pro.Visible = false;}

        private void TLB_AddHuman_Click(object sender, EventArgs e)
        {
            if (GBX_Pro.Visible == true)
            {
                Eleveur eleveur = new Eleveur(int.Parse(TBX_IDPerso.Text), TBX_NomPersonne.Text, TBX_PrenomPersonne.Text, TBX_AdrPer.Text, int.Parse(TBX_TelPer.Text), TBX_AdrPro.Text, long.Parse(TBX_TelPro.Text), TBX_Siret.Text, TBX_NomElevage.Text);
                RemplirLB_Eleveur(eleveur);
            }
            else if (GBX_Proprio.Visible == true)
            {
                Proprietaire proprio = new Proprietaire(int.Parse(TBX_IDPerso.Text), TBX_NomPersonne.Text, TBX_PrenomPersonne.Text, TBX_AdrPer.Text, int.Parse(TBX_TelPer.Text), TBX_TypeLogement.Text, TBX_AnimalProprio.Text);
                RemplirLB_Proprio(proprio);
            }
        }

        private void TLB_UpdateHuman_Click(object sender, EventArgs e)
        {
            if (GBX_Pro.Visible == true) { Eleveur eleveur = (Eleveur)LBX_Eleveur.SelectedItem; ModifLBL_Eleveur(eleveur); UpdateLBL_Eleveur(eleveur); }
            else if (GBX_Proprio.Visible == true) { Proprietaire proprio = (Proprietaire)LBX_Proprio.SelectedItem; ModifLBL_Proprio(proprio); UpdateLBL_Proprio(proprio); }
        }

        private void TLB_SupprimerHumain_Click(object sender, EventArgs e)
        {
            if (GBX_Pro.Visible == true) { if (LBX_Eleveur.Text.Length != 0) { LBX_Eleveur.Items.Remove(LBX_Eleveur.SelectedItem); } }
            if (GBX_Proprio.Visible == true) { if (LBX_Proprio.Text.Length != 0) { LBX_Proprio.Items.Remove(LBX_Proprio.SelectedItem); } }
        }

        private void TLB_SaveHumain_Click(object sender, EventArgs e) { EcritFichierH(); MessageBox.Show("Fichier sauvegardé"); }

        private void TLb_OpenHumanity_Click(object sender, EventArgs e) { LireFichierHumain(); }

    }
}

