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
        public Persona NuovaPersona { get; private set; }
        public AddPersonaS()
        {
            InitializeComponent();
        }

        private void AddPersonaS_Load(object sender, EventArgs e)
        {
            // Aggiungi "true" come primo elemento
            comboBox1.Items.Add("true");

            // Aggiungi "false" come secondo elemento
            comboBox1.Items.Add("false");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leggi i dati inseriti dall'utente dal modulo di inserimento
            string nome = textBox1.Text;
            string cognome = textBox2.Text;
            double telefono = double.Parse(textBox3.Text);
            int debito = int.Parse(textBox4.Text);
            //string input = textBox5.Text.ToLower(); // Leggi il testo dalla TextBox e convertilo in minuscolo
                                                    // Leggi la selezione dalla ComboBox
            string selezione = comboBox1.SelectedItem.ToString();

            // Confronta la selezione con le opzioni possibili
            bool segreteria;
            if (selezione == "true")
            {
                segreteria = true;
            }
            else if (selezione == "false")
            {
                segreteria = false;
            }
            else
            {
                // Gestisci il caso in cui la selezione non corrisponda a "true" o "false"
                MessageBox.Show("Seleziona una delle opzioni disponibili.");
                return;
            }

            // Assegna la nuova persona alla proprietà NuovaPersona
            NuovaPersona = new Persona(cognome, nome, telefono, debito, segreteria);

            // Apri Form1 passando nuovaPersona al costruttore
            //Form1 form1 = new Form1(nuovaPersona);
            if (Owner is Form1 form1)
            {
                form1.AggiungiElementoAllaLista(form1.persone, NuovaPersona);
                form1.Aggiornamento(); // Aggiorna la visualizzazione nella lista delle persone
            }

            // Salva i dati

            // Chiudi la form corrente
            this.Close();
        }
    }
}
