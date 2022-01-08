
namespace ProiectIPLA
{
    partial class FormClienti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClienti));
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label codPostalLabel;
            System.Windows.Forms.Label nrTelefonLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label codFiscalLabel;
            System.Windows.Forms.Label reprezentantLabel;
            System.Windows.Forms.Label calitateLabel;
            System.Windows.Forms.Label idLabel;
            this.databaseDataSet = new ProiectIPLA.DatabaseDataSet();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientiTableAdapter = new ProiectIPLA.DatabaseDataSetTableAdapters.ClientiTableAdapter();
            this.tableAdapterManager = new ProiectIPLA.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.clientiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clientiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.codPostalTextBox = new System.Windows.Forms.TextBox();
            this.nrTelefonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.codFiscalTextBox = new System.Windows.Forms.TextBox();
            this.reprezentantTextBox = new System.Windows.Forms.TextBox();
            this.calitateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            numeLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            codPostalLabel = new System.Windows.Forms.Label();
            nrTelefonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            codFiscalLabel = new System.Windows.Forms.Label();
            reprezentantLabel = new System.Windows.Forms.Label();
            calitateLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).BeginInit();
            this.clientiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.databaseDataSet;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientiTableAdapter = this.clientiTableAdapter;
            this.tableAdapterManager.ContracteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProiectIPLA.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientiBindingNavigator
            // 
            this.clientiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientiBindingNavigator.BindingSource = this.clientiBindingSource;
            this.clientiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientiBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.clientiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientiBindingNavigatorSaveItem});
            this.clientiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientiBindingNavigator.Name = "clientiBindingNavigator";
            this.clientiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientiBindingNavigator.Size = new System.Drawing.Size(358, 33);
            this.clientiBindingNavigator.TabIndex = 0;
            this.clientiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // clientiBindingNavigatorSaveItem
            // 
            this.clientiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientiBindingNavigatorSaveItem.Image")));
            this.clientiBindingNavigatorSaveItem.Name = "clientiBindingNavigatorSaveItem";
            this.clientiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.clientiBindingNavigatorSaveItem.Text = "Save Data";
            this.clientiBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientiBindingNavigatorSaveItem_Click);
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(34, 83);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(55, 20);
            numeLabel.TabIndex = 3;
            numeLabel.Text = "Nume:";
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(151, 80);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 26);
            this.numeTextBox.TabIndex = 4;
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(34, 115);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(64, 20);
            adresaLabel.TabIndex = 5;
            adresaLabel.Text = "Adresa:";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(151, 112);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 26);
            this.adresaTextBox.TabIndex = 6;
            // 
            // codPostalLabel
            // 
            codPostalLabel.AutoSize = true;
            codPostalLabel.Location = new System.Drawing.Point(34, 147);
            codPostalLabel.Name = "codPostalLabel";
            codPostalLabel.Size = new System.Drawing.Size(90, 20);
            codPostalLabel.TabIndex = 7;
            codPostalLabel.Text = "Cod Postal:";
            // 
            // codPostalTextBox
            // 
            this.codPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "CodPostal", true));
            this.codPostalTextBox.Location = new System.Drawing.Point(151, 144);
            this.codPostalTextBox.Name = "codPostalTextBox";
            this.codPostalTextBox.Size = new System.Drawing.Size(100, 26);
            this.codPostalTextBox.TabIndex = 8;
            // 
            // nrTelefonLabel
            // 
            nrTelefonLabel.AutoSize = true;
            nrTelefonLabel.Location = new System.Drawing.Point(34, 179);
            nrTelefonLabel.Name = "nrTelefonLabel";
            nrTelefonLabel.Size = new System.Drawing.Size(86, 20);
            nrTelefonLabel.TabIndex = 9;
            nrTelefonLabel.Text = "Nr Telefon:";
            // 
            // nrTelefonTextBox
            // 
            this.nrTelefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "NrTelefon", true));
            this.nrTelefonTextBox.Location = new System.Drawing.Point(151, 176);
            this.nrTelefonTextBox.Name = "nrTelefonTextBox";
            this.nrTelefonTextBox.Size = new System.Drawing.Size(100, 26);
            this.nrTelefonTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(34, 211);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(151, 208);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 26);
            this.emailTextBox.TabIndex = 12;
            // 
            // codFiscalLabel
            // 
            codFiscalLabel.AutoSize = true;
            codFiscalLabel.Location = new System.Drawing.Point(34, 243);
            codFiscalLabel.Name = "codFiscalLabel";
            codFiscalLabel.Size = new System.Drawing.Size(87, 20);
            codFiscalLabel.TabIndex = 13;
            codFiscalLabel.Text = "Cod Fiscal:";
            // 
            // codFiscalTextBox
            // 
            this.codFiscalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "CodFiscal", true));
            this.codFiscalTextBox.Location = new System.Drawing.Point(151, 240);
            this.codFiscalTextBox.Name = "codFiscalTextBox";
            this.codFiscalTextBox.Size = new System.Drawing.Size(100, 26);
            this.codFiscalTextBox.TabIndex = 14;
            // 
            // reprezentantLabel
            // 
            reprezentantLabel.AutoSize = true;
            reprezentantLabel.Location = new System.Drawing.Point(34, 275);
            reprezentantLabel.Name = "reprezentantLabel";
            reprezentantLabel.Size = new System.Drawing.Size(111, 20);
            reprezentantLabel.TabIndex = 15;
            reprezentantLabel.Text = "Reprezentant:";
            // 
            // reprezentantTextBox
            // 
            this.reprezentantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Reprezentant", true));
            this.reprezentantTextBox.Location = new System.Drawing.Point(151, 272);
            this.reprezentantTextBox.Name = "reprezentantTextBox";
            this.reprezentantTextBox.Size = new System.Drawing.Size(100, 26);
            this.reprezentantTextBox.TabIndex = 16;
            // 
            // calitateLabel
            // 
            calitateLabel.AutoSize = true;
            calitateLabel.Location = new System.Drawing.Point(34, 307);
            calitateLabel.Name = "calitateLabel";
            calitateLabel.Size = new System.Drawing.Size(67, 20);
            calitateLabel.TabIndex = 17;
            calitateLabel.Text = "Calitate:";
            // 
            // calitateTextBox
            // 
            this.calitateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Calitate", true));
            this.calitateTextBox.Location = new System.Drawing.Point(151, 304);
            this.calitateTextBox.Name = "calitateTextBox";
            this.calitateTextBox.Size = new System.Drawing.Size(100, 26);
            this.calitateTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(34, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 20;
            idLabel.Text = "Id:";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientiBindingSource, "Id", true));
            this.idNumericUpDown.Location = new System.Drawing.Point(151, 48);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.idNumericUpDown.TabIndex = 21;
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 380);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(codPostalLabel);
            this.Controls.Add(this.codPostalTextBox);
            this.Controls.Add(nrTelefonLabel);
            this.Controls.Add(this.nrTelefonTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(codFiscalLabel);
            this.Controls.Add(this.codFiscalTextBox);
            this.Controls.Add(reprezentantLabel);
            this.Controls.Add(this.reprezentantTextBox);
            this.Controls.Add(calitateLabel);
            this.Controls.Add(this.calitateTextBox);
            this.Controls.Add(this.clientiBindingNavigator);
            this.Name = "FormClienti";
            this.Text = "FormClienti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClienti_FormClosed);
            this.Load += new System.EventHandler(this.FormClienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).EndInit();
            this.clientiBindingNavigator.ResumeLayout(false);
            this.clientiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private DatabaseDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox codPostalTextBox;
        private System.Windows.Forms.TextBox nrTelefonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox codFiscalTextBox;
        private System.Windows.Forms.TextBox reprezentantTextBox;
        private System.Windows.Forms.TextBox calitateTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
    }
}