using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificacionCerveza {
    class ListaCervezas {
        // Instancia.
        private List<Cervezas> cervezaLista = new List<Cervezas>();

        // Contructor.
        public ListaCervezas() { }

        // Métodos Get y Set.
        public List<Cervezas> CervezaLista {
            get { return cervezaLista; }
            set { cervezaLista = value; }
        }

        // Iniciar lista con datos.
        public void IniciaLista() {
            Cervezas dt1 = new Cervezas(1, "Heroica", "Dunkel", "Dulce", "Ámbar", 5.3, 10);
            CervezaLista.Add(dt1);
            Cervezas dt2 = new Cervezas(2, "Tres Muertos", "Dunkel", "Dulce", "Ámbar", 5.5, 12);
            CervezaLista.Add(dt2);
            Cervezas dt3 = new Cervezas(3, "Minerva Stout", "Stout", "Intermedio", "Oscura", 5, 10);
            CervezaLista.Add(dt3);
            Cervezas dt4 = new Cervezas(4, "Chela Libre", "Stout", "Amarga", "Oscura", 6.2, 6);
            CervezaLista.Add(dt4);
            Cervezas dt5 = new Cervezas(5, "Drunken", "Stout", "Amarga", "Oscura", 6, 10);
            CervezaLista.Add(dt5);
            Cervezas dt6 = new Cervezas(6, "Santos", "Stout", "Amarga", "Oscura", 4.5, 6);
            CervezaLista.Add(dt6);
            Cervezas dt7 = new Cervezas(7, "Invasión", "Stout", "Dulce", "Oscura", 5, 3);
            CervezaLista.Add(dt7);
            Cervezas dt8 = new Cervezas(8, "Abizmal", "Stout", "Amarga", "Oscura", 8.2, 6);
            CervezaLista.Add(dt8);
            Cervezas dt9 = new Cervezas(9, "Paramo", "Pale Ale", "Amarga", "Clara", 5.2, 3);
            CervezaLista.Add(dt9);
            Cervezas dt10 = new Cervezas(10, "Corazón de Malta", "Pale Ale", "Amarga", "Clara", 5, 6);
            CervezaLista.Add(dt10);
            Cervezas dt11 = new Cervezas(11, "Chela libre", "Pale Ale", "Intermedio", "Clara", 5.8, 4);
            CervezaLista.Add(dt11);
            Cervezas dt12 = new Cervezas(12, "Minerva", "Pale Ale", "Intermedio", "Ámbar", 6, 10);
            CervezaLista.Add(dt12);
            Cervezas dt13 = new Cervezas(13, "Z - Rush", "Pale Ale", "Intermedio", "Ámbar", 5, 3);
            CervezaLista.Add(dt13);
            Cervezas dt14 = new Cervezas(14, "Medusa", "Pale Ale", "Amarga", "Ámbar", 5, 6);
            CervezaLista.Add(dt14);
            Cervezas dt15 = new Cervezas(15, "Ingrata", "Pale Ale", "Dulce", "Ámbar", 5.5, 10);
            CervezaLista.Add(dt15);
            Cervezas dt16 = new Cervezas(16, "Tenebrosa", "Pale Ale", "Dulce", "Clara", 5.5, 8);
            CervezaLista.Add(dt16);
            Cervezas dt17 = new Cervezas(17, "Misterio", "Pale Ale", "Dulce", "Clara", 6, 3);
            CervezaLista.Add(dt17);
            Cervezas dt18 = new Cervezas(18, "Allende", "Golden Ale", "Intermedio", "Clara", 4.5, 8);
            CervezaLista.Add(dt18);
            Cervezas dt19 = new Cervezas(19, "El secreto", "Golden Ale", "Intermedio", "Ámbar", 6, 5);
            CervezaLista.Add(dt19);
            Cervezas dt20 = new Cervezas(20, "Karamawi", "Golden Ale", "Intermedio", "Ámbar", 8, 4);
            CervezaLista.Add(dt20);
            Cervezas dt21 = new Cervezas(21, "Zamora", "Golden Ale", "Intermedio", "Ámbar", 5, 3);
            CervezaLista.Add(dt21);
            Cervezas dt22 = new Cervezas(22, "Chalupa", "Golden Ale", "Dulce", "Ámbar", 5, 6);
            CervezaLista.Add(dt22);
            Cervezas dt23 = new Cervezas(23, "Ruta Libre", "Golden Ale", "Dulce", "Ámbar", 5, 6);
            CervezaLista.Add(dt23);
            Cervezas dt24 = new Cervezas(24, "Pulpo", "Stout", "Amarga", "Oscura", 6, 6);
            CervezaLista.Add(dt24);
            Cervezas dt25 = new Cervezas(25, "FH 110", "Stout", "Amarga", "Oscura", 4.5, 4);
            CervezaLista.Add(dt25);
            Cervezas dt26 = new Cervezas(26, "Wasumara", "Agave Ale", "Amarga", "Oscura", 7, 3);
            CervezaLista.Add(dt26);
            Cervezas dt27 = new Cervezas(27, "Band", "Agave Ale", "Amarga", "Ámbar", 4.9, 4);
            CervezaLista.Add(dt27);
            Cervezas dt28 = new Cervezas(28, "Mestiza", "Agave Ale", "Amarga", "Clara", 8.1, 7);
            CervezaLista.Add(dt28);
            Cervezas dt29 = new Cervezas(29, "Doppelbock", "Agave Ale", "Amarga", "Oscura", 8.5, 3);
            CervezaLista.Add(dt29);
            Cervezas dt30 = new Cervezas(30, "Minerva Ita", "Agave Ale", "Amarga", "Ámbar", 7, 13);
            CervezaLista.Add(dt30);
            Cervezas dt31 = new Cervezas(31, "Vida Latina", "Agave Ale", "Amarga", "Ámbar", 4.5, 4);
            CervezaLista.Add(dt31);
            Cervezas dt32 = new Cervezas(32, "Quarzo", "Sin Alcohol", "Amarga", "Clara", 0.8, 6);
            CervezaLista.Add(dt32);
            Cervezas dt33 = new Cervezas(33, "ITA", "Agave Ale", "Amarga", "Ámbar", 5, 8);
            CervezaLista.Add(dt33);
            Cervezas dt34 = new Cervezas(34, "Steinbock", "Hefeweizen", "Amarga", "Clara", 5.5, 3);
            CervezaLista.Add(dt34);
            Cervezas dt35 = new Cervezas(35, "Matrioshka", "Hefeweizen", "Intermedio", "Clara", 5, 2);
            CervezaLista.Add(dt35);
            Cervezas dt36 = new Cervezas(36, "Summer Daze", "Hefeweizen", "Intermedio", "Ámbar", 6, 7);
            CervezaLista.Add(dt36);
            Cervezas dt37 = new Cervezas(37, "Querida", "Hefeweizen", "Intermedio", "Ámbar", 5.5, 4);
            CervezaLista.Add(dt37);
            Cervezas dt38 = new Cervezas(38, "Zurumuato", "Hefeweizen", "Intermedio", "Ámbar", 5, 3);
            CervezaLista.Add(dt38);
            Cervezas dt39 = new Cervezas(39, "Pariente", "Hefeweizen", "Intermedio", "Clara", 5, 3);
            CervezaLista.Add(dt39);
            Cervezas dt40 = new Cervezas(40, "Heroica", "Hefeweizen", "Intermedio", "Clara", 4.1, 7);
            CervezaLista.Add(dt40);
            Cervezas dt41 = new Cervezas(41, "María Porfiria", "Hefeweizen", "Amarga", "Clara", 4.5, 4);
            CervezaLista.Add(dt41);
            Cervezas dt42 = new Cervezas(42, "Ceiba", "Hefeweizen", "Amarga", "Clara", 4.9, 3);
            CervezaLista.Add(dt42);
            Cervezas dt43 = new Cervezas(43, "Patito Heffe", "Hefeweizen", "Intermedio", "Clara", 4.5, 2);
            CervezaLista.Add(dt43);
            Cervezas dt44 = new Cervezas(44, "Minerva Colonial", "Kolsch", "Amarga", "Ámbar", 5, 5);
            CervezaLista.Add(dt44);
            Cervezas dt45 = new Cervezas(45, "Magna", "Kolsch", "Intermedio", "Clara", 4.5, 12);
            CervezaLista.Add(dt45);
            Cervezas dt46 = new Cervezas(46, "Alux Cab", "Kolsch", "Dulce", "Clara", 4.5, 12);
            CervezaLista.Add(dt46);
            Cervezas dt47 = new Cervezas(47, "Caperuza", "Kolsch", "Dulce", "Clara", 5, 8);
            CervezaLista.Add(dt47);
            Cervezas dt48 = new Cervezas(48, "Arlequín", "Kolsch", "Amarga", "Clara", 5, 6);
            CervezaLista.Add(dt48);
            Cervezas dt49 = new Cervezas(49, "Reliquia", "Kölsch", "Intermedio", "Clara", 5.5, 4);
            CervezaLista.Add(dt49);
            Cervezas dt50 = new Cervezas(50, "Buscapleitos", "Porter", "Amarga", "Oscura", 7.1, 10);
            CervezaLista.Add(dt50);
            Cervezas dt51 = new Cervezas(51, "Ticús", "Porter", "Dulce", "Oscura", 4.6, 8);
            CervezaLista.Add(dt51);
            Cervezas dt52 = new Cervezas(52, "Malapinta", "Porter", "Dulce", "Oscura", 8, 5);
            CervezaLista.Add(dt52);
            Cervezas dt53 = new Cervezas(53, "Loba Negra", "Porter", "Amarga", "Oscura", 5, 4);
            CervezaLista.Add(dt53);
            Cervezas dt54 = new Cervezas(54, "Fauna", "Porter", "Intermedio", "Oscura", 5, 4);
            CervezaLista.Add(dt54);
            Cervezas dt55 = new Cervezas(55, "Mulatt", "Porter", "Amarga", "Oscura", 8, 7);
            CervezaLista.Add(dt55);
            Cervezas dt56 = new Cervezas(56, "Campeón", "Porter", "Amarga", "Oscura", 5, 4);
            CervezaLista.Add(dt56);
            Cervezas dt57 = new Cervezas(57, "Amateur", "Porter", "Amarga", "Oscura", 6, 13);
            CervezaLista.Add(dt57);
            Cervezas dt58 = new Cervezas(58, "Ventura", "Porter", "Dulce", "Oscura", 5.5, 7);
            CervezaLista.Add(dt58);
            Cervezas dt59 = new Cervezas(59, "Sierra Fría", "Porter", "Amarga", "Oscura", 6, 4);
            CervezaLista.Add(dt59);
            Cervezas dt60 = new Cervezas(60, "Guanajuato", "Porter", "Amarga", "Oscura", 5, 7);
            CervezaLista.Add(dt60);
            Cervezas dt61 = new Cervezas(61, "Malora", "Porter", "Amarga", "Oscura", 6.5, 8);
            CervezaLista.Add(dt61);
            Cervezas dt62 = new Cervezas(62, "Colimita", "Lager", "Amarga", "Clara", 4.2, 6);
            CervezaLista.Add(dt62);
            Cervezas dt63 = new Cervezas(63, "Cayaco", "Lager", "Amarga", "Clara", 3.9, 3);
            CervezaLista.Add(dt63);
            Cervezas dt64 = new Cervezas(64, "Märzen", "Lager", "Amarga", "Clara", 5.3, 6);
            CervezaLista.Add(dt64);
            Cervezas dt65 = new Cervezas(65, "Acapulco", "Lager", "Amarga", "Ámbar", 4.8,2);
            CervezaLista.Add(dt65);
            Cervezas dt66 = new Cervezas(66, "Temido", "Lager", "Amarga", "Ámbar", 5, 7);
            CervezaLista.Add(dt66);
            Cervezas dt67 = new Cervezas(67, "Concordia", "Lager", "Intermedio", "Clara", 4.7, 3);
            CervezaLista.Add(dt67);
            Cervezas dt68 = new Cervezas(68, "Libertad", "Lager", "Amarga", "Clara", 5, 6);
            CervezaLista.Add(dt68);
            Cervezas dt69 = new Cervezas(69, "Arrecife", "Lager", "Amarga", "Ámbar", 4.2, 2);
            CervezaLista.Add(dt69);
            Cervezas dt70 = new Cervezas(70, "Zapotlense", "Lager", "Amarga", "Clara", 4.2, 2);
            CervezaLista.Add(dt70);
            Cervezas dt71 = new Cervezas(71, "Loba Alteña", "Lager", "Dulce", "Oscura", 4.8, 6);
            CervezaLista.Add(dt71);
            Cervezas dt72 = new Cervezas(72, "Colima", "Lager", "Amarga", "Oscura", 5.4, 4);
            CervezaLista.Add(dt72);
            Cervezas dt73 = new Cervezas(73, "Maligna", "Lager", "Amarga", "Oscura", 5, 3);
            CervezaLista.Add(dt73);
            Cervezas dt74 = new Cervezas(74, "Blonde Witch", "Lager", "Amarga", "Clara", 4.4, 4);
            CervezaLista.Add(dt74);
            Cervezas dt75 = new Cervezas(75, "Saga", "Blonde Ale", "Amarga", "Clara", 6, 7);
            CervezaLista.Add(dt75);
            Cervezas dt76 = new Cervezas(76, "Albur", "Blonde Ale", "Amarga", "Ámbar", 5, 4);
            CervezaLista.Add(dt76);
            Cervezas dt77 = new Cervezas(77, "Libertad", "Blonde Ale", "Amarga", "Ámbar", 5, 3);
            CervezaLista.Add(dt77);
            Cervezas dt78 = new Cervezas(78, "Malaventura", "Blonde Ale", "Amarga", "Clara", 3.7, 4);
            CervezaLista.Add(dt78);
            Cervezas dt79 = new Cervezas(79, "Chaneque", "Blonde Ale", "Intermedio", "Clara", 5.4, 8);
            CervezaLista.Add(dt79);
            Cervezas dt80 = new Cervezas(80, "Veraniega", "Blonde Ale", "Intermedio", "Oscura", 4.4, 2);
            CervezaLista.Add(dt80);
            Cervezas dt81 = new Cervezas(81, "Brewing", "Blonde Ale", "Amarga", "Clara", 5.5, 3);
            CervezaLista.Add(dt81);
            Cervezas dt82 = new Cervezas(82, "5 de Mayo", "Blonde Ale", "Intermedio", "Oscura", 6, 4.5);
            CervezaLista.Add(dt82);
            Cervezas dt83 = new Cervezas(83, "Calavera", "Blonde Ale", "Dulce", "Oscura", 6.4, 8);
            CervezaLista.Add(dt83);
            Cervezas dt84 = new Cervezas(84, "El Pilon", "Scotch Ale", "Dulce", "Oscura", 6.6,6);
            CervezaLista.Add(dt84);
            Cervezas dt85 = new Cervezas(85, "Karamawi", "Scotch Ale", "Dulce", "Oscura", 9, 5);
            CervezaLista.Add(dt85);
            Cervezas dt86 = new Cervezas(86, "Lola", "Scotch Ale", "Dulce", "Oscura", 7, 12);
            CervezaLista.Add(dt86);
            Cervezas dt87 = new Cervezas(87, "Morelos", "Scotch Ale", "Dulce", "Oscura", 5.4, 10);
            CervezaLista.Add(dt87);
            Cervezas dt88 = new Cervezas(88, "Cienfuegos", "Scotch Ale", "Intermedio", "Clara", 5, 3);
            CervezaLista.Add(dt88);
            Cervezas dt89 = new Cervezas(89, "Malteza", "Scotch Ale", "Dulce", "Ámbar", 7.5, 2);
            CervezaLista.Add(dt89);
            Cervezas dt90 = new Cervezas(90, "Yakuza", "Scotch Ale", "Dulce", "Oscura", 6.0, 12);
            CervezaLista.Add(dt90);
            Cervezas dt91 = new Cervezas(91, "5 de Mayo", "Bitter", "Intermedio", "Ámbar", 6, 8);
            CervezaLista.Add(dt91);
            Cervezas dt92 = new Cervezas(92, "Buscapleitos", "Bitter", "Intermedio", "Clara", 5.9, 3);
            CervezaLista.Add(dt92);
            Cervezas dt93 = new Cervezas(93, "Adela", "Bitter", "Amarga", "Clara", 3.9, 6);
            CervezaLista.Add(dt93);
            Cervezas dt94 = new Cervezas(94, "Don Goyo", "Saison", "Intermedio", "Oscura", 4.5, 2);
            CervezaLista.Add(dt94);
            Cervezas dt95 = new Cervezas(95, "Aldanis", "Saison", "Dulce", "Ámbar", 2, 4);
            CervezaLista.Add(dt95);
            Cervezas dt96 = new Cervezas(96, "Embajador", "Agave Ale", "Dulce", "Clara", 7.2, 2);
            CervezaLista.Add(dt96);
            Cervezas dt97 = new Cervezas(97, "Malapinta", "Vienna", "Intermedio", "Clara", 3, 6);
            CervezaLista.Add(dt97);
            Cervezas dt98 = new Cervezas(98, "Ceiba", "Vienna", "Amarga", "Ámbar", 4.8, 4);
            CervezaLista.Add(dt98);
            Cervezas dt99 = new Cervezas(99, "Tres Eles", "Vienna", "Dulce", "Ámbar", 4.5, 5);
            CervezaLista.Add(dt99);
            Cervezas dt100 = new Cervezas(100, "Minerva Viena", "Vienna", "Dulce", "Ámbar", 5, 7);
            CervezaLista.Add(dt100);
        }

        // Ingresar datos a la lista.
        public void InsertarLista(Cervezas dt) {
            CervezaLista.Add(dt);
        }

        // Mostrar la lista.
        public List<Cervezas> MostrarLista() {
            return CervezaLista;
        }

        // Reiniciar la lista.
        public void ReiniciarLista() {
            CervezaLista.Clear();
        }
    }
}