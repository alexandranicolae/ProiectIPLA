using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIPLA
{
    public partial class FormVizualizareDate : Form
    {
        public FormVizualizareDate()
        {
            InitializeComponent();
        }

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FormVizualizareDate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Contracte' table. You can move, or remove it, as needed.
            this.contracteTableAdapter.Fill(this.databaseDataSet.Contracte);
            // TODO: This line of code loads data into the 'databaseDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.databaseDataSet.Clienti);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            clientiBindingSource.ResetBindings(false);
            contracteBindingSource.ResetBindings(false);
            clientiDataGridView.Refresh();
            contracteDataGridView.Refresh();
        }
    }
}
