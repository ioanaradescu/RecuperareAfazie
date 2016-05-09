using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.UI
{
    public partial class TestAles5 : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        private int id_test;
        private int id_pacient;
        private int nivelTest;

        private int total;

        private int id_rezultat = 0;
        private int raspunsuriCorecte = 0;
        private int raspunsuriGresite = 0;

        int ore, min, sec, ms = 0;

        private Test test;
        private IList<Intrebare> intrebari;
        private int index;
        private int x = 0;

        private Button butonV = new Button();
        private PictureBox[] raspunsuriDate = new PictureBox[20];
        private PictureBox[] raspunsuriCor = new PictureBox[20];

        public TestAles5(int idT, int idP, Button btn)
        {
            InitializeComponent();

            id_test = idT;
            id_pacient = idP;

            test = dbContext.Teste.Where(t => t.TestId == id_test).SingleOrDefault();
            nivelTest = test.Nivel;

            intrebari = dbContext.Intrebari.Where(p => p.TestId == id_test).ToList();
            index = 0;

            total = intrebari.Count();

            raspunsCorectLbl.Text = raspunsuriCorecte.ToString();
            raspunsGresitLbl.Text = raspunsuriGresite.ToString();

            butonV = btn;

            timer1.Start();
            NextQuestion(index);
        }

        public void VerificaRaspuns(PictureBox imag)
        {
            raspunsuriDate[index] = imag;               // de modificat a.i sa nu existe test ales fara intrebari!!
            raspunsuriCor[index] = imaginePictureBox;

            if (Compare(imag, imaginePictureBox) == true)
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

        private bool Compare(PictureBox imag, PictureBox imaginePictureBox)
        {
            Bitmap bmp1 = (Bitmap)imag.Image;
            Bitmap bmp2 = (Bitmap)imaginePictureBox.Image;

            bool equals = true;
            bool flag = true;  //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bmp1.Size == bmp2.Size)
            {
                for (int x = 0; x < bmp1.Width; ++x)
                {
                    for (int y = 0; y < bmp1.Height; ++y)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }

        public void TerminareTest(PictureBox[] raspCor, PictureBox[] raspDat)
        {
            timer1.Stop();

            var rezultat = new Rezultat
            {
                PacientId = id_pacient,
                TestId = id_test,
                RaspunsuriCorecte = raspunsuriCorecte,
                RaspunsuriGresite = raspunsuriGresite,
                TimpRezolvare = timeLbl.Text,
                DataRezolvare = DateTime.Now.Date
            };

            dbContext.Rezultate.Add(rezultat);
            dbContext.SaveChanges();

            id_rezultat = rezultat.RezultatId;

            for (int i = 0; i < total; i++)
            {
                var raspuns = new Raspuns
                {
                    RezultatId = rezultat.RezultatId,
                    NumarIntrebare = i + 1,
                    RaspunsCorect = raspCor[i].ImageLocation,
                    RaspunsDat = raspDat[i].ImageLocation
                };

                dbContext.Raspunsuri.Add(raspuns);
                dbContext.SaveChanges();
            }

            MessageBox.Show("Felicitari! \nTestul a luat sfarsit. \nAti raspuns corect la " + raspunsuriCorecte + " intrebari");

            rasp1PictureBox.Enabled = false;
            rasp2PictureBox.Enabled = false;
            rasp3PictureBox.Enabled = false;
            rasp4PictureBox.Enabled = false;

            raspCorectLbl.Text = raspunsuriCorecte.ToString();
            raspGresitLbl.Text = raspunsuriGresite.ToString();
            timpRezLbl.Text = timeLbl.Text;

            var raspunsuri = dbContext.Raspunsuri.Where(x => x.Rezultat.TestId == id_test && x.Rezultat.PacientId == id_pacient && x.Rezultat.RezultatId == id_rezultat)
                .Select(x =>
                    new
                    {
                        Numar_Intrebare = x.NumarIntrebare,
                        Raspuns_Corect = x.RaspunsCorect,
                        Raspuns_Primit = x.RaspunsDat
                    })
                .ToList();

            rezultateGridView.DataSource = raspunsuri;
            rezultateGrBox.Visible = true;
            rezultateGridView.Visible = true;
        }

        private void rasp1PictureBox_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(rasp1PictureBox);
        }

        private void rasp2PictureBox_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(rasp2PictureBox);
        }

        private void rasp3PictureBox_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(rasp3PictureBox);
        }

        private void rasp4PictureBox_Click(object sender, EventArgs e)
        {
            VerificaRaspuns(rasp4PictureBox);
        }

        private void TestAles5_Load(object sender, EventArgs e)
        {

        }

        public void NextQuestion(int index1)
        {
            x = intrebari.Count;

            imaginePictureBox.ImageLocation = intrebari[index1].ImagineIntrebare;
            textIntrebareLabel.Text = intrebari[index1].TextIntrebare;
            rasp1PictureBox.ImageLocation = intrebari[index1].Raspuns1;
            rasp2PictureBox.ImageLocation = intrebari[index1].Raspuns2;
            rasp3PictureBox.ImageLocation = intrebari[index1].Raspuns3;
            rasp4PictureBox.ImageLocation = intrebari[index1].Raspuns4;
        }

        private void iesireButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Teste(id_pacient, nivelTest, butonV).Show();
        }

        private void timer1_tick(object sender, EventArgs e)
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
    }
}
