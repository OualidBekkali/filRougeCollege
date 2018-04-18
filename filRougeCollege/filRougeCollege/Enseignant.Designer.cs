namespace filRougeCollege
{
    partial class ENSEIGNANT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ENSEIGNANT));
            this.lblEnseignant = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbEnseignant = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbGerer = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnEtudiants = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbEnseignant.SuspendLayout();
            this.gbGerer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnseignant
            // 
            this.lblEnseignant.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnseignant.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEnseignant.Location = new System.Drawing.Point(126, 9);
            this.lblEnseignant.Name = "lblEnseignant";
            this.lblEnseignant.Size = new System.Drawing.Size(435, 124);
            this.lblEnseignant.TabIndex = 0;
            this.lblEnseignant.Text = "ENSEIGNANT";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.comboBox1.Font = new System.Drawing.Font("Agency FB", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // gbEnseignant
            // 
            this.gbEnseignant.Controls.Add(this.comboBox2);
            this.gbEnseignant.Controls.Add(this.comboBox1);
            this.gbEnseignant.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnseignant.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbEnseignant.Location = new System.Drawing.Point(30, 176);
            this.gbEnseignant.Name = "gbEnseignant";
            this.gbEnseignant.Size = new System.Drawing.Size(271, 344);
            this.gbEnseignant.TabIndex = 2;
            this.gbEnseignant.TabStop = false;
            this.gbEnseignant.Text = "MENU ENSEIGNANT";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.comboBox2.Font = new System.Drawing.Font("Agency FB", 16F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(39, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 2;
            // 
            // gbGerer
            // 
            this.gbGerer.Controls.Add(this.btnSupprimer);
            this.gbGerer.Controls.Add(this.btnModifier);
            this.gbGerer.Controls.Add(this.btnCreer);
            this.gbGerer.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGerer.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbGerer.Location = new System.Drawing.Point(629, 176);
            this.gbGerer.Name = "gbGerer";
            this.gbGerer.Size = new System.Drawing.Size(271, 344);
            this.gbGerer.TabIndex = 3;
            this.gbGerer.TabStop = false;
            this.gbGerer.Text = "GERER";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimer.Location = new System.Drawing.Point(69, 280);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(132, 48);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Location = new System.Drawing.Point(69, 205);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(132, 48);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnCreer
            // 
            this.btnCreer.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCreer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreer.Location = new System.Drawing.Point(69, 61);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(132, 48);
            this.btnCreer.TabIndex = 0;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = false;
            // 
            // btnEtudiants
            // 
            this.btnEtudiants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEtudiants.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtudiants.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEtudiants.Location = new System.Drawing.Point(30, 550);
            this.btnEtudiants.Name = "btnEtudiants";
            this.btnEtudiants.Size = new System.Drawing.Size(144, 49);
            this.btnEtudiants.TabIndex = 7;
            this.btnEtudiants.Text = "<<";
            this.btnEtudiants.UseVisualStyleBackColor = true;
            this.btnEtudiants.Click += new System.EventHandler(this.btnEtudiants_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(756, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "QUITTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnHome.TabIndex = 9;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(775, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 82);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // ENSEIGNANT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(923, 611);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEtudiants);
            this.Controls.Add(this.gbGerer);
            this.Controls.Add(this.gbEnseignant);
            this.Controls.Add(this.lblEnseignant);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "ENSEIGNANT";
            this.Text = "Form2";
            this.gbEnseignant.ResumeLayout(false);
            this.gbGerer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEnseignant;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbEnseignant;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox gbGerer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnEtudiants;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}