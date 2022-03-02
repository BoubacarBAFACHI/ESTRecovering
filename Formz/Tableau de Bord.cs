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
    public partial class Tableau_de_Bord : Form
    {
        string con = "datasource=localhost;port=3308; Database=annee; Uid=root; Pwd=17091995#Bb;";
        int ID_AN = 0;
        string H = "H";
        string F = "F";
        public Tableau_de_Bord()
        {
            InitializeComponent();
        }

        private void Tableau_de_Bord_Load(object sender, EventArgs e)
        {
            LoadTheme();
            clear();
            GridFill();
            datstyl();
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
            labelSlectAnnAca.ForeColor = ThemeColor.PrimaryColor;
        }

        private void datstyl()
        {
            dtaGrdViWan.BorderStyle = BorderStyle.None;
            dtaGrdViWan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtaGrdViWan.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtaGrdViWan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtaGrdViWan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtaGrdViWan.BackgroundColor = Color.DimGray;
            dtaGrdViWan.EnableHeadersVisualStyles = false;
            dtaGrdViWan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtaGrdViWan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtaGrdViWan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void GridFill()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(con))
            {
                mySqlCon.Open();
                MySqlDataAdapter my = new MySqlDataAdapter("annee_acaViewAll", mySqlCon);
                my.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                my.Fill(dt);
                dtaGrdViWan.DataSource = dt;
                dtaGrdViWan.Columns[0].Visible = false;
                mySqlCon.Close();
            }
        }

        void clear()
        {
            txtboxannee.Text = "";
            ID_AN = 0;
            btnAdEDanne.Text = "Ajouter Année";
        }

        public void dtaGrdViWan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtaGrdViWan.CurrentRow.Index != -1)
            {
                txtboxannee.Text = dtaGrdViWan.CurrentRow.Cells[1].Value.ToString();
                ID_AN = Convert.ToInt32(dtaGrdViWan.CurrentRow.Cells[0].Value.ToString());
                btnAdEDanne.Text = "Modifer Année";

                using (MySqlConnection mySqlCon = new MySqlConnection(con))
                {
                    mySqlCon.Open();
                    var sql = "select count(*) from etudiant e, inscrire i where i.id_ins = e.id_e and id_an = '" + ID_AN + "'";
                    var req = new MySqlCommand(sql, mySqlCon);

                    var reader = req.ExecuteReader();                
                    if (reader.Read())
                    {
                        label2.Text = reader.GetString(0);
                    }
                    else

                    {

                    }
                    mySqlCon.Close();


                    mySqlCon.Open();
                    var sql1 = "select count(*) from etudiant e, inscrire i where id_ins = e.id_e and genre = '" + H + "' and id_an = '" + ID_AN + "'";
                    var req1 = new MySqlCommand(sql1, mySqlCon);

                    var reader1 = req1.ExecuteReader();
                    if (reader1.Read())
                    {
                        label3.Text = reader1.GetString(0);
                    }
                    else

                    {

                    }
                    mySqlCon.Close();


                    mySqlCon.Open();
                    var sql2 = "select count(*) from etudiant e, inscrire i where id_ins = e.id_e and genre = '"+ F +"' and id_an = '" + ID_AN + "'";
                    var req2 = new MySqlCommand(sql2, mySqlCon);

                    var reader2 = req2.ExecuteReader();
                    if (reader2.Read())
                    {
                        label4.Text = reader2.GetString(0);
                    }
                    else

                    {

                    }
                    mySqlCon.Close();
                }
            }
        }

        private void btnAdEDanne_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(con))
            {
                mySqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("Addannee_acaOrEdit", mySqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_ID_AN", ID_AN);
                mysqlCmd.Parameters.AddWithValue("_NOM_AN", txtboxannee.Text.Trim());
                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Succès Opération..!");
                clear();
                GridFill();
                mySqlCon.Close();
            }
        }

    }
}
