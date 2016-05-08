namespace WindowsFormsApplication1
{
    partial class Pacienti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacienti));
            this.label2 = new System.Windows.Forms.Label();
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prenTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.varstaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.obsTextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.modificaDateButton = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pacientiDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stergePacientButton = new System.Windows.Forms.Button();
            this.cautareGroupBox = new System.Windows.Forms.GroupBox();
            this.numeComboBox = new System.Windows.Forms.ComboBox();
            this.cautaBtn = new System.Windows.Forms.Button();
            this.prenComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CautaLbl = new System.Windows.Forms.Label();
            this.cnpTextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cautaDupaCnpBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.cautareGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNP ";
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cnpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cnpTextBox.Location = new System.Drawing.Point(119, 50);
            this.cnpTextBox.MaxLength = 13;
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(158, 26);
            this.cnpTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nume";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numeTextBox
            // 
            this.numeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numeTextBox.Location = new System.Drawing.Point(119, 93);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(158, 26);
            this.numeTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prenume";
            // 
            // prenTextBox
            // 
            this.prenTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prenTextBox.Location = new System.Drawing.Point(119, 135);
            this.prenTextBox.Name = "prenTextBox";
            this.prenTextBox.Size = new System.Drawing.Size(158, 26);
            this.prenTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(13, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vârstă";
            // 
            // varstaTextBox
            // 
            this.varstaTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.varstaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varstaTextBox.Location = new System.Drawing.Point(119, 172);
            this.varstaTextBox.Name = "varstaTextBox";
            this.varstaTextBox.Size = new System.Drawing.Size(158, 26);
            this.varstaTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.adaugaButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.obsTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.varstaTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.prenTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cnpTextBox);
            this.groupBox1.Controls.Add(this.numeTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(772, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 406);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Pacient";
            // 
            // adaugaButton
            // 
            this.adaugaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adaugaButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.adaugaButton.Image = global::WindowsFormsApplication1.Properties.Resources.Dislalia_315x133;
            this.adaugaButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.adaugaButton.Location = new System.Drawing.Point(17, 335);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(129, 52);
            this.adaugaButton.TabIndex = 16;
            this.adaugaButton.Text = "Adaugă Pacient";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(13, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Observații";
            // 
            // obsTextbox
            // 
            this.obsTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.obsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obsTextbox.Location = new System.Drawing.Point(111, 229);
            this.obsTextbox.Multiline = true;
            this.obsTextbox.Name = "obsTextbox";
            this.obsTextbox.Size = new System.Drawing.Size(181, 76);
            this.obsTextbox.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.modificaDateButton);
            this.groupBox3.Controls.Add(this.saveBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(1090, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 111);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modifica Date Pacient";
            // 
            // modificaDateButton
            // 
            this.modificaDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modificaDateButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.modificaDateButton.Image = global::WindowsFormsApplication1.Properties.Resources.Dislalia_315x133;
            this.modificaDateButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.modificaDateButton.Location = new System.Drawing.Point(6, 62);
            this.modificaDateButton.Name = "modificaDateButton";
            this.modificaDateButton.Size = new System.Drawing.Size(105, 42);
            this.modificaDateButton.TabIndex = 21;
            this.modificaDateButton.Text = "Modifică Date Pacient";
            this.modificaDateButton.UseVisualStyleBackColor = true;
            this.modificaDateButton.Click += new System.EventHandler(this.modificaDateButton_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.saveBtn.Image = global::WindowsFormsApplication1.Properties.Resources.Dislalia_315x133;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.saveBtn.Location = new System.Drawing.Point(126, 62);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 43);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Salveaza";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pacientiDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pacientiDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pacientiDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.pacientiDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.pacientiDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.pacientiDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pacientiDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.pacientiDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pacientiDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.pacientiDataGrid.ColumnHeadersHeight = 40;
            this.pacientiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pacientiDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pacientiDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.pacientiDataGrid.EnableHeadersVisualStyles = false;
            this.pacientiDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pacientiDataGrid.Location = new System.Drawing.Point(29, 161);
            this.pacientiDataGrid.MultiSelect = false;
            this.pacientiDataGrid.Name = "pacientiDataGrid";
            this.pacientiDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pacientiDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.pacientiDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.pacientiDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.pacientiDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.pacientiDataGrid.RowTemplate.Height = 25;
            this.pacientiDataGrid.Size = new System.Drawing.Size(737, 356);
            this.pacientiDataGrid.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.stergePacientButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(1090, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 101);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ștergeți Pacient";
            // 
            // stergePacientButton
            // 
            this.stergePacientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stergePacientButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.stergePacientButton.Image = global::WindowsFormsApplication1.Properties.Resources.Dislalia_315x133;
            this.stergePacientButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stergePacientButton.Location = new System.Drawing.Point(6, 52);
            this.stergePacientButton.Name = "stergePacientButton";
            this.stergePacientButton.Size = new System.Drawing.Size(117, 43);
            this.stergePacientButton.TabIndex = 16;
            this.stergePacientButton.Text = "Șterge Pacient";
            this.stergePacientButton.UseVisualStyleBackColor = true;
            this.stergePacientButton.Click += new System.EventHandler(this.stergePacientButton_Click);
            // 
            // cautareGroupBox
            // 
            this.cautareGroupBox.BackColor = System.Drawing.SystemColors.Info;
            this.cautareGroupBox.Controls.Add(this.numeComboBox);
            this.cautareGroupBox.Controls.Add(this.cautaBtn);
            this.cautareGroupBox.Controls.Add(this.prenComboBox);
            this.cautareGroupBox.Controls.Add(this.label6);
            this.cautareGroupBox.Controls.Add(this.CautaLbl);
            this.cautareGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cautareGroupBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cautareGroupBox.Location = new System.Drawing.Point(127, 97);
            this.cautareGroupBox.Name = "cautareGroupBox";
            this.cautareGroupBox.Size = new System.Drawing.Size(372, 58);
            this.cautareGroupBox.TabIndex = 20;
            this.cautareGroupBox.TabStop = false;
            // 
            // numeComboBox
            // 
            this.numeComboBox.FormattingEnabled = true;
            this.numeComboBox.Location = new System.Drawing.Point(6, 28);
            this.numeComboBox.Name = "numeComboBox";
            this.numeComboBox.Size = new System.Drawing.Size(121, 26);
            this.numeComboBox.TabIndex = 33;
            this.numeComboBox.SelectedIndexChanged += new System.EventHandler(this.numeComboBox_SelectedIndexChanged);
            // 
            // cautaBtn
            // 
            this.cautaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cautaBtn.BackColor = System.Drawing.Color.Bisque;
            this.cautaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cautaBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cautaBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cautaBtn.Location = new System.Drawing.Point(261, 2);
            this.cautaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cautaBtn.Name = "cautaBtn";
            this.cautaBtn.Size = new System.Drawing.Size(105, 52);
            this.cautaBtn.TabIndex = 21;
            this.cautaBtn.Text = "Cauta dupa\r\nnume";
            this.cautaBtn.UseVisualStyleBackColor = false;
            this.cautaBtn.Click += new System.EventHandler(this.cautaBtn_Click);
            // 
            // prenComboBox
            // 
            this.prenComboBox.FormattingEnabled = true;
            this.prenComboBox.Location = new System.Drawing.Point(133, 28);
            this.prenComboBox.Name = "prenComboBox";
            this.prenComboBox.Size = new System.Drawing.Size(121, 26);
            this.prenComboBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(130, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Prenume Pacient";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CautaLbl
            // 
            this.CautaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CautaLbl.Location = new System.Drawing.Point(6, 6);
            this.CautaLbl.Name = "CautaLbl";
            this.CautaLbl.Size = new System.Drawing.Size(121, 23);
            this.CautaLbl.TabIndex = 28;
            this.CautaLbl.Text = "Nume Pacient";
            this.CautaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cnpTextBox1
            // 
            this.cnpTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cnpTextBox1.Location = new System.Drawing.Point(6, 29);
            this.cnpTextBox1.Name = "cnpTextBox1";
            this.cnpTextBox1.Size = new System.Drawing.Size(138, 24);
            this.cnpTextBox1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "CNP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Controls.Add(this.cautaDupaCnpBtn);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cnpTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(505, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 57);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            // 
            // cautaDupaCnpBtn
            // 
            this.cautaDupaCnpBtn.BackColor = System.Drawing.Color.Bisque;
            this.cautaDupaCnpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cautaDupaCnpBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cautaDupaCnpBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cautaDupaCnpBtn.Location = new System.Drawing.Point(150, 5);
            this.cautaDupaCnpBtn.Name = "cautaDupaCnpBtn";
            this.cautaDupaCnpBtn.Size = new System.Drawing.Size(103, 48);
            this.cautaDupaCnpBtn.TabIndex = 34;
            this.cautaDupaCnpBtn.Text = "Cauta dupa CNP";
            this.cautaDupaCnpBtn.UseVisualStyleBackColor = false;
            this.cautaDupaCnpBtn.Click += new System.EventHandler(this.cautaDupaCnpBtn_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button6.Image = global::WindowsFormsApplication1.Properties.Resources.Dislalia_315x133;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.Location = new System.Drawing.Point(23, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 58);
            this.button6.TabIndex = 18;
            this.button6.Text = "Vezi Pacienți";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(29, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cautareGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pacientiDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Name = "Pacienti";
            this.Text = "Pacienți";
            this.Load += new System.EventHandler(this.Pacienti_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.cautareGroupBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prenTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox varstaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView pacientiDataGrid;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox obsTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox cautareGroupBox;
        private System.Windows.Forms.ComboBox prenComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CautaLbl;
        private System.Windows.Forms.TextBox cnpTextBox1;
        private System.Windows.Forms.Button cautaBtn;
        private System.Windows.Forms.Button modificaDateButton;
        private System.Windows.Forms.Button stergePacientButton;
        private System.Windows.Forms.ComboBox numeComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cautaDupaCnpBtn;
        private System.Windows.Forms.Button adaugaButton;
    }
}