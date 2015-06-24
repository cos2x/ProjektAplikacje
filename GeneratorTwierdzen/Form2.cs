using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorTwierdzen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = limie.Text;
            string nazwisko = lnazwisko.Text;
            string nazwiskop = lpromotor.Text;
            int dzien = ldata.Value.Day;
            int miesiac = ldata.Value.Month;
            int rok = ldata.Value.Year;
            // konwertujemy string na sumę liczb odpowiadających każdemu znakowi w ascii
            int imieliczba = 0;
            for (int i = 0; i < imie.Length; i++)
            {
                imieliczba += (int)imie[i];
            }
            int nazwiskoliczba = 0;
            for (int i = 0; i < nazwisko.Length; i++)
            {
                nazwiskoliczba += (int)nazwisko[i];
            }
            int promotorliczba = 0;
            for (int i = 0; i < nazwiskop.Length; i++)
            {
                promotorliczba += (int)nazwiskop[i];
            }

            // wypisujemy wektory wyrażeń do generowanych zdań
            string[] kategoria = new string[] { "Geometria", "Teoria Liczb", "Topologia" };
            string[] costam = new string[] { "Twierdzenie", "Paradoks", "Lemat", "Hipoteza", "Aksjomat" };

            string[] geomn = new string[] { "Cauchy'ego", "Lagrange'a", "Peano", "Riemanna", "Gaussa", "Jordana", "Talesa", "Euklidesa", "Pitagorasa" };
            string[] geom1 = new string[] { "trójkąta", "odcinka", "wielokąta", "sześcianu", "koła", "punktu", "okręgu" };
            string[] geom2 = new string[] { "ostrosłup", "punkt", "wektor", "prostokąt", "kwadrat", "okrąg", "wierzchołek", "student", "graf", "breloczek" };
            string[] geom3 = new string[] { "z nim izometryczny", "od niego większy", "od niego różny", "z którym nie ma żadnych punktów wspólnych", "o mniejszej średnicy", "od niego ładniejszy"};

            string[] topon = new string[] { "Lindelofa", "Banacha", "Tarskiego", "Kuratowskiego", "Brouwera", "Cantora", "Hausdorffa", "Hilberta"};
            string[] topo1 = new string[] { "Kwadrat", "Płaszczyzna", "Koło", "Spirala", "Krzywa Peano", "Sfera", "Dwa punkty" };
            string[] topo2 = new string[] { "prostokąt", "trójkąt", "punkt", "prosta", "zbiór Cantora", "zbiór pusty", "liczba 7", "Czechosłowacja", "wszechświat" };
            string[] topo3 = new string[] { "nie mają żadnych ciekawych własności", "są homeomorficzne", "to tak naprawdę to samo", "nie są homeomorficzne", "pod wpływem zimna stają się niespójne", "po zmieszaniu z wodą stają się kulą"};

            string[] teoln = new string[] { "Sierpińskiego", "Zermelo", "Archimedesa", "Goldbacha", "Eulera", "Peano", "Fermata", "Euklidesa", "Weierstrassa" };
            string[] teol1 = new string[] { "pierwszą", "podzielną przez 3", "nieparzystą", "dodatnią", "ujemną", "większą od 5", "mniejszą od 30" };
            string[] teol2 = new string[] { "sumę trzech", "sumę dwóch", "iloczyn trzech", "iloraz dwóch", "macierz złożoną z", "różnicę dwóch" };
            string[] teol3 = new string[] { "liczb pierwszych", "liczb zespolonych", "liczb dwucyfrowych", "jedynek", "zer", "cukierków", "liczb kardynalnych", "liczb Fibonacciego"};

           //Przygotowujemy indeksy, na podstawie których zostanie wygenerowane twierdzenie
            int ktorakategoria = (imieliczba + nazwiskoliczba + promotorliczba + dzien + miesiac + rok) % kategoria.Length;
            int icostam = (imieliczba * dzien + nazwiskoliczba + promotorliczba + miesiac) % costam.Length;
            int zn = 0, z1 = 0, z2 = 0, z3 = 0;
            switch (ktorakategoria)
            {
                case 0:
                    zn = geomn.Length;
                    z1 = geom1.Length;
                    z2 = geom2.Length;
                    z3 = geom3.Length;
                    break;
                case 1:
                    zn = teoln.Length;
                    z1 = teol1.Length;
                    z2 = teol2.Length;
                    z3 = teol3.Length;
                    break;
                case 2:
                    zn = topon.Length;
                    z1 = topo1.Length;
                    z2 = topo2.Length;
                    z3 = topo3.Length;
                    break;
            }
            int iktostam1 = (miesiac * (rok + imieliczba) + promotorliczba) % zn;
            int iktostam2 = (rok * (miesiac + dzien) + nazwiskoliczba) % zn;
            int zdanie1 = (miesiac * imieliczba + promotorliczba + dzien) % z1;
            int zdanie2 = (4 * dzien + nazwiskoliczba + 3*imieliczba) % z2;
            int zdanie3 = (imieliczba + promotorliczba + nazwiskoliczba + miesiac * rok) % z3;

            string zdanie = "";
            string tytulzdania = "";
            switch (ktorakategoria)
            {
                case 0:
                    if (iktostam1 == iktostam2) tytulzdania = costam[icostam] + " " + geomn[iktostam1];
                    else tytulzdania = costam[icostam] + " " + geomn[iktostam1] + "-" + geomn[iktostam2];
                    zdanie = "Dla każdego " + geom1[zdanie1] + " istnieje " + geom2[zdanie2] + " " + geom3[zdanie3] + ".";
                    break;
                case 1:
                    if (iktostam1 == iktostam2) tytulzdania = costam[icostam] + " " + teoln[iktostam1];
                    else tytulzdania = costam[icostam] + " " + teoln[iktostam1] + "-" + teoln[iktostam2];
                    zdanie = "Każdą liczbę " + teol1[zdanie1] + " można zapisać jako " + teol2[zdanie2] + " " + teol3[zdanie3] + ".";
                    break;
                case 2:
                    if (iktostam1 == iktostam2) tytulzdania = costam[icostam] + " " + topon[iktostam1];
                    else tytulzdania = costam[icostam] + " " + topon[iktostam1] + "-" + topon[iktostam2];
                    zdanie = topo1[zdanie1] + " i " + topo2[zdanie2] + " " + topo3[zdanie3] + ".";
                    break;
            }
            label6.Text = tytulzdania;
            label7.Text = zdanie;

             
            Close();
        }
        public string tytul { get { return label7.Text; } }
        public string twierdzenie { get { return label6.Text; } }
    }
}
