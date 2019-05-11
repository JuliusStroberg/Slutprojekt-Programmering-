using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form4 : Form
    {
        List<double> lista = new List<double>();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Width = 816;
        }
        /*När meny alternativet klickas öppnas ett nytt form och den gamla tas ned*/
        private void MiniräknartypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Den nya form får samma position som den tidigare och en startposition som anges manuellt av datorn*/
            var frm = new Form1
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };  /*När det nya form stängs ned, öppnas den gamla igen*/
            frm.Show();
            this.Hide();
        }
        /*När meny alternativet klickas öppnas ett nytt form och den gamla tas ned*/
        private void UtökadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Den nya form får samma position som den tidigare och en startposition som anges manuellt av datorn*/
            var frm = new Form1
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };  /*När det nya form stängs ned, öppnas den gamla igen*/
            frm.Show();
            this.Hide();
        }
        /*När meny alternativet klickas öppnas ett nytt form och den gamla tas ned*/
        private void HexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Den nya form får samma position som den tidigare och en startposition som anges manuellt av datorn*/
            var frm = new Form2
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); }; /*När det nya form stängs ned, öppnas den gamla igen*/
            frm.Show();
            this.Hide();
        }
        /*När meny alternativet klickas öppnas ett nytt form och den gamla tas ned*/
        private void BinärToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Den nya form får samma position som den tidigare och en startposition som anges manuellt av datorn*/
            var frm = new Form3
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };  /*När det nya form stängs ned, öppnas den gamla igen*/
            frm.Show();
            this.Hide();
        }
        /*När Add knappen trycks på läggs talet in i en lista*/
        private void Add_Click(object sender, EventArgs e)
        {
            lista.Add(double.Parse(input.Text));
            input.Clear();
            listBox1.Items.Clear();
            for (int i = lista.Count; i > 0; i--)
            {
                listBox1.Items.Add(i + "." + "   " + lista.ElementAt(i-1)); // I fungerar som ett indexnummer
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            lista.Clear();
            listBox1.Items.Clear();
        }
        /*När man trycker på knappen för typvärde grupperas listan efter tal och sedan antalet av samma nummer.
          Det nummer med flest antal blir typvärdet*/
        private void Typvärde_Click(object sender, EventArgs e)
        {
            double värde = (from värden in lista //Varje nummer i listan 
                         group värden by värden into nyLista //Grupperas för varje siffra i en ny lista
                         orderby nyLista.Count() descending //Den listan sorteras efter antalet tal per siffra med den siffra med flest tal först
                         select nyLista.Key).First(); //Det första talet väljs och blir typvärdet
            Typvärde_value.Text = värde.ToString();
        }
    }
}
