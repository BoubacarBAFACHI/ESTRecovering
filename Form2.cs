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

namespace ESTRecovering
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            var con_string = "datasource=localhost;port=3308; Database=annee; Uid=root; Pwd=17091995#Bb;";
            var con = new MySqlConnection(con_string);
            con.Open();
            var sql = "select * from user where USERNAME='" + TextBox1.Text + "' and PASSWORD='" + TextBox2.Text + "'";
            var req = new MySqlCommand(sql, con);

            try
            {
                var reader = req.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Utilisateur Authentifier...");
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
                else

                {
                    MessageBox.Show("Utilisateur non Authentifier");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreurs : {ex.Message}");
            }
            con.Close();
            clear();
        }

        void clear()
        {
            TextBox1.Text = TextBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.PasswordChar == '\0')
            {
                button2.BringToFront();
                TextBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TextBox2.PasswordChar == '*')
            {
                button1.BringToFront();
                TextBox2.PasswordChar = '\0';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
