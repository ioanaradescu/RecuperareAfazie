using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Data_Access_Layer;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class GenereazaTest4 : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        int idTest = 0;
        int numarIntrebare = 0;

        public GenereazaTest4(Button btn)
        {
            InitializeComponent();

            numarIntrebare = 1;
            numeTestGroupBox.Text = btn.Text;
        }

        private void cautaButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                imagineTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void GenereazaTest4_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new GenereazaTeste().Show();
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
                    test.Nivel = 4;
                    dbContext.Teste.Add(test);
                    dbContext.SaveChanges();     // Salvez testul

                    intrebariGroupBox.Visible = true;
                    intrebareaUrmBtn.Visible = true;
                    genereazaTestBtn.Enabled = false;

                    imagineTextBox.Enabled = true;
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

            var intrebare = new Intrebare();  // insert in Intrebari
            intrebare.TestId = idTest;
            intrebare.ImagineIntrebare = imagineTextBox.Text;
            intrebare.TextIntrebare = textIntrebareTextBox.Text;
            intrebare.Raspuns1 = textBox2.Text;
            intrebare.Raspuns2 = textBox3.Text;
            intrebare.Raspuns3 = textBox4.Text;
            intrebare.Raspuns4 = textBox5.Text;

            dbContext.Intrebari.Add(intrebare);
            dbContext.SaveChanges();
            label7.Text = numarIntrebare.ToString();

            imagineTextBox.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textIntrebareTextBox.Clear();

            SalveazaBtn.Enabled = true;
            SalveazaBtn.Visible = true;
        }

        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            if (imagineTextBox.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
            {
                var intrebare = new Intrebare();
                intrebare.TestId = idTest;
                intrebare.ImagineIntrebare = imagineTextBox.Text;
                intrebare.TextIntrebare = textIntrebareTextBox.Text;
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
            imagineTextBox.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            imagineTextBox.Enabled = false;
            cautaButton.Enabled = false;
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

        private void imagineTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
