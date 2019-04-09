using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificacionCerveza {
    class Cervezas {
        // Atributos.
        private int id;
        private string nombre;
        private string estilo;
        private string sabor;
        private string aspecto;
        private double alcohol;
        private double temperatura;

        // Contructores.
        public Cervezas() { }
        public Cervezas(int id, string nombre, string estilo, string sabor, string aspecto, 
            double alcohol, double temperatura) {
            this.id = id;
            this.nombre = nombre;
            this.estilo = estilo;
            this.sabor = sabor;
            this.aspecto = aspecto;
            this.alcohol = alcohol;
            this.temperatura = temperatura;
        }

        // Métodos Get y Set.
        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Estilo {
            get { return estilo; }
            set { nombre = value; }
        }

        public string Sabor {
            get { return sabor; }
            set { sabor = value; }
        }

        public string Aspecto {
            get { return aspecto; }
            set { aspecto = value; }
        }

        public double Alcohol {
            get { return alcohol; }
            set { alcohol = value; }
        }

        public double Temperatura {
            get { return temperatura; }
            set { temperatura = value; }
        }
    }
}