using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Data_Access_Layer;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();
        int raspunsuriCorecte = 0;
        int raspunsuriGresite = 0;

        int index = 0;
        int idTst = 0;
        int x = 0;

        int ore, min, sec, ms = 0;

        public Form8(int idTest)
        {
            InitializeComponent();

            idTst = idTest;

            timer1.Start();
            NextQuestion(index);
        }

        public void NextQuestion(int index1)
        {
            var intrebari = dbContext.Intrebari.Where(i => i.TestId == idTst).ToList();
            x = intrebari.Count;

            afisezLitera.Text = intrebari[index1].TextIntrebare;
            Litera1.Text = intrebari[index1].Raspuns1;
            Litera2.Text = intrebari[index1].Raspuns2;
            Litera3.Text = intrebari[index1].Raspuns3;
            Litera4.Text = intrebari[index1].Raspuns4;
        }

        public void VerificaRaspuns(Button btn)
        {
            if (btn.Text == afisezLitera.Text)
            {
                raspunsuriCorecte++;
                index++;
                raspunsCorect.Text = raspunsuriCorecte.ToString();
                if (index <= x - 1)
                {
                    NextQuestion(index);
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Felicitari! \nTestul a luat sfarsit. \nAti raspuns corect la " + raspunsuriCorecte + " intrebari");

                    Litera1.Enabled = false;
                    Litera2.Enabled = false;
                    Litera3.Enabled = false;
                    Litera4.Enabled = false;
                }
            }
            else
            {
                raspunsuriGresite++;
                index++;
                raspunsGresit.Text = raspunsuriGresite.ToString();

                if (index <= x - 1)
                {
                    NextQuestion(index);
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Felicitari! \nTestul a luat sfarsit. \nAti raspuns corect la " + raspunsuriCorecte + " intrebari");
                    Litera1.Enabled = false;
                    Litera2.Enabled = false;
                    Litera3.Enabled = false;
                    Litera4.Enabled = false;
                }
            }
        }

        private void SalveazaRaspuns(Button btn)
        {


            //var pacient = new Pacient();  //creez pacient

            //pacient.CNP = textBox2.Text;
            //pacient.Nume = textBox3.Text;
            //pacient.Prenume = textBox4.Text;
            //int varsta;
            //bool varstaParsata = int.TryParse(textBox5.Text, out varsta);
            //if (varstaParsata == true)
            //{
            //    pacient.Varsta = varsta;
            //}
            //pacient.Observatii = textBox6.Text;
            //dbContext.Pacienti.Add(pacient);
            //dbContext.SaveChanges(); //Adaug pacient
        }

        private void Litera1_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(Litera1);
        }

        private void Litera2_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(Litera2);
        }

        private void Litera3_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(Litera3);
        }

        private void afisezLitera_Click(object sender, EventArgs e)
        {

        }

        private void Litera4_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(Litera4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer.Text = ore + " : " + min + ":" + sec.ToString();
            ms++;

            if (ms > 15)
            {
                sec++;
                ms = 0;
            }
            else
            {
                ms++;
            }

            if (sec > 60)
            {
                min++;
                sec = 0;
            }
            if (min > 60)
            {
                ore++;
                min = 0;
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
