using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filRougeCollege
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCours_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ENSEIGNANT enseignant = new ENSEIGNANT();
            enseignant.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEtudiants_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant();
            etudiant.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir quitter ?","Quitter",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Departement departement = new Departement();
            departement.Show();
            this.Hide();
        }

        private void btnCours_Click_1(object sender, EventArgs e)
        {
            Cours cours = new Cours();
            cours.Show();
            this.Hide();
        }

        private void btnSalles_Click(object sender, EventArgs e)
        {
            Salles salle = new Salles();
            salle.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Accueil ac = new Accueil();
            ac.Show();
            this.Hide();
        }
    }
}
