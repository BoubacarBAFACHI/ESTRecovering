namespace ESTRecovering.Formz
{
    partial class Classe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Combbox_listeClasse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mat_etud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Etud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom_Etud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_Etud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Niveau_Etud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaCboBoxAnnee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ButtonImp = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Combbox_listeClasse
            // 
            this.Combbox_listeClasse.BackColor = System.Drawing.Color.Transparent;
            this.Combbox_listeClasse.BorderColor = System.Drawing.Color.DarkGray;
            this.Combbox_listeClasse.BorderRadius = 10;
            this.Combbox_listeClasse.BorderThickness = 3;
            this.Combbox_listeClasse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combbox_listeClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combbox_listeClasse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combbox_listeClasse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combbox_listeClasse.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combbox_listeClasse.ForeColor = System.Drawing.Color.Black;
            this.Combbox_listeClasse.ItemHeight = 30;
            this.Combbox_listeClasse.Location = new System.Drawing.Point(204, 34);
            this.Combbox_listeClasse.Name = "Combbox_listeClasse";
            this.Combbox_listeClasse.Size = new System.Drawing.Size(336, 36);
            this.Combbox_listeClasse.TabIndex = 30;
            this.Combbox_listeClasse.SelectedIndexChanged += new System.EventHandler(this.Combbox_listeClasse_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(22, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 1);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 49);
            this.label1.TabIndex = 27;
            this.label1.Text = "Liste des élèves de la Classe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mat_etud,
            this.Nom_Etud,
            this.Prenom_Etud,
            this.Genre_Etud,
            this.Niveau_Etud});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(22, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(917, 356);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Mat_etud
            // 
            this.Mat_etud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mat_etud.DataPropertyName = "matricule";
            this.Mat_etud.HeaderText = "Matricule";
            this.Mat_etud.MinimumWidth = 6;
            this.Mat_etud.Name = "Mat_etud";
            this.Mat_etud.ReadOnly = true;
            this.Mat_etud.Width = 105;
            // 
            // Nom_Etud
            // 
            this.Nom_Etud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nom_Etud.DataPropertyName = "nom_etudiant";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_Etud.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nom_Etud.HeaderText = "Nom";
            this.Nom_Etud.MinimumWidth = 6;
            this.Nom_Etud.Name = "Nom_Etud";
            this.Nom_Etud.ReadOnly = true;
            this.Nom_Etud.Width = 220;
            // 
            // Prenom_Etud
            // 
            this.Prenom_Etud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Prenom_Etud.DataPropertyName = "prenom_etudiant";
            this.Prenom_Etud.FillWeight = 12.83423F;
            this.Prenom_Etud.HeaderText = "Prenom";
            this.Prenom_Etud.MinimumWidth = 10;
            this.Prenom_Etud.Name = "Prenom_Etud";
            this.Prenom_Etud.ReadOnly = true;
            this.Prenom_Etud.Width = 200;
            // 
            // Genre_Etud
            // 
            this.Genre_Etud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Genre_Etud.DataPropertyName = "genre";
            this.Genre_Etud.FillWeight = 12.83423F;
            this.Genre_Etud.HeaderText = "Genre";
            this.Genre_Etud.MinimumWidth = 6;
            this.Genre_Etud.Name = "Genre_Etud";
            this.Genre_Etud.ReadOnly = true;
            this.Genre_Etud.Width = 80;
            // 
            // Niveau_Etud
            // 
            this.Niveau_Etud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Niveau_Etud.DataPropertyName = "niveau";
            this.Niveau_Etud.FillWeight = 12.83423F;
            this.Niveau_Etud.HeaderText = "Niveau";
            this.Niveau_Etud.MinimumWidth = 6;
            this.Niveau_Etud.Name = "Niveau_Etud";
            this.Niveau_Etud.ReadOnly = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.BorderThickness = 3;
            this.guna2GroupBox1.Controls.Add(this.gunaCboBoxAnnee);
            this.guna2GroupBox1.Controls.Add(this.Combbox_listeClasse);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(21, 67);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(550, 86);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Choisissez une classe";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(-120, -7);
            // 
            // gunaCboBoxAnnee
            // 
            this.gunaCboBoxAnnee.BackColor = System.Drawing.Color.Transparent;
            this.gunaCboBoxAnnee.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaCboBoxAnnee.BorderRadius = 10;
            this.gunaCboBoxAnnee.BorderThickness = 3;
            this.gunaCboBoxAnnee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaCboBoxAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaCboBoxAnnee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaCboBoxAnnee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaCboBoxAnnee.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCboBoxAnnee.ForeColor = System.Drawing.Color.Black;
            this.gunaCboBoxAnnee.ItemHeight = 30;
            this.gunaCboBoxAnnee.Location = new System.Drawing.Point(10, 34);
            this.gunaCboBoxAnnee.Name = "gunaCboBoxAnnee";
            this.gunaCboBoxAnnee.Size = new System.Drawing.Size(186, 36);
            this.gunaCboBoxAnnee.TabIndex = 31;
            // 
            // ButtonImp
            // 
            this.ButtonImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonImp.BackColor = System.Drawing.Color.Transparent;
            this.ButtonImp.BorderColor = System.Drawing.Color.Gainsboro;
            this.ButtonImp.BorderRadius = 8;
            this.ButtonImp.BorderThickness = 2;
            this.ButtonImp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonImp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonImp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonImp.FillColor = System.Drawing.Color.DarkBlue;
            this.ButtonImp.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImp.ForeColor = System.Drawing.Color.White;
            this.ButtonImp.HoverState.FillColor = System.Drawing.Color.MediumBlue;
            this.ButtonImp.Location = new System.Drawing.Point(727, 549);
            this.ButtonImp.Name = "ButtonImp";
            this.ButtonImp.PressedColor = System.Drawing.Color.Blue;
            this.ButtonImp.PressedDepth = 40;
            this.ButtonImp.Size = new System.Drawing.Size(188, 50);
            this.ButtonImp.TabIndex = 51;
            this.ButtonImp.Text = "Imprimer";
            this.ButtonImp.Click += new System.EventHandler(this.ButtonImp_Click);
            // 
            // Classe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 626);
            this.Controls.Add(this.ButtonImp);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Classe";
            this.Text = "Classe";
            this.Load += new System.EventHandler(this.Classe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox Combbox_listeClasse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox gunaCboBoxAnnee;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mat_etud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Etud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom_Etud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_Etud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Niveau_Etud;
        private Guna.UI2.WinForms.Guna2Button ButtonImp;
    }
}