using System;
using System.Collections.Generic;
using System.Linq;
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
        List<Historik> Historiken = new List<Historik>(); 

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Startskärmen får en bredd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 510;
            textBox1.Width = 258;
        }
        /// <summary>
        /// Standard miniräknaren får den bredd som startskärmen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiniräknartypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 510;
            textBox1.Width = 258;
        }
        /// <summary>
        /// Skrämens bredd ökas och visar därmed ytterligare knappar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UtökadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 750;
            textBox1.Width = 258;
        }
        /// <summary>
        /// När meny alternativet klickas öppnas ett nytt form och den gamla tas ned
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// När meny alternativet klickas öppnas ett nytt form och den gamla tas ned
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// När meny alternativet klickas öppnas ett nytt form och den gamla tas ned
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypvärdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var frm = new Form4
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };  
            frm.Show();
            this.Hide();
        }
        /// <summary>
        /// När knapparna från 0-9, pi eller . trycks på skörs metoden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender; /*Den knappen som tryckts ned avläses för att rätt knapp ska användas. */
            /*Om det står 0 i textboxen försvinnertalet om det man skriver in inte är .*/
            if ((textBox1.Text == "0") || (angivet_värde))
                if (num.Text != ",")
                    textBox1.Text = "";

            angivet_värde = false;

            if (num.Text == ",") /*Trycker man på knappen för . kollas det om det redan finns i talet. Gör det det så skrivs inget ut. Annars gör det det.*/
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }
        /// <summary>
        /// När knapparna + - * eller / trycks på skörs metoden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Aritmetisk_operation(object sender, EventArgs e)
        {
                Button num = (Button)sender; /*Den knappen som tryckts ned avläses för att rätt knapp ska användas.*/
                operation = num.Text;
                resultat = Double.Parse(textBox1.Text); /*Det som stod i textrutan sparas för att användas i ekvationen*/
                textBox1.Text = ""; /*Över textrutan visas det tidigare talet med operationen.*/
                label1.Text = System.Convert.ToString(resultat) + " " + operation;
        }
        /// <summary>
        /// Trycker man på enter räknas den ekvation man valt ut. Exempelvis om man valt addition räknas det ut och visas på skärmen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnter_Click(object sender, EventArgs e)
        {  /*Skriver användaren inte in det andra värdet körs inte operationen*/
            if (textBox1.Text != "")
            {
                switch (operation)
                {
                    case "+": /*Om det finns ett additions tecken görs en addition och svaret sparas i en variabel för senare användning*/
                        svar = (resultat + Double.Parse(textBox1.Text)).ToString();
                        ans = double.Parse(svar);
                        break;
                    case "-": /*Samma funktion som innan*/
                        svar = (resultat - Double.Parse(textBox1.Text)).ToString();
                        ans = double.Parse(svar);
                        break;
                    case "*": /*Samma funktion som innan*/
                        svar = (resultat * Double.Parse(textBox1.Text)).ToString();
                        ans = double.Parse(svar);
                        break;
                    case "/": /*Samma funktion som innan*/
                        svar = (resultat / Double.Parse(textBox1.Text)).ToString();
                        ans = double.Parse(svar);
                        break;
                    default:
                        break;
                }
                
                label1.Text = label1.Text + " " + textBox1.Text + " " + "=" + " " + svar;
                textBox1.Text = "0";
            }
            else
                label1.Text = "";
            
        }
        /// <summary>
        /// När man trycker på clear nollställs allt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultat = 0;
            label1.Text = "";
        }
        /// <summary>
        /// När man trycker på return försvinner den senaste skrivna siffran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buttonreturn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }

            if (textBox1.Text.Length > 1) /*Om det finns mer än en siffra försvinner den längst till höger*/
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        /// <summary>
        /// Svaret man fick från förra ekvationen anropas och används
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAns_Click(object sender, EventArgs e)
        {
            textBox1.Text = ans.ToString();
        }
        /// <summary>
        /// När man trycker på knappen för i kvadrat multipliceras talet med sig själv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonKvadrat2_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(textBox1.Text) * double.Parse(textBox1.Text);
            label1.Text = textBox1.Text + "^" + 2 + " " + "=" + " " + tal.ToString();
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /// <summary>
        /// När man trycker på knappen för a^n multipliceras talet med sig självt n antal gånger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            label1.Text = textBox1.Text + "^" + n + " " + "=" + " " + tal;
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /// <summary>
        /// Knappen pi har ett värde på 3.1415... och används som en vanlig siffra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + Math.PI;
        }
        /// <summary>
        /// Metoden använder det inskrivna talet, omvandlar det till radius och beroende på nedtryckt knapp sätter in det i sinus, cosinus eller tangens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoden kör roten ur det inskrivna talet och skriver sedan ut svaret på skärmen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRoten_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(textBox1.Text);
            tal = Math.Sqrt(tal); //Uträkning
            label1.Text = "√" + textBox1.Text + " " + "=" + " " + tal.ToString();
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /// <summary>
        /// Metoden räknar ut n√ av det inskrivna talet och skrver ut svaret
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRotenN_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double n = decimal.ToDouble(numericUpDown2.Value); //Talet n tas från värdet man kan välja bredvid knappen

            double tal = Math.Pow(a, 1 / n); //Räknar n√ av det inskrivna talet

            label1.Text = n + "√" + textBox1.Text + " " + "=" + " " + tal;
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /// <summary>
        /// Metoden hämtar det inskrivna talet och lägger det i den naturliga logaritmen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLn_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(textBox1.Text);
            tal = Math.Log(tal);
            label1.Text = "ln(" + textBox1.Text + ")" + " " + "=" + " " + tal;
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /// <summary>
        /// Metoden hämtar det inskriva talet och lägger det i 10 logarimen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLog_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(textBox1.Text);
            tal = Math.Log10(tal);
            label1.Text = "ln(" + textBox1.Text + ")" + " " + "=" + " " + tal;
            textBox1.Text = "0";
            ans = tal; //Svaret kan anropas genom knappen ans
        }
        /// <summary>
        /// Varje gång label1 uppdateras läggs det till i historiken och skrivs ut i listboxen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Uppdatering_historik(object sender, EventArgs e)
        {   /*if satsen säger att om label1 innehåller ett = tecken körs satsen*/
            if (label1.Text.Contains("="))
                {
                    Historiken.Add(new Historik(label1.Text));
                    ListboxHistorik.Items.Clear(); //Listboxen töms för att inte nya historiken ska skrivas ovanför den gamla
                                                   /*For loppen går igenom listan med historik bakvänt och lägger till elementen i Listbox som visas på skärmen*/
                    for (int i = Historiken.Count; i > 0; i--)
                    {
                        ListboxHistorik.Items.Add(i + "." + "   " + Historiken[i - 1].Ekvation); // I fungerar som ett indexnummer
                    }
                }
        }
        /// <summary>
        /// Trycker man på knappen för Clear History rensas historiken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClearHistory_Click(object sender, EventArgs e)
        {
            ListboxHistorik.Items.Clear();
            Historiken.Clear();
        }
        /// <summary>
        /// Metoden anropar en av ekvatioenerna i hisstoriken genom att man anger numret som visas framför ekvationen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCallEquation_Click(object sender, EventArgs e)
        {
            int n = decimal.ToInt32(numericUpDown3.Value); //Talet n tas från värdet man kan välja bredvid knappen.
            label1.Text = Historiken[n - 1].Ekvation;
            textBox1.Text = Historiken[n - 1].Ekvation.Split('=').Last(); // När ekvationen hämtas lägger sig svaret ut ekvationen i skrivrutan.
        }
    }
}