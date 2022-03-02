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
    public partial class ModifClasseETAnnACA : Form
    {
        string sql = "datasource=localhost;port=3308; Database=annee; Uid=root; Pwd=17091995#Bb;";

        public int id_ins3 { get; set; }

        public ModifClasseETAnnACA()
        {
            InitializeComponent();
        }

        private void ModifClasseETAnnACA_Load(object sender, EventArgs e)
        {
            AnnACAcombo();
            Niveaucombo();
        }

        private void AnnACAcombo()
        {
            string query = "select ID_AN,NOM_AN from annee_aca;";
            MySqlDataAdapter da = new MySqlDataAdapter(query, sql);
            DataSet dt = new DataSet();
            da.Fill(dt, "NOM_AN");
            boBoxAnnee.DataSource = dt.Tables["NOM_AN"];
            boBoxAnnee.DisplayMember = "NOM_AN";
            boBoxAnnee.ValueMember = "ID_AN";

        }

        private void Niveaucombo()
        {
            string query1 = "select ID_N,NIVEAU from niveau;";
            MySqlDataAdapter da = new MySqlDataAdapter(query1, sql);
            DataSet dt = new DataSet();
            da.Fill(dt, "NIVEAU");
            listeClasse.DataSource = dt.Tables["NIVEAU"];
            listeClasse.DisplayMember = "NIVEAU";
            listeClasse.ValueMember = "ID_N";

        }


        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enr_Etd_Ins_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(sql))
            {
                try
                {
                    mySqlCon.Open();
                    MySqlCommand mysqlCmd = new MySqlCommand("Modifclass", mySqlCon);
                    mysqlCmd.CommandType = CommandType.StoredProcedure;
                    mysqlCmd.Parameters.AddWithValue("_ID_INS", id_ins3);
                    mysqlCmd.Parameters.AddWithValue("_ID_AN", boBoxAnnee.SelectedValue.ToString());
                    mysqlCmd.Parameters.AddWithValue("_ID_N", listeClasse.SelectedValue.ToString());
                    mysqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Mise a jour éffectuée avec Succès..!");

                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Mise a jour non éffectuée..!");

                }
                mySqlCon.Close();
            }

        }

    }

}
