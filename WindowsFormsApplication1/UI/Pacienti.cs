using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.UI
{
    public partial class Pacienti : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();
        int idPacient = 0;

     
        public Pacienti()
        {
            InitializeComponent();

            var pacienti = dbContext.Pacienti
                .OrderBy (p => p.Nume)
                .Select(p => new { p.Nume, p.Prenume }).ToList();

            foreach (var x in pacienti)
            {
                numeComboBox.Items.Add(x.Nume);
            }
        }

        private void numeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prenComboBox.Items.Clear();

            var pacienti = dbContext.Pacienti
              .Where(p => p.Nume == numeComboBox.Text)
              .OrderBy(p => p.Prenume)
              .Select(p => new { p.Prenume }).ToList();

            foreach (var p in pacienti)
            {
                if (pacienti.Count == 1)
                {
                    prenComboBox.Text = p.Prenume;
                }
                else
                {
                    prenComboBox.Items.Add(p.Prenume);
                }
            }
        }

        public void AfiseazaPacienti()
        {
            var pacienti = dbContext.Pacienti.ToList();
            pacientiDataGrid.DataSource = pacienti;

            pacientiDataGrid.Columns["Rezultate"].Visible = false;
        }

        public void AfiseazaPacientDupaId(int idP)
        {
            var pacient = dbContext.Pacienti.Where(p => p.Id == idP).ToList();
            pacientiDataGrid.DataSource = pacient;
        }


        private void adaugaButton_Click(object sender, EventArgs e)
        {
            var pacient = new Pacient();  //creez pacient

            pacient.CNP = cnpTextBox.Text;
            pacient.Nume = numeTextBox.Text;
            pacient.Prenume = prenTextBox.Text;
            int varsta;
            bool varstaParsata = int.TryParse(varstaTextBox.Text, out varsta);
            if (varstaParsata == true)
            {
                pacient.Varsta = varsta;
            }
            pacient.Observatii = obsTextbox.Text;
            dbContext.Pacienti.Add(pacient);
            dbContext.SaveChanges(); //Adaug pacient
            AfiseazaPacienti();
            MessageBox.Show("Datele au fost salvate");

            cnpTextBox.Clear();
            numeTextBox.Clear();
            prenTextBox.Clear();
            varstaTextBox.Clear();
            obsTextbox.Clear();
        }

        private void button2_Click(object sender, EventArgs e) // ADAUG PACIENT
        {
            var pacient = new Pacient();  //creez pacient

            pacient.CNP = cnpTextBox.Text;
            pacient.Nume = numeTextBox.Text;
            pacient.Prenume = prenTextBox.Text;
            int varsta;
            bool varstaParsata = int.TryParse(varstaTextBox.Text, out varsta);
            if(varstaParsata == true)
            {
                pacient.Varsta = varsta;
            }
            pacient.Observatii = obsTextbox.Text;
            dbContext.Pacienti.Add(pacient);
            dbContext.SaveChanges(); //Adaug pacient
            AfiseazaPacienti();
            MessageBox.Show("Datele au fost salvate");

            cnpTextBox.Clear();
            numeTextBox.Clear();
            prenTextBox.Clear();
            varstaTextBox.Clear();
            obsTextbox.Clear();
        }

        private void stergePacientButton_Click(object sender, EventArgs e)
        {
            if (pacientiDataGrid.Rows.Count != 0)
            {
                bool selectat = pacientiDataGrid.CurrentRow.Selected;
                if (selectat == true)
                {
                    if (MessageBox.Show("Sigur doriti sa stergeti datele selectate ?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var idPacient = ((Pacient)pacientiDataGrid.CurrentRow.DataBoundItem).Id;
                        //var id = ((Pacient)dataGridView1.CurrentRow.DataBoundItem).Id;
                        //foreach (DataGridViewRow row in pacientiDataGrid.SelectedRows)
                        //{
                        //    var id = row.Cells[0].Value.ToString();
                        //    idPacient = int.Parse(id);
                        //}
                        var pacient = dbContext.Pacienti.SingleOrDefault(p => p.Id == idPacient);
                        dbContext.Pacienti.Remove(pacient);
                        dbContext.SaveChanges();
                        AfiseazaPacienti();
                        MessageBox.Show("Datele pacientului au fost sterse");
                    }
                }
                else
                {
                    MessageBox.Show("Selectati pacientul pentru a sterge datele acestuia");
                }
            }
            else
            {
                MessageBox.Show("Selectati un pacient pentru a sterge datele acestuia");
            }
        }
        
       
        private void button6_Click(object sender, EventArgs e)
        {
            AfiseazaPacienti();
        }

        private void modificaDateButton_Click(object sender, EventArgs e)
        {
            if (pacientiDataGrid.Rows.Count != 0)
            {
                bool selectat = pacientiDataGrid.CurrentRow.Selected;
                if (selectat == true)
                {
                    // var id = ((Pacient)dataGridView1.CurrentRow.DataBoundItem).Id;
                    foreach (DataGridViewRow row in pacientiDataGrid.SelectedRows)
                    {
                        var id = row.Cells[0].Value.ToString();
                        idPacient = int.Parse(id);
                    }

                    var pacient = dbContext.Pacienti
                        .Where(p => p.Id == idPacient)
                        .FirstOrDefault();

                    cnpTextBox.Text = pacient.CNP.ToString();
                    numeTextBox.Text = pacient.Nume;
                    prenTextBox.Text = pacient.Prenume;
                    varstaTextBox.Text = pacient.Varsta.ToString();
                    obsTextbox.Text = pacient.Observatii;

                    saveBtn.Enabled = true;
                    adaugaButton.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Selectati pacientul pentru a modifica datele acestuia");
                }
            }
            else
            {
                MessageBox.Show("Selectati un pacient pentru a modifica datele acestuia");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool selectat = pacientiDataGrid.CurrentRow.Selected;
            if (selectat == true)
            {
                if (MessageBox.Show("Sigur doriti sa modificati datele pacientului ?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // var id = ((Pacient)dataGridView1.CurrentRow.DataBoundItem).Id;
                    foreach (DataGridViewRow row in pacientiDataGrid.SelectedRows)
                    {
                        var id = row.Cells[0].Value.ToString();
                        idPacient = int.Parse(id);
                    }

                    var pacient = dbContext.Pacienti.SingleOrDefault(p => p.Id == idPacient);
                    pacient.CNP = cnpTextBox.Text;
                    pacient.Nume = numeTextBox.Text;
                    pacient.Prenume = prenTextBox.Text;

                    int varsta;
                    bool varstaParsata = int.TryParse(varstaTextBox.Text, out varsta); // VARSTA
                    if (varstaParsata == true)
                    {
                        pacient.Varsta = varsta;
                    }
                    pacient.Observatii = obsTextbox.Text;

                    dbContext.SaveChanges();
                    AfiseazaPacientDupaId(idPacient);
                    MessageBox.Show("Datele au fost modificate");
                    
                    cnpTextBox.Clear();
                    numeTextBox.Clear();
                    prenTextBox.Clear();
                    varstaTextBox.Clear();
                    obsTextbox.Clear();
                }
            }
        }

        private void cautaBtn_Click(object sender, EventArgs e)  // cauta dupa nume
        {
            var pacienti = (from p in dbContext.Pacienti
                           where (p.Nume == numeComboBox.Text && prenComboBox.Text == "") || (numeComboBox.Text == "" && p.Prenume == prenComboBox.Text) || (p.Nume == numeComboBox.Text && p.Prenume == prenComboBox.Text) 
                           select new
                           {  
                               p.Id,
                               p.Nume,
                               p.Prenume,
                               p.CNP,
                               p.Varsta,
                               p.Observatii
                           }).ToList();

            if (pacienti.Count != 0)
            {
                pacientiDataGrid.DataSource = pacienti;
                numeComboBox.Text = "";
                prenComboBox.Text = "";
            }
            else
            {
                pacientiDataGrid.DataSource = pacienti;
                MessageBox.Show("Nu a fot gasit niciun pacient cu datele selectate");
            }
        }

        private void cautaDupaCnpBtn_Click(object sender, EventArgs e)
        {
            var pacienti = (from p in dbContext.Pacienti
                            where (p.CNP == cnpTextBox1.Text) 
                            select new
                            {
                                p.Id,
                                p.Nume,
                                p.Prenume,
                                p.CNP,
                                p.Varsta,
                                p.Observatii
                            }).ToList();

            if (pacienti.Count != 0)
            {
                pacientiDataGrid.DataSource = pacienti;
                cnpTextBox1.Clear();
            }
            else
            {
                pacientiDataGrid.DataSource = pacienti;
                MessageBox.Show("Nu a fot gasit niciun pacient cu datele selectate");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new StartPage().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Pacienti_Load(object sender, EventArgs e)
        {

        }

    }
}
