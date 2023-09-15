using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BdT_Vita
{
    public partial class Form1 : Form
    {

        public List<Persona> persone = new List<Persona>();
        public List<Prestazione> prestazioni = new List<Prestazione>();

        public List<Persona> Persone
        {
            get { return persone; }
        }


        public Form1()
        {
            InitializeComponent();
            persone = new List<Persona>(); // Inizializza la lista persone
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaricamentoDati();

            /*
            Persona persona1 = new Persona("Vita", "Thomas", 1111111111, 2, false);
            Persona persona2 = new Persona("Valceschini", "Paolo", 2222222222, 2, true);
            Persona persona3 = new Persona("Pavoni", "Andrea", 3333333333, 2, true);

            persone.Add(persona1);
            persone.Add(persona2);
            persone.Add(persona3);

            Prestazione prestazione1 = new Prestazione("1", persona1, persona2, 6, DateTime.Now, "Pulizia");
            Prestazione prestazione2 = new Prestazione("2", persona2, persona3, 4, DateTime.Now, "Giardinaggio");
            Prestazione prestazione3 = new Prestazione("3", persona3, persona1, 2, DateTime.Now, "DogSitting");

            prestazioni.Add(prestazione1);
            prestazioni.Add(prestazione2);
            prestazioni.Add(prestazione3);
            */


            SalvataggioDati();
            Aggiornamento();

        }

        private void CaricamentoDati()
        {

            if (!File.Exists("persone.json"))
            {
                File.WriteAllText("persone.json", "[]");
            }

            if (!File.Exists("prestazioni.json"))
            {
                File.WriteAllText("prestazioni.json", "[]");
            }


            if (File.Exists("persone.json"))
            {
                string personeJson = File.ReadAllText("persone.json");
                persone = JsonConvert.DeserializeObject<List<Persona>>(personeJson);
            }

            if (File.Exists("prestazioni.json"))
            {
                string prestazioniJson = File.ReadAllText("prestazioni.json");
                prestazioni = JsonConvert.DeserializeObject<List<Prestazione>>(prestazioniJson);
            }

            
        }

        private void SalvataggioDati()
        {
            string personeJson = JsonConvert.SerializeObject(persone);
            File.WriteAllText("persone.json", personeJson);

            string prestazioniJson = JsonConvert.SerializeObject(prestazioni);
            File.WriteAllText("prestazioni.json", prestazioniJson);
        }

        public void Aggiornamento()
        {
            ListaPersone.Items.Clear();
            foreach (Persona persona in persone)
            {
                ListaPersone.Items.Add($"{persona.Cognome}, {persona.Nome} - Tel: {persona.Telefono}");
            }

            // Cancella tutte le prestazioni visualizzate precedentemente
            ListaPrest.Items.Clear();

            foreach (Prestazione prestazione in prestazioni)
            {
                ListaPrest.Items.Add($"{prestazione.Giver.Cognome}, {prestazione.Giver.Nome} -> {prestazione.Reciver.Cognome}, {prestazione.Reciver.Nome} - {prestazione.Ore} ore di {prestazione.Tipo} il giorno {prestazione.Giorno}");
            }
        }
        public void AggiungiElementoAllaLista(List<Persona> persone, Persona nuovaPersona)
        {
            persone.Add(nuovaPersona);
            SalvataggioDati();
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            CaricamentoDati();
            Aggiornamento();
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnSegreteria_Click_1(object sender, EventArgs e)
        {
            if (persone != null && persone.Any())
            {
                List<Persona> SegPersone = persone.Where(p => p.Segreteria).ToList();

                ListaSeg.Items.Clear();
                foreach (Persona SegPersona in SegPersone)
                {
                    ListaSeg.Items.Add($"{SegPersona.Cognome}, {SegPersona.Nome} - Tel: {SegPersona.Telefono}");
                }
            }
            else
            {
                // Gestire il caso in cui la lista persone sia vuota o nulla
                MessageBox.Show("La lista delle persone è vuota o nulla.");
            }
        }

        private void btnOrdinaPrestazioni_Click_1(object sender, EventArgs e)
        {
            if(prestazioni != null && prestazioni.Any())
            {
                List<Prestazione> prestazioniOrdinate = prestazioni.OrderByDescending(p => p.Ore).ToList();

                ListaPrest.Items.Clear();
                foreach (Prestazione prestazione in prestazioniOrdinate)
                {
                    ListaPrest.Items.Add($"{prestazione.Giver.Cognome}, {prestazione.Giver.Nome} -> {prestazione.Reciver.Cognome}, {prestazione.Reciver.Nome} - {prestazione.Ore} ore di {prestazione.Tipo} il giorno {prestazione.Giorno}");
                }
            }
            else
            {
                // Gestire il caso in cui la lista prestazioni sia vuota o nulla
                MessageBox.Show("La lista delle prestazioni è vuota o nulla.");
            }

        }

        private void btnDebito_Click_1(object sender, EventArgs e)
        {
            // Calcola i debiti
            List<Persona> debitors = persone.Where(s => s.CalcolaDebito() > 0).ToList();

            // Aggiorna la lista dei debiti
            ListaDebiti.Items.Clear();
            foreach (Persona debitor in debitors)
            {
                if(debitor.Debito != 0)
                {
                    ListaDebiti.Items.Add($"{debitor.Cognome}, {debitor.Nome} | Debito: {debitor.Debito}");

                }
            }

            // Aggiorna la lista dei debiti dopo aver calcolato e popolato i debiti
            //Aggiornamento();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ListaDebiti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddPersonaS nuovaForm = new AddPersonaS();
            //nuovaForm.Show();

            //persone.Add(nuovaPersona);

            AddPersonaS nuovaForm = new AddPersonaS();
            nuovaForm.ShowDialog(); // Mostra la form in modalità dialogo
            if (nuovaForm.NuovaPersona != null)
            {
                // Aggiungi la nuova persona alla lista persone solo se è stata creata
                persone.Add(nuovaForm.NuovaPersona);
                Aggiornamento(); // Aggiorna la visualizzazione nella lista delle persone
                SalvataggioDati();
            }


        }

        public bool PrestazioneIdEsiste(string id)
        {
            return prestazioni.Any(p => p.Id == id);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            AddPrestazioneS nuovaForm2 = new AddPrestazioneS();
            nuovaForm2.ShowDialog();
            if (nuovaForm2.NuovaPrestazione != null)
            {
                //prestazioni.Add(nuovaForm2.NuovaPrestazione); // Aggiungi la nuova prestazione alla lista delle prestazioni nella nuova form
                Aggiornamento(); // Aggiorna la visualizzazione nella lista delle persone
                SalvataggioDati();
            }

        }

        private void EliminaPersona_Click(object sender, EventArgs e)
        {
            EliminaPersonaForm eliminaPersonaForm = new EliminaPersonaForm();
            if (eliminaPersonaForm.ShowDialog() == DialogResult.OK)
            {
                // Ottieni il cognome e il nome dalla form di eliminazione
                string cognome = eliminaPersonaForm.Cognome;
                string nome = eliminaPersonaForm.Nome;

                // Trova la persona nella lista delle persone per cognome e nome e rimuovila
                Persona personaDaRimuovere = persone.FirstOrDefault(p => p.Cognome == cognome && p.Nome == nome);
                if (personaDaRimuovere != null)
                {
                    persone.Remove(personaDaRimuovere);
                    SalvataggioDati();
                    Aggiornamento();
                }
                else
                {
                    // Mostra un messaggio se la persona non è stata trovata nella lista
                    MessageBox.Show("La persona non è stata trovata.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminaPrestazione_Click(object sender, EventArgs e)
        {
            EliminaPrestazioneForm eliminaPrestazioneForm = new EliminaPrestazioneForm();
            if (eliminaPrestazioneForm.ShowDialog() == DialogResult.OK)
            {
                // Ottieni l'ID dalla form di eliminazione
                string idPrestazione = eliminaPrestazioneForm.IdPrestazione;

                // Trova la prestazione nella lista delle prestazioni per ID e rimuovila
                Prestazione prestazioneDaRimuovere = prestazioni.FirstOrDefault(p => p.Id == idPrestazione);
                if (prestazioneDaRimuovere != null)
                {
                    prestazioni.Remove(prestazioneDaRimuovere);
                    SalvataggioDati();
                    Aggiornamento(); // Aggiorna la visualizzazione delle prestazioni dopo la rimozione
                }
                else
                {
                    // Mostra un messaggio se la prestazione non è stata trovata nella lista
                    MessageBox.Show("La prestazione non è stata trovata.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ListaPrest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /*private Persona nuovaPersona;

        public Form1(Persona nuovaPersona) : this()
        {
            this.nuovaPersona = nuovaPersona;
            // Ora puoi usare nuovaPersona in questa form
            CaricamentoDati();
            SalvataggioDati();
            Aggiornamento();
        }
        */


    }
}
