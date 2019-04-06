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
    public partial class Form1 : Form
    {
        double resultat = 0;
        String operation = "";
        bool angivet_värde = false;

        public Form1()
        {
            InitializeComponent();
        }
        /*Startskärmen får en bredd*/
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 510;
            textBox1.Width = 258;
        }
        /*Standard miniräknaren får den bredd som startskärmen*/
        private void miniräknartypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 510;
            textBox1.Width = 258;
        }
        /*Skrämens bredd ökas och visar därmed ytterligare knappar*/
        private void utökadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 685;
            textBox1.Width = 258;
        }
        /*När meny alternativet klickas öppnas ett nytt form och den gamla tas ned*/
        private void hexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); }; /*När det nya form stängs ned öppnas det gamla igen*/
            frm.Show();
            this.Hide();
        }
        /*När meny alternativet klickas öppnas ett nytt form och den gamla tas ned*/
        private void binärToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };  /*När det nya form stängs ned öppnas det gamla igen*/
            frm.Show();
            this.Hide();
        }
        /*När meny alternativet klickas öppnas ett nytt form och den gamla tas ned*/
        private void typvärdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };  /*När det nya form stängs ned öppnas det gamla igen*/
            frm.Show();
            this.Hide();
        }
        /*När knapparna från 0-9 eller . trycks på skörs metoden*/
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (angivet_värde))
                textBox1.Text = "";
            angivet_värde = false;
            Button num = (Button) sender; /*Den knappen som tryckts ned avläses för att rätt knapp ska användas. */
            if (num.Text == ".") /*Trycker man på knappen för . kollas det om det redan finns i talet. Gör det det så skrivs inget ut. Annars gör det det.*/
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void Aritmetisk_operation(object sender, EventArgs e)
        {
            Button num = (Button) sender;
            operation = num.Text;
            resultat = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(resultat) + " " + operation;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " " +textBox1.Text;
            switch (operation)
            {
                case "+":
                    textBox1.Text = (resultat + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultat - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultat * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultat / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultat = 0;
            label1.Text = "";
        }
    }
}
