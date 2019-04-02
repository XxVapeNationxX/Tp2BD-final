namespace TP2_ASP.NET
{
    partial class Admin
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
            this.CB_Catégoire = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Question = new System.Windows.Forms.TextBox();
            this.Question_LB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Reponse1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Reponse3 = new System.Windows.Forms.TextBox();
            this.Reponse4 = new System.Windows.Forms.TextBox();
            this.Reponse2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catégorie:";
            // 
            // CB_Catégoire
            // 
            this.CB_Catégoire.FormattingEnabled = true;
            this.CB_Catégoire.Location = new System.Drawing.Point(101, 24);
            this.CB_Catégoire.Name = "CB_Catégoire";
            this.CB_Catégoire.Size = new System.Drawing.Size(235, 21);
            this.CB_Catégoire.TabIndex = 1;
            this.CB_Catégoire.SelectedIndexChanged += new System.EventHandler(this.CB_Catégoire_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question:";
            // 
            // TXT_Question
            // 
            this.TXT_Question.Location = new System.Drawing.Point(101, 60);
            this.TXT_Question.Name = "TXT_Question";
            this.TXT_Question.Size = new System.Drawing.Size(235, 20);
            this.TXT_Question.TabIndex = 3;
            this.TXT_Question.TextChanged += new System.EventHandler(this.TXT_Question_TextChanged);
            this.TXT_Question.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Question_KeyPress);
            // 
            // Question_LB
            // 
            this.Question_LB.FormattingEnabled = true;
            this.Question_LB.Location = new System.Drawing.Point(16, 267);
            this.Question_LB.Name = "Question_LB";
            this.Question_LB.Size = new System.Drawing.Size(320, 212);
            this.Question_LB.TabIndex = 4;
            this.Question_LB.SelectedIndexChanged += new System.EventHandler(this.Question_LB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Questions de la catégoire:";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(261, 206);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 6;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(175, 496);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Supprimer.TabIndex = 7;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Location = new System.Drawing.Point(261, 496);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 8;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Réponse1:";
            // 
            // Reponse1
            // 
            this.Reponse1.Location = new System.Drawing.Point(101, 92);
            this.Reponse1.Name = "Reponse1";
            this.Reponse1.Size = new System.Drawing.Size(235, 20);
            this.Reponse1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 12;
            // 
            // Reponse3
            // 
            this.Reponse3.Location = new System.Drawing.Point(101, 148);
            this.Reponse3.Name = "Reponse3";
            this.Reponse3.Size = new System.Drawing.Size(235, 20);
            this.Reponse3.TabIndex = 13;
            // 
            // Reponse4
            // 
            this.Reponse4.Location = new System.Drawing.Point(101, 175);
            this.Reponse4.Name = "Reponse4";
            this.Reponse4.Size = new System.Drawing.Size(235, 20);
            this.Reponse4.TabIndex = 14;
            // 
            // Reponse2
            // 
            this.Reponse2.AutoSize = true;
            this.Reponse2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reponse2.Location = new System.Drawing.Point(7, 121);
            this.Reponse2.Name = "Reponse2";
            this.Reponse2.Size = new System.Drawing.Size(87, 21);
            this.Reponse2.TabIndex = 15;
            this.Reponse2.Text = "Réponse2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Réponse3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Réponse4:";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(346, 178);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 17);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = "Est Bonne";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox4_MouseClick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(346, 121);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Est Bonne";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox2_MouseClick);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(346, 150);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 17);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "Est Bonne";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox3_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(346, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Est Bonne";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 553);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Reponse2);
            this.Controls.Add(this.Reponse4);
            this.Controls.Add(this.Reponse3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Reponse1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Question_LB);
            this.Controls.Add(this.TXT_Question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Catégoire);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Catégoire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Question;
        private System.Windows.Forms.ListBox Question_LB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Reponse1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Reponse3;
        private System.Windows.Forms.TextBox Reponse4;
        private System.Windows.Forms.Label Reponse2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}