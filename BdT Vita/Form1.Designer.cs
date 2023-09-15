namespace BdT_Vita
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
            this.btnSegreteria = new System.Windows.Forms.Button();
            this.btnOrdinaPrestazioni = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.ListaSeg = new System.Windows.Forms.ListBox();
            this.ListaPrest = new System.Windows.Forms.ListBox();
            this.ListaDebiti = new System.Windows.Forms.ListBox();
            this.ListaPersone = new System.Windows.Forms.ListBox();
            this.AddPersona = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EliminaPersona = new System.Windows.Forms.Button();
            this.EliminaPrestazione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSegreteria
            // 
            this.btnSegreteria.Location = new System.Drawing.Point(523, 12);
            this.btnSegreteria.Name = "btnSegreteria";
            this.btnSegreteria.Size = new System.Drawing.Size(143, 108);
            this.btnSegreteria.TabIndex = 0;
            this.btnSegreteria.Text = "Aggiorna Segreteria";
            this.btnSegreteria.UseVisualStyleBackColor = true;
            this.btnSegreteria.Click += new System.EventHandler(this.btnSegreteria_Click_1);
            // 
            // btnOrdinaPrestazioni
            // 
            this.btnOrdinaPrestazioni.Location = new System.Drawing.Point(523, 126);
            this.btnOrdinaPrestazioni.Name = "btnOrdinaPrestazioni";
            this.btnOrdinaPrestazioni.Size = new System.Drawing.Size(143, 108);
            this.btnOrdinaPrestazioni.TabIndex = 1;
            this.btnOrdinaPrestazioni.Text = "Aggiorna Prestazioni";
            this.btnOrdinaPrestazioni.UseVisualStyleBackColor = true;
            this.btnOrdinaPrestazioni.Click += new System.EventHandler(this.btnOrdinaPrestazioni_Click_1);
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(523, 240);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(143, 108);
            this.btnDebito.TabIndex = 2;
            this.btnDebito.Text = "Aggiorna Debiti";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click_1);
            // 
            // ListaSeg
            // 
            this.ListaSeg.FormattingEnabled = true;
            this.ListaSeg.ItemHeight = 16;
            this.ListaSeg.Location = new System.Drawing.Point(714, 12);
            this.ListaSeg.Name = "ListaSeg";
            this.ListaSeg.Size = new System.Drawing.Size(542, 100);
            this.ListaSeg.TabIndex = 4;
            // 
            // ListaPrest
            // 
            this.ListaPrest.FormattingEnabled = true;
            this.ListaPrest.ItemHeight = 16;
            this.ListaPrest.Location = new System.Drawing.Point(714, 126);
            this.ListaPrest.Name = "ListaPrest";
            this.ListaPrest.Size = new System.Drawing.Size(542, 100);
            this.ListaPrest.TabIndex = 5;
            this.ListaPrest.SelectedIndexChanged += new System.EventHandler(this.ListaPrest_SelectedIndexChanged);
            // 
            // ListaDebiti
            // 
            this.ListaDebiti.FormattingEnabled = true;
            this.ListaDebiti.ItemHeight = 16;
            this.ListaDebiti.Location = new System.Drawing.Point(714, 240);
            this.ListaDebiti.Name = "ListaDebiti";
            this.ListaDebiti.Size = new System.Drawing.Size(542, 100);
            this.ListaDebiti.TabIndex = 6;
            this.ListaDebiti.SelectedIndexChanged += new System.EventHandler(this.ListaDebiti_SelectedIndexChanged);
            // 
            // ListaPersone
            // 
            this.ListaPersone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaPersone.FormattingEnabled = true;
            this.ListaPersone.ItemHeight = 25;
            this.ListaPersone.Location = new System.Drawing.Point(12, 12);
            this.ListaPersone.Name = "ListaPersone";
            this.ListaPersone.Size = new System.Drawing.Size(457, 379);
            this.ListaPersone.TabIndex = 7;
            // 
            // AddPersona
            // 
            this.AddPersona.Location = new System.Drawing.Point(12, 388);
            this.AddPersona.Name = "AddPersona";
            this.AddPersona.Size = new System.Drawing.Size(592, 79);
            this.AddPersona.TabIndex = 8;
            this.AddPersona.Text = "Aggiungi persona";
            this.AddPersona.UseVisualStyleBackColor = true;
            this.AddPersona.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(590, 79);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aggiungi prestazione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EliminaPersona
            // 
            this.EliminaPersona.Location = new System.Drawing.Point(12, 473);
            this.EliminaPersona.Name = "EliminaPersona";
            this.EliminaPersona.Size = new System.Drawing.Size(592, 79);
            this.EliminaPersona.TabIndex = 10;
            this.EliminaPersona.Text = "Elimina persona";
            this.EliminaPersona.UseVisualStyleBackColor = true;
            this.EliminaPersona.Click += new System.EventHandler(this.EliminaPersona_Click);
            // 
            // EliminaPrestazione
            // 
            this.EliminaPrestazione.Location = new System.Drawing.Point(610, 473);
            this.EliminaPrestazione.Name = "EliminaPrestazione";
            this.EliminaPrestazione.Size = new System.Drawing.Size(590, 79);
            this.EliminaPrestazione.TabIndex = 11;
            this.EliminaPrestazione.Text = "Elimina prestazione";
            this.EliminaPrestazione.UseVisualStyleBackColor = true;
            this.EliminaPrestazione.Click += new System.EventHandler(this.EliminaPrestazione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 564);
            this.Controls.Add(this.EliminaPrestazione);
            this.Controls.Add(this.EliminaPersona);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddPersona);
            this.Controls.Add(this.ListaPersone);
            this.Controls.Add(this.ListaDebiti);
            this.Controls.Add(this.ListaPrest);
            this.Controls.Add(this.ListaSeg);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.btnOrdinaPrestazioni);
            this.Controls.Add(this.btnSegreteria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSegreteria;
        private System.Windows.Forms.Button btnOrdinaPrestazioni;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.ListBox ListaSeg;
        private System.Windows.Forms.ListBox ListaPrest;
        private System.Windows.Forms.ListBox ListaDebiti;
        private System.Windows.Forms.ListBox ListaPersone;
        private System.Windows.Forms.Button AddPersona;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EliminaPersona;
        private System.Windows.Forms.Button EliminaPrestazione;
    }
}

