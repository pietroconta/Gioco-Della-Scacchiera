
namespace scacchieragioco
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_pc = new System.Windows.Forms.Label();
            this.lbl_gioc = new System.Windows.Forms.Label();
            this.btn_turnosucc = new System.Windows.Forms.Button();
            this.btn_inizia = new System.Windows.Forms.Button();
            this.tab_s = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tab_s)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pc
            // 
            this.lbl_pc.AutoSize = true;
            this.lbl_pc.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pc.Location = new System.Drawing.Point(274, 9);
            this.lbl_pc.Name = "lbl_pc";
            this.lbl_pc.Size = new System.Drawing.Size(56, 16);
            this.lbl_pc.TabIndex = 9;
            this.lbl_pc.Text = "Punti Pc:";
            // 
            // lbl_gioc
            // 
            this.lbl_gioc.AutoSize = true;
            this.lbl_gioc.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioc.Location = new System.Drawing.Point(133, 9);
            this.lbl_gioc.Name = "lbl_gioc";
            this.lbl_gioc.Size = new System.Drawing.Size(96, 16);
            this.lbl_gioc.TabIndex = 8;
            this.lbl_gioc.Text = "Punti Giocatore:";
            // 
            // btn_turnosucc
            // 
            this.btn_turnosucc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_turnosucc.Location = new System.Drawing.Point(12, 264);
            this.btn_turnosucc.Name = "btn_turnosucc";
            this.btn_turnosucc.Size = new System.Drawing.Size(80, 23);
            this.btn_turnosucc.TabIndex = 7;
            this.btn_turnosucc.Text = "Avanza";
            this.btn_turnosucc.UseVisualStyleBackColor = true;
            this.btn_turnosucc.Visible = false;
            this.btn_turnosucc.Click += new System.EventHandler(this.btn_turnosucc_Click);
            // 
            // btn_inizia
            // 
            this.btn_inizia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inizia.Location = new System.Drawing.Point(12, 264);
            this.btn_inizia.Name = "btn_inizia";
            this.btn_inizia.Size = new System.Drawing.Size(80, 23);
            this.btn_inizia.TabIndex = 6;
            this.btn_inizia.Text = "Inizia";
            this.btn_inizia.UseVisualStyleBackColor = true;
            this.btn_inizia.Click += new System.EventHandler(this.button1_Click);
            // 
            // tab_s
            // 
            this.tab_s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.22F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tab_s.DefaultCellStyle = dataGridViewCellStyle3;
            this.tab_s.Location = new System.Drawing.Point(136, 38);
            this.tab_s.Name = "tab_s";
            this.tab_s.Size = new System.Drawing.Size(259, 249);
            this.tab_s.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 302);
            this.Controls.Add(this.lbl_pc);
            this.Controls.Add(this.lbl_gioc);
            this.Controls.Add(this.btn_turnosucc);
            this.Controls.Add(this.btn_inizia);
            this.Controls.Add(this.tab_s);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(421, 345);
            this.MinimumSize = new System.Drawing.Size(421, 345);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Gioco della Scacchiera";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_s)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pc;
        private System.Windows.Forms.Label lbl_gioc;
        private System.Windows.Forms.Button btn_turnosucc;
        private System.Windows.Forms.Button btn_inizia;
        private System.Windows.Forms.DataGridView tab_s;
    }
}

