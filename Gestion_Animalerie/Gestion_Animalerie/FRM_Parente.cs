using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestion_Animalerie
{
    public partial class FRM_Parente : Form
    {
        public static string chemin = ("K:/Antoine/Cours/DEV2/DEV/Projet Gestion d'une animalerie/");
        ArrayList Chat = new ArrayList();
        ArrayList Chien = new ArrayList();
        ArrayList Pigeon = new ArrayList();
        public FRM_Parente()
        {
            InitializeComponent();

            
        }

        //Remplir ListBox
        private void RemplirLB_Chat(Chat chat) { LBX_Chat.Items.Add(chat); }
   
        private void RemplirLB_Chien(Chien chien) { LBX_Chien.Items.Add(chien); }

        //Sélection dans les ListBox
        private void SelectLBL_Chat(Chat chat)
        {
            if (chat.IDPereChat == 0 && chat.IDMereChat==0) { TBX_IDChaton.Text = chat.ID_Pet.ToString(); TBX_Chaton.Text = chat.Nom_Pet; }
            if (chat.Sexe_Cat == "Mâle") { TBX_IDMaleChat.Text = chat.ID_Pet.ToString(); TBX_NomMaleChat.Text = chat.Nom_Pet; }
            else if (chat.Sexe_Cat == "Femelle") { TBX_IDFemelleChat.Text = chat.ID_Pet.ToString(); TBX_NomFemelleChat.Text = chat.Nom_Pet; }
        }

        private void SelectLBL_Chien(Chien chien)
        {
            if (chien.IDPereChien == 0 && chien.IDMereChien == 0) { TBX_IDChiot.Text = chien.ID_Pet.ToString(); TBX_NomChiot.Text = chien.Nom_Pet; }
            if (chien.SexeDog == "Mâle") { TBX_IDMaleChien.Text = chien.ID_Pet.ToString(); TBX_NomMaleChien.Text = chien.Nom_Pet; }
            else if (chien.SexeDog == "Femelle") { TBX_IDFemelleChien.Text = chien.ID_Pet.ToString(); TBX_NomFemelleChien.Text = chien.Nom_Pet; }
        }
        private void SelectLBL_Pigeon(Pigeon pigeon)
        {
            if (pigeon.IDPerePigeon == 0 && pigeon.IDMerePigeon == 0) { TBX_IDPigeonneau.Text = pigeon.ID_Oiseau.ToString(); TBX_NomPigeonneau.Text = pigeon.Nom_Oiseau; }
            if (pigeon.Sexe_Pigeon == "Mâle") { TBX_IDPerePigeon.Text = pigeon.ID_Oiseau.ToString(); TBX_NomPerePigeon.Text = pigeon.Nom_Oiseau; }
            else if (pigeon.Sexe_Pigeon == "Femelle") { TBX_IDMerePigeon.Text = pigeon.ID_Oiseau.ToString(); TBX_NomMerePigeon.Text = pigeon.Nom_Oiseau; }
        }


        //ModifChat
        private void ModifLBL_Chat(Chat chat) { chat.Nom_Pet = TBX_Chaton.Text; chat.IDPereChat = Convert.ToInt32(TBX_IDMaleChat.Text); chat.NomPereChat = TBX_NomMaleChat.Text; chat.IDMereChat =Convert.ToInt32(TBX_IDFemelleChat.Text);chat.NomMereChat = TBX_NomFemelleChat.Text;}
        private void ModifLBL_Chien(Chien chien) { chien.Nom_Pet = TBX_NomChiot.Text; chien.IDPereChien = Convert.ToInt32(TBX_IDMaleChien.Text); chien.NomPereChien = TBX_NomMaleChien.Text; chien.IDMereChien = Convert.ToInt32(TBX_IDFemelleChien.Text); chien.NomMereChien = TBX_NomFemelleChien.Text; }
        private void ModifLBL_Pigeon(Pigeon pigeon) {pigeon.Nom_Oiseau = TBX_NomPigeonneau.Text; pigeon.IDPerePigeon = Convert.ToInt32(TBX_IDPerePigeon.Text); pigeon.NomPerePigeon = TBX_NomPerePigeon.Text; pigeon.IDMerePigeon = Convert.ToInt32(TBX_IDMerePigeon.Text); pigeon.NomMerePigeon = TBX_NomMerePigeon.Text; }


        //UpdateListBox
        private void UpdateLBL_Chat(Chat chat) { LBX_Chat.Items.Add(chat); LBX_Chat.Items.Remove(LBX_Chat.SelectedItem); }
        private void UpdateLBL_Chien(Chien chien) { LBX_Chien.Items.Add(chien); LBX_Chien.Items.Remove(LBX_Chien.SelectedItem); }
        private void UpdateLBL_Pigeon(Pigeon pigeon) { LBX_Pigeon.Items.Add(pigeon);LBX_Pigeon.Items.Remove(LBX_Pigeon.SelectedItem); }

    





        /// <summary>
        /// Sauvegarde
        /// </summary>
        private void SaveLBChat()
        {
            Chat.Clear(); ;
            foreach(object element in LBX_Chat.Items) { Chat.Add(element); }
        }
        private void SaveLBChien()
        {
            Chien.Clear();
            foreach (object element in LBX_Chien.Items) { Chien.Add(element); }
        }
        private void SaveLBPigeon()
        {
            Pigeon.Clear();
            foreach (object element in LBX_Pigeon.Items) { Pigeon.Add(element); }
        }
        private void EcritFichierAnimaux()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(chemin + "Animaux", FileMode.OpenOrCreate, FileAccess.Write);
            SaveLBChat();
            SaveLBChien();
            SaveLBPigeon();
            try
            {
                formatter.Serialize(fs, Chien);
                formatter.Serialize(fs, Chat);
                formatter.Serialize(fs, Pigeon);
            }
            catch (SerializationException e) { MessageBox.Show("" + e.Message); }
            fs.Close();
        }
        

        /// <summary>
        /// Copie vers List box
        /// </summary>
        private void CopieLBChat() //Chat
        {
            LBX_Chat.Items.Clear(); ;
            foreach (object element in Chat) { LBX_Chat.Items.Add(element); }
        }
        private void CopieChienVersLB() //Chat
        {
            LBX_Chien.Items.Clear();
            foreach (object element in Chien) { LBX_Chien.Items.Add(element); }
        }
        private void CopieLBPigeon()
        {
            LBX_Pigeon.Items.Clear();
            foreach (object element in Pigeon) { LBX_Pigeon.Items.Add(element); }
       }
        /// <summary>
        /// Ouvrir Fichier 
        /// </summary>
        private void LireFichier()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(chemin + "Animaux", FileMode.Open, FileAccess.Read);
            try
            {
                Chien = (ArrayList)formatter.Deserialize(fs);
                CopieChienVersLB();

                Chat = (ArrayList)formatter.Deserialize(fs);
                CopieLBChat();

                Pigeon = (ArrayList)formatter.Deserialize(fs);
                CopieLBPigeon();

            }
            catch (SerializationException e) { MessageBox.Show("" + e.Message); }
            fs.Close();
        }







        /// <summary>
        /// Interface
        /// </summary>
        /// 


        //Sélection
        private void LBX_Chat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (LBX_Chat.Text.Length != 0) { Chat Chat = (Chat)LBX_Chat.SelectedItem; SelectLBL_Chat(Chat); }
        }
        private void LBX_Chien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_Chien.Text.Length != 0) { Chien chien = (Chien)LBX_Chien.SelectedItem; SelectLBL_Chien(chien); }
        }
        private void LBX_Pigeon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_Pigeon.Text.Length != 0) { Pigeon pigeon = (Pigeon)LBX_Pigeon.SelectedItem; SelectLBL_Pigeon(pigeon); }
        }


        /// <summary>
        /// Modif Parenté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_AddParenteChat_Click(object sender, EventArgs e){Chat chat = (Chat)LBX_Chat.SelectedItem; ModifLBL_Chat(chat); UpdateLBL_Chat(chat);}

        private void B_AddChien_Click(object sender, EventArgs e) { Chien chien = (Chien)LBX_Chien.SelectedItem; ModifLBL_Chien(chien); UpdateLBL_Chien(chien); }
        private void B_AddPigeon_Click(object sender, EventArgs e) { Pigeon pigeon = (Pigeon)LBX_Pigeon.SelectedItem;  ModifLBL_Pigeon(pigeon);UpdateLBL_Pigeon(pigeon); }
        //Save & Open
        private void TLB_Save_Click(object sender, EventArgs e){ if (LBX_Chat.Text != "") { EcritFichierAnimaux(); } }

        private void TLB_Open_Click(object sender, EventArgs e){   LireFichier();  }

        private void TLB_Back_Click(object sender, EventArgs e)
        {
            FRM_Acceuil ecran2 = new FRM_Acceuil();
            ecran2.Owner = this;
            ecran2.Show();
            this.Hide();
        }

        private void FRM_Parente_Load(object sender, EventArgs e)
        {
            LireFichier();
        }
    }
}
