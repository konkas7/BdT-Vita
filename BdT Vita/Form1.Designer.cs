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
            this.SuspendLayout();
            // 
            // btnSegreteria
            // 
            this.btnSegreteria.Location = new System.Drawing.Point(8, 126);
            this.btnSegreteria.Name = "btnSegreteria";
            this.btnSegreteria.Size = new System.Drawing.Size(143, 108);
            this.btnSegreteria.TabIndex = 0;
            this.btnSegreteria.Text = "Segreteria";
            this.btnSegreteria.UseVisualStyleBackColor = true;
            this.btnSegreteria.Click += new System.EventHandler(this.btnSegreteria_Click_1);
            // 
            // btnOrdinaPrestazioni
            // 
            this.btnOrdinaPrestazioni.Location = new System.Drawing.Point(8, 240);
            this.btnOrdinaPrestazioni.Name = "btnOrdinaPrestazioni";
            this.btnOrdinaPrestazioni.Size = new System.Drawing.Size(143, 108);
            this.btnOrdinaPrestazioni.TabIndex = 1;
            this.btnOrdinaPrestazioni.Text = "Prestazioni";
            this.btnOrdinaPrestazioni.UseVisualStyleBackColor = true;
            this.btnOrdinaPrestazioni.Click += new System.EventHandler(this.btnOrdinaPrestazioni_Click_1);
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(8, 354);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(143, 108);
            this.btnDebito.TabIndex = 2;
            this.btnDebito.Text = "Debiti";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click_1);
            // 
            // ListaSeg
            // 
            this.ListaSeg.FormattingEnabled = true;
            this.ListaSeg.ItemHeight = 16;
            this.ListaSeg.Location = new System.Drawing.Point(247, 126);
            this.ListaSeg.Name = "ListaSeg";
            this.ListaSeg.Size = new System.Drawing.Size(480, 100);
            this.ListaSeg.TabIndex = 4;
            // 
            // ListaPrest
            // 
            this.ListaPrest.FormattingEnabled = true;
            this.ListaPrest.ItemHeight = 16;
            this.ListaPrest.Location = new System.Drawing.Point(247, 240);
            this.ListaPrest.Name = "ListaPrest";
            this.ListaPrest.Size = new System.Drawing.Size(480, 100);
            this.ListaPrest.TabIndex = 5;
            // 
            // ListaDebiti
            // 
            this.ListaDebiti.FormattingEnabled = true;
            this.ListaDebiti.ItemHeight = 16;
            this.ListaDebiti.Location = new System.Drawing.Point(247, 354);
            this.ListaDebiti.Name = "ListaDebiti";
            this.ListaDebiti.Size = new System.Drawing.Size(480, 100);
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
            this.ListaPersone.Size = new System.Drawing.Size(715, 79);
            this.ListaPersone.TabIndex = 7;
            // 
            // AddPersona
            // 
            this.AddPersona.Location = new System.Drawing.Point(796, 12);
            this.AddPersona.Name = "AddPersona";
            this.AddPersona.Size = new System.Drawing.Size(357, 79);
            this.AddPersona.TabIndex = 8;
            this.AddPersona.Text = "Aggiungi persona";
            this.AddPersona.UseVisualStyleBackColor = true;
            this.AddPersona.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 470);
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
    }
}

