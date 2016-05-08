using System;

namespace WindowsFormsApplication1.UI
{
    partial class Rezultate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezultate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RezultateGridView = new System.Windows.Forms.DataGridView();
            this.cautareGroupBox = new System.Windows.Forms.GroupBox();
            this.dataRezolvareDatePicker = new System.Windows.Forms.DateTimePicker();
            this.nivelTestComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeTestComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prenComboBox = new System.Windows.Forms.ComboBox();
            this.numeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.veziRezultateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ordDupaRaspGresButton = new System.Windows.Forms.Button();
            this.ordDupaRaspCorButton = new System.Windows.Forms.Button();
            this.ordDupaTimpRezButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.veziRaspButton = new System.Windows.Forms.Button();
            this.raspunsuriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataRezolvareCheckBox = new System.Windows.Forms.CheckBox();
            this.dataRezolvareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RezultateGridView)).BeginInit();
            this.cautareGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspunsuriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RezultateGridView
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RezultateGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.RezultateGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.RezultateGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RezultateGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RezultateGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RezultateGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.RezultateGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.RezultateGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RezultateGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.RezultateGridView.ColumnHeadersHeight = 25;
            this.RezultateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RezultateGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.RezultateGridView.EnableHeadersVisualStyles = false;
            this.RezultateGridView.Location = new System.Drawing.Point(58, 213);
            this.RezultateGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RezultateGridView.Name = "RezultateGridView";
            this.RezultateGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RezultateGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Red;
            this.RezultateGridView.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.RezultateGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.RezultateGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.RezultateGridView.RowTemplate.Height = 25;
            this.RezultateGridView.Size = new System.Drawing.Size(1098, 497);
            this.RezultateGridView.TabIndex = 18;
            // 
            // cautareGroupBox
            // 
            this.cautareGroupBox.BackColor = System.Drawing.Color.GhostWhite;
            this.cautareGroupBox.Controls.Add(this.dataRezolvareLabel);
            this.cautareGroupBox.Controls.Add(this.dataRezolvareCheckBox);
            this.cautareGroupBox.Controls.Add(this.dataRezolvareDatePicker);
            this.cautareGroupBox.Controls.Add(this.nivelTestComboBox);
            this.cautareGroupBox.Controls.Add(this.label1);
            this.cautareGroupBox.Controls.Add(this.numeTestComboBox);
            this.cautareGroupBox.Controls.Add(this.label3);
            this.cautareGroupBox.Controls.Add(this.prenComboBox);
            this.cautareGroupBox.Controls.Add(this.numeComboBox);
            this.cautareGroupBox.Controls.Add(this.label6);
            this.cautareGroupBox.Controls.Add(this.label2);
            this.cautareGroupBox.Controls.Add(this.veziRezultateBtn);
            this.cautareGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cautareGroupBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cautareGroupBox.Location = new System.Drawing.Point(57, 88);
            this.cautareGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cautareGroupBox.Name = "cautareGroupBox";
            this.cautareGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cautareGroupBox.Size = new System.Drawing.Size(1099, 117);
            this.cautareGroupBox.TabIndex = 29;
            this.cautareGroupBox.TabStop = false;
            // 
            // dataRezolvareDatePicker
            // 
            this.dataRezolvareDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataRezolvareDatePicker.Location = new System.Drawing.Point(802, 71);
            this.dataRezolvareDatePicker.Name = "dataRezolvareDatePicker";
            this.dataRezolvareDatePicker.Size = new System.Drawing.Size(159, 24);
            this.dataRezolvareDatePicker.TabIndex = 38;
            this.dataRezolvareDatePicker.Value = new System.DateTime(2016, 5, 8, 18, 42, 3, 754);
            this.dataRezolvareDatePicker.Visible = false;
            this.dataRezolvareDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // nivelTestComboBox
            // 
            this.nivelTestComboBox.FormattingEnabled = true;
            this.nivelTestComboBox.Location = new System.Drawing.Point(390, 71);
            this.nivelTestComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nivelTestComboBox.Name = "nivelTestComboBox";
            this.nivelTestComboBox.Size = new System.Drawing.Size(180, 26);
            this.nivelTestComboBox.TabIndex = 37;
            this.nivelTestComboBox.SelectedIndexChanged += new System.EventHandler(this.nivelTestComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(386, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 35);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nivel Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeTestComboBox
            // 
            this.numeTestComboBox.FormattingEnabled = true;
            this.numeTestComboBox.Location = new System.Drawing.Point(578, 71);
            this.numeTestComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeTestComboBox.Name = "numeTestComboBox";
            this.numeTestComboBox.Size = new System.Drawing.Size(180, 26);
            this.numeTestComboBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(575, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 35);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nume Test";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prenComboBox
            // 
            this.prenComboBox.FormattingEnabled = true;
            this.prenComboBox.Location = new System.Drawing.Point(202, 71);
            this.prenComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prenComboBox.Name = "prenComboBox";
            this.prenComboBox.Size = new System.Drawing.Size(180, 26);
            this.prenComboBox.TabIndex = 31;
            this.prenComboBox.SelectedIndexChanged += new System.EventHandler(this.prenComboBox_SelectedIndexChanged);
            // 
            // numeComboBox
            // 
            this.numeComboBox.FormattingEnabled = true;
            this.numeComboBox.Location = new System.Drawing.Point(14, 71);
            this.numeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeComboBox.Name = "numeComboBox";
            this.numeComboBox.Size = new System.Drawing.Size(180, 26);
            this.numeComboBox.TabIndex = 21;
            this.numeComboBox.SelectedIndexChanged += new System.EventHandler(this.numeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(198, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 35);
            this.label6.TabIndex = 29;
            this.label6.Text = "Prenume Pacient";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 35);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nume Pacient";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // veziRezultateBtn
            // 
            this.veziRezultateBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.veziRezultateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.veziRezultateBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.veziRezultateBtn.Image = global::WindowsFormsApplication1.Properties.Resources.Dislalia_315x133;
            this.veziRezultateBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.veziRezultateBtn.Location = new System.Drawing.Point(968, 39);
            this.veziRezultateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.veziRezultateBtn.Name = "veziRezultateBtn";
            this.veziRezultateBtn.Size = new System.Drawing.Size(123, 77);
            this.veziRezultateBtn.TabIndex = 20;
            this.veziRezultateBtn.Text = "Vezi Rezultate";
            this.veziRezultateBtn.UseVisualStyleBackColor = false;
            this.veziRezultateBtn.Click += new System.EventHandler(this.veziRezultateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.ordDupaRaspGresButton);
            this.groupBox1.Controls.Add(this.ordDupaRaspCorButton);
            this.groupBox1.Controls.Add(this.ordDupaTimpRezButton);
            this.groupBox1.Location = new System.Drawing.Point(57, 720);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(735, 125);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // ordDupaRaspGresButton
            // 
            this.ordDupaRaspGresButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ordDupaRaspGresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ordDupaRaspGresButton.Image = ((System.Drawing.Image)(resources.GetObject("ordDupaRaspGresButton.Image")));
            this.ordDupaRaspGresButton.Location = new System.Drawing.Point(256, 29);
            this.ordDupaRaspGresButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ordDupaRaspGresButton.Name = "ordDupaRaspGresButton";
            this.ordDupaRaspGresButton.Size = new System.Drawing.Size(218, 85);
            this.ordDupaRaspGresButton.TabIndex = 4;
            this.ordDupaRaspGresButton.Text = "Ordoneaza dupa raspunsuri gresite";
            this.ordDupaRaspGresButton.UseVisualStyleBackColor = false;
            this.ordDupaRaspGresButton.Click += new System.EventHandler(this.ordDupaRaspGresButton_Click);
            // 
            // ordDupaRaspCorButton
            // 
            this.ordDupaRaspCorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ordDupaRaspCorButton.Image = global::WindowsFormsApplication1.Properties.Resources.Tapet_Parato_Cristiana_Masi_NOBILE_2911;
            this.ordDupaRaspCorButton.Location = new System.Drawing.Point(30, 29);
            this.ordDupaRaspCorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ordDupaRaspCorButton.Name = "ordDupaRaspCorButton";
            this.ordDupaRaspCorButton.Size = new System.Drawing.Size(218, 85);
            this.ordDupaRaspCorButton.TabIndex = 3;
            this.ordDupaRaspCorButton.Text = "Ordoneaza dupa raspunsuri corecte";
            this.ordDupaRaspCorButton.UseVisualStyleBackColor = true;
            this.ordDupaRaspCorButton.Click += new System.EventHandler(this.ordDupaRaspCorButton_Click);
            // 
            // ordDupaTimpRezButton
            // 
            this.ordDupaTimpRezButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ordDupaTimpRezButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ordDupaTimpRezButton.Image = ((System.Drawing.Image)(resources.GetObject("ordDupaTimpRezButton.Image")));
            this.ordDupaTimpRezButton.Location = new System.Drawing.Point(483, 31);
            this.ordDupaTimpRezButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ordDupaTimpRezButton.Name = "ordDupaTimpRezButton";
            this.ordDupaTimpRezButton.Size = new System.Drawing.Size(218, 85);
            this.ordDupaTimpRezButton.TabIndex = 2;
            this.ordDupaTimpRezButton.Text = "Ordoneaza dupa timp rezolvare";
            this.ordDupaTimpRezButton.UseVisualStyleBackColor = false;
            this.ordDupaTimpRezButton.Click += new System.EventHandler(this.ordDupaTimpRezButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(75, 951);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 75);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // veziRaspButton
            // 
            this.veziRaspButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.veziRaspButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.veziRaspButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.veziRaspButton.Image = global::WindowsFormsApplication1.Properties.Resources.Dislalia_315x133;
            this.veziRaspButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.veziRaspButton.Location = new System.Drawing.Point(1212, 133);
            this.veziRaspButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.veziRaspButton.Name = "veziRaspButton";
            this.veziRaspButton.Size = new System.Drawing.Size(207, 77);
            this.veziRaspButton.TabIndex = 38;
            this.veziRaspButton.Text = "Vezi raspunsuri complete";
            this.veziRaspButton.UseVisualStyleBackColor = false;
            this.veziRaspButton.Click += new System.EventHandler(this.veziRaspButton_Click);
            // 
            // raspunsuriDataGridView
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.raspunsuriDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.raspunsuriDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.raspunsuriDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.raspunsuriDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.raspunsuriDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.raspunsuriDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.raspunsuriDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspunsuriDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.raspunsuriDataGridView.ColumnHeadersHeight = 40;
            this.raspunsuriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.raspunsuriDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.raspunsuriDataGridView.DefaultCellStyle = dataGridViewCellStyle28;
            this.raspunsuriDataGridView.EnableHeadersVisualStyles = false;
            this.raspunsuriDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.raspunsuriDataGridView.Location = new System.Drawing.Point(1164, 214);
            this.raspunsuriDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.raspunsuriDataGridView.Name = "raspunsuriDataGridView";
            this.raspunsuriDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspunsuriDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Red;
            this.raspunsuriDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.raspunsuriDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.raspunsuriDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.raspunsuriDataGridView.RowTemplate.Height = 25;
            this.raspunsuriDataGridView.Size = new System.Drawing.Size(795, 497);
            this.raspunsuriDataGridView.TabIndex = 39;
            // 
            // dataRezolvareCheckBox
            // 
            this.dataRezolvareCheckBox.AutoSize = true;
            this.dataRezolvareCheckBox.Location = new System.Drawing.Point(781, 77);
            this.dataRezolvareCheckBox.Name = "dataRezolvareCheckBox";
            this.dataRezolvareCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dataRezolvareCheckBox.TabIndex = 39;
            this.dataRezolvareCheckBox.UseVisualStyleBackColor = true;
            this.dataRezolvareCheckBox.CheckedChanged += new System.EventHandler(this.dataRezolvareCheckBox_CheckedChanged);
            // 
            // dataRezolvareLabel
            // 
            this.dataRezolvareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataRezolvareLabel.Location = new System.Drawing.Point(778, 31);
            this.dataRezolvareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataRezolvareLabel.Name = "dataRezolvareLabel";
            this.dataRezolvareLabel.Size = new System.Drawing.Size(183, 35);
            this.dataRezolvareLabel.TabIndex = 40;
            this.dataRezolvareLabel.Text = "Data Rezolvare";
            this.dataRezolvareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rezultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 1045);
            this.Controls.Add(this.raspunsuriDataGridView);
            this.Controls.Add(this.veziRaspButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cautareGroupBox);
            this.Controls.Add(this.RezultateGridView);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rezultate";
            this.Text = "Rezultate";
            ((System.ComponentModel.ISupportInitialize)(this.RezultateGridView)).EndInit();
            this.cautareGroupBox.ResumeLayout(false);
            this.cautareGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raspunsuriDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView RezultateGridView;
        private System.Windows.Forms.Button veziRezultateBtn;
        private System.Windows.Forms.GroupBox cautareGroupBox;
        private System.Windows.Forms.ComboBox prenComboBox;
        private System.Windows.Forms.ComboBox numeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numeTestComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nivelTestComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ordDupaTimpRezButton;
        private System.Windows.Forms.Button ordDupaRaspCorButton;
        private System.Windows.Forms.Button ordDupaRaspGresButton;
        private System.Windows.Forms.Button veziRaspButton;
        private System.Windows.Forms.DataGridView raspunsuriDataGridView;
        private System.Windows.Forms.DateTimePicker dataRezolvareDatePicker;
        private System.Windows.Forms.Label dataRezolvareLabel;
        private System.Windows.Forms.CheckBox dataRezolvareCheckBox;
    }
}