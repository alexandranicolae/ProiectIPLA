
namespace ProiectIPLA
{
    partial class FormContract
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
            System.Windows.Forms.Label nrIntrareLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label idClientLabel;
            System.Windows.Forms.Label realizareProiectLabel;
            System.Windows.Forms.Label valoare1Label;
            System.Windows.Forms.Label provenientaAchizitie1Label;
            System.Windows.Forms.Label termeni1Label;
            System.Windows.Forms.Label valoare2Label;
            System.Windows.Forms.Label provenientaAchizitie2Label;
            System.Windows.Forms.Label termeni2Label;
            System.Windows.Forms.Label mentenantaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContract));
            System.Windows.Forms.Label idLabel;
            this.contracteBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contracteBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nrIntrareTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.realizareProiectCheckBox = new System.Windows.Forms.CheckBox();
            this.valoare1TextBox = new System.Windows.Forms.TextBox();
            this.provenientaAchizitie1TextBox = new System.Windows.Forms.TextBox();
            this.termeni1TextBox = new System.Windows.Forms.TextBox();
            this.valoare2TextBox = new System.Windows.Forms.TextBox();
            this.provenientaAchizitie2TextBox = new System.Windows.Forms.TextBox();
            this.termeni2TextBox = new System.Windows.Forms.TextBox();
            this.mentenantaComboBox = new System.Windows.Forms.ComboBox();
            this.contracteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new ProiectIPLA.DatabaseDataSet();
            this.clientiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contracteTableAdapter1 = new ProiectIPLA.DatabaseDataSetTableAdapters.ContracteTableAdapter();
            this.tableAdapterManager1 = new ProiectIPLA.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.clientiTableAdapter1 = new ProiectIPLA.DatabaseDataSetTableAdapters.ClientiTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            nrIntrareLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            idClientLabel = new System.Windows.Forms.Label();
            realizareProiectLabel = new System.Windows.Forms.Label();
            valoare1Label = new System.Windows.Forms.Label();
            provenientaAchizitie1Label = new System.Windows.Forms.Label();
            termeni1Label = new System.Windows.Forms.Label();
            valoare2Label = new System.Windows.Forms.Label();
            provenientaAchizitie2Label = new System.Windows.Forms.Label();
            termeni2Label = new System.Windows.Forms.Label();
            mentenantaLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contracteBindingSource1BindingNavigator)).BeginInit();
            this.contracteBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contracteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nrIntrareLabel
            // 
            nrIntrareLabel.AutoSize = true;
            nrIntrareLabel.Location = new System.Drawing.Point(12, 85);
            nrIntrareLabel.Name = "nrIntrareLabel";
            nrIntrareLabel.Size = new System.Drawing.Size(80, 20);
            nrIntrareLabel.TabIndex = 5;
            nrIntrareLabel.Text = "Nr Intrare:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(12, 118);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(48, 20);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "Data:";
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Location = new System.Drawing.Point(12, 149);
            idClientLabel.Name = "idClientLabel";
            idClientLabel.Size = new System.Drawing.Size(71, 20);
            idClientLabel.TabIndex = 9;
            idClientLabel.Text = "Id Client:";
            // 
            // realizareProiectLabel
            // 
            realizareProiectLabel.AutoSize = true;
            realizareProiectLabel.Location = new System.Drawing.Point(12, 183);
            realizareProiectLabel.Name = "realizareProiectLabel";
            realizareProiectLabel.Size = new System.Drawing.Size(133, 20);
            realizareProiectLabel.TabIndex = 11;
            realizareProiectLabel.Text = "Realizare Proiect:";
            // 
            // valoare1Label
            // 
            valoare1Label.AutoSize = true;
            valoare1Label.Location = new System.Drawing.Point(12, 244);
            valoare1Label.Name = "valoare1Label";
            valoare1Label.Size = new System.Drawing.Size(77, 20);
            valoare1Label.TabIndex = 15;
            valoare1Label.Text = "Valoare1:";
            // 
            // provenientaAchizitie1Label
            // 
            provenientaAchizitie1Label.AutoSize = true;
            provenientaAchizitie1Label.Location = new System.Drawing.Point(12, 276);
            provenientaAchizitie1Label.Name = "provenientaAchizitie1Label";
            provenientaAchizitie1Label.Size = new System.Drawing.Size(169, 20);
            provenientaAchizitie1Label.TabIndex = 17;
            provenientaAchizitie1Label.Text = "Provenienta Achizitie1:";
            // 
            // termeni1Label
            // 
            termeni1Label.AutoSize = true;
            termeni1Label.Location = new System.Drawing.Point(12, 308);
            termeni1Label.Name = "termeni1Label";
            termeni1Label.Size = new System.Drawing.Size(79, 20);
            termeni1Label.TabIndex = 19;
            termeni1Label.Text = "Termeni1:";
            // 
            // valoare2Label
            // 
            valoare2Label.AutoSize = true;
            valoare2Label.Location = new System.Drawing.Point(12, 340);
            valoare2Label.Name = "valoare2Label";
            valoare2Label.Size = new System.Drawing.Size(77, 20);
            valoare2Label.TabIndex = 21;
            valoare2Label.Text = "Valoare2:";
            // 
            // provenientaAchizitie2Label
            // 
            provenientaAchizitie2Label.AutoSize = true;
            provenientaAchizitie2Label.Location = new System.Drawing.Point(12, 372);
            provenientaAchizitie2Label.Name = "provenientaAchizitie2Label";
            provenientaAchizitie2Label.Size = new System.Drawing.Size(169, 20);
            provenientaAchizitie2Label.TabIndex = 23;
            provenientaAchizitie2Label.Text = "Provenienta Achizitie2:";
            // 
            // termeni2Label
            // 
            termeni2Label.AutoSize = true;
            termeni2Label.Location = new System.Drawing.Point(12, 404);
            termeni2Label.Name = "termeni2Label";
            termeni2Label.Size = new System.Drawing.Size(79, 20);
            termeni2Label.TabIndex = 25;
            termeni2Label.Text = "Termeni2:";
            // 
            // mentenantaLabel1
            // 
            mentenantaLabel1.AutoSize = true;
            mentenantaLabel1.Location = new System.Drawing.Point(12, 215);
            mentenantaLabel1.Name = "mentenantaLabel1";
            mentenantaLabel1.Size = new System.Drawing.Size(99, 20);
            mentenantaLabel1.TabIndex = 27;
            mentenantaLabel1.Text = "Mentenanta:";
            // 
            // contracteBindingSource1BindingNavigator
            // 
            this.contracteBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.contracteBindingSource1BindingNavigator.BindingSource = this.contracteBindingSource1;
            this.contracteBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.contracteBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.contracteBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contracteBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.contracteBindingSource1BindingNavigatorSaveItem});
            this.contracteBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contracteBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.contracteBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.contracteBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.contracteBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.contracteBindingSource1BindingNavigator.Name = "contracteBindingSource1BindingNavigator";
            this.contracteBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.contracteBindingSource1BindingNavigator.Size = new System.Drawing.Size(489, 33);
            this.contracteBindingSource1BindingNavigator.TabIndex = 0;
            this.contracteBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 28);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // contracteBindingSource1BindingNavigatorSaveItem
            // 
            this.contracteBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contracteBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contracteBindingSource1BindingNavigatorSaveItem.Image")));
            this.contracteBindingSource1BindingNavigatorSaveItem.Name = "contracteBindingSource1BindingNavigatorSaveItem";
            this.contracteBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.contracteBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.contracteBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.contracteBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // nrIntrareTextBox
            // 
            this.nrIntrareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contracteBindingSource1, "NrIntrare", true));
            this.nrIntrareTextBox.Location = new System.Drawing.Point(187, 82);
            this.nrIntrareTextBox.Name = "nrIntrareTextBox";
            this.nrIntrareTextBox.Size = new System.Drawing.Size(200, 26);
            this.nrIntrareTextBox.TabIndex = 6;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contracteBindingSource1, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(187, 114);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dataDateTimePicker.TabIndex = 8;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contracteBindingSource1, "IdClient", true));
            this.idClientTextBox.Location = new System.Drawing.Point(187, 146);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(200, 26);
            this.idClientTextBox.TabIndex = 10;
            // 
            // realizareProiectCheckBox
            // 
            this.realizareProiectCheckBox.Checked = true;
            this.realizareProiectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realizareProiectCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contracteBindingSource1, "RealizareProiect", true));
            this.realizareProiectCheckBox.Location = new System.Drawing.Point(187, 178);
            this.realizareProiectCheckBox.Name = "realizareProiectCheckBox";
            this.realizareProiectCheckBox.Size = new System.Drawing.Size(200, 24);
            this.realizareProiectCheckBox.TabIndex = 12;
            this.realizareProiectCheckBox.Text = "da";
            this.realizareProiectCheckBox.UseVisualStyleBackColor = true;
            this.realizareProiectCheckBox.CheckedChanged += new System.EventHandler(this.realizareProiectCheckBox_CheckedChanged);
            // 
            // valoare1TextBox
            // 
            this.valoare1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contracteBindingSource1, "Valoare1", true));
            this.valoare1TextBox.Location = new System.Drawing.Point(187, 241);
            this.valoare1TextBox.Name = "valoare1TextBox";
            this.valoare1TextBox.Size = new System.Drawing.Size(200, 26);
            this.valoare1TextBox.TabIndex = 16;
            // 
            // provenientaAchizitie1TextBox
            // 
            this.provenientaAchizitie1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contracteBindingSource1, "ProvenientaAchizitie1", true));
            this.provenientaAchizitie1TextBox.Location = new System.Drawing.Point(187, 273);
            this.provenientaAchizitie1TextBox.Name = "provenientaAchizitie1TextBox";
            this.provenientaAchizitie1TextBox.Size = new System.Drawing.Size(200, 26);
            this.provenientaAchizitie1TextBox.TabIndex = 18;
            // 
            // termeni1TextBox
            // 
            this.termeni1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contracteBindingSource1, "Termeni1", true));
            this.termeni1TextBox.Location = new System.Drawing.Point(187, 305);
            this.termeni1TextBox.Name = "termeni1TextBox";
            this.termeni1TextBox.Size = new System.Drawing.Size(200, 26);
            this.termeni1TextBox.TabIndex = 20;
            // 
            // valoare2TextBox
            // 
            this.valoare2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contracteBindingSource1, "Valoare2", true));
            this.valoare2TextBox.Enabled = false;
            this.valoare2TextBox.Location = new System.Drawing.Point(187, 337);
            this.valoare2TextBox.Name = "valoare2TextBox";
            this.valoare2TextBox.Size = new System.Drawing.Size(200, 26);
            this.valoare2TextBox.TabIndex = 22;
            // 
            // provenientaAchizitie2TextBox
            // 
            this.provenientaAchizitie2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contracteBindingSource1, "ProvenientaAchizitie2", true));
            this.provenientaAchizitie2TextBox.Enabled = false;
            this.provenientaAchizitie2TextBox.Location = new System.Drawing.Point(187, 369);
            this.provenientaAchizitie2TextBox.Name = "provenientaAchizitie2TextBox";
            this.provenientaAchizitie2TextBox.Size = new System.Drawing.Size(200, 26);
            this.provenientaAchizitie2TextBox.TabIndex = 24;
            // 
            // termeni2TextBox
            // 
            this.termeni2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contracteBindingSource1, "Termeni2", true));
            this.termeni2TextBox.Enabled = false;
            this.termeni2TextBox.Location = new System.Drawing.Point(187, 401);
            this.termeni2TextBox.Name = "termeni2TextBox";
            this.termeni2TextBox.Size = new System.Drawing.Size(200, 26);
            this.termeni2TextBox.TabIndex = 26;
            // 
            // mentenantaComboBox
            // 
            this.mentenantaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contracteBindingSource1, "Mentenanta", true));
            this.mentenantaComboBox.FormattingEnabled = true;
            this.mentenantaComboBox.Items.AddRange(new object[] {
            "Null",
            "Lunar",
            "Anual"});
            this.mentenantaComboBox.Location = new System.Drawing.Point(187, 207);
            this.mentenantaComboBox.Name = "mentenantaComboBox";
            this.mentenantaComboBox.Size = new System.Drawing.Size(200, 28);
            this.mentenantaComboBox.TabIndex = 28;
            this.mentenantaComboBox.SelectedIndexChanged += new System.EventHandler(this.mentenantaComboBox_SelectedIndexChanged_1);
            // 
            // contracteBindingSource1
            // 
            this.contracteBindingSource1.DataMember = "Contracte";
            this.contracteBindingSource1.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiBindingSource1
            // 
            this.clientiBindingSource1.DataMember = "Clienti";
            this.clientiBindingSource1.DataSource = this.databaseDataSet;
            // 
            // contracteTableAdapter1
            // 
            this.contracteTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientiTableAdapter = this.clientiTableAdapter1;
            this.tableAdapterManager1.ContracteTableAdapter = this.contracteTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ProiectIPLA.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientiTableAdapter1
            // 
            this.clientiTableAdapter1.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(394, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 26);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 52);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 30;
            idLabel.Text = "Id:";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contracteBindingSource1, "Id", true));
            this.idNumericUpDown.Location = new System.Drawing.Point(187, 50);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.idNumericUpDown.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 32;
            this.button2.Text = "Vezi date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormContract
            // 
            this.ClientSize = new System.Drawing.Size(489, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(mentenantaLabel1);
            this.Controls.Add(this.mentenantaComboBox);
            this.Controls.Add(nrIntrareLabel);
            this.Controls.Add(this.nrIntrareTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(idClientLabel);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(realizareProiectLabel);
            this.Controls.Add(this.realizareProiectCheckBox);
            this.Controls.Add(valoare1Label);
            this.Controls.Add(this.valoare1TextBox);
            this.Controls.Add(provenientaAchizitie1Label);
            this.Controls.Add(this.provenientaAchizitie1TextBox);
            this.Controls.Add(termeni1Label);
            this.Controls.Add(this.termeni1TextBox);
            this.Controls.Add(valoare2Label);
            this.Controls.Add(this.valoare2TextBox);
            this.Controls.Add(provenientaAchizitie2Label);
            this.Controls.Add(this.provenientaAchizitie2TextBox);
            this.Controls.Add(termeni2Label);
            this.Controls.Add(this.termeni2TextBox);
            this.Controls.Add(this.contracteBindingSource1BindingNavigator);
            this.Name = "FormContract";
            this.Load += new System.EventHandler(this.FormContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contracteBindingSource1BindingNavigator)).EndInit();
            this.contracteBindingSource1BindingNavigator.ResumeLayout(false);
            this.contracteBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contracteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource contracteBindingSource1;
        private DatabaseDataSetTableAdapters.ContracteTableAdapter contracteTableAdapter1;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator contracteBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton contracteBindingSource1BindingNavigatorSaveItem;
        private DatabaseDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter1;
        private System.Windows.Forms.BindingSource clientiBindingSource1;
        private System.Windows.Forms.TextBox nrIntrareTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.CheckBox realizareProiectCheckBox;
        private System.Windows.Forms.TextBox valoare1TextBox;
        private System.Windows.Forms.TextBox provenientaAchizitie1TextBox;
        private System.Windows.Forms.TextBox termeni1TextBox;
        private System.Windows.Forms.TextBox valoare2TextBox;
        private System.Windows.Forms.TextBox provenientaAchizitie2TextBox;
        private System.Windows.Forms.TextBox termeni2TextBox;
        private System.Windows.Forms.ComboBox mentenantaComboBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.Button button2;
    }
}

