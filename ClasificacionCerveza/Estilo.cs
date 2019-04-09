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
    public partial class Estilo : Form {
        // Constructor.
        public Estilo() {
            InitializeComponent();
            rtbEstilos.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}