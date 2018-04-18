namespace filRougeCollege
{
    partial class Departement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departement));
            this.lblDepartement = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.gbMenuEtudiant = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbGerer = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEtudiants = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gbMenuEtudiant.SuspendLayout();
            this.gbGerer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepartement
            // 
            this.lblDepartement.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartement.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblDepartement.Location = new System.Drawing.Point(126, 9);
            this.lblDepartement.Name = "lblDepartement";
            this.lblDepartement.Size = new System.Drawing.Size(538, 124);
            this.lblDepartement.TabIndex = 2;
            this.lblDepartement.Text = "DEPARTEMENTS";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 113);
            this.btnHome.TabIndex = 11;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // gbMenuEtudiant
            // 
            this.gbMenuEtudiant.Controls.Add(this.textBox1);
            this.gbMenuEtudiant.Controls.Add(this.comboBox1);
            this.gbMenuEtudiant.Font = new System.Drawing.Font("Agency FB", 24F);
            this.gbMenuEtudiant.ForeColor = System.Drawing.Color.LemonChiffon;
            this.gbMenuEtudiant.Location = new System.Drawing.Point(50, 182);
            this.gbMenuEtudiant.Name = "gbMenuEtudiant";
            this.gbMenuEtudiant.Size = new System.Drawing.Size(194, 343);
            this.gbMenuEtudiant.TabIndex = 12;
            this.gbMenuEtudiant.TabStop = false;
            this.gbMenuEtudiant.Text = "DEPARTEMENTS";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Agency FB", 16F);
            this.textBox1.Location = new System.Drawing.Point(24, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 33);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.comboBox1.Font = new System.Drawing.Font("Agency FB", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // gbGerer
            // 
            this.gbGerer.Controls.Add(this.button5);
            this.gbGerer.Controls.Add(this.button4);
            this.gbGerer.Controls.Add(this.button3);
            this.gbGerer.Font = new System.Drawing.Font("Agency FB", 24F);
            this.gbGerer.ForeColor = System.Drawing.Color.LemonChiffon;
            this.gbGerer.Location = new System.Drawing.Point(688, 182);
            this.gbGerer.Name = "gbGerer";
            this.gbGerer.Size = new System.Drawing.Size(194, 337);
            this.gbGerer.TabIndex = 13;
            this.gbGerer.TabStop = false;
            this.gbGerer.Text = "GERER";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button5.Location = new System.Drawing.Point(31, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "Supprimer";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button4.Location = new System.Drawing.Point(31, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Créer";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button3.Location = new System.Drawing.Point(31, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnEtudiants
            // 
            this.btnEtudiants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEtudiants.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtudiants.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnEtudiants.Location = new System.Drawing.Point(50, 550);
            this.btnEtudiants.Name = "btnEtudiants";
            this.btnEtudiants.Size = new System.Drawing.Size(144, 49);
            this.btnEtudiants.TabIndex = 16;
            this.btnEtudiants.Text = "<<";
            this.btnEtudiants.UseVisualStyleBackColor = true;
            this.btnEtudiants.Click += new System.EventHandler(this.btnEtudiants_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button6.Location = new System.Drawing.Point(738, 549);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 49);
            this.button6.TabIndex = 17;
            this.button6.Text = "QUITTER";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Departement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(923, 611);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnEtudiants);
            this.Controls.Add(this.gbGerer);
            this.Controls.Add(this.gbMenuEtudiant);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblDepartement);
            this.Name = "Departement";
            this.Text = "departement";
            this.Load += new System.EventHandler(this.departement_Load);
            this.gbMenuEtudiant.ResumeLayout(false);
            this.gbMenuEtudiant.PerformLayout();
            this.gbGerer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDepartement;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox gbMenuEtudiant;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbGerer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEtudiants;
        private System.Windows.Forms.Button button6;
    }
}