using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BdT_Vita
{
    public class Persona : IEquatable<Persona>
    {
        public string _nome;
        public string _cognome;
        public double _telefono;
        public int _debito;
        public bool _segreteria;

        
        
        [JsonProperty]
        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _nome = value;
                else
                    throw new Exception("Nome non valido");
            }
        }
        [JsonProperty]

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _cognome = value;
                else
                    throw new Exception("Cognome non valido");
            }
        }
        [JsonProperty]
        public double Telefono
        {
            get
            {
                return _telefono;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value.ToString()) && value.ToString().Length == 10)
                    _telefono = value;
                else
                    throw new Exception("Numero di Telefono non valido");
            }
        }
        [JsonProperty]
        public int Debito
        {
            get
            {
                return _debito;
            }
            set
            {
                _debito = value;
            }
        }
        [JsonProperty]
        public bool Segreteria
        {
            get
            {
                return _segreteria;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value.ToString()))
                    _segreteria = value;
                else
                    throw new Exception("Partecipazione alla segreteria non valida");
            }
        }

        [JsonProperty]
        public List<Prestazione> Prestazioni { get; set; } // Elenco delle prestazioni offerte o ricevute dal socio

        public Persona(string cognome, string nome, double telefono, int debito, bool segreteria)
        {
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            Debito = debito;
            Segreteria = segreteria;
            Prestazioni = new List<Prestazione>();
        }
        public Persona()
        {
            Cognome = "NoData";
            Nome = "NoData";
            Telefono = 1000000000;
            Debito = 0;
            Segreteria = false;
            Prestazioni = new List<Prestazione>();
        }
        // Metodo per aggiungere una prestazione alla lista del socio
        public void AggiungiPrestazione(Prestazione prestazione)
        {
            Prestazioni.Add(prestazione);
        }

        // Metodo per calcolare il debito del socio (ore erogate - ore ricevute)
        public int CalcolaDebito()
        {
            int oreErogate = Prestazioni.Where(p => p.Giver == this).Sum(p => p.Ore);
            int oreRicevute = Prestazioni.Where(p => p.Reciver == this).Sum(p => p.Ore);

            return oreRicevute - oreErogate;
        }


        protected Persona(Persona other) : this(other.Cognome, other.Nome, other.Telefono, other.Debito, other.Segreteria)
        {

        }
        public Persona Clone()
        {
            return new Persona(this);
        }
        public bool Equals(Persona u)
        {
            if (u == null) return false;

            if (this == u) return true;

            return (this.Cognome == u.Cognome && this.Nome == u.Nome);
        }

        public override string ToString()
        {
            return $"Persona: {Cognome} {Nome}; {Telefono}, {Debito}";
        }
    }
}
