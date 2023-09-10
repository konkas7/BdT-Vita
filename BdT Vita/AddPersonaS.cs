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
            bool segreteria;
            if (textBox5.Text == "true")
            {
                segreteria = true;
            }
            if (textBox5.Text == "false")
            {
                segreteria = false;
            }
            else
                throw new Exception("Risposta non valida");



            Persona nuovaPersona = new Persona(cognome, nome, telefono, debito, segreteria);
            
            // Chiudi il modulo di inserimento
            this.Close();
        }
    }
}
