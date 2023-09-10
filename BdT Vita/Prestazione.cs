using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BdT_Vita
{
    public class Prestazione : IEquatable<Prestazione>
    {
        public string _id;
        public Persona _giver; 
        public Persona _reciver; 
        public int _ore;    
        public DateTime _data; 
        public string _tipo; 

        [JsonProperty]
        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _id = value;
                else
                    throw new Exception("Id non valido");
            }
        }
        [JsonProperty]
        public Persona Giver
        {
            get
            {
                return _giver;
            }
            private set
            {
                if (value != null)
                    _giver = value;
                else
                    throw new Exception("Erogatore non valido");
            }
        }
        [JsonProperty]
        public Persona Reciver
        {
            get
            {
                return _reciver;
            }
            private set
            {
                if (value != null)
                    _reciver = value;
                else
                    throw new Exception("Ricevente non valido");
            }
        }
        [JsonProperty]
        public int Ore
        {
            get
            {
                return _ore;
            }
            private set
            {
                if (value > 0)//Prestazioni da min 1h
                    _ore = value;
                else
                    throw new Exception("Ore non valide");
            }
        }
        [JsonProperty]
        public DateTime Data
        {
            get
            {
                return _data;
            }
            private set
            {
                if (value != null)
                    _data = value;
                else
                    throw new Exception("Data non valida");
            }
        }
        [JsonProperty]
        public string Tipo
        {
            get
            {
                return _tipo;
            }
            private set
            {
                if (value != null)
                    _tipo = value;
                else
                    throw new Exception("Tipo non valido");
            }
        }

        public Prestazione(string id, Persona giver, Persona reciver, int ore, DateTime data, string tipo)
        {
            Id = id;
            Giver = giver;
            Reciver = reciver;
            Ore = ore;
            Data = data;
            Tipo = tipo;
        }
        public Prestazione()
        {

        }


        protected Prestazione(Prestazione other) : this(other.Id, other.Giver, other.Reciver, other.Ore, other.Data, other.Tipo)
        {
        }
        public Prestazione Clone()
        {
            return new Prestazione(this);
        }
        public bool Equals(Prestazione p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Id == p.Id);
        }
        public override string ToString()
        {
            return $"Prestazione:{Id} {Giver}; {Reciver}; {Ore}; {Data}; {Tipo}";
        }
    }
}
