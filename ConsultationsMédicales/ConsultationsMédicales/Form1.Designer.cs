
namespace ConsultationsMédicales
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvConsultations = new System.Windows.Forms.DataGridView();
            this.lblNomPatient = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblPrenomPatient = new System.Windows.Forms.Label();
            this.lblNomMedecin = new System.Windows.Forms.Label();
            this.lblTypeConsul = new System.Windows.Forms.Label();
            this.lblUrgence = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.txtPrenomPatient = new System.Windows.Forms.TextBox();
            this.txtNomPatient = new System.Windows.Forms.TextBox();
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.pnlTypeConsul = new System.Windows.Forms.Panel();
            this.rbtnGeneraliste = new System.Windows.Forms.RadioButton();
            this.rbtnSpecialiste = new System.Windows.Forms.RadioButton();
            this.pnlUrgence = new System.Windows.Forms.Panel();
            this.rbtnNon = new System.Windows.Forms.RadioButton();
            this.rbtnOui = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvMatricule = new System.Windows.Forms.ListView();
            this.colMatricule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenomPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            this.pnlTypeConsul.SuspendLayout();
            this.pnlUrgence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultations
            // 
            this.dgvConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrenomPatient,
            this.colNomPatient,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvConsultations.Location = new System.Drawing.Point(12, 348);
            this.dgvConsultations.Name = "dgvConsultations";
            this.dgvConsultations.Size = new System.Drawing.Size(723, 177);
            this.dgvConsultations.TabIndex = 0;
            // 
            // lblNomPatient
            // 
            this.lblNomPatient.AutoSize = true;
            this.lblNomPatient.Location = new System.Drawing.Point(15, 22);
            this.lblNomPatient.Name = "lblNomPatient";
            this.lblNomPatient.Size = new System.Drawing.Size(85, 13);
            this.lblNomPatient.TabIndex = 1;
            this.lblNomPatient.Text = "Nom du patient: ";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(15, 122);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(111, 13);
            this.lblMatricule.TabIndex = 2;
            this.lblMatricule.Text = "Matricule du médecin:";
            // 
            // lblPrenomPatient
            // 
            this.lblPrenomPatient.AutoSize = true;
            this.lblPrenomPatient.Location = new System.Drawing.Point(15, 54);
            this.lblPrenomPatient.Name = "lblPrenomPatient";
            this.lblPrenomPatient.Size = new System.Drawing.Size(99, 13);
            this.lblPrenomPatient.TabIndex = 3;
            this.lblPrenomPatient.Text = "Prénom du patient: ";
            // 
            // lblNomMedecin
            // 
            this.lblNomMedecin.AutoSize = true;
            this.lblNomMedecin.Location = new System.Drawing.Point(15, 82);
            this.lblNomMedecin.Name = "lblNomMedecin";
            this.lblNomMedecin.Size = new System.Drawing.Size(93, 13);
            this.lblNomMedecin.TabIndex = 4;
            this.lblNomMedecin.Text = "Nom du médecin: ";
            // 
            // lblTypeConsul
            // 
            this.lblTypeConsul.AutoSize = true;
            this.lblTypeConsul.Location = new System.Drawing.Point(15, 256);
            this.lblTypeConsul.Name = "lblTypeConsul";
            this.lblTypeConsul.Size = new System.Drawing.Size(109, 13);
            this.lblTypeConsul.TabIndex = 5;
            this.lblTypeConsul.Text = "Type de consultation:";
            // 
            // lblUrgence
            // 
            this.lblUrgence.AutoSize = true;
            this.lblUrgence.Location = new System.Drawing.Point(15, 308);
            this.lblUrgence.Name = "lblUrgence";
            this.lblUrgence.Size = new System.Drawing.Size(51, 13);
            this.lblUrgence.TabIndex = 6;
            this.lblUrgence.Text = "Urgence:";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(365, 16);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 23);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.Location = new System.Drawing.Point(365, 51);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(100, 23);
            this.btnInitialiser.TabIndex = 9;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = true;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(635, 321);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 23);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(529, 321);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(100, 23);
            this.btnSauvegarder.TabIndex = 11;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // txtPrenomPatient
            // 
            this.txtPrenomPatient.Location = new System.Drawing.Point(138, 51);
            this.txtPrenomPatient.Name = "txtPrenomPatient";
            this.txtPrenomPatient.Size = new System.Drawing.Size(200, 20);
            this.txtPrenomPatient.TabIndex = 12;
            // 
            // txtNomPatient
            // 
            this.txtNomPatient.Location = new System.Drawing.Point(138, 19);
            this.txtNomPatient.Name = "txtNomPatient";
            this.txtNomPatient.Size = new System.Drawing.Size(200, 20);
            this.txtNomPatient.TabIndex = 13;
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.Enabled = false;
            this.txtNomMedecin.Location = new System.Drawing.Point(138, 82);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.Size = new System.Drawing.Size(200, 20);
            this.txtNomMedecin.TabIndex = 14;
            // 
            // pnlTypeConsul
            // 
            this.pnlTypeConsul.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlTypeConsul.Controls.Add(this.rbtnSpecialiste);
            this.pnlTypeConsul.Controls.Add(this.rbtnGeneraliste);
            this.pnlTypeConsul.Location = new System.Drawing.Point(138, 256);
            this.pnlTypeConsul.Name = "pnlTypeConsul";
            this.pnlTypeConsul.Size = new System.Drawing.Size(200, 23);
            this.pnlTypeConsul.TabIndex = 15;
            // 
            // rbtnGeneraliste
            // 
            this.rbtnGeneraliste.AutoSize = true;
            this.rbtnGeneraliste.Location = new System.Drawing.Point(4, 3);
            this.rbtnGeneraliste.Name = "rbtnGeneraliste";
            this.rbtnGeneraliste.Size = new System.Drawing.Size(78, 17);
            this.rbtnGeneraliste.TabIndex = 0;
            this.rbtnGeneraliste.TabStop = true;
            this.rbtnGeneraliste.Text = "Généraliste";
            this.rbtnGeneraliste.UseVisualStyleBackColor = true;
            // 
            // rbtnSpecialiste
            // 
            this.rbtnSpecialiste.AutoSize = true;
            this.rbtnSpecialiste.Location = new System.Drawing.Point(101, 3);
            this.rbtnSpecialiste.Name = "rbtnSpecialiste";
            this.rbtnSpecialiste.Size = new System.Drawing.Size(76, 17);
            this.rbtnSpecialiste.TabIndex = 16;
            this.rbtnSpecialiste.TabStop = true;
            this.rbtnSpecialiste.Text = "Spécialiste";
            this.rbtnSpecialiste.UseVisualStyleBackColor = true;
            // 
            // pnlUrgence
            // 
            this.pnlUrgence.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlUrgence.Controls.Add(this.rbtnNon);
            this.pnlUrgence.Controls.Add(this.rbtnOui);
            this.pnlUrgence.Location = new System.Drawing.Point(138, 298);
            this.pnlUrgence.Name = "pnlUrgence";
            this.pnlUrgence.Size = new System.Drawing.Size(200, 23);
            this.pnlUrgence.TabIndex = 17;
            // 
            // rbtnNon
            // 
            this.rbtnNon.AutoSize = true;
            this.rbtnNon.Location = new System.Drawing.Point(60, 3);
            this.rbtnNon.Name = "rbtnNon";
            this.rbtnNon.Size = new System.Drawing.Size(45, 17);
            this.rbtnNon.TabIndex = 16;
            this.rbtnNon.TabStop = true;
            this.rbtnNon.Text = "Non";
            this.rbtnNon.UseVisualStyleBackColor = true;
            // 
            // rbtnOui
            // 
            this.rbtnOui.AutoSize = true;
            this.rbtnOui.Location = new System.Drawing.Point(4, 3);
            this.rbtnOui.Name = "rbtnOui";
            this.rbtnOui.Size = new System.Drawing.Size(41, 17);
            this.rbtnOui.TabIndex = 0;
            this.rbtnOui.TabStop = true;
            this.rbtnOui.Text = "Oui";
            this.rbtnOui.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsultationsMédicales.Properties.Resources._415;
            this.pictureBox1.Location = new System.Drawing.Point(486, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lvMatricule
            // 
            this.lvMatricule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMatricule,
            this.colNomMedecin});
            this.lvMatricule.HideSelection = false;
            this.lvMatricule.Location = new System.Drawing.Point(138, 120);
            this.lvMatricule.MultiSelect = false;
            this.lvMatricule.Name = "lvMatricule";
            this.lvMatricule.Size = new System.Drawing.Size(200, 118);
            this.lvMatricule.TabIndex = 19;
            this.lvMatricule.UseCompatibleStateImageBehavior = false;
            this.lvMatricule.View = System.Windows.Forms.View.Details;
            this.lvMatricule.SelectedIndexChanged += new System.EventHandler(this.lvMatricule_SelectedIndexChanged);
            // 
            // colMatricule
            // 
            this.colMatricule.Text = "Matricule";
            this.colMatricule.Width = 100;
            // 
            // colNomMedecin
            // 
            this.colNomMedecin.Text = "Nom du Médecin";
            this.colNomMedecin.Width = 100;
            // 
            // colPrenomPatient
            // 
            this.colPrenomPatient.HeaderText = "Nom Patient";
            this.colPrenomPatient.Name = "colPrenomPatient";
            this.colPrenomPatient.Width = 150;
            // 
            // colNomPatient
            // 
            this.colNomPatient.HeaderText = "Prénom Patient";
            this.colNomPatient.Name = "colNomPatient";
            this.colNomPatient.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Médecin";
            this.Column2.Name = "Column2";
            this.Column2.Width = 185;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Urgence";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 541);
            this.Controls.Add(this.lvMatricule);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlUrgence);
            this.Controls.Add(this.pnlTypeConsul);
            this.Controls.Add(this.txtNomMedecin);
            this.Controls.Add(this.txtNomPatient);
            this.Controls.Add(this.txtPrenomPatient);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblUrgence);
            this.Controls.Add(this.lblTypeConsul);
            this.Controls.Add(this.lblNomMedecin);
            this.Controls.Add(this.lblPrenomPatient);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblNomPatient);
            this.Controls.Add(this.dgvConsultations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestions des consultations médicales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).EndInit();
            this.pnlTypeConsul.ResumeLayout(false);
            this.pnlTypeConsul.PerformLayout();
            this.pnlUrgence.ResumeLayout(false);
            this.pnlUrgence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultations;
        private System.Windows.Forms.Label lblNomPatient;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblPrenomPatient;
        private System.Windows.Forms.Label lblNomMedecin;
        private System.Windows.Forms.Label lblTypeConsul;
        private System.Windows.Forms.Label lblUrgence;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.TextBox txtPrenomPatient;
        private System.Windows.Forms.TextBox txtNomPatient;
        private System.Windows.Forms.TextBox txtNomMedecin;
        private System.Windows.Forms.Panel pnlTypeConsul;
        private System.Windows.Forms.RadioButton rbtnSpecialiste;
        private System.Windows.Forms.RadioButton rbtnGeneraliste;
        private System.Windows.Forms.Panel pnlUrgence;
        private System.Windows.Forms.RadioButton rbtnNon;
        private System.Windows.Forms.RadioButton rbtnOui;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvMatricule;
        private System.Windows.Forms.ColumnHeader colMatricule;
        private System.Windows.Forms.ColumnHeader colNomMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenomPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

