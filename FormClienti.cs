using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIPLA
{
    public partial class FormClienti : Form
    {
        string sircc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexa\Downloads\IPLA\Proiect\ProiectIPLA\Database1.mdf;Integrated Security=True";
       
        TextBox tb;
        public FormClienti(TextBox idClientTextBox)
        {
            
            tb = idClientTextBox;
            InitializeComponent();
        }

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FormClienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.databaseDataSet.Clienti);

        }

        private void FormClienti_FormClosed(object sender, FormClosedEventArgs e)
        {
            adaugaInBD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaugaInBD();
            this.Close();
        }

        private void adaugaInBD()
        {
            // se construieste un obiect de tip OleDbConnection 
            // care face conexiunea la sursa de date
            SqlConnection con = new SqlConnection(sircc);
            // formarea șirului dintr-un singur caracter în urma optiunii 
            // introduse pentru sexul persoanei
            string nume = numeTextBox.Text, adresa = adresaTextBox.Text, codPostal = codFiscalTextBox.Text, nrTelefon = nrTelefonTextBox.Text, email = emailTextBox.Text, cui = codFiscalTextBox.Text, repr = reprezentantTextBox.Text, cal = calitateTextBox.Text;

            // construirea sirului ce contine comanda de inserare 
            // a tuplului în tabela Persoane

            con.Open();

            string sinsert = @"INSERT INTO Clienti(Id, Nume,Adresa,CodPostal,NrTelefon,Email,CodFiscal,Reprezentant,Calitate) 
                VALUES('" + idNumericUpDown.Value + "','" + nume + "','" + adresa + "','" + codPostal + "','" + nrTelefon + "','" + email + "','" + cui + "','" +
                        repr + "','" + cal + "')";

            SqlCommand cinsert = new SqlCommand(sinsert, con);
            //executia comenzii de inserare
            cinsert.ExecuteNonQuery();
            //inchiderea conexiunii
            con.Close();
            //mesaj de confirmare pentru adaugarea datelor in tabela
            MessageBox.Show("Date adaugate in tabela!!!");

            tb.Text = idNumericUpDown.Value.ToString();
        }
    }
}
