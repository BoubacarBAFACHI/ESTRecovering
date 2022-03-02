using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ESTRecovering.Formz
{
    public partial class Inscription : Form
    {
        MySqlConnection sql = new MySqlConnection("datasource=localhost;port=3308; Database=annee; Uid=root; Pwd=17091995#Bb;");

        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            Niveaucombo();
            AnnACAcombo();
            LoadTheme();
            clear();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }
            label13.ForeColor = ThemeColor.PrimaryColor;
            label17.ForeColor = ThemeColor.PrimaryColor;
        }

        private void AnnACAcombo()
        {
            string query = "select ID_AN,NOM_AN from annee_aca;";
            MySqlDataAdapter da = new MySqlDataAdapter(query, sql);
            DataSet dt = new DataSet();
            da.Fill(dt, "NOM_AN");
            CmboBoxAnnee_Aca.DataSource = dt.Tables["NOM_AN"];
            CmboBoxAnnee_Aca.DisplayMember = "NOM_AN";
            CmboBoxAnnee_Aca.ValueMember = "ID_AN";

        }

        private void Niveaucombo()
        {
            string query1 = "select ID_N,NIVEAU from niveau;";
            MySqlDataAdapter da = new MySqlDataAdapter(query1, sql);
            DataSet dt = new DataSet();
            da.Fill(dt, "NIVEAU");
            CmboboxNiveau.DataSource = dt.Tables["NIVEAU"];
            CmboboxNiveau.DisplayMember = "NIVEAU";
            CmboboxNiveau.ValueMember = "ID_N";

        }

        private void btn_Enr_Etd_Ins_Click(object sender, EventArgs e)
        {
            sql.Open();

            if (txtbox_matriEtud.Text !="" && txtbox_nomEtud.Text !="" 
                && txtbox_prenomEtud.Text !="" && Combbox_genreEtud.Text !=""
                && txtbox_datenaissEtud.Text !="" && txtbox_lieunaissEtud.Text !=""
                && CmboboxNiveau.SelectedValue.ToString() !="" && CmboBoxAnnee_Aca.SelectedValue.ToString() !=""
                && DateTimePickerIns.Text !="")
            {
                var reqInsert = "INSERT INTO etudiant (MATRICULE,NOM_ETUDIANT,PRENOM_ETUDIANT,GENRE,DATE_NAISS,LIEU_NAISS,TEL_ETUDIANT) " +
                                "VALUES ('" + txtbox_matriEtud.Text + "', '" + txtbox_nomEtud.Text + "', '" + txtbox_prenomEtud.Text + "', '" + Combbox_genreEtud.Text + "', '" + txtbox_datenaissEtud.Text + "', '" + txtbox_lieunaissEtud.Text + "', '" + txtbox_telEtud.Text + "'); select @@identity;";
                var req = new MySqlCommand(reqInsert, sql);
                int last_id = int.Parse(req.ExecuteScalar().ToString());

                var reqInsert2 = "INSERT INTO inscrire (ID_E,ID_N,ID_AN,DATE_INS,BOURSIER,FRAIS_INS,MONTANT_VERSE,MONTANT_REST,NOM_BANQUE) " +
                                 "VALUES ('" + last_id + "', '" + CmboboxNiveau.SelectedValue + "','" + CmboBoxAnnee_Aca.SelectedValue + "', '" + DateTimePickerIns.Text + "', '" + CmboboxBourse.Text + "', '" + CmboBoxFrais_Ins.Text + "', '" + TextBoxMontantV.Text + "', '" + TextBoxMontantR.Text + "', '" + TextBoxBanque.Text + "'); select @@identity";
                var req1 = new MySqlCommand(reqInsert2, sql);
                var last_IdIns = int.Parse(req1.ExecuteScalar().ToString());

                if (MessageBox.Show("Générer le Recu...?", "Inscription Bien Effectuée", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                        var sql1 = "select e.matricule,e.nom_etudiant,e.prenom_etudiant,n.niveau,a.nom_an,i.date_ins,i.frais_ins,i.montant_verse,i.montant_rest,i.nom_banque from etudiant e, annee_aca a, niveau n, inscrire i where e.id_e = i.id_e and n.id_n = i.id_n and a.id_an = i.id_an and id_ins = '" + last_IdIns + "'";
                        var req2 = new MySqlCommand(sql1, sql);

                        var reader = req2.ExecuteReader();
                        if (reader.Read())
                        {
                             ReceptIns R2 = new ReceptIns();
                             R2.labelmat.Text = reader.GetString(0);
                             R2.labelNom.Text = reader.GetString(1);
                             R2.labelPrenom.Text = reader.GetString(2);
                             R2.labelniv.Text = reader.GetString(3);
                             R2.labelaca.Text = reader.GetString(4);
                             R2.labeldateIns.Text = reader.GetString(5);
                             R2.labelfraisIns.Text = reader.GetString(6);
                             R2.labelVers.Text = reader.GetString(7);
                             R2.labelRest.Text = reader.GetString(8);
                             R2.labelbanq.Text = reader.GetString(9);

                             R2.Show();

                        }
                        else
                        {

                        }
             
                }
                else
                {

                }

                clear();

            }
            else
            {
                MessageBox.Show("Inscription non effecutuée, Champs manquants...!");
            }
            sql.Close();
        }

        void clear()
        {
            txtbox_nomEtud.Text = txtbox_prenomEtud.Text = txtbox_datenaissEtud.Text = 
                txtbox_lieunaissEtud.Text = txtbox_matriEtud.Text = Combbox_genreEtud.Text = 
                txtbox_telEtud.Text = DateTimePickerIns.Text = TextBoxMontantV.Text = 
                TextBoxMontantR.Text = TextBoxBanque.Text = "";
            CmboBoxAnnee_Aca.Text = CmboBoxFrais_Ins.Text = CmboboxBourse.Text = 
                CmboboxNiveau.Text = "";
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
