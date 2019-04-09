using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificacionCerveza {
    class SistemaFuzzy {
        // Instancia de la Biblioteca Fuzzy.
        BiblioFuzzy bf = new BiblioFuzzy();

        // Atributos.
        private string msg1, msg2, msg3;
        
        // Rangos y Salidas.
        public String[] conjuntosSabor = { "Dulce", "Intermedio", "Amarga" };
        public String[] conjuntosTemperatura = { "Muy-Fría", "Fría", "Tibia" };
        public String[] conjuntosAlcohol = { "Bajo", "Medio", "Alto" };
        public String[] conjuntosEstilos ={"ScotchAle", "Dunkel", "Kolsch-Saison-Vienna",
                "GoldenAle", "Bitter-PaleAle", "Hefeweizen", "AgaveAle-Stout-Porter", "BlondeAle", "Lager"};

        // Arreglos de Niveles de Membrecía.
        public double[] nivsMemSabor = new double[3];
        public double[] nivsMemTemperatura = new double[3];
        public double[] nivsMemAlcohol = new double[3];
        public double[] nivsMemEstilos = new double[9];

        // Método de Posición Nivel de Membrecía.
        public int PosNivMemMay(double[] nivsMem) {
            int posMay = 0;
            for (int i = 0; i < nivsMem.Length; i++) {
                if (nivsMem[i] > nivsMem[posMay]) posMay = i;
            }
            return posMay;
        }

        // Método de Muestra Nivel de Membrecía.
        public string MuestraNivMemMay(String msg, double[] nivsMem) {
            msg1 = (msg + ": [");
            for (int i = 0; i < nivsMem.Length; i++) {
                msg2 =(nivsMem[i] + (i + 1 == nivsMem.Length ? "]" : ", "));
                msg3 = (msg1 + msg2);
            }
            return msg3;
        }

        // Método Membrecía Sabor.
        public string ProdMembsSabor(double datoNitidoSabor) {
            nivsMemSabor[0] = bf.Curva_Z(datoNitidoSabor, 0, 60);
            nivsMemSabor[1] = bf.TriangularSuave(datoNitidoSabor, 0, 60, 120);
            nivsMemSabor[2] = bf.Curva_S(datoNitidoSabor, 60, 120);
            return MuestraNivMemMay(("\n-Membresías Sabor: " + datoNitidoSabor), nivsMemSabor);
        }

        // Método Membrecía Temperatura.
        public string ProdMembsTemperatura(double datoNitidoTemperatura) {
            nivsMemTemperatura[0] = bf.Curva_Z(datoNitidoTemperatura, 2, 5.665);
            nivsMemTemperatura[1] = bf.TriangularSuave(datoNitidoTemperatura, 2, 5.665, 13);
            nivsMemTemperatura[2] = bf.Curva_S(datoNitidoTemperatura, 5.665, 13);
            return MuestraNivMemMay(("\n-Membresías Temperatura: " + datoNitidoTemperatura), nivsMemTemperatura);
        }

        // Método Membrecía Alcohol.
        public string ProdMembsAlcohol(double datoNitidoAlcohol) {
            nivsMemAlcohol[0] = bf.Curva_Z(datoNitidoAlcohol, 0.8, 5.373);
            nivsMemAlcohol[1] = bf.TriangularSuave(datoNitidoAlcohol, 0.8, 5.373, 9);
            nivsMemAlcohol[2] = bf.Curva_S(datoNitidoAlcohol, 5.373, 9);
            return MuestraNivMemMay(("\n-Membresías Alcohol: " + datoNitidoAlcohol), nivsMemAlcohol);
        }

        // Método Fuzzificar Sabor.
        public String FuzzificarSabor(double datoNitidoSabor) {
            String conjunto = "";
            ProdMembsSabor(datoNitidoSabor);
            conjunto = conjuntosSabor[PosNivMemMay(nivsMemSabor)];
            return conjunto;
        }

        // Método Fuzzificar Temperatura.
        public String FuzzificarTemperatura(double datoNitidoTemperatura) {
            String conjunto = "";
            ProdMembsTemperatura(datoNitidoTemperatura);
            conjunto = conjuntosTemperatura[PosNivMemMay(nivsMemTemperatura)];
            return conjunto;
        }

        // Método Fuzzificar Alcohol.
        public String FuzzificarAlcohol(double datoNitidoAlcohol) {
            String conjunto = "";
            ProdMembsAlcohol(datoNitidoAlcohol);
            conjunto = conjuntosAlcohol[PosNivMemMay(nivsMemAlcohol)];
            return conjunto;
        }

        // Método Inferir Estilo Difusa Cualitativo.
        public String InferirEstiloDifusaCualitativo(String saborDifuso, String temperaturaDifuso,
            String alcoholDifuso) {
            String estiloDifuso = "";
            if (saborDifuso.Equals("Dulce") && (temperaturaDifuso.Equals("Muy-Fría") ||
                temperaturaDifuso.Equals("Fría")) || temperaturaDifuso.Equals("Tibia")) {
                if (alcoholDifuso.Equals("Alto")) {
                    estiloDifuso = "ScotchAle";
                }
                else if (alcoholDifuso.Equals("Medio")) {
                    estiloDifuso = "Dunkel";
                }
                else {
                    estiloDifuso = "Kolsch-Saison-Vienna";
                }
            }
            else if (saborDifuso.Equals("Intermedio") && (temperaturaDifuso.Equals("Muy-Fría") ||
                 temperaturaDifuso.Equals("Fría")) || temperaturaDifuso.Equals("Tibia")) {
                if (alcoholDifuso.Equals("Alto")) {
                    estiloDifuso = "GoldenAle";
                }
                else if (alcoholDifuso.Equals("Medio")) {
                    estiloDifuso = "Bitter-PaleAle";
                }
                else {
                    estiloDifuso = "Hefeweizen";
                }
            }
            else if (saborDifuso.Equals("Amarga") && (temperaturaDifuso.Equals("Muy-Fría") ||
                temperaturaDifuso.Equals("Fría")) || temperaturaDifuso.Equals("Tibia")) {
                if (alcoholDifuso.Equals("Alto")) {
                    estiloDifuso = "AgaveAle-Stout-Porter";
                }
                else if (alcoholDifuso.Equals("Medio")) {
                    estiloDifuso = "BlondeAle";
                }
                else {
                    estiloDifuso = "Lager";
                }
            }
            else {
                // Ninguna recomendación.
            }
            return estiloDifuso;
        }

        // Método Inferir Estilo Difusa Cuantitativo.
        public double InferirTallaDifusaCuantitativo(String saborDifuso, String temperaturaDifuso,
            String alcoholDifuso) {
            double nivMemSabor, nivMemTemperatura, nivMemAlcohol, nivMemEstilos;
            nivMemSabor = nivsMemSabor[PosNivMemMay(nivsMemSabor)];
            nivMemTemperatura = nivsMemTemperatura[PosNivMemMay(nivsMemTemperatura)];
            nivMemAlcohol = nivsMemAlcohol[PosNivMemMay(nivsMemAlcohol)];
            // El cálculo se ha colocado una sola vez puesto que es estructuralmente el mismo
            // para todas las reglas. Si fuera distinto en las reglas, cada una debería llevarlo.
            nivMemEstilos = Math.Min(Math.Max(nivMemTemperatura, nivMemSabor), nivMemAlcohol);

            if (saborDifuso.Equals("Dulce") && (temperaturaDifuso.Equals("Muy-Fría") ||
                temperaturaDifuso.Equals("Fría")) || temperaturaDifuso.Equals("Tibia")) {
                if (alcoholDifuso.Equals("Alto")) {
                    nivsMemEstilos[0] = nivMemEstilos;
                }
                else if (alcoholDifuso.Equals("Medio")) {
                    nivsMemEstilos[1] = nivMemEstilos;
                }
                else {
                    nivsMemEstilos[2] = nivMemEstilos;
                }
            }
            else if (saborDifuso.Equals("Intermadio") && (temperaturaDifuso.Equals("Muy-Fría") ||
                 temperaturaDifuso.Equals("Fría")) || temperaturaDifuso.Equals("Tibia")) {
                if (alcoholDifuso.Equals("Alto")) {
                    nivsMemEstilos[3] = nivMemEstilos;
                }
                else if (alcoholDifuso.Equals("Medio")) {
                    nivsMemEstilos[4] = nivMemEstilos;
                }
                else {
                    nivsMemEstilos[5] = nivMemEstilos;
                }
            }
            else if (saborDifuso.Equals("Amarga") && (temperaturaDifuso.Equals("Muy-Fría") ||
                temperaturaDifuso.Equals("Fría")) || temperaturaDifuso.Equals("Tibia")) {
                if (alcoholDifuso.Equals("Alto")) {
                    nivsMemEstilos[6] = nivMemEstilos;
                }
                else if (alcoholDifuso.Equals("Medio")) {
                    nivsMemEstilos[7] = nivMemEstilos;
                }
                else {
                    nivsMemEstilos[8] = nivMemEstilos;
                }
            }
            else {
                // Fuera del rango.
            }
            return nivsMemEstilos[PosNivMemMay(nivsMemEstilos)];
        }

        // Método DesFuzzificar.
        public double Desfuzzificar(String tallaEstilo, double nivMemEstilo) {
            switch (tallaEstilo) {
                case "Kolsch-Saison-Vienna": return nivMemEstilo * 20;
                case "Dunkel": return nivMemEstilo * 40;
                case "ScotchAle": return nivMemEstilo * 60;
                case "Hefeweizen": return nivMemEstilo * 80;
                case "Bitter-PaleAle": return nivMemEstilo * 100;
                case "GoldenAle": return nivMemEstilo * 120;
                case "Lager": return nivMemEstilo * 140;
                case "BlondeAle": return nivMemEstilo * 160;
                case "AgaveAle-Stout-Porter": return nivMemEstilo * 180;
            }
            return 0.0;
        }
    }
}