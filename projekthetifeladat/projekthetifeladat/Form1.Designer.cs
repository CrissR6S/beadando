namespace projekthetifeladat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.sor_torlese = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tb_Mev = new System.Windows.Forms.TextBox();
            this.tb_Mmufaj = new System.Windows.Forms.TextBox();
            this.tb_Mcim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.meglevo_modositasa = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tb_Ujev = new System.Windows.Forms.TextBox();
            this.tb_Ujmufaj = new System.Windows.Forms.TextBox();
            this.tb_Ujleiras = new System.Windows.Forms.TextBox();
            this.tb_Ujcim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCim = new System.Windows.Forms.Label();
            this.uj_film_hozzaadasa = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mufaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadas_eve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(1120, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(251, 52);
            this.btnDelete.TabIndex = 88;
            this.btnDelete.Text = "Sor törlése";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // sor_torlese
            // 
            this.sor_torlese.AutoSize = true;
            this.sor_torlese.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sor_torlese.Location = new System.Drawing.Point(1120, 37);
            this.sor_torlese.Name = "sor_torlese";
            this.sor_torlese.Size = new System.Drawing.Size(123, 30);
            this.sor_torlese.TabIndex = 87;
            this.sor_torlese.Text = "Sor törlése:";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(260, 585);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(179, 23);
            this.tb_path.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 15);
            this.label9.TabIndex = 85;
            this.label9.Text = "Borítókép neve + kiterjesztése:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(548, 609);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(243, 48);
            this.btnUpdate.TabIndex = 84;
            this.btnUpdate.Text = "Módosítás";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tb_Mev
            // 
            this.tb_Mev.Location = new System.Drawing.Point(548, 547);
            this.tb_Mev.Name = "tb_Mev";
            this.tb_Mev.Size = new System.Drawing.Size(243, 23);
            this.tb_Mev.TabIndex = 83;
            // 
            // tb_Mmufaj
            // 
            this.tb_Mmufaj.Location = new System.Drawing.Point(552, 500);
            this.tb_Mmufaj.Name = "tb_Mmufaj";
            this.tb_Mmufaj.Size = new System.Drawing.Size(239, 23);
            this.tb_Mmufaj.TabIndex = 82;
            // 
            // tb_Mcim
            // 
            this.tb_Mcim.Location = new System.Drawing.Point(548, 447);
            this.tb_Mcim.Name = "tb_Mcim";
            this.tb_Mcim.Size = new System.Drawing.Size(243, 23);
            this.tb_Mcim.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 80;
            this.label8.Text = "Kiadás éve:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 79;
            this.label7.Text = "Új műfaj:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 78;
            this.label6.Text = "Új cím:";
            // 
            // meglevo_modositasa
            // 
            this.meglevo_modositasa.AutoSize = true;
            this.meglevo_modositasa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.meglevo_modositasa.Location = new System.Drawing.Point(470, 389);
            this.meglevo_modositasa.Name = "meglevo_modositasa";
            this.meglevo_modositasa.Size = new System.Drawing.Size(220, 30);
            this.meglevo_modositasa.TabIndex = 77;
            this.meglevo_modositasa.Text = "Meglévő módosítása:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(210, 617);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(230, 41);
            this.btnInsert.TabIndex = 76;
            this.btnInsert.Text = "Film hozzáadása";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tb_Ujev
            // 
            this.tb_Ujev.Location = new System.Drawing.Point(210, 549);
            this.tb_Ujev.Name = "tb_Ujev";
            this.tb_Ujev.Size = new System.Drawing.Size(229, 23);
            this.tb_Ujev.TabIndex = 75;
            // 
            // tb_Ujmufaj
            // 
            this.tb_Ujmufaj.Location = new System.Drawing.Point(210, 506);
            this.tb_Ujmufaj.Name = "tb_Ujmufaj";
            this.tb_Ujmufaj.Size = new System.Drawing.Size(229, 23);
            this.tb_Ujmufaj.TabIndex = 74;
            // 
            // tb_Ujleiras
            // 
            this.tb_Ujleiras.Location = new System.Drawing.Point(212, 465);
            this.tb_Ujleiras.Name = "tb_Ujleiras";
            this.tb_Ujleiras.Size = new System.Drawing.Size(227, 23);
            this.tb_Ujleiras.TabIndex = 73;
            // 
            // tb_Ujcim
            // 
            this.tb_Ujcim.Location = new System.Drawing.Point(212, 430);
            this.tb_Ujcim.Name = "tb_Ujcim";
            this.tb_Ujcim.Size = new System.Drawing.Size(227, 23);
            this.tb_Ujcim.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Kiadás éve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 70;
            this.label4.Text = "Műfaja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 69;
            this.label3.Text = "Rövid ismertető:";
            // 
            // txtCim
            // 
            this.txtCim.AutoSize = true;
            this.txtCim.Location = new System.Drawing.Point(79, 433);
            this.txtCim.Name = "txtCim";
            this.txtCim.Size = new System.Drawing.Size(32, 15);
            this.txtCim.TabIndex = 68;
            this.txtCim.Text = "Cím:";
            // 
            // uj_film_hozzaadasa
            // 
            this.uj_film_hozzaadasa.AutoSize = true;
            this.uj_film_hozzaadasa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uj_film_hozzaadasa.Location = new System.Drawing.Point(79, 386);
            this.uj_film_hozzaadasa.Name = "uj_film_hozzaadasa";
            this.uj_film_hozzaadasa.Size = new System.Drawing.Size(197, 30);
            this.uj_film_hozzaadasa.TabIndex = 67;
            this.uj_film_hozzaadasa.Text = "Új film hozzáadása:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cime,
            this.mufaja,
            this.kiadas_eve});
            this.dgv.Location = new System.Drawing.Point(332, 13);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(742, 358);
            this.dgv.TabIndex = 66;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // cime
            // 
            this.cime.HeaderText = "Címe";
            this.cime.Name = "cime";
            this.cime.Width = 200;
            // 
            // mufaja
            // 
            this.mufaja.HeaderText = "Műfaja";
            this.mufaja.Name = "mufaja";
            this.mufaja.Width = 200;
            // 
            // kiadas_eve
            // 
            this.kiadas_eve.HeaderText = "Kiadás éve";
            this.kiadas_eve.Name = "kiadas_eve";
            this.kiadas_eve.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 670);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.sor_torlese);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tb_Mev);
            this.Controls.Add(this.tb_Mmufaj);
            this.Controls.Add(this.tb_Mcim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.meglevo_modositasa);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tb_Ujev);
            this.Controls.Add(this.tb_Ujmufaj);
            this.Controls.Add(this.tb_Ujleiras);
            this.Controls.Add(this.tb_Ujcim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCim);
            this.Controls.Add(this.uj_film_hozzaadasa);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnDelete;
        private Label sor_torlese;
        private TextBox tb_path;
        private Label label9;
        private Button btnUpdate;
        private TextBox tb_Mev;
        private TextBox tb_Mmufaj;
        private TextBox tb_Mcim;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label meglevo_modositasa;
        private Button btnInsert;
        private TextBox tb_Ujev;
        private TextBox tb_Ujmufaj;
        private TextBox tb_Ujleiras;
        private TextBox tb_Ujcim;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label txtCim;
        private Label uj_film_hozzaadasa;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cime;
        private DataGridViewTextBoxColumn mufaja;
        private DataGridViewTextBoxColumn kiadas_eve;
    }
}