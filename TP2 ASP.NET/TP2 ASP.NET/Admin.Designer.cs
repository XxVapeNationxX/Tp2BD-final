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
            this.Question_LB.Location = new System.Drawing.Point(16, 155);
            this.Question_LB.Name = "Question_LB";
            this.Question_LB.Size = new System.Drawing.Size(320, 212);
            this.Question_LB.TabIndex = 4;
            this.Question_LB.SelectedIndexChanged += new System.EventHandler(this.Question_LB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Questions de la catégoire:";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(261, 96);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 6;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(180, 373);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Supprimer.TabIndex = 7;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Location = new System.Drawing.Point(261, 373);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 8;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 410);
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
            this.Text = "Supprimer";
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
    }
}