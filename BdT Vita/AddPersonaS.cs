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
    public partial class AddPersonaS : Form
    {
        public AddPersonaS()
        {
            InitializeComponent();
        }

        private void AddPersonaS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leggi i dati inseriti dall'utente dal modulo di inserimento
            string nome = textBox1.Text;
            string cognome = textBox2.Text;
            double telefono = double.Parse(textBox3.Text);
            int debito = int.Parse(textBox4.Text);
            string input = textBox5.Text.ToLower(); // Leggi il testo dalla TextBox e convertilo in minuscolo
            bool segreteria;

            if (input == "true")
            {
                segreteria = true;
            }
            else if (input == "false")
            {
                segreteria = false;
            }
            else
            {
                // La conversione non è riuscita, gestisci l'input non valido
                throw new Exception("Input non valido. Inserisci 'true' o 'false'.");
            }

            Persona nuovaPersona = new Persona(cognome, nome, telefono, debito, segreteria);

            // Apri Form1 passando nuovaPersona al costruttore
            //Form1 form1 = new Form1(nuovaPersona);
            if (Owner is Form1 form1)
            {
                form1.AggiungiElementoAllaLista(form1.persone, nuovaPersona);
                form1.Aggiornamento(); // Aggiorna la visualizzazione nella lista delle persone
            }

            // Nascondi la Form corrente invece di chiuderla
            this.Hide();
        }
    }
}
