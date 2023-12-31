﻿using System;
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
    public partial class AddPrestazioneS : Form
    {
        public Prestazione NuovaPrestazione { get; private set; }
        Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public AddPrestazioneS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string id = textBox1.Text;

            // Verifica se l'ID esiste già
            if (form1.PrestazioneIdEsiste(id) && int.TryParse(id, out int numero) && numero > 0)
            {
                MessageBox.Show("L'ID specificato esiste già.");
                return; // Esci dalla funzione senza aggiungere la prestazione
            }
            int ore = int.Parse(textBox2.Text);
            string tipo = textBox3.Text;
            DateTime data = DateTime.Now;

            string giorno = textBox4.Text;
            // Leggi l'erogatore selezionato dalla ComboBox
            string erogatoreSelezionato = comboBox1.SelectedItem.ToString();
            

            // Trova la persona corrispondente nella lista delle persone
            Persona erogatore = form1.persone.FirstOrDefault(p => $"{p.Cognome}, {p.Nome}" == erogatoreSelezionato);
            erogatore.Debito -= ore;
            // Leggi il ricevente selezionato dalla ComboBox
            string riceventeSelezionato = comboBox2.SelectedItem.ToString();

            // Trova la persona corrispondente nella lista delle persone
            Persona ricevente = form1.persone.FirstOrDefault(p => $"{p.Cognome}, {p.Nome}" == riceventeSelezionato);
            ricevente.Debito += ore;
            // Crea l'oggetto Prestazione utilizzando erogatore e ricevente
            NuovaPrestazione = new Prestazione(id,giorno,erogatore, ricevente,ore, data, tipo);

            // Aggiungi la nuova prestazione alla lista delle prestazioni
            form1.prestazioni.Add(NuovaPrestazione);

            // Chiudi la form o esegui altre azioni a seconda delle tue esigenze
            this.Close();
        }

        private void AddPrestazioneS_Load(object sender, EventArgs e)
        {
            // Popola la ComboBox per l'erogatore
            foreach (Persona persona in form1.persone)
            {
                comboBox1.Items.Add($"{persona.Cognome}, {persona.Nome}");
            }

            // Popola la ComboBox per il ricevente
            foreach (Persona persona in form1.persone)
            {
                comboBox2.Items.Add($"{persona.Cognome}, {persona.Nome}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
