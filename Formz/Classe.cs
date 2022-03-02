using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace ESTRecovering.Formz
{
    public partial class Classe : Form

    {
        String sql = "datasource=localhost;port=3308; Database=annee; Uid=root; Pwd=17091995#Bb;";
        int Matri = 0;

        public Classe()
        {
            InitializeComponent();
        }
        

        private void Classe_Load(object sender, EventArgs e)
        {
            LoadTheme();
            AnnACAcombo();
            Niveaucombo();
            Combbox_listeClasse_SelectedIndexChanged(null, null);
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
            MySqlDataAdapter da = new MySqlDataAdapter(query, sql);
            DataSet dt = new DataSet();
            da.Fill(dt, "NOM_AN");
            gunaCboBoxAnnee.DataSource = dt.Tables["NOM_AN"];
            gunaCboBoxAnnee.DisplayMember = "NOM_AN";
            gunaCboBoxAnnee.ValueMember = "ID_AN";

        }

        public void Niveaucombo()
        {

            string query1 = "select ID_N,NIVEAU from niveau;";
            MySqlDataAdapter da = new MySqlDataAdapter(query1, sql);
            DataSet dt = new DataSet();
            da.Fill(dt, "NIVEAU");
            Combbox_listeClasse.DataSource = dt.Tables["NIVEAU"];
            Combbox_listeClasse.DisplayMember = "NIVEAU";
            Combbox_listeClasse.ValueMember = "ID_N";

        }

        public void Combbox_listeClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string Query = "select e.matricule,e.nom_etudiant,e.prenom_etudiant,e.genre,n.niveau from etudiant e, niveau n, inscrire i where e.id_e = i.id_e and n.id_n = i.id_n and id_an = '"+ gunaCboBoxAnnee.SelectedValue +"' and i.id_n = '"+ Combbox_listeClasse.SelectedValue +"'";

            using (MySqlConnection SqlCon = new MySqlConnection(sql))
            {
                SqlCon.Open();
                MySqlDataAdapter my = new MySqlDataAdapter(Query, sql);
                DataTable dt = new DataTable();
                my.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = true;

                SqlCon.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection SqlCon = new MySqlConnection(sql))
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    Matri = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    SqlCon.Open();
                    var sql = "select * from etudiant where matricule = '"+ Matri +"'";
                    var req = new MySqlCommand(sql, SqlCon);

                    var reader = req.ExecuteReader();
                    if (reader.Read())
                    {
                       
                        ModifEtud m2 = new ModifEtud();
                        m2.ID_E = reader.GetInt32(0);
                        m2.txtboxmatriEtud.Text = reader.GetString(1);
                        m2.txtbox_nomEtud.Text = reader.GetString(2);
                        m2.txtbox_prenomEtud.Text = reader.GetString(3);
                        m2.Combbox_genreEtud.Text = reader.GetString(4);
                        m2.txtbox_datenaissEtud.Text = reader.GetString(5);
                        m2.txtbox_lieunaissEtud.Text = reader.GetString(6);
                        m2.txtbox_telEtud.Text = reader.GetString(7);

                        m2.Show();
                    }
                    else

                    {

                    }
                    SqlCon.Close();

                }
            }
        }

        private void ButtonImp_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = Combbox_listeClasse.Text;
            printer.SubTitle = gunaCboBoxAnnee.Text;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Ecole Supérieure des Télécommunications EST_Niger";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);
        }
    }
}
