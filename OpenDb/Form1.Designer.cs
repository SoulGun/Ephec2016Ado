namespace OpenDb
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.retourData = new System.Windows.Forms.RichTextBox();
            this.ChoosenConButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baseDeDonnées = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.idToDelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxMatricule = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.CreateEtuPanel = new System.Windows.Forms.Panel();
            this.panel_InsertButton = new System.Windows.Forms.Panel();
            this.OperationChoicePanel = new System.Windows.Forms.Panel();
            this.CheckBoxDelete = new System.Windows.Forms.CheckBox();
            this.CheckBoxUpdate = new System.Windows.Forms.CheckBox();
            this.checkBoxRead = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.panelEtuDeleteByName = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.nameToDeleteTextbox = new System.Windows.Forms.TextBox();
            this.panelEtuDeleteID = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.panelUpdateByName = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNameUpdate = new System.Windows.Forms.TextBox();
            this.buttonNameUpdate = new System.Windows.Forms.Button();
            this.panelUpdateById = new System.Windows.Forms.Panel();
            this.buttonVueUpdate = new System.Windows.Forms.Button();
            this.buttonIdUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.listBoxEtudiants = new System.Windows.Forms.ListBox();
            this.panelSelectAll = new System.Windows.Forms.Panel();
            this.panelDataGriedView = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sgbd2016DataSet = new OpenDb.Sgbd2016DataSet();
            this.sgbd2016DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rechargeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.CreateEtuPanel.SuspendLayout();
            this.panel_InsertButton.SuspendLayout();
            this.OperationChoicePanel.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelEtuDeleteByName.SuspendLayout();
            this.panelEtuDeleteID.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelUpdateByName.SuspendLayout();
            this.panelUpdateById.SuspendLayout();
            this.panelConnection.SuspendLayout();
            this.panelSelectAll.SuspendLayout();
            this.panelDataGriedView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgbd2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgbd2016DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // retourData
            // 
            this.retourData.Location = new System.Drawing.Point(188, 41);
            this.retourData.Name = "retourData";
            this.retourData.Size = new System.Drawing.Size(100, 96);
            this.retourData.TabIndex = 2;
            this.retourData.Text = "";
            // 
            // ChoosenConButton
            // 
            this.ChoosenConButton.Location = new System.Drawing.Point(62, 117);
            this.ChoosenConButton.Name = "ChoosenConButton";
            this.ChoosenConButton.Size = new System.Drawing.Size(100, 34);
            this.ChoosenConButton.TabIndex = 3;
            this.ChoosenConButton.Text = "ChosenConnection";
            this.ChoosenConButton.UseVisualStyleBackColor = true;
            this.ChoosenConButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(62, 54);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 20);
            this.userTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "db";
            // 
            // baseDeDonnées
            // 
            this.baseDeDonnées.Location = new System.Drawing.Point(62, 28);
            this.baseDeDonnées.Name = "baseDeDonnées";
            this.baseDeDonnées.Size = new System.Drawing.Size(100, 20);
            this.baseDeDonnées.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(62, 87);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "idToDelete";
            // 
            // idToDelete
            // 
            this.idToDelete.Location = new System.Drawing.Point(92, 15);
            this.idToDelete.Name = "idToDelete";
            this.idToDelete.Size = new System.Drawing.Size(29, 20);
            this.idToDelete.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "prenom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "matricule";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(65, 20);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 16;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(65, 68);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 17;
            // 
            // textBoxMatricule
            // 
            this.textBoxMatricule.Location = new System.Drawing.Point(65, 115);
            this.textBoxMatricule.Name = "textBoxMatricule";
            this.textBoxMatricule.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatricule.TabIndex = 18;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(22, 15);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 19;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.button4_Click);
            // 
            // CreateEtuPanel
            // 
            this.CreateEtuPanel.Controls.Add(this.panel_InsertButton);
            this.CreateEtuPanel.Controls.Add(this.textBoxNom);
            this.CreateEtuPanel.Controls.Add(this.label5);
            this.CreateEtuPanel.Controls.Add(this.label7);
            this.CreateEtuPanel.Controls.Add(this.textBoxMatricule);
            this.CreateEtuPanel.Controls.Add(this.label6);
            this.CreateEtuPanel.Controls.Add(this.textBoxPrenom);
            this.CreateEtuPanel.Location = new System.Drawing.Point(0, 250);
            this.CreateEtuPanel.Name = "CreateEtuPanel";
            this.CreateEtuPanel.Size = new System.Drawing.Size(223, 204);
            this.CreateEtuPanel.TabIndex = 20;
            // 
            // panel_InsertButton
            // 
            this.panel_InsertButton.Controls.Add(this.buttonInsert);
            this.panel_InsertButton.Location = new System.Drawing.Point(56, 144);
            this.panel_InsertButton.Name = "panel_InsertButton";
            this.panel_InsertButton.Size = new System.Drawing.Size(116, 51);
            this.panel_InsertButton.TabIndex = 25;
            // 
            // OperationChoicePanel
            // 
            this.OperationChoicePanel.Controls.Add(this.CheckBoxDelete);
            this.OperationChoicePanel.Controls.Add(this.CheckBoxUpdate);
            this.OperationChoicePanel.Controls.Add(this.checkBoxRead);
            this.OperationChoicePanel.Controls.Add(this.checkBox1);
            this.OperationChoicePanel.Location = new System.Drawing.Point(12, 92);
            this.OperationChoicePanel.Name = "OperationChoicePanel";
            this.OperationChoicePanel.Size = new System.Drawing.Size(136, 152);
            this.OperationChoicePanel.TabIndex = 21;
            // 
            // CheckBoxDelete
            // 
            this.CheckBoxDelete.AutoSize = true;
            this.CheckBoxDelete.Location = new System.Drawing.Point(44, 125);
            this.CheckBoxDelete.Name = "CheckBoxDelete";
            this.CheckBoxDelete.Size = new System.Drawing.Size(57, 17);
            this.CheckBoxDelete.TabIndex = 3;
            this.CheckBoxDelete.Text = "Delete";
            this.CheckBoxDelete.UseVisualStyleBackColor = true;
            this.CheckBoxDelete.CheckedChanged += new System.EventHandler(this.CheckBoxDelete_CheckedChanged);
            // 
            // CheckBoxUpdate
            // 
            this.CheckBoxUpdate.AutoSize = true;
            this.CheckBoxUpdate.Location = new System.Drawing.Point(44, 102);
            this.CheckBoxUpdate.Name = "CheckBoxUpdate";
            this.CheckBoxUpdate.Size = new System.Drawing.Size(61, 17);
            this.CheckBoxUpdate.TabIndex = 2;
            this.CheckBoxUpdate.Text = "Update";
            this.CheckBoxUpdate.UseVisualStyleBackColor = true;
            this.CheckBoxUpdate.CheckedChanged += new System.EventHandler(this.CheckBoxUpdate_CheckedChanged);
            // 
            // checkBoxRead
            // 
            this.checkBoxRead.AutoSize = true;
            this.checkBoxRead.Location = new System.Drawing.Point(44, 79);
            this.checkBoxRead.Name = "checkBoxRead";
            this.checkBoxRead.Size = new System.Drawing.Size(52, 17);
            this.checkBoxRead.TabIndex = 1;
            this.checkBoxRead.Text = "Read";
            this.checkBoxRead.UseVisualStyleBackColor = true;
            this.checkBoxRead.CheckedChanged += new System.EventHandler(this.checkBoxRead_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(44, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Create";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.panelEtuDeleteByName);
            this.panelDelete.Controls.Add(this.panelEtuDeleteID);
            this.panelDelete.Location = new System.Drawing.Point(232, 268);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(177, 186);
            this.panelDelete.TabIndex = 22;
            // 
            // panelEtuDeleteByName
            // 
            this.panelEtuDeleteByName.Controls.Add(this.label8);
            this.panelEtuDeleteByName.Controls.Add(this.nameToDeleteTextbox);
            this.panelEtuDeleteByName.Controls.Add(this.button3);
            this.panelEtuDeleteByName.Location = new System.Drawing.Point(9, 101);
            this.panelEtuDeleteByName.Name = "panelEtuDeleteByName";
            this.panelEtuDeleteByName.Size = new System.Drawing.Size(149, 82);
            this.panelEtuDeleteByName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "NameToDelete";
            // 
            // nameToDeleteTextbox
            // 
            this.nameToDeleteTextbox.Location = new System.Drawing.Point(6, 18);
            this.nameToDeleteTextbox.Name = "nameToDeleteTextbox";
            this.nameToDeleteTextbox.Size = new System.Drawing.Size(124, 20);
            this.nameToDeleteTextbox.TabIndex = 14;
            // 
            // panelEtuDeleteID
            // 
            this.panelEtuDeleteID.Controls.Add(this.button2);
            this.panelEtuDeleteID.Controls.Add(this.label4);
            this.panelEtuDeleteID.Controls.Add(this.idToDelete);
            this.panelEtuDeleteID.Location = new System.Drawing.Point(9, 7);
            this.panelEtuDeleteID.Name = "panelEtuDeleteID";
            this.panelEtuDeleteID.Size = new System.Drawing.Size(149, 91);
            this.panelEtuDeleteID.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.panelUpdateByName);
            this.panelUpdate.Controls.Add(this.panelUpdateById);
            this.panelUpdate.Controls.Add(this.retourData);
            this.panelUpdate.Location = new System.Drawing.Point(371, 12);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(314, 186);
            this.panelUpdate.TabIndex = 23;
            // 
            // panelUpdateByName
            // 
            this.panelUpdateByName.Controls.Add(this.button5);
            this.panelUpdateByName.Controls.Add(this.label9);
            this.panelUpdateByName.Controls.Add(this.textBoxNameUpdate);
            this.panelUpdateByName.Controls.Add(this.buttonNameUpdate);
            this.panelUpdateByName.Location = new System.Drawing.Point(6, 99);
            this.panelUpdateByName.Name = "panelUpdateByName";
            this.panelUpdateByName.Size = new System.Drawing.Size(149, 84);
            this.panelUpdateByName.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.AutoEllipsis = true;
            this.button5.Location = new System.Drawing.Point(83, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 37);
            this.button5.TabIndex = 25;
            this.button5.Text = "check";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "NameToUpdate";
            // 
            // textBoxNameUpdate
            // 
            this.textBoxNameUpdate.Location = new System.Drawing.Point(6, 18);
            this.textBoxNameUpdate.Name = "textBoxNameUpdate";
            this.textBoxNameUpdate.Size = new System.Drawing.Size(124, 20);
            this.textBoxNameUpdate.TabIndex = 14;
            // 
            // buttonNameUpdate
            // 
            this.buttonNameUpdate.Location = new System.Drawing.Point(6, 44);
            this.buttonNameUpdate.Name = "buttonNameUpdate";
            this.buttonNameUpdate.Size = new System.Drawing.Size(60, 37);
            this.buttonNameUpdate.TabIndex = 10;
            this.buttonNameUpdate.Text = "Update";
            this.buttonNameUpdate.UseVisualStyleBackColor = true;
            this.buttonNameUpdate.Click += new System.EventHandler(this.buttonNameUpdate_Click);
            // 
            // panelUpdateById
            // 
            this.panelUpdateById.Controls.Add(this.buttonVueUpdate);
            this.panelUpdateById.Controls.Add(this.buttonIdUpdate);
            this.panelUpdateById.Controls.Add(this.label10);
            this.panelUpdateById.Controls.Add(this.textBoxIdUpdate);
            this.panelUpdateById.Location = new System.Drawing.Point(6, 3);
            this.panelUpdateById.Name = "panelUpdateById";
            this.panelUpdateById.Size = new System.Drawing.Size(149, 91);
            this.panelUpdateById.TabIndex = 15;
            // 
            // buttonVueUpdate
            // 
            this.buttonVueUpdate.AutoEllipsis = true;
            this.buttonVueUpdate.Location = new System.Drawing.Point(83, 51);
            this.buttonVueUpdate.Name = "buttonVueUpdate";
            this.buttonVueUpdate.Size = new System.Drawing.Size(57, 37);
            this.buttonVueUpdate.TabIndex = 24;
            this.buttonVueUpdate.Text = "check";
            this.buttonVueUpdate.UseVisualStyleBackColor = true;
            this.buttonVueUpdate.Click += new System.EventHandler(this.buttonVueUpdate_Click);
            // 
            // buttonIdUpdate
            // 
            this.buttonIdUpdate.Location = new System.Drawing.Point(3, 51);
            this.buttonIdUpdate.Name = "buttonIdUpdate";
            this.buttonIdUpdate.Size = new System.Drawing.Size(63, 37);
            this.buttonIdUpdate.TabIndex = 23;
            this.buttonIdUpdate.Text = "Update";
            this.buttonIdUpdate.UseVisualStyleBackColor = true;
            this.buttonIdUpdate.Click += new System.EventHandler(this.buttonIdUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "idToUpdate";
            // 
            // textBoxIdUpdate
            // 
            this.textBoxIdUpdate.Location = new System.Drawing.Point(92, 15);
            this.textBoxIdUpdate.Name = "textBoxIdUpdate";
            this.textBoxIdUpdate.Size = new System.Drawing.Size(29, 20);
            this.textBoxIdUpdate.TabIndex = 12;
            // 
            // panelConnection
            // 
            this.panelConnection.Controls.Add(this.label2);
            this.panelConnection.Controls.Add(this.label1);
            this.panelConnection.Controls.Add(this.label3);
            this.panelConnection.Controls.Add(this.baseDeDonnées);
            this.panelConnection.Controls.Add(this.userTextBox);
            this.panelConnection.Controls.Add(this.ChoosenConButton);
            this.panelConnection.Controls.Add(this.textBoxPassword);
            this.panelConnection.Location = new System.Drawing.Point(176, 80);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(189, 154);
            this.panelConnection.TabIndex = 24;
            // 
            // listBoxEtudiants
            // 
            this.listBoxEtudiants.FormattingEnabled = true;
            this.listBoxEtudiants.Location = new System.Drawing.Point(21, 5);
            this.listBoxEtudiants.Name = "listBoxEtudiants";
            this.listBoxEtudiants.Size = new System.Drawing.Size(169, 121);
            this.listBoxEtudiants.TabIndex = 25;
            // 
            // panelSelectAll
            // 
            this.panelSelectAll.Controls.Add(this.listBoxEtudiants);
            this.panelSelectAll.Location = new System.Drawing.Point(713, 63);
            this.panelSelectAll.Name = "panelSelectAll";
            this.panelSelectAll.Size = new System.Drawing.Size(212, 135);
            this.panelSelectAll.TabIndex = 26;
            // 
            // panelDataGriedView
            // 
            this.panelDataGriedView.Controls.Add(this.submitButton);
            this.panelDataGriedView.Controls.Add(this.dataGridView);
            this.panelDataGriedView.Controls.Add(this.rechargeButton);
            this.panelDataGriedView.Location = new System.Drawing.Point(415, 208);
            this.panelDataGriedView.Name = "panelDataGriedView";
            this.panelDataGriedView.Size = new System.Drawing.Size(539, 246);
            this.panelDataGriedView.TabIndex = 27;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(22, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(401, 218);
            this.dataGridView.TabIndex = 0;
            // 
            // sgbd2016DataSet
            // 
            this.sgbd2016DataSet.DataSetName = "Sgbd2016DataSet";
            this.sgbd2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rechargeButton
            // 
            this.rechargeButton.Location = new System.Drawing.Point(455, 59);
            this.rechargeButton.Name = "rechargeButton";
            this.rechargeButton.Size = new System.Drawing.Size(75, 23);
            this.rechargeButton.TabIndex = 28;
            this.rechargeButton.Text = "button4";
            this.rechargeButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(455, 108);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 29;
            this.submitButton.Text = "button6";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 466);
            this.Controls.Add(this.panelDataGriedView);
            this.Controls.Add(this.panelSelectAll);
            this.Controls.Add(this.panelConnection);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.OperationChoicePanel);
            this.Controls.Add(this.CreateEtuPanel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CreateEtuPanel.ResumeLayout(false);
            this.CreateEtuPanel.PerformLayout();
            this.panel_InsertButton.ResumeLayout(false);
            this.OperationChoicePanel.ResumeLayout(false);
            this.OperationChoicePanel.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelEtuDeleteByName.ResumeLayout(false);
            this.panelEtuDeleteByName.PerformLayout();
            this.panelEtuDeleteID.ResumeLayout(false);
            this.panelEtuDeleteID.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdateByName.ResumeLayout(false);
            this.panelUpdateByName.PerformLayout();
            this.panelUpdateById.ResumeLayout(false);
            this.panelUpdateById.PerformLayout();
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.panelSelectAll.ResumeLayout(false);
            this.panelDataGriedView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgbd2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgbd2016DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox retourData;
        private System.Windows.Forms.Button ChoosenConButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseDeDonnées;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idToDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxMatricule;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Panel CreateEtuPanel;
        private System.Windows.Forms.Panel OperationChoicePanel;
        private System.Windows.Forms.CheckBox CheckBoxDelete;
        private System.Windows.Forms.CheckBox CheckBoxUpdate;
        private System.Windows.Forms.CheckBox checkBoxRead;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Panel panelEtuDeleteByName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameToDeleteTextbox;
        private System.Windows.Forms.Panel panelEtuDeleteID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Panel panelUpdateByName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNameUpdate;
        private System.Windows.Forms.Button buttonNameUpdate;
        private System.Windows.Forms.Panel panelUpdateById;
        private System.Windows.Forms.Button buttonIdUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxIdUpdate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonVueUpdate;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Panel panel_InsertButton;
        private System.Windows.Forms.ListBox listBoxEtudiants;
        private System.Windows.Forms.Panel panelSelectAll;
        private System.Windows.Forms.Panel panelDataGriedView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource sgbd2016DataSetBindingSource;
        private Sgbd2016DataSet sgbd2016DataSet;
        private System.Windows.Forms.Button rechargeButton;
        private System.Windows.Forms.Button submitButton;
    }
}

