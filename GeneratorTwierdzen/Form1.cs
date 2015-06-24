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

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form2 okno = new Form2())
            {
                okno.ShowDialog();

                if (!(okno.tytul.Equals("")))
                {
                    tytul.Text = okno.tytul;
                    tresc.Text = okno.twierdzenie;
                    button1.Text = "Wprowadź nowe dane";
                }
            }
        }

 
    }
}
