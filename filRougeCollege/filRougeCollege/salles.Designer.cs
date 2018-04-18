namespace filRougeCollege
{
    partial class Salles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salles));
            this.btnHome = new System.Windows.Forms.Button();
            this.lblSalles = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnEtudiants = new System.Windows.Forms.Button();
            this.btnAjouterSalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // lblSalles
            // 
            this.lblSalles.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalles.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblSalles.Location = new System.Drawing.Point(158, 1);
            this.lblSalles.Name = "lblSalles";
            this.lblSalles.Size = new System.Drawing.Size(366, 124);
            this.lblSalles.TabIndex = 12;
            this.lblSalles.Text = "SALLES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(721, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 78);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Location = new System.Drawing.Point(48, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 307);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU SALLES";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Agency FB", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAjouterSalle);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Location = new System.Drawing.Point(686, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 307);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GERER";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SteelBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Agency FB", 24F);
            this.button7.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button7.Location = new System.Drawing.Point(24, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 48);
            this.button7.TabIndex = 8;
            this.button7.Text = "Supprimer";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Agency FB", 24F);
            this.button5.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button5.Location = new System.Drawing.Point(24, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "Modifier";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Agency FB", 24F);
            this.button4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button4.Location = new System.Drawing.Point(24, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 48);
            this.button4.TabIndex = 4;
            this.button4.Text = "Créer";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button6.Location = new System.Drawing.Point(735, 540);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 49);
            this.button6.TabIndex = 17;
            this.button6.Text = "QUITTER";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnEtudiants
            // 
            this.btnEtudiants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEtudiants.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtudiants.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnEtudiants.Location = new System.Drawing.Point(57, 540);
            this.btnEtudiants.Name = "btnEtudiants";
            this.btnEtudiants.Size = new System.Drawing.Size(144, 49);
            this.btnEtudiants.TabIndex = 18;
            this.btnEtudiants.Text = "<<";
            this.btnEtudiants.UseVisualStyleBackColor = true;
            this.btnEtudiants.Click += new System.EventHandler(this.btnEtudiants_Click);
            // 
            // btnAjouterSalle
            // 
            this.btnAjouterSalle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjouterSalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterSalle.Font = new System.Drawing.Font("Agency FB", 24F);
            this.btnAjouterSalle.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnAjouterSalle.Location = new System.Drawing.Point(24, 108);
            this.btnAjouterSalle.Name = "btnAjouterSalle";
            this.btnAjouterSalle.Size = new System.Drawing.Size(132, 48);
            this.btnAjouterSalle.TabIndex = 9;
            this.btnAjouterSalle.Text = "Ajouter";
            this.btnAjouterSalle.UseVisualStyleBackColor = false;
            this.btnAjouterSalle.Visible = false;
            // 
            // Salles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(923, 611);
            this.Controls.Add(this.btnEtudiants);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSalles);
            this.Controls.Add(this.btnHome);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Salles";
            this.Text = "salles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblSalles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEtudiants;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAjouterSalle;
    }
}