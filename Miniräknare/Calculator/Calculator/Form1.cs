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
        double ans;
        string svar;
        String operation = "";
        bool angivet_värde = false;
        List<Historik> Historiken = new List<Historik>(); //Skapar en lista som håller all historik

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
        private void MiniräknartypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 510;
            textBox1.Width = 258;
        }
        /*Skrämens bredd ökas och visar därmed ytterligare knappar*/
        private void UtökadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 750;
            textBox1.Width = 258;
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
        /*När meny alternativet klickas öppnas ett nytt form och den gamla tas ned*/
        private void TypvärdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Den nya form får samma position som den tidigare och en startposition som anges manuellt av datorn*/
            var frm = new Form4
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };  /*När det nya form stängs ned, öppnas den gamla igen*/
            frm.Show();
            this.Hide();
        }
        /*När knapparna från 0-9, pi eller . trycks på skörs metoden*/
        private void Button_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender; /*Den knappen som tryckts ned avläses för att rätt knapp ska användas. */
            /*Om det står 0 i textboxen försvinnertalet om det man skriver in inte är .*/
            if ((textBox1.Text == "0") || (angivet_värde))
                if (num.Text != ".")
                    textBox1.Text = "";

            angivet_värde = false;

            if (num.Text == ".") /*Trycker man på knappen för . kollas det om det redan finns i talet. Gör det det så skrivs inget ut. Annars gör det det.*/
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }
        /*När knapparna + - * eller / trycks på skörs metoden*/
        private void Aritmetisk_operation(object sender, EventArgs e)
        {
            Button num = (Button)sender; /*Den knappen som tryckts ned avläses för att rätt knapp ska användas.*/
            operation = num.Text;
            resultat = Double.Parse(textBox1.Text); /*Det som stod i textrutan sparas för att användas i ekvationen*/
            textBox1.Text = ""; /*Över textrutan visas det tidigare talet med operationen.*/
            label1.Text = System.Convert.ToString(resultat) + " " + operation;
        }
        /*Trycker man på enter räknas den ekvation man valt ut. Exempelvis om man valt addition räknas det ut och visas på skärmen*/
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+": /*Om det finns ett additions tecken görs en addition och svaret sparas i en variabel för senare användning*/
                    svar = (resultat + Double.Parse(textBox1.Text)).ToString();
                    ans = double.Parse(svar);
                    break;
                case "-": /*Om det finns ett subtraktions tecken görs en subtraktion och svaret sparas i en variabel för senare användning*/
                    svar = (resultat - Double.Parse(textBox1.Text)).ToString();
                    ans = double.Parse(svar);
                    break;
                case "*": /*Om det finns ett multiplikations tecken görs en multiplikation och svaret sparas i en variabel för senare användning*/
                    svar = (resultat * Double.Parse(textBox1.Text)).ToString();
                    ans = double.Parse(svar);
                    break;
                case "/": /*Om det finns ett divisions tecken görs en division och svaret sparas i en variabel för senare användning*/
                    svar = (resultat / Double.Parse(textBox1.Text)).ToString();
                    ans = double.Parse(svar);
                    break;
                default:
                    break;

            }
            /*Ekvationen skrivs ut överst*/
            label1.Text = label1.Text + " " + textBox1.Text + " " + "=" + " " + svar;
            textBox1.Text = "0";
        }
        /*När man trycker på clear nollställs allt*/
        private void Buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultat = 0;
            label1.Text = "";
        }
        /*När man trycker på return försvinner den senaste skrivna siffran*/
        private void Buttonreturn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1) /*Om den bara finns en siffra i textrutan blir det en 0*/
            {
                textBox1.Text = "0";
            }

            if (textBox1.Text.Length > 1) /*Om det finns mer än en siffra försvinner den längst till höger*/
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        /*Svaret man fick från förra ekvationen anropas och används*/
        private void ButtonAns_Click(object sender, EventArgs e)
        {
            textBox1.Text = ans.ToString();
        }
        /*När man trycker på knappen för i kvadrat multipliceras talet med sig själv*/
        private void ButtonKvadrat2_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(textBox1.Text) * double.Parse(textBox1.Text);
            label1.Text = textBox1.Text + "^" + 2 + " " + "=" + " " + tal.ToString();
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /*När man trycker på knappen för a^n multipliceras talet med sig självt n antal gånger*/
        private void ButtonKvadratN_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            decimal n = numericUpDown1.Value; //Talet n tas från värdet man kan välja bredvid knappen
            double tal = a;
            /*Talet a multipliceras med sig självt n antal gånger i en loop*/
            for (int i = 1; i < n; i++)
            {
                tal = tal * a;
            }
            /*Svaret skrivs ut*/
            label1.Text = textBox1.Text + "^" + n + " " + "=" + " " + tal;
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /*Knappen pi har ett värde på 3.1415... och används som en vanlig siffra*/
        private void ButtonPi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + Math.PI;
        }
        /*Metoden använder det inskrivna talet, omvandlar det till radius och beroende på nedtryckt knapp sätter in det i sinus, cosinus eller tangens*/
        private void SinCosTan_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender; /*Den knappen som tryckts ned avläses för att rätt knapp ska användas.*/
            operation = num.Text;
            double tal = double.Parse(textBox1.Text);
            tal = tal * Math.PI / 180.0; //Omvandlas till radius
            /*Switchen gör att beroende på vilken knapp som blir nedtryck körs olika uträkninar*/
            switch (operation)
            {
                case "Sin":
                    tal = Math.Sin(tal);
                    label1.Text = "Sin(" + textBox1.Text + ") " + "= " + tal;
                    break;
                case "Cos":
                    tal = Math.Cos(tal);
                    label1.Text = "Cos(" + textBox1.Text + ") " + "= " + tal;
                    break;
                case "Tan":
                    tal = Math.Tan(tal);
                    label1.Text = "Tan(" + textBox1.Text + ") " + "= " + tal;
                    break;
                default:
                    break;
            }
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /*Metoden kör roten ur det inskrivna talet och skriver sedan ut svaret på skärmen*/
        private void ButtonRoten_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(textBox1.Text);
            tal = Math.Sqrt(tal); //Uträkning
            label1.Text = "√" + textBox1.Text + " " + "=" + " " + tal.ToString();
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /*Metoden räknar ut n√ av det inskrivna talet och skrver ut svaret*/
        private void ButtonRotenN_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double n = decimal.ToDouble(numericUpDown2.Value); //Talet n tas från värdet man kan välja bredvid knappen

            double tal = Math.Pow(a, 1 / n); //Räknar n√ av det inskrivna talet

            label1.Text = n + "√" + textBox1.Text + " " + "=" + " " + tal;
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /*Metoden hämtar det inskrivna talet och lägger det i den naturliga logaritmen*/
        private void ButtonLn_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(textBox1.Text);
            tal = Math.Log(tal);
            label1.Text = "ln(" + textBox1.Text + ")" + " " + "=" + " " + tal;
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /*Metoden hämtar det inskriva talet och lägger det i 10 logarimen*/
        private void ButtonLog_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(textBox1.Text);
            tal = Math.Log10(tal);
            label1.Text = "ln(" + textBox1.Text + ")" + " " + "=" + " " + tal;
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /*Varje gång textboxen uppdateras läggs det till i historiken och skrivs ut i listboxen*/
        private void Uppdatering_historik(object sender, EventArgs e)
        {   /*if satsen säger att om label1 innehåller ett = tecken körs satsen*/
            if (label1.Text.Contains("="))
            {
                Historiken.Add(new Historik(label1.Text)); 
                ListboxHistorik.Items.Clear(); //Listboxen töms för att inte nya historiken ska skrivas ovanför den gamla
                /*For loppen går igenom listan med historik bakvänt och lägger till elementen i Listbox som visas på skärmen*/
                for (int i = Historiken.Count; i > 0; i--)
                {
                    ListboxHistorik.Items.Add(Historiken[i - 1].Ekvation);
                }
            }
        }
    }
}
