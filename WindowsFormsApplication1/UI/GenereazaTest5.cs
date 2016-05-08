using System;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.UI
{
    public partial class GenereazaTest5 : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        int idTest = 0;
        int numarIntrebare = 0;

        public GenereazaTest5(Button btn)
        {
            InitializeComponent();

            numarIntrebare = 1;
            numeTestGroupBox.Text = btn.Text;
        }

        private void genereazaTestBtn_Click(object sender, EventArgs e)
        {
            if (numeTestTextBox.Text == "")
            {
                MessageBox.Show("Introduceti numele testului");
            }
            else
            {
                var test = new Test();    //creez test
                try
                {
                    test.Nume = numeTestTextBox.Text;
                    test.Nivel = 5;
                    dbContext.Teste.Add(test);
                    dbContext.SaveChanges();     // Salvez testul

                    intrebariGroupBox.Visible = true;
                    intrebareaUrmBtn.Visible = true;
                    genereazaTestBtn.Enabled = false;

                    imagineTextBox.Enabled = true;
                    rasp1TextBox.Enabled = true;
                    rasp2TextBox.Enabled = true;
                    rasp3TextBox.Enabled = true;
                    rasp4TextBox.Enabled = true;
                    intrebareaUrmBtn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                idTest = test.TestId;
            }
        }

        private void intrebareaUrmBtn_Click(object sender, EventArgs e)
        {
            numarIntrebare++;

            var intrebare = new Intrebare();  // insert in Intrebari
            intrebare.TestId = idTest;
            intrebare.ImagineIntrebare = imagineTextBox.Text;
            intrebare.TextIntrebare = textIntrebareTextBox.Text;
            intrebare.Raspuns1 = rasp1TextBox.Text;
            intrebare.Raspuns2 = rasp2TextBox.Text;
            intrebare.Raspuns3 = rasp3TextBox.Text;
            intrebare.Raspuns4 = rasp4TextBox.Text;

            dbContext.Intrebari.Add(intrebare);
            dbContext.SaveChanges();
            label7.Text = numarIntrebare.ToString();

            imagineTextBox.Clear();
            rasp1TextBox.Clear();
            rasp2TextBox.Clear();
            rasp3TextBox.Clear();
            rasp4TextBox.Clear();
            textIntrebareTextBox.Clear();

            SalveazaBtn.Enabled = true;
            SalveazaBtn.Visible = true;
        }

        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            if (imagineTextBox.Text != "" || rasp1TextBox.Text != "" || rasp2TextBox.Text != "" || rasp3TextBox.Text != "" || rasp4TextBox.Text != "")
            {
                var intrebare = new Intrebare();
                intrebare.TestId = idTest;
                intrebare.ImagineIntrebare = imagineTextBox.Text;
                intrebare.TextIntrebare = textIntrebareTextBox.Text;
                intrebare.Raspuns1 = rasp1TextBox.Text;
                intrebare.Raspuns2 = rasp2TextBox.Text;
                intrebare.Raspuns3 = rasp3TextBox.Text;
                intrebare.Raspuns4 = rasp4TextBox.Text;

                dbContext.Intrebari.Add(intrebare);
                dbContext.SaveChanges();
            }

            MessageBox.Show("Testul a fost salvat");

            numarIntrebare = 1;
            label7.Text = numarIntrebare.ToString();
            imagineTextBox.Clear();
            rasp1TextBox.Clear();
            rasp2TextBox.Clear();
            rasp3TextBox.Clear();
            rasp4TextBox.Clear();

            imagineTextBox.Enabled = false;
            cautaButton.Enabled = false;
            rasp1TextBox.Enabled = false;
            rasp2TextBox.Enabled = false;
            rasp3TextBox.Enabled = false;
            rasp4TextBox.Enabled = false;
            intrebareaUrmBtn.Enabled = false;
            SalveazaBtn.Enabled = false;


            numeTestTextBox.Enabled = true;
            numeTestTextBox.Clear();
            genereazaTestBtn.Enabled = true;
        }

        private void GenereazaTest5_Load(object sender, EventArgs e)
        {

        }

        private void cautaButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagineTextBox.Text = openFileDialog1.FileName;

            }
        }

        private void cautaRasp1Btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rasp1TextBox.Text = openFileDialog1.FileName;
            }
        }

        private void cautaRasp2Btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rasp2TextBox.Text = openFileDialog1.FileName;
            }
        }

        private void cautaRasp3Btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rasp3TextBox.Text = openFileDialog1.FileName;
            }
        }

        private void cautaRasp4Btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rasp4TextBox.Text = openFileDialog1.FileName;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new GenereazaTeste().Show();
        }
    }
}
