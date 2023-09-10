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

        Persona nuovaPersona = new Persona("NuovoCognome", "NuovoNome", 1234567890, 0, false);

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaricamentoDati();
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

        private void Aggiornamento()
        {
            ListaPersone.Items.Clear();
            foreach (Persona persona in persone)
            {
                ListaPersone.Items.Add($"{persona.Cognome}, {persona.Nome} - Tel: {persona.Telefono}");
            }
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            List<Persona> debitori = persone.Where(s => s.CalcolaDebito() > 0).ToList();

            ListaDebiti.Items.Clear();
            foreach (Persona debitor in debitori)
            {
                ListaDebiti.Items.Add($"{debitor.Cognome}, {debitor.Nome} | Debito: {debitor.Debito}");
            }
        }

        private void btnSegreteria_Click(object sender, EventArgs e)
        {
            List<Persona> SegPersone = persone.Where(s => s.Segreteria).ToList();

            ListaSeg.Items.Clear();
            foreach (Persona SegPersona in SegPersone)
            {
                ListaSeg.Items.Add($"{SegPersona.Cognome}, {SegPersona.Nome} - Tel: {SegPersona.Telefono}");
            }
        }

        private void btnOrdinaPrestazioni_Click(object sender, EventArgs e)
        {
            List<Prestazione> prestazioniOrdinate = prestazioni.OrderByDescending(p => p.Ore).ToList();

            ListaPrest.Items.Clear();
            foreach (Prestazione prestazione in prestazioniOrdinate)
            {
                ListaPrest.Items.Add($"{prestazione.Giver.Cognome}, {prestazione.Giver.Nome} -> {prestazione.Reciver.Cognome}, {prestazione.Reciver.Nome} - {prestazione.Ore} ore di {prestazione.Tipo}");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            CaricamentoDati();
            Aggiornamento();
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
