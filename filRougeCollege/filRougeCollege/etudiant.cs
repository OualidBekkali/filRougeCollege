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
    public partial class Etudiant : Form
    {
        public Etudiant()
        {
            InitializeComponent();
        }

        private void btnEtudiants_Click(object sender, EventArgs e)
        {
            Accueil ac = new Accueil();
            ac.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir quitter ?", "Quitter", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Accueil ac = new Accueil();
            ac.Show();
            this.Hide();
        }
    }
}
