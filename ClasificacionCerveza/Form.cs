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
    public partial class ClasificacionCerveza : Form {
        // Instancia de la Sistema Fuzzy.
        SistemaFuzzy sf = new SistemaFuzzy();

        // Atributos.
        public double saborNitido, temperaturaNitido, alcoholNitido, nivMemEstilo, estiloNitido, v1;
        public String saborDifuso, temperaturaDifuso, alcoholDifuso, estiloDifuso;

        // Constructor.
        public ClasificacionCerveza() {
            InitializeComponent();
        }

        // Scroll de Sabor.
        private void trbSab_Scroll(object sender, EventArgs e) {
            saborNitido = trbSab.Value;
        }

        // Información del Scroll de Sabor.
        private void trbSab_MouseHover(object sender, EventArgs e) {
            this.ttipMsj.SetToolTip(this.trbSab, "Basado en el cálculo de IBU.");
            this.ttipMsj.ToolTipTitle = "Niveles de amargura.";
            this.ttipMsj.ToolTipIcon = ToolTipIcon.Info;
        }

        // Scroll de Temperatura.
        private void trbTem_Scroll(object sender, EventArgs e) {
            v1 = trbTem.Value * 10;
            temperaturaNitido = v1 / 1000;
        }

        // Información del Scroll de Temperatura.
        private void trbTem_MouseHover(object sender, EventArgs e) {
            this.ttipMsj.SetToolTip(this.trbTem, "Temperatura deseada para su consumo.");
            this.ttipMsj.ToolTipTitle = "Temperatura °C.";
            this.ttipMsj.ToolTipIcon = ToolTipIcon.Info;
        }

        // Scroll de Alcohol.
        private void trbAlc_Scroll(object sender, EventArgs e) {
            v1 = trbAlc.Value * 10;
            alcoholNitido = v1 / 1000;
        }

        // Información del Scroll de Alcohol.
        private void trbAlc_MouseHover(object sender, EventArgs e) {
            this.ttipMsj.SetToolTip(this.trbAlc, "Grados o niveles de alcohol en la cerveza.");
            this.ttipMsj.ToolTipTitle = "Alcohol %.";
            this.ttipMsj.ToolTipIcon = ToolTipIcon.Info;
        }

        // Botón de Respuesta.
        private void btnRes_Click(object sender, EventArgs e) {
            Resultados();
        }

        // Botón de Tabla de Cervezas.
        private void btnCervezas_Click(object sender, EventArgs e) {
            Tabla abrir = new Tabla();
            abrir.ShowDialog();
        }

        // Botón de Información de los Estilos de Cervezas.
        private void btnEst_Click(object sender, EventArgs e) {
            Estilo abrir = new Estilo();
            abrir.ShowDialog();
        }

        // Botón de Información del Sistema.
        private void btnInf_Click(object sender, EventArgs e) {
            string mensaje = "Este sistema esta creado por ArdComputer.\nPrograma: Clasificación de Cerveza.\nProgramador: Alfredo Carreón Urbano.\nVersión: 1.0";
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Resultados() {
            string data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11;
            // double[]  nivsMemSabor = null;
            // double[] nivsMemTemperatura = null;
            // double[] nivsMemAlcohol = null;
            // string[] args;
            estiloNitido = 0.0;
            // temperaturaNitido = Double.Parse(args[0]);
            // saborNitido = Double.Parse(args[1]);
            // alcoholNitido = Double.Parse(args[2]);

            // Fuzzificar Valores Nítidos de Entrada...
            saborDifuso = sf.FuzzificarSabor(saborNitido);
            temperaturaDifuso = sf.FuzzificarTemperatura(temperaturaNitido);
            alcoholDifuso = sf.FuzzificarAlcohol(alcoholNitido);
            data1 = ("\t\t\t Estilos de Cervezas.\n");
            data2 = sf.ProdMembsSabor(saborNitido);
            data3 = sf.ProdMembsTemperatura(temperaturaNitido);
            data4 = sf.ProdMembsAlcohol(alcoholNitido);

            // Notificar en Consola Resultados de la Fuzzificación.
            data5 = ("\n\n-Para Sabor: " + saborNitido + " Corresponde: " + saborDifuso);
            data6 = ("\n-Para Temperatura: " + temperaturaNitido + " Corresponde: " + temperaturaDifuso);
            data7 = ("\n-Para Alcohol: " + alcoholNitido + " Corresponde: " + alcoholDifuso);

            // Realizar Inferencia Difusa Cualitativa. A partir de Valores Difusos Calculados.
            estiloDifuso = sf.InferirEstiloDifusaCualitativo(saborDifuso, temperaturaDifuso, alcoholDifuso);

            // Notificar en Consola Resultados de la Inferencia Difusa Cualitativa.
            data8 = ("\n\n-El Estilo(s) que se recomienda(n) es(son): " + estiloDifuso);
            this.lblEst.Text = "Estilo(s): " + estiloDifuso;
            // Realizar Inferencia Difusa Cuantitativa. A partir de Valores Difusos Calculados.
            nivMemEstilo = sf.InferirTallaDifusaCuantitativo(saborDifuso, temperaturaDifuso, alcoholDifuso);

            // Notificar en Consola Resultados de la Inferencia Difusa Cuantitativa.
            data9 = (", con una certeza de: " + nivMemEstilo);
            data10 = sf.MuestraNivMemMay("\n-Membresías Estilo(s)", sf.nivsMemEstilos);

            // Con el fin de realizar alguna respuesta de control, es posible Desfuzzificar la respuesta 
            // Difusa que el sistema produce. En este caso, elegir una camisa específica por número directo
            // y NO por una el estilo genérica.
            estiloNitido = sf.Desfuzzificar(estiloDifuso, nivMemEstilo);

            // Notificar en Consola Resultados de la Desfuzzificación.
            data11 = ("\n-Desfuzzificación correspondiente: " + estiloNitido);
            rtbResultados.Text = (data1 + data2 + data3 + data4 + data5 + data6 + data7 + data8 + data9 + data10 + data11);
        }
    }
}