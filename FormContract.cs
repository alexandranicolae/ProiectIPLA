using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ProiectIPLA
{
    public partial class FormContract : Form
    {
        string sircc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexa\Downloads\IPLA\Proiect\ProiectIPLA\Database1.mdf;Integrated Security=True";

        public FormContract()
        {
            InitializeComponent();
        }

        private void FindAndReplace(Word.Application wordApp, object toFindText, object replacedWithText)
        {
            object matchCase = true, matchWholeWord = true, matchWildCards = false,
                matchSoundLike = false, matchAllForms = false, forward = true, format = false,
                matchkashida = false, matchdiacritics = false, matchalefhamza = false, matchcontrol = false,
                redonly = false, vizible = true, replace = 2, wrap = 1;

            wordApp.Selection.Find.Execute(ref toFindText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike, ref matchAllForms, ref forward,
                ref wrap, ref format, ref replacedWithText, ref replace, ref matchkashida,
                ref matchdiacritics, ref matchalefhamza, ref matchcontrol);

        }

        private void CreateWordDoc(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myDoc = null;
            if (File.Exists((string)filename))
            {
                object readOnly = false, isVisible = false;
                wordApp.Visible = false;

                myDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);
                myDoc.Activate();

                //Inlocuiri:
                this.FindAndReplace(wordApp, "<numeClient>", "Ana");
            }
            else
            {
                MessageBox.Show("404! File not found!");
            }

            //Save new
            myDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,ref missing, ref missing);

            myDoc.Close();
            wordApp.Quit();

            MessageBox.Show("Contract creat");
        }

        private void contracteBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contracteBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.databaseDataSet);

        }

        private void FormContract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter1.Fill(this.databaseDataSet.Clienti);
            // TODO: This line of code loads data into the 'databaseDataSet.Contracte' table. You can move, or remove it, as needed.
            this.contracteTableAdapter1.Fill(this.databaseDataSet.Contracte);
        }

        private void mentenantaComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (mentenantaComboBox.SelectedItem.Equals("Null"))
            {
                valoare2TextBox.Enabled = false;
                provenientaAchizitie2TextBox.Enabled = false;
                termeni2TextBox.Enabled = false;
            }
            else
            {
                valoare2TextBox.Enabled = true;
                provenientaAchizitie2TextBox.Enabled = true;
                termeni2TextBox.Enabled = true;
            }
        }

        private void realizareProiectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (realizareProiectCheckBox.CheckState == CheckState.Unchecked)
            {
                valoare1TextBox.Enabled = false;
                provenientaAchizitie1TextBox.Enabled = false;
                termeni1TextBox.Enabled = false;
                realizareProiectCheckBox.Text = "nu";
            }
            else
            {
                valoare1TextBox.Enabled = true;
                provenientaAchizitie1TextBox.Enabled = true;
                termeni1TextBox.Enabled = true;
                realizareProiectCheckBox.Text = "da";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormClienti fc = new FormClienti(idClientTextBox);
            fc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validare
            // val1 sau val 2 sa fie completate
            if (valoare1TextBox.Text == "" && valoare2TextBox.Text == "")
            {
                MessageBox.Show("Trebuie sa introduceti cel putin o valoare!");
            }
            else
            {
                if (idClientTextBox.Text == "")
                {
                    MessageBox.Show("Trebuie sa introduceti un client valid!");
                }
                else
                {
                    adaugainDB();
                    CreateWordDoc(@"C:\Users\alexa\Downloads\IPLA\Proiect\ProiectIPLA\contractX.docx", @"C:\Users\alexa\Downloads\IPLA\Proiect\ContractAna.docx");
                }
            }
        }

        private void adaugainDB()
        {
            SqlConnection con = new SqlConnection(sircc);

            con.Open();

            double val1 = Double.Parse(valoare1TextBox.Text);
            double val2 = Double.Parse(valoare1TextBox.Text);

            string sinsert = @"INSERT INTO Contracte VALUES('" + idNumericUpDown.Value + "','" + nrIntrareTextBox.Text + "','"
                + dataDateTimePicker.Value.ToString() + "','" + idClientTextBox.Text + "','" + realizareProiectCheckBox.Checked + "','" + mentenantaComboBox.Text + "','"
                + val1 + "','" + provenientaAchizitie1TextBox.Text + "','" + termeni1TextBox.Text + "','"
                + val2 + "','" + provenientaAchizitie2TextBox.Text + "','" + termeni2TextBox.Text + "')";

            SqlCommand cinsert = new SqlCommand(sinsert, con);
            //executia comenzii de inserare
            cinsert.ExecuteNonQuery();
            //inchiderea conexiunii
            con.Close();
            //mesaj de confirmare pentru adaugarea datelor in tabela
            MessageBox.Show("Date adaugate in tabela!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVizualizareDate f = new FormVizualizareDate();
            f.Show();
        }
    }

        
}
