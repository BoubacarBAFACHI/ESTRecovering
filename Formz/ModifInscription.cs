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
    public partial class ModifInscription : Form
    {
        String sql = "datasource=localhost;port=3308; Database=annee; Uid=root; Pwd=17091995#Bb;";

        public int Id_ins2 { get; set; }

        public ModifInscription()
        {
            InitializeComponent();
        }

        private void ModifInscription_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Enr_Etd_Ins_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(sql))
            {
                try
                {
                    mySqlCon.Open();
                    MySqlCommand mysqlCmd = new MySqlCommand("AddInscriptionOrEdit", mySqlCon);
                    mysqlCmd.CommandType = CommandType.StoredProcedure;
                    mysqlCmd.Parameters.AddWithValue("_ID_INS", Id_ins2);
                    mysqlCmd.Parameters.AddWithValue("_DATE_INS", DateTimePickerIns.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_BOURSIER", CmboboxBourse.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_FRAIS_INS", CmboBoxFrais_Ins.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_MONTANT_VERSE", TextBoxMontantV.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_MONTANT_REST", TextBoxMontantR.Text.Trim());
                    mysqlCmd.Parameters.AddWithValue("_NOM_BANQUE", TextBoxBanque.Text.Trim());
                    mysqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Mise a jour éffectuée avec Succès..!");
                    mySqlCon.Close();

                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Mise a jour non éffectuée..!");

                }
                
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
