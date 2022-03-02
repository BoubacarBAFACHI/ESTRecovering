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
    public partial class ModifEtud : Form
    {
        string con = "datasource=localhost;port=3308; Database=annee; Uid=root; Pwd=17091995#Bb;";

        public int ID_E { get; set; }
        public ModifEtud()
        {
            InitializeComponent();
        }

        private void ModifEtud_Load(object sender, EventArgs e)
        {

        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(con))
            {
                try
                {
                    mySqlCon.Open();
                    MySqlCommand mysqlCmd = new MySqlCommand("InscriptionDeletebyID", mySqlCon);
                    mysqlCmd.CommandType = CommandType.StoredProcedure;
                    mysqlCmd.Parameters.AddWithValue("_ID_INS", ID_E);
                    mysqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Suppression éffectuée avec Succès..!");
                    mySqlCon.Close();

                    this.Close();
                }
                catch
                {
                MessageBox.Show("Suppression non éffectuée..!");

                }

            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enr_Etd_Ins_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(con))
            {
                try
                {
                    mySqlCon.Open();
                    MySqlCommand mysqlCmd = new MySqlCommand("AddetudiantOrEdit", mySqlCon);
                    mysqlCmd.CommandType = CommandType.StoredProcedure;
                    mysqlCmd.Parameters.AddWithValue("_ID_E", ID_E);
                    mysqlCmd.Parameters.AddWithValue("_MATRICULE", txtboxmatriEtud.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_NOM_ETUDIANT", txtbox_nomEtud.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_PRENOM_ETUDIANT", txtbox_prenomEtud.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_GENRE", Combbox_genreEtud.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_DATE_NAISS", txtbox_datenaissEtud.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_LIEU_NAISS", txtbox_lieunaissEtud.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_TEL_ETUDIANT", txtbox_telEtud.Text.Trim());
                    mysqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Mise a jour éffectuée avec Succès..!");

                    mySqlCon.Close();
                }
                catch
                {
                    MessageBox.Show("Mise a jour non éffectuée..!");

                }
                this.Close();
            }
        }
    }
}
