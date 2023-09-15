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
    public partial class EliminaPrestazioneForm : Form
    {

        // Proprietà per ottenere l'ID della prestazione dalla form
        public string IdPrestazione => textBox1.Text;
        public EliminaPrestazioneForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Valida il campo di input, ad esempio, assicurandoti che non sia vuoto

            if (string.IsNullOrEmpty(IdPrestazione))
            {
                MessageBox.Show("Inserisci l'ID della prestazione.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Qui puoi inserire ulteriori controlli sulla validità dell'ID se necessario

            // Chiudi la form con DialogResult.OK per confermare l'eliminazione
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
