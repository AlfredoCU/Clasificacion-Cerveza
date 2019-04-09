using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasificacionCerveza {
    public partial class Tabla : Form {
        // Instancia de la Lista de Cervezas.
        ListaCervezas lc = new ListaCervezas();

        // Constructor.
        public Tabla() {
            InitializeComponent();
        }

        // Load.
        private void Tabla_Load(object sender, EventArgs e) {
            lc.IniciaLista();
            dgvCervezas.DataSource = null;
            dgvCervezas.DataSource = lc.MostrarLista();
        }
    }
}