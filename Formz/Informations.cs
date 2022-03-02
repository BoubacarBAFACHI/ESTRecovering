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
using DGVPrinterHelper;

namespace ESTRecovering.Formz
{
    public partial class Informations : Form
    {
        String Con = "datasource=localhost;port=3308; Database=annee; Uid=root; Pwd=17091995#Bb;";
        string O = "OUI";
        string N = "NON";
        int id_ins = 0;

        public Informations()
        {
            InitializeComponent();
        }

        private void Informations_Load(object sender, EventArgs e)
        {
            LoadTheme();
            AnnACAcombo();
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
        }

        private void datstyl()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void AnnACAcombo()
        {
            string query = "select ID_AN,NOM_AN from annee_aca;";
            MySqlDataAdapter da = new MySqlDataAdapter(query, Con);
            DataSet dt = new DataSet();
            da.Fill(dt, "NOM_AN");
            CboBoxAnneeV.DataSource = dt.Tables["NOM_AN"];
            CboBoxAnneeV.DisplayMember = "NOM_AN";
            CboBoxAnneeV.ValueMember = "ID_AN";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            string Query = "select e.matricule,e.nom_etudiant,e.prenom_etudiant,e.genre,n.niveau,i.id_ins,i.boursier from etudiant e, niveau n, inscrire i where e.id_e = i.id_e and n.id_n = i.id_n and id_an = '" + CboBoxAnneeV.SelectedValue + "' and boursier = '" + O + "'";

            using (MySqlConnection SqlCon = new MySqlConnection(Con))
            {
                SqlCon.Open();
                MySqlDataAdapter my = new MySqlDataAdapter(Query, SqlCon);
                DataTable dt = new DataTable();
                my.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = true;

                SqlCon.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            string Query = "select e.matricule,e.nom_etudiant,e.prenom_etudiant,e.genre,n.niveau,i.id_ins,i.boursier from etudiant e, niveau n, inscrire i where e.id_e = i.id_e and n.id_n = i.id_n and id_an = '" + CboBoxAnneeV.SelectedValue + "' and boursier = '" + N + "'";

            using (MySqlConnection SqlCon = new MySqlConnection(Con))
            {
                SqlCon.Open();
                MySqlDataAdapter my = new MySqlDataAdapter(Query, SqlCon);
                DataTable dt = new DataTable();
                my.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = true;

                SqlCon.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            string Query = "select e.matricule,e.nom_etudiant,e.prenom_etudiant,e.genre,n.niveau,i.id_ins,i.Frais_ins from etudiant e, niveau n, inscrire i where e.id_e = i.id_e and n.id_n = i.id_n and id_an = '" + CboBoxAnneeV.SelectedValue + "'";

            using (MySqlConnection SqlCon = new MySqlConnection(Con))
            {
                SqlCon.Open();
                MySqlDataAdapter my = new MySqlDataAdapter(Query, SqlCon);
                DataTable dt = new DataTable();
                my.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = true;

                SqlCon.Close();
            }
        }

        private void ButtonImp_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Année Académique";
            printer.SubTitle = CboBoxAnneeV.Text;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Ecole Supérieure des Télécommunications EST_Niger";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection SqlCon = new MySqlConnection(Con))
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    id_ins = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());

                    SqlCon.Open();
                    var sql = "select i.id_ins,e.nom_etudiant,e.prenom_etudiant from etudiant e, inscrire i where e.id_e = i.id_e and id_ins = '" + id_ins + "'";
                    var req = new MySqlCommand(sql, SqlCon);

                    var reader = req.ExecuteReader();
                    if (reader.Read())
                    {

                        ModifClasseETAnnACA M2 = new ModifClasseETAnnACA();
                        M2.id_ins3 = reader.GetInt32(0);
                        M2.labelNom.Text = reader.GetString(1);
                        M2.labelPrenom.Text = reader.GetString(2);

                        M2.Show();
                    }
                    else

                    {

                    }
                    SqlCon.Close();

                }
            }
        }
    }
}