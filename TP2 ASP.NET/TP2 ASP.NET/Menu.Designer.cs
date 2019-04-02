namespace TP2_ASP.NET
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Joueur1Prenom = new System.Windows.Forms.TextBox();
            this.Joueur2Prenom = new System.Windows.Forms.TextBox();
            this.Joueur3Prenom = new System.Windows.Forms.TextBox();
            this.Joueur4Prenom = new System.Windows.Forms.TextBox();
            this.Joueur1Nom = new System.Windows.Forms.TextBox();
            this.Joueur2Nom = new System.Windows.Forms.TextBox();
            this.Joueur3Nom = new System.Windows.Forms.TextBox();
            this.Joueur4Nom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "TriviaCrook";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP2_ASP.NET.Properties.Resources.Emojione_1F3AE_svg;
            this.pictureBox1.Location = new System.Drawing.Point(459, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Firebrick;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.Start.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(268, 350);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(287, 66);
            this.Start.TabIndex = 2;
            this.Start.Text = "Jouer!";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Joueur 1:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Joueur 2:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Joueur 3:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Joueur 4:";
            // 
            // Joueur1Prenom
            // 
            this.Joueur1Prenom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur1Prenom.Location = new System.Drawing.Point(250, 140);
            this.Joueur1Prenom.Name = "Joueur1Prenom";
            this.Joueur1Prenom.Size = new System.Drawing.Size(147, 29);
            this.Joueur1Prenom.TabIndex = 8;
            this.Joueur1Prenom.TextChanged += new System.EventHandler(this.Menu_TextChanged);
            this.Joueur1Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            // 
            // Joueur2Prenom
            // 
            this.Joueur2Prenom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur2Prenom.Location = new System.Drawing.Point(250, 187);
            this.Joueur2Prenom.Name = "Joueur2Prenom";
            this.Joueur2Prenom.Size = new System.Drawing.Size(147, 29);
            this.Joueur2Prenom.TabIndex = 9;
            this.Joueur2Prenom.TextChanged += new System.EventHandler(this.Menu_TextChanged);
            this.Joueur2Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            // 
            // Joueur3Prenom
            // 
            this.Joueur3Prenom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur3Prenom.Location = new System.Drawing.Point(250, 238);
            this.Joueur3Prenom.Name = "Joueur3Prenom";
            this.Joueur3Prenom.Size = new System.Drawing.Size(147, 29);
            this.Joueur3Prenom.TabIndex = 10;
            this.Joueur3Prenom.TextChanged += new System.EventHandler(this.Menu_TextChanged);
            this.Joueur3Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            // 
            // Joueur4Prenom
            // 
            this.Joueur4Prenom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur4Prenom.Location = new System.Drawing.Point(250, 289);
            this.Joueur4Prenom.Name = "Joueur4Prenom";
            this.Joueur4Prenom.Size = new System.Drawing.Size(147, 29);
            this.Joueur4Prenom.TabIndex = 11;
            this.Joueur4Prenom.TextChanged += new System.EventHandler(this.Menu_TextChanged);
            this.Joueur4Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            // 
            // Joueur1Nom
            // 
            this.Joueur1Nom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur1Nom.Location = new System.Drawing.Point(423, 140);
            this.Joueur1Nom.Name = "Joueur1Nom";
            this.Joueur1Nom.Size = new System.Drawing.Size(153, 29);
            this.Joueur1Nom.TabIndex = 12;
            this.Joueur1Nom.TextChanged += new System.EventHandler(this.Menu_TextChanged);
            this.Joueur1Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            // 
            // Joueur2Nom
            // 
            this.Joueur2Nom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur2Nom.Location = new System.Drawing.Point(423, 188);
            this.Joueur2Nom.Name = "Joueur2Nom";
            this.Joueur2Nom.Size = new System.Drawing.Size(153, 29);
            this.Joueur2Nom.TabIndex = 13;
            this.Joueur2Nom.TextChanged += new System.EventHandler(this.Menu_TextChanged);
            this.Joueur2Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            // 
            // Joueur3Nom
            // 
            this.Joueur3Nom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur3Nom.Location = new System.Drawing.Point(423, 239);
            this.Joueur3Nom.Name = "Joueur3Nom";
            this.Joueur3Nom.Size = new System.Drawing.Size(153, 29);
            this.Joueur3Nom.TabIndex = 14;
            this.Joueur3Nom.TextChanged += new System.EventHandler(this.Menu_TextChanged);
            this.Joueur3Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            // 
            // Joueur4Nom
            // 
            this.Joueur4Nom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur4Nom.Location = new System.Drawing.Point(423, 290);
            this.Joueur4Nom.Name = "Joueur4Nom";
            this.Joueur4Nom.Size = new System.Drawing.Size(153, 29);
            this.Joueur4Nom.TabIndex = 15;
            this.Joueur4Nom.TextChanged += new System.EventHandler(this.Menu_TextChanged);
            this.Joueur4Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Menu_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "Prenom";
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Firebrick;
            this.Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.Admin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(703, 12);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(85, 49);
            this.Admin.TabIndex = 18;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Joueur4Nom);
            this.Controls.Add(this.Joueur3Nom);
            this.Controls.Add(this.Joueur2Nom);
            this.Controls.Add(this.Joueur1Nom);
            this.Controls.Add(this.Joueur4Prenom);
            this.Controls.Add(this.Joueur3Prenom);
            this.Controls.Add(this.Joueur2Prenom);
            this.Controls.Add(this.Joueur1Prenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Joueur1Prenom;
        private System.Windows.Forms.TextBox Joueur2Prenom;
        private System.Windows.Forms.TextBox Joueur3Prenom;
        private System.Windows.Forms.TextBox Joueur4Prenom;
        private System.Windows.Forms.TextBox Joueur1Nom;
        private System.Windows.Forms.TextBox Joueur2Nom;
        private System.Windows.Forms.TextBox Joueur3Nom;
        private System.Windows.Forms.TextBox Joueur4Nom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Admin;
    }
}