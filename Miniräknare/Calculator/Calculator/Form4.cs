using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form4 : Form
    {
        List<double> lista = new List<double>();
        double sum = 0;

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
        /*Har samma funktin som övre*/
        private void UtökadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var frm = new Form1
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };  
            frm.Show();
            this.Hide();
        }
        /*Har samma funktin som övre*/
        private void HexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var frm = new Form2
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); }; 
            frm.Show();
            this.Hide();
        }
        /*Har samma funktin som övre*/
        private void BinärToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var frm = new Form3
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };  
            frm.Show();
            this.Hide();
        }
        /*När Add knappen trycks på läggs talet in i en lista*/
        private void Add_Click(object sender, EventArgs e)
        {   /*Det man lägger till måste vara någonting, annars händer ingenting*/
            if(input.Text == "")
            {

            }
            else
            {
                lista.Add(double.Parse(input.Text));
                input.Clear();
                listBox1.Items.Clear();
                for (int i = lista.Count; i > 0; i--)
                {
                    listBox1.Items.Add(i + "." + "   " + lista.ElementAt(i - 1)); // I fungerar som ett indexnummer
                }
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
        /*Metoden sorterar listan i storleksordning genom bubblesort.
         Bubblesort används eftersom listan som används inte kommer 
         vara speciellt lång och tiden därmed inte kommer påverka.
         Tagen från didigare uppgift*/
        public static void Bubblesort(List<double> li, double length)
        {
            /*Går igenom alla tal i listan*/
            for (double m = length - 1; m > 0; m--)
            {
                /*Går igenom alla tal som ska bytas*/
                for (int n = 0; n < m; n++)
                {
                    /*Utför en swapmetod, som därmed byter plats på de två talen 
                      som jämförs om det tidigare talet är större än det senare*/
                    if (li[n] > li[n + 1])
                    {

                        double temp = li[n];
                        li[n] = li[n + 1];
                        li[n + 1] = temp;
                    }
                }
            }
        }
        /*Trycker man på knappen för medianen räknar man ut medianen för listan*/
        private void MedianVärde_Click(object sender, EventArgs e)
        {
            Bubblesort(lista, lista.Count); //Metoden Bubblesort anropas.

            if (lista.Count % 2 == 0) //Är listan ett jämt antal körs satsen
            {
                double median = lista[lista.Count / 2] + lista[(lista.Count / 2) + 1] / 2; //Medianen räknas ut som medelvärdet av de två mittersta talen
                Median_value.Text = median.ToString();
            }
            else
            {
                Median_value.Text = lista[(lista.Count / 2)].ToString(); //Mittentalet letas upp och används
            }
        }
        /*Trycker man på knappen för medelvärde räknas medelvärdet för listan ut*/
        private void MedelVärde_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= lista.Count; i++)
            {
                 sum += lista[i-1]; //Varje tal i listan adderas ihop till en summa
            }
            Medel_value.Text = (sum / lista.Count).ToString(); //Summan divideras på antalet tal för att få fram medelvärdet. 
        }
    }
}
