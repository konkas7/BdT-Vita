using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdT_Vita
{
    public partial class EliminaPersonaForm : Form
    {

        // Proprietà per ottenere il cognome dalla form
        public string Cognome => textBox1.Text;

        // Proprietà per ottenere il nome dalla form
        public string Nome => textBox2.Text;
        public EliminaPersonaForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Valida i campi di input, ad esempio, assicurandosi che non siano vuoti

            if (string.IsNullOrEmpty(Cognome) || string.IsNullOrEmpty(Nome))
            {
                MessageBox.Show("Inserisci sia il cognome che il nome.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Qui puoi inserire ulteriori controlli sulla validità dei dati se necessario

            // Chiudi la form con DialogResult.OK per confermare l'eliminazione
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
