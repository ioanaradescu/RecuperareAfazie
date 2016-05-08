using System;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.UI
{
    public partial class GenereazaTest2 : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        int idTest = 0;
        int numarIntrebare = 0;

        public GenereazaTest2(Button btn)
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
            else {

                var test = new Test();    //creez test

                try
                {
                    test.Nume = numeTestTextBox.Text;
                    test.Nivel = 2;
                    dbContext.Teste.Add(test);
                    dbContext.SaveChanges();     // Salvez testul

                    intrebariGroupBox.Visible = true;
                    intrebareaUrmBtn.Visible = true;
                    genereazaTestBtn.Enabled = false;

                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
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

            var intrebare = new Intrebare();

            intrebare.TestId = idTest;
            intrebare.TextIntrebare = textBox1.Text;
            //intrebare.numarIntrebare = label7.Text;
            intrebare.Raspuns1 = textBox2.Text;
            intrebare.Raspuns2 = textBox3.Text;
            intrebare.Raspuns3 = textBox4.Text;
            intrebare.Raspuns4 = textBox5.Text;

            dbContext.Intrebari.Add(intrebare);
            dbContext.SaveChanges();
            label7.Text = numarIntrebare.ToString();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            SalveazaBtn.Enabled = true;
            SalveazaBtn.Visible = true;
        }

        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
            {
                var intrebare = new Intrebare();

                intrebare.TestId = idTest;
                intrebare.TextIntrebare = textBox1.Text;
               // intrebare.numarIntrebare = label7.Text;
                intrebare.Raspuns1 = textBox2.Text;
                intrebare.Raspuns2 = textBox3.Text;
                intrebare.Raspuns3 = textBox4.Text;
                intrebare.Raspuns4 = textBox5.Text;

                dbContext.Intrebari.Add(intrebare);
                dbContext.SaveChanges();
            }

            MessageBox.Show("Testul a fost salvat");

            numarIntrebare = 1;
            label7.Text = numarIntrebare.ToString();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            intrebareaUrmBtn.Enabled = false;
            SalveazaBtn.Enabled = false;


            numeTestTextBox.Enabled = true;
            numeTestTextBox.Clear();
            genereazaTestBtn.Enabled = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new GenereazaTeste().Show();
        }

    }
}
