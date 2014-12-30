namespace CompetencePlus.PackageFormateurs
{
    partial class FormGestionFormateur
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
            this.components = new System.ComponentModel.Container();
            this.BtAjouter = new System.Windows.Forms.Button();
            this.btFin = new System.Windows.Forms.Button();
            this.BtSuivant = new System.Windows.Forms.Button();
            this.btPrecedent = new System.Windows.Forms.Button();
            this.btDebut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FormateurdataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtRechercher = new System.Windows.Forms.Button();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labMataricule = new System.Windows.Forms.Label();
            this.labPrenom = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletepng = new System.Windows.Forms.DataGridViewImageColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormateurdataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formateurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtAjouter
            // 
            this.BtAjouter.Location = new System.Drawing.Point(736, 34);
            this.BtAjouter.Name = "BtAjouter";
            this.BtAjouter.Size = new System.Drawing.Size(75, 23);
            this.BtAjouter.TabIndex = 15;
            this.BtAjouter.Text = "Ajouter ";
            this.BtAjouter.UseVisualStyleBackColor = true;
            this.BtAjouter.Click += new System.EventHandler(this.BtAjouter_Click);
            // 
            // btFin
            // 
            this.btFin.Location = new System.Drawing.Point(598, 317);
            this.btFin.Name = "btFin";
            this.btFin.Size = new System.Drawing.Size(75, 23);
            this.btFin.TabIndex = 14;
            this.btFin.Text = ">>";
            this.btFin.UseVisualStyleBackColor = true;
            this.btFin.Click += new System.EventHandler(this.btFin_Click);
            // 
            // BtSuivant
            // 
            this.BtSuivant.Location = new System.Drawing.Point(507, 317);
            this.BtSuivant.Name = "BtSuivant";
            this.BtSuivant.Size = new System.Drawing.Size(75, 23);
            this.BtSuivant.TabIndex = 13;
            this.BtSuivant.Text = ">";
            this.BtSuivant.UseVisualStyleBackColor = true;
            this.BtSuivant.Click += new System.EventHandler(this.BtSuivant_Click);
            // 
            // btPrecedent
            // 
            this.btPrecedent.Location = new System.Drawing.Point(391, 317);
            this.btPrecedent.Name = "btPrecedent";
            this.btPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btPrecedent.TabIndex = 12;
            this.btPrecedent.Text = "<";
            this.btPrecedent.UseVisualStyleBackColor = true;
            this.btPrecedent.Click += new System.EventHandler(this.btPrecedent_Click);
            // 
            // btDebut
            // 
            this.btDebut.Location = new System.Drawing.Point(284, 317);
            this.btDebut.Name = "btDebut";
            this.btDebut.Size = new System.Drawing.Size(75, 23);
            this.btDebut.TabIndex = 11;
            this.btDebut.Text = "<<";
            this.btDebut.UseVisualStyleBackColor = true;
            this.btDebut.Click += new System.EventHandler(this.btDebut_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FormateurdataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(265, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 248);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste Formateur";
            // 
            // FormateurdataGridView1
            // 
            this.FormateurdataGridView1.AutoGenerateColumns = false;
            this.FormateurdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormateurdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.Column3,
            this.Deletepng,
            this.Update});
            this.FormateurdataGridView1.DataSource = this.formateurBindingSource;
            this.FormateurdataGridView1.Location = new System.Drawing.Point(6, 41);
            this.FormateurdataGridView1.Name = "FormateurdataGridView1";
            this.FormateurdataGridView1.Size = new System.Drawing.Size(529, 145);
            this.FormateurdataGridView1.TabIndex = 0;
            this.FormateurdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FormateurdataGridView1_CellClick);
            this.FormateurdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FormateurdataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtRechercher);
            this.groupBox2.Controls.Add(this.txtMatricule);
            this.groupBox2.Controls.Add(this.txtPrenom);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 151);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rechercher Formateur";
            // 
            // BtRechercher
            // 
            this.BtRechercher.Location = new System.Drawing.Point(97, 122);
            this.BtRechercher.Name = "BtRechercher";
            this.BtRechercher.Size = new System.Drawing.Size(75, 23);
            this.BtRechercher.TabIndex = 6;
            this.BtRechercher.Text = "Rechercher";
            this.BtRechercher.UseVisualStyleBackColor = true;
            this.BtRechercher.Click += new System.EventHandler(this.BtRechercher_Click);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(78, 86);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(152, 20);
            this.txtMatricule.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(78, 56);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(152, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(78, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(152, 20);
            this.txtNom.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Matricule :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Prenom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nom :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labMataricule);
            this.groupBox1.Controls.Add(this.labPrenom);
            this.groupBox1.Controls.Add(this.labNom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formateur";
            // 
            // labMataricule
            // 
            this.labMataricule.AutoSize = true;
            this.labMataricule.Location = new System.Drawing.Point(164, 72);
            this.labMataricule.Name = "labMataricule";
            this.labMataricule.Size = new System.Drawing.Size(35, 13);
            this.labMataricule.TabIndex = 6;
            this.labMataricule.Text = "label6";
            // 
            // labPrenom
            // 
            this.labPrenom.AutoSize = true;
            this.labPrenom.Location = new System.Drawing.Point(164, 46);
            this.labPrenom.Name = "labPrenom";
            this.labPrenom.Size = new System.Drawing.Size(35, 13);
            this.labPrenom.TabIndex = 5;
            this.labPrenom.Text = "label5";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(152, 20);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(47, 13);
            this.labNom.TabIndex = 4;
            this.labNom.Text = "    label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matricule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formateurBindingSource
            // 
            this.formateurBindingSource.DataSource = typeof(CompetencePlus.PackageFormateurs.Formateur);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Matricule";
            this.Column3.HeaderText = "Matricule ";
            this.Column3.Name = "Column3";
            // 
            // Deletepng
            // 
            this.Deletepng.HeaderText = "";
            this.Deletepng.Name = "Deletepng";
            // 
            // Update
            // 
            this.Update.HeaderText = "";
            this.Update.Name = "Update";
            // 
            // FormGestionFormateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 374);
            this.Controls.Add(this.BtAjouter);
            this.Controls.Add(this.btFin);
            this.Controls.Add(this.BtSuivant);
            this.Controls.Add(this.btPrecedent);
            this.Controls.Add(this.btDebut);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestionFormateur";
            this.Text = "FormGestionFormateur";
            this.Load += new System.EventHandler(this.FormGestionFormateur_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormateurdataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formateurBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtAjouter;
        private System.Windows.Forms.Button btFin;
        private System.Windows.Forms.Button BtSuivant;
        private System.Windows.Forms.Button btPrecedent;
        private System.Windows.Forms.Button btDebut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView FormateurdataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtRechercher;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labMataricule;
        private System.Windows.Forms.Label labPrenom;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Deletepng;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.BindingSource formateurBindingSource;
    }
}