using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RecuperareAfazie;Data Source=(local)";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("select p.Nume,p.Prenume,t.Numar_Test as 'Numar Test' ,r.Raspunsuri_Corecte as 'Raspunsuri Corecte',r.Raspunsuri_Gresite as 'Raspunsuri Gresite', r.Timp_Rezolvare as 'Timp Rezolvare', r.Data_Rezolvare as 'Data Rezolvare' from Pacienti p , Teste t, Rezultate r where p.Id_Pacient = r.Id_Pacient and t.Numar_Test=r.Numar_Test order by p.Nume, p.Prenume,t.Numar_Test ;", conDataBase);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        
    }
}
