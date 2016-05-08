using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.UI
{
    public partial class Rezultate : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        int nivel = 0;
        string numePacient = "";
        string prenumePacient = "";
        string numeTest = "";

        int idPacient = 0;
        int idTest = 0;
        int nrTeste = 0;

        private List<Rezultat> rezultate;

        public Rezultate()
        {
            InitializeComponent();

            var pacienti = dbContext.Pacienti
               .OrderBy(p => p.Nume)
               .Select(p => new { p.Nume }).ToList();

            foreach (var x in pacienti)
            {
                numeComboBox.Items.Add(x.Nume);
            }

            for (int i = 1; i <= 20; i++)
            {
                nivelTestComboBox.Items.Add(i);
            }

        }

        private void numeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prenComboBox.Text = "";

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

        private void nivelTestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeTestComboBox.Items.Clear();

            nivel = int.Parse(nivelTestComboBox.Text);

            var teste = dbContext.Teste
                .Where(t => t.Nivel == nivel)
                .OrderBy(t => t.TestId)
                .Select(t => new { t.Nume }).ToList();

            foreach (var t in teste)
            {
                numeTestComboBox.Items.Add(t.Nume);
            }
        }

        private void veziRezultateBtn_Click(object sender, EventArgs e)
        {
            if (numeComboBox.Text == "")
            {
                MessageBox.Show("Selectati numele pacientului");
            }
            else if (prenComboBox.Text == "")
            {
                MessageBox.Show("Selectati prenumele pacientului");
            }
            
            else
            {
                var rezultateQuery = dbContext.Rezultate.Where(x => x.Pacient.Nume == numeComboBox.Text && x.Pacient.Prenume == prenComboBox.Text);
                if (!string.IsNullOrWhiteSpace(nivelTestComboBox.Text))
                {
                    bool nivelParsat = int.TryParse(nivelTestComboBox.Text, out nivel);
                    if (nivelParsat == true)
                    {
                        nivel = int.Parse(nivelTestComboBox.Text);
                        rezultateQuery = rezultateQuery.Where(x => x.Test.Nivel == nivel);
                    }
                }
                if (!string.IsNullOrWhiteSpace(numeTestComboBox.Text))
                {
                    rezultateQuery = rezultateQuery.Where(x => x.Test.Nume == numeTestComboBox.Text);
                }
                if (dataRezolvareCheckBox.Checked)
                {
                    rezultateQuery = rezultateQuery.Where(x => x.DataRezolvare == dataRezolvareDatePicker.Value.Date);
                }
                rezultate = rezultateQuery.ToList();

                var rezultateAfisate = rezultate.Select(x => 
                    new
                    {
                        Nume_Pacient = x.Pacient.Nume,
                        Prenume_Pacient = x.Pacient.Prenume,
                        Nume_Test = x.Test.Nume,
                        Nivel_Test = x.Test.Nivel,
                        Raspunsuri_Corecte = x.RaspunsuriCorecte, // de scos proprietati 'RaspunsuriCorecte' si 'RaspunsuriGresite' si de adaugat bool 'EsteCorect' pe entitatea 'Raspuns'
                        Raspunsuri_Gresite = x.RaspunsuriGresite,
                        Timp_Rezolvare = x.TimpRezolvare,
                        Data_Rezolvare = x.DataRezolvare
                    }).ToList();

                numePacient = numeComboBox.Text;
                prenumePacient = prenComboBox.Text;
                numeTest = numeTestComboBox.Text;

                nrTeste = rezultate.Count();

                RezultateGridView.DataSource = rezultateAfisate;

                numeTestComboBox.Text = "";
            }
        }

        private void veziRaspButton_Click(object sender, EventArgs e)
        {
            var raspunsuriAfisate = rezultate.SelectMany(x => x.Raspunsuri)
                .Select(x =>
                    new
                    {
                        Numar_Intrebare = x.NumarIntrebare,
                        Raspuns_Corect = x.RaspunsCorect,
                        Raspuns_Primit = x.RaspunsDat,
                    }).ToList();

            raspunsuriDataGridView.DataSource = raspunsuriAfisate;
        }

        public void VeziRaspunsuriCompleteOrdonate(Button btn)
        {
            if (btn.Name == ordDupaRaspCorButton.Name)
            {

                var raspunsuri = (from rasp in dbContext.Raspunsuri
                                  join r in dbContext.Rezultate on rasp.RezultatId equals r.RezultatId
                                  where r.TestId == idTest && r.PacientId == idPacient
                                  orderby r.RaspunsuriCorecte
                                  select new
                                  {
                                      Numar_Intrebare = rasp.NumarIntrebare,
                                      Raspuns_Corect = rasp.RaspunsCorect,
                                      Raspuns_Primit = rasp.RaspunsDat,

                                  }).ToList();

                raspunsuriDataGridView.DataSource = raspunsuri;
            }

            else
                if (btn.Name == ordDupaRaspGresButton.Name)
            {
                var raspunsuri = (from rasp in dbContext.Raspunsuri
                                  join r in dbContext.Rezultate on rasp.RezultatId equals r.RezultatId
                                  where r.TestId == idTest && r.PacientId == idPacient
                                  orderby r.RaspunsuriGresite
                                  select new
                                  {
                                      Numar_Intrebare = rasp.NumarIntrebare,
                                      Raspuns_Corect = rasp.RaspunsCorect,
                                      Raspuns_Primit = rasp.RaspunsDat,

                                  }).ToList();

                raspunsuriDataGridView.DataSource = raspunsuri;
            }
            else
                 if (btn.Name == ordDupaTimpRezButton.Name)
            {
                var raspunsuri = (from rasp in dbContext.Raspunsuri
                                  join r in dbContext.Rezultate on rasp.RezultatId equals r.RezultatId
                                  where r.TestId == idTest && r.PacientId == idPacient
                                  orderby r.TimpRezolvare
                                  select new
                                  {
                                      Numar_Intrebare = rasp.NumarIntrebare,
                                      Raspuns_Corect = rasp.RaspunsCorect,
                                      Raspuns_Primit = rasp.RaspunsDat,

                                  }).ToList();

                raspunsuriDataGridView.DataSource = raspunsuri;
            }
        }


        private void ordDupaRaspCorButton_Click(object sender, EventArgs e)
        {
            var rezultate = (from rez in dbContext.Rezultate
                             join p in dbContext.Pacienti on rez.PacientId equals p.Id
                             join t in dbContext.Teste on rez.TestId equals t.TestId
                             where (p.Nume == numePacient && p.Prenume == prenumePacient && t.Nivel == nivel && t.Nume == numeTest)
                             orderby rez.RaspunsuriCorecte ascending
                             select new
                             {
                                 Nume_Pacient = p.Nume,
                                 Prenume_Pacient = p.Prenume,
                                 Nume_Test = t.Nume,
                                 Nivel_Test = t.Nivel,
                                 Raspunsuri_Corecte = rez.RaspunsuriCorecte,
                                 Raspunsuri_Gresite = rez.RaspunsuriGresite,
                                 Timp_Rezolvare = rez.TimpRezolvare,
                                 Data_Rezolvare = rez.DataRezolvare,

                             }).ToList();
            RezultateGridView.DataSource = rezultate;

            VeziRaspunsuriCompleteOrdonate(ordDupaRaspCorButton);
        }

        private void ordDupaRaspGresButton_Click(object sender, EventArgs e)
        {
            var rezultate = (from rez in dbContext.Rezultate
                             join p in dbContext.Pacienti on rez.PacientId equals p.Id
                             join t in dbContext.Teste on rez.TestId equals t.TestId
                             where (p.Nume == numePacient && p.Prenume == prenumePacient && t.Nivel == nivel && t.Nume == numeTest)
                             orderby rez.RaspunsuriGresite ascending
                             select new
                             {
                                 Nume_Pacient = p.Nume,
                                 Prenume_Pacient = p.Prenume,
                                 Nume_Test = t.Nume,
                                 Nivel_Test = t.Nivel,
                                 Raspunsuri_Corecte = rez.RaspunsuriCorecte,
                                 Raspunsuri_Gresite = rez.RaspunsuriGresite,
                                 Timp_Rezolvare = rez.TimpRezolvare,
                                 Data_Rezolvare = rez.DataRezolvare,

                             }).ToList();
            RezultateGridView.DataSource = rezultate;

            VeziRaspunsuriCompleteOrdonate(ordDupaRaspGresButton);
        }

        private void ordDupaTimpRezButton_Click(object sender, EventArgs e)
        {
            var rezultate = (from rez in dbContext.Rezultate
                             join p in dbContext.Pacienti on rez.PacientId equals p.Id
                             join t in dbContext.Teste on rez.TestId equals t.TestId
                             where (p.Nume == numePacient && p.Prenume == prenumePacient && t.Nivel == nivel && t.Nume == numeTest)
                             orderby rez.TimpRezolvare ascending
                             select new
                             {
                                 Nume_Pacient = p.Nume,
                                 Prenume_Pacient = p.Prenume,
                                 Nume_Test = t.Nume,
                                 Nivel_Test = t.Nivel,
                                 Raspunsuri_Corecte = rez.RaspunsuriCorecte,
                                 Raspunsuri_Gresite = rez.RaspunsuriGresite,
                                 Timp_Rezolvare = rez.TimpRezolvare,
                                 Data_Rezolvare = rez.DataRezolvare,

                             }).ToList();
            RezultateGridView.DataSource = rezultate;

            VeziRaspunsuriCompleteOrdonate(ordDupaTimpRezButton);
        }

        public Rezultate(int idT, int idP, int idRez)
        {
            InitializeComponent();

            var pacienti = dbContext.Pacienti
                .OrderBy(p => p.Nume)
                .Select(p => new { p.Nume }).ToList();

            foreach (var x in pacienti)
            {
                numeComboBox.Items.Add(x.Nume);
            }

            for (int i = 1; i <= 20; i++)
            {
                nivelTestComboBox.Items.Add(i);
            }

            var rezultate = (from rez in dbContext.Rezultate
                             join p in dbContext.Pacienti on rez.PacientId equals p.Id
                             join t in dbContext.Teste on rez.TestId equals t.TestId
                             join r in dbContext.Raspunsuri on rez.RezultatId equals r.RezultatId
                             where rez.TestId == idT && rez.PacientId == idP && rez.RezultatId == idRez
                             orderby rez.RezultatId descending
                             select new
                             {
                                 Nume_Test = t.Nume,
                                 Nivel_Test = t.Nivel,
                                 Nume_Pacient = p.Nume,
                                 Prenume_Pacient = p.Prenume,
                                 Raspunsuri_Corecte = rez.RaspunsuriCorecte,
                                 Raspunsuri_Gresite = rez.RaspunsuriGresite,
                                 Timp_Rezolvare = rez.TimpRezolvare,
                                 Raspuns_Corect = r.RaspunsCorect,
                                 Raspuns_Primit = r.RaspunsDat,

                             }).ToList();

            RezultateGridView.DataSource = rezultate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new StartPage().Show();
        }

        private void prenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dataRezolvareCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataRezolvareDatePicker.Visible = dataRezolvareCheckBox.Checked;
        }
    }
}
