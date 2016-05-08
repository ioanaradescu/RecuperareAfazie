﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.UI
{
    public partial class TestAles4 : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        int id_test = 0;
        int id_pacient = 0;
        int id_rezultat = 0;
        int nivelTest = 0;

        int total = 0; //total Intrebari pentru un test

        int raspunsuriCorecte = 0;
        int raspunsuriGresite = 0;

        Button butonV = new Button();

        int ore, min, sec, ms = 0;

        int index = 0;
        int x = 0;

        string[] raspunsuriDate = new string[20];
        string[] raspunsuriCor = new string[20];

        public TestAles4()
        {
            InitializeComponent();
        }

        public TestAles4(int idT, int idP, Button btn)
        {
            InitializeComponent();

            id_test = idT;
            id_pacient = idP;

            var teste = dbContext.Teste
                .Where(t => t.TestId == id_test)
                .Select(t => new { t.Nivel }).SingleOrDefault();

            nivelTest = teste.Nivel;

            var intrebari = dbContext.Intrebari
                .Where(p => p.TestId == id_test)
                .Select(p => new { p.Id }).ToList();

            total = intrebari.Count();

            raspunsCorectLbl.Text = raspunsuriCorecte.ToString();
            raspunsGresitLbl.Text = raspunsuriGresite.ToString();

            butonV = btn;

            timer1.Start();
            NextQuestion(index);
        }

        public void VerificaRaspuns(Button btn)
        {
            raspunsuriDate[index] = btn.Text;               // de modificat a.i sa nu existe test ales fara intrebari!!
            raspunsuriCor[index] = textIntrebareLabel.Text;

            if (btn.Text == textIntrebareLabel.Text)
            {
                raspunsuriCorecte++;
                index++;
                raspunsCorectLbl.Text = raspunsuriCorecte.ToString();
                if (index <= x - 1)
                {
                    NextQuestion(index);
                }
                else
                {
                    TerminareTest(raspunsuriCor, raspunsuriDate);
                }
            }
            else
            {
                raspunsuriGresite++;
                index++;
                raspunsGresitLbl.Text = raspunsuriGresite.ToString();

                if (index <= x - 1)
                {
                    NextQuestion(index);
                }
                else
                {
                    TerminareTest(raspunsuriCor, raspunsuriDate);
                }
            }
        }

        public void TerminareTest(string[] raspCor, string[] raspDat)
        {
            timer1.Stop();

            var rezultat = new Rezultat();
            rezultat.PacientId = id_pacient;
            rezultat.TestId = id_test;
            rezultat.RaspunsuriCorecte = raspunsuriCorecte;
            rezultat.RaspunsuriGresite = raspunsuriGresite;
            rezultat.TimpRezolvare = timeLbl.Text;
            rezultat.DataRezolvare = DateTime.Now.Date;
            dbContext.Rezultate.Add(rezultat);
            dbContext.SaveChanges();

            id_rezultat = rezultat.RezultatId;

            for (int i = 0; i < total; i++)
            {
                var raspuns = new Raspuns();
                raspuns.RezultatId = rezultat.RezultatId;
                raspuns.NumarIntrebare = i + 1;
                raspuns.RaspunsCorect = raspCor[i];
                raspuns.RaspunsDat = raspDat[i];
                dbContext.Raspunsuri.Add(raspuns);
                dbContext.SaveChanges();
            }

            MessageBox.Show("Felicitari! \nTestul a luat sfarsit. \nAti raspuns corect la " + raspunsuriCorecte + " intrebari");

            raspuns1Button.Enabled = false;
            raspuns2Button.Enabled = false;
            raspuns3Button.Enabled = false;
            raspuns4Button.Enabled = false;

            raspCorectLbl.Text = raspunsuriCorecte.ToString();
            raspGresitLbl.Text = raspunsuriGresite.ToString();
            timpRezLbl.Text = timeLbl.Text;

            var raspunsuri = (from rasp in dbContext.Raspunsuri
                              join r in dbContext.Rezultate on rasp.RezultatId equals r.RezultatId
                              where r.TestId == id_test && r.PacientId == id_pacient
                              select new
                              {
                                  Numar_Intrebare = rasp.NumarIntrebare,
                                  Raspuns_Corect = rasp.RaspunsCorect,
                                  Raspuns_Primit = rasp.RaspunsDat,

                              }).ToList();

            rezultateGridView.DataSource = raspunsuri;
            rezultateGrBox.Visible = true;
            rezultateGridView.Visible = true;
        }

        private void raspuns1Button_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(raspuns1Button);
        }

        private void raspuns2Button_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(raspuns2Button);
        }

        private void raspuns3Button_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(raspuns3Button);
        }

        private void raspuns4Button_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(raspuns4Button);
        }

        //private void veziRezultateBtn_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Rezultate f5 = new Rezultate(id_test, id_pacient, id_rezultat);
        //    f5.ShowDialog();
        //}

        private void iesireButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Teste(id_pacient, nivelTest, butonV).Show();
        }

        private void rezultateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rezultateGrBox_Enter(object sender, EventArgs e)
        {

        }

        public void NextQuestion(int index1)
        {
            var intrebari = (from i in dbContext.Intrebari
                             join t in dbContext.Teste on i.TestId equals t.TestId
                             where t.TestId == id_test
                             select new
                             {
                                 i.TextIntrebare,
                                 i.ImagineIntrebare,
                                 i.Raspuns1,
                                 i.Raspuns2,
                                 i.Raspuns3,
                                 i.Raspuns4
                             }).ToList();

            x = intrebari.Count;

            imaginePictureBox.Image = System.Drawing.Image.FromFile(intrebari[index1].ImagineIntrebare);
            textIntrebareLabel.Text = intrebari[index1].TextIntrebare;
            raspuns1Button.Text = intrebari[index1].Raspuns1;
            raspuns2Button.Text = intrebari[index1].Raspuns2;
            raspuns3Button.Text = intrebari[index1].Raspuns3;
            raspuns4Button.Text = intrebari[index1].Raspuns4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (min < 10 && sec < 10)
            {
                timeLbl.Text = ore + " : " + "0" + min + ":" + "0" + sec.ToString();
            }

            if (min < 10 && sec > 9)
            {
                timeLbl.Text = ore + " : " + "0" + min + ":" + sec.ToString();
            }

            if (min > 9 && sec > 9)
            {
                timeLbl.Text = ore + " : " + min + ":" + sec.ToString();
            }
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

        private void TestAles4_Load(object sender, EventArgs e)
        {

        }
    }
}
