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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        string im = "";
        string na = "";
        string np = "";
        DateTime da = DateTime.Now;


        private void button1_Click(object sender, EventArgs e)
        {
            using (Form2 okno = new Form2(im, na, np, da))
            {
                okno.ShowDialog();

                if (!(okno.tytul.Equals("")))
                {
                    tytul.Text = okno.tytul;
                    tresc.Text = okno.twierdzenie;
                    button1.Text = "Edytuj dane";
                    im = okno.fimie;
                    na = okno.fnazwisko;
                    np = okno.fpromotor;
                    da = okno.fdata;

                }
            }
        }

 
    }
}
