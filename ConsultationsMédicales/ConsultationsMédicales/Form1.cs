//Marc-André Dussault gr 427

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultationsMédicales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader readList = new StreamReader("Consultations.txt");
            string ligne = string.Empty;
            while ((ligne = readList.ReadLine()) != null)
            {
                string[] tabLigne = ligne.Split(';');

                dgvConsultations.Rows.Add(tabLigne);

            }
            readList.Close();

            // charge la liste des matricules
            var item1 = new ListViewItem(new[] { "JAD123", "Jaques Dubois"});
            var item2 = new ListViewItem(new[] { "NAH234", "Nassim Hilali" });
            var item3 = new ListViewItem(new[] { "QA567", "Quan" });
            var item4 = new ListViewItem(new[] { "SO9876", "Soulière" });
            lvMatricule.Items.Add(item1);
            lvMatricule.Items.Add(item2);
            lvMatricule.Items.Add(item3);
            lvMatricule.Items.Add(item4);
        }

        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            txtPrenomPatient.Text = "";
            txtNomPatient.Text = "";
            txtNomMedecin.Text = "";
            rbtnSpecialiste.Checked = false;
            rbtnGeneraliste.Checked = false;
            rbtnOui.Checked = false;
            rbtnNon.Checked = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Color whiteRgbColor = new Color();
            whiteRgbColor = Color.FromArgb(255, 255, 255);
            txtPrenomPatient.BackColor = whiteRgbColor;
            txtNomPatient.BackColor = whiteRgbColor;
            txtNomMedecin.BackColor = whiteRgbColor;
            pnlTypeConsul.BackColor = whiteRgbColor;
            pnlUrgence.BackColor = whiteRgbColor;

            Color pinkRgbColor = new Color();
            pinkRgbColor = Color.FromArgb(255, 192, 192);

            if (txtPrenomPatient.Text == "") 
            {
                MessageBox.Show("Veuillez donner le prénom du patient.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrenomPatient.BackColor = pinkRgbColor;
                return;
            }

            if (txtNomPatient.Text == "")
            {
                MessageBox.Show("Veuillez donner le nom du patient.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomPatient.BackColor = pinkRgbColor;
                return;
            }

            if (txtNomMedecin.Text == "")
            {
                MessageBox.Show("Veuillez donner le nom du médecin.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomMedecin.BackColor = pinkRgbColor;
                return;
            }

            if (rbtnGeneraliste.Checked == false && rbtnSpecialiste.Checked == false) 
            {
                MessageBox.Show("Veuillez choisir le type de médecin.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlTypeConsul.BackColor = pinkRgbColor;
                return;
            }

            if (rbtnOui.Checked == false && rbtnNon.Checked == false)
            {
                MessageBox.Show("Veuillez indiquer si il y a urgence ou non.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlUrgence.BackColor = pinkRgbColor;
            }
            string medecinType = pnlTypeConsul.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            string urgence = pnlUrgence.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            dgvConsultations.Rows.Add(txtPrenomPatient.Text, txtNomPatient.Text, txtNomMedecin.Text, medecinType, urgence);

        }

        private void lvMatricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMatricule.SelectedItems.Count > 0)
            {
                txtNomMedecin.Text = lvMatricule.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            TextWriter saveList = new StreamWriter("Consultations.txt");

            for (int i = 0; i < dgvConsultations.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvConsultations.Columns.Count; j++)
                {
                    saveList.Write(dgvConsultations.Rows[i].Cells[j].Value.ToString() + ";");
                }
                saveList.WriteLine("");
            }
            saveList.Close();
            MessageBox.Show("Consultation enregistré.");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvConsultations.Rows.Count == 1)
            {
                MessageBox.Show("Votre liste de consultation est vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNomPatient.Text == "")
            {
                MessageBox.Show("Veuillez donner le nom du patient à retirer de la liste.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtPrenomPatient.Text == "")
            {
                MessageBox.Show("Veuillez donner le prénom du patient à retirer de la liste.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool trouve = false;
            for (int i = 0; i < dgvConsultations.Rows.Count; i++)
            {
                if (dgvConsultations.Rows[i].Cells[0].Value == null || dgvConsultations.Rows[i].Cells[1].Value == null)
                {
                    trouve = false;
                    break;
                }
                if (dgvConsultations.Rows[i].Cells[0].Value.ToString().Equals(txtNomPatient.Text) && dgvConsultations.Rows[i].Cells[1].Value.ToString().Equals(txtPrenomPatient.Text))
                {
                    DialogResult suppression = MessageBox.Show("Voulez vous vraiment faire la suppression ?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (suppression == DialogResult.Yes)
                    {
                        dgvConsultations.Rows.RemoveAt(i);
                        trouve = true;
                        break;
                    }
                }
            }
            if (!trouve)
            {
                MessageBox.Show("Aucune patient ne correspond au nom que vous avez entré.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
