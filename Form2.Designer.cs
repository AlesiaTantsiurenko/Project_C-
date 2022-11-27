
namespace Class_Student_Teacher
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxlistteacher = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.soapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelinfo = new System.Windows.Forms.Label();
            this.label1inizial = new System.Windows.Forms.Label();
            this.labeldatebirthday = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelcountry = new System.Windows.Forms.Label();
            this.labelcity = new System.Windows.Forms.Label();
            this.labelgroup = new System.Windows.Forms.Label();
            this.labelform = new System.Windows.Forms.Label();
            this.labelkey = new System.Windows.Forms.Label();
            this.textBoxinizial = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxcountry = new System.Windows.Forms.TextBox();
            this.textBoxcity = new System.Windows.Forms.TextBox();
            this.comboBoxgroup = new System.Windows.Forms.ComboBox();
            this.checkBoxform = new System.Windows.Forms.CheckBox();
            this.comboBoxkey = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonoutputstudent = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonclearlist = new System.Windows.Forms.Button();
            this.buttonaddcoursework = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAll = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonaddphoto = new System.Windows.Forms.Button();
            this.buttonshowinfo = new System.Windows.Forms.Button();
            this.ФИОColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ДатаРожденияColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ПочтаColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.СтранаColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ГородColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ГруппаColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ФормаОбученияColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.СпециализацияColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxlistteacher
            // 
            this.comboBoxlistteacher.FormattingEnabled = true;
            this.comboBoxlistteacher.Location = new System.Drawing.Point(143, 5);
            this.comboBoxlistteacher.Name = "comboBoxlistteacher";
            this.comboBoxlistteacher.Size = new System.Drawing.Size(221, 28);
            this.comboBoxlistteacher.TabIndex = 0;
            this.comboBoxlistteacher.Text = "Выберите преподавателя";
            this.comboBoxlistteacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxlistteacher_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1543, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатьДанныеToolStripMenuItem,
            this.прочитатьДанныеToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // записатьДанныеToolStripMenuItem
            // 
            this.записатьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonToolStripMenuItem,
            this.xmlToolStripMenuItem,
            this.soapToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.записатьДанныеToolStripMenuItem.Name = "записатьДанныеToolStripMenuItem";
            this.записатьДанныеToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.записатьДанныеToolStripMenuItem.Text = "Записать данные";
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.jsonToolStripMenuItem.Text = "json";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.xmlToolStripMenuItem.Text = "xml";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.xmlToolStripMenuItem_Click);
            // 
            // soapToolStripMenuItem
            // 
            this.soapToolStripMenuItem.Name = "soapToolStripMenuItem";
            this.soapToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.soapToolStripMenuItem.Text = "soap";
            this.soapToolStripMenuItem.Click += new System.EventHandler(this.soapToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.excelToolStripMenuItem.Text = "excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // прочитатьДанныеToolStripMenuItem
            // 
            this.прочитатьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonToolStripMenuItem1,
            this.xmlToolStripMenuItem1,
            this.soapToolStripMenuItem1,
            this.excelToolStripMenuItem1});
            this.прочитатьДанныеToolStripMenuItem.Name = "прочитатьДанныеToolStripMenuItem";
            this.прочитатьДанныеToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.прочитатьДанныеToolStripMenuItem.Text = "Прочитать данные";
            // 
            // jsonToolStripMenuItem1
            // 
            this.jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            this.jsonToolStripMenuItem1.Size = new System.Drawing.Size(153, 34);
            this.jsonToolStripMenuItem1.Text = "json";
            this.jsonToolStripMenuItem1.Click += new System.EventHandler(this.jsonToolStripMenuItem1_Click);
            // 
            // xmlToolStripMenuItem1
            // 
            this.xmlToolStripMenuItem1.Name = "xmlToolStripMenuItem1";
            this.xmlToolStripMenuItem1.Size = new System.Drawing.Size(153, 34);
            this.xmlToolStripMenuItem1.Text = "xml";
            this.xmlToolStripMenuItem1.Click += new System.EventHandler(this.xmlToolStripMenuItem1_Click);
            // 
            // soapToolStripMenuItem1
            // 
            this.soapToolStripMenuItem1.Name = "soapToolStripMenuItem1";
            this.soapToolStripMenuItem1.Size = new System.Drawing.Size(153, 34);
            this.soapToolStripMenuItem1.Text = "soap";
            this.soapToolStripMenuItem1.Click += new System.EventHandler(this.soapToolStripMenuItem1_Click);
            // 
            // excelToolStripMenuItem1
            // 
            this.excelToolStripMenuItem1.Name = "excelToolStripMenuItem1";
            this.excelToolStripMenuItem1.Size = new System.Drawing.Size(153, 34);
            this.excelToolStripMenuItem1.Text = "excel";
            this.excelToolStripMenuItem1.Click += new System.EventHandler(this.excelToolStripMenuItem1_Click);
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelinfo.Location = new System.Drawing.Point(12, 48);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(259, 25);
            this.labelinfo.TabIndex = 2;
            this.labelinfo.Text = "Ввод даных о студентах";
            // 
            // label1inizial
            // 
            this.label1inizial.AutoSize = true;
            this.label1inizial.Location = new System.Drawing.Point(94, 93);
            this.label1inizial.Name = "label1inizial";
            this.label1inizial.Size = new System.Drawing.Size(47, 20);
            this.label1inizial.TabIndex = 3;
            this.label1inizial.Text = "ФИО";
            // 
            // labeldatebirthday
            // 
            this.labeldatebirthday.AutoSize = true;
            this.labeldatebirthday.Location = new System.Drawing.Point(13, 130);
            this.labeldatebirthday.Name = "labeldatebirthday";
            this.labeldatebirthday.Size = new System.Drawing.Size(128, 20);
            this.labeldatebirthday.TabIndex = 4;
            this.labeldatebirthday.Text = "Дата рождения";
            this.labeldatebirthday.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(84, 174);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(57, 20);
            this.labelemail.TabIndex = 5;
            this.labelemail.Text = "Почта";
            // 
            // labelcountry
            // 
            this.labelcountry.AutoSize = true;
            this.labelcountry.Location = new System.Drawing.Point(76, 225);
            this.labelcountry.Name = "labelcountry";
            this.labelcountry.Size = new System.Drawing.Size(65, 20);
            this.labelcountry.TabIndex = 6;
            this.labelcountry.Text = "Страна";
            // 
            // labelcity
            // 
            this.labelcity.AutoSize = true;
            this.labelcity.Location = new System.Drawing.Point(84, 270);
            this.labelcity.Name = "labelcity";
            this.labelcity.Size = new System.Drawing.Size(56, 20);
            this.labelcity.TabIndex = 7;
            this.labelcity.Text = "Город";
            // 
            // labelgroup
            // 
            this.labelgroup.AutoSize = true;
            this.labelgroup.Location = new System.Drawing.Point(84, 319);
            this.labelgroup.Name = "labelgroup";
            this.labelgroup.Size = new System.Drawing.Size(61, 20);
            this.labelgroup.TabIndex = 8;
            this.labelgroup.Text = "Группа";
            // 
            // labelform
            // 
            this.labelform.AutoSize = true;
            this.labelform.Location = new System.Drawing.Point(23, 354);
            this.labelform.Name = "labelform";
            this.labelform.Size = new System.Drawing.Size(118, 40);
            this.labelform.TabIndex = 9;
            this.labelform.Text = "Очная форма \r\n         обучения";
            // 
            // labelkey
            // 
            this.labelkey.AutoSize = true;
            this.labelkey.Location = new System.Drawing.Point(17, 424);
            this.labelkey.Name = "labelkey";
            this.labelkey.Size = new System.Drawing.Size(128, 20);
            this.labelkey.TabIndex = 10;
            this.labelkey.Text = "Специализация";
            // 
            // textBoxinizial
            // 
            this.textBoxinizial.Location = new System.Drawing.Point(171, 87);
            this.textBoxinizial.Name = "textBoxinizial";
            this.textBoxinizial.Size = new System.Drawing.Size(193, 26);
            this.textBoxinizial.TabIndex = 11;
            this.textBoxinizial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxinizial_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(171, 171);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(193, 26);
            this.textBoxemail.TabIndex = 13;
            this.textBoxemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxemail_KeyDown);
            // 
            // textBoxcountry
            // 
            this.textBoxcountry.Location = new System.Drawing.Point(171, 225);
            this.textBoxcountry.Name = "textBoxcountry";
            this.textBoxcountry.Size = new System.Drawing.Size(193, 26);
            this.textBoxcountry.TabIndex = 14;
            this.textBoxcountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxcountry_KeyDown);
            // 
            // textBoxcity
            // 
            this.textBoxcity.Location = new System.Drawing.Point(171, 267);
            this.textBoxcity.Name = "textBoxcity";
            this.textBoxcity.Size = new System.Drawing.Size(193, 26);
            this.textBoxcity.TabIndex = 15;
            this.textBoxcity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxcity_KeyDown);
            // 
            // comboBoxgroup
            // 
            this.comboBoxgroup.FormattingEnabled = true;
            this.comboBoxgroup.Location = new System.Drawing.Point(171, 316);
            this.comboBoxgroup.Name = "comboBoxgroup";
            this.comboBoxgroup.Size = new System.Drawing.Size(193, 28);
            this.comboBoxgroup.TabIndex = 16;
            this.comboBoxgroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxgroup_KeyDown);
            // 
            // checkBoxform
            // 
            this.checkBoxform.AutoSize = true;
            this.checkBoxform.Location = new System.Drawing.Point(171, 373);
            this.checkBoxform.Name = "checkBoxform";
            this.checkBoxform.Size = new System.Drawing.Size(22, 21);
            this.checkBoxform.TabIndex = 17;
            this.checkBoxform.UseVisualStyleBackColor = true;
            // 
            // comboBoxkey
            // 
            this.comboBoxkey.FormattingEnabled = true;
            this.comboBoxkey.Location = new System.Drawing.Point(171, 421);
            this.comboBoxkey.Name = "comboBoxkey";
            this.comboBoxkey.Size = new System.Drawing.Size(193, 28);
            this.comboBoxkey.TabIndex = 18;
            this.comboBoxkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxkey_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИОColumn,
            this.ДатаРожденияColumn,
            this.ПочтаColumn,
            this.СтранаColumn,
            this.ГородColumn,
            this.ГруппаColumn,
            this.ФормаОбученияColumn,
            this.СпециализацияColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(392, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 408);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(27, 621);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(166, 59);
            this.buttonAddStudent.TabIndex = 20;
            this.buttonAddStudent.Text = "Добавить в список студентов";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonoutputstudent
            // 
            this.buttonoutputstudent.Location = new System.Drawing.Point(199, 621);
            this.buttonoutputstudent.Name = "buttonoutputstudent";
            this.buttonoutputstudent.Size = new System.Drawing.Size(186, 59);
            this.buttonoutputstudent.TabIndex = 21;
            this.buttonoutputstudent.Text = "Вывести список студентов в таблицу";
            this.buttonoutputstudent.UseVisualStyleBackColor = true;
            this.buttonoutputstudent.Click += new System.EventHandler(this.buttonoutputstudent_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(392, 621);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(112, 59);
            this.buttonclear.TabIndex = 22;
            this.buttonclear.Text = "Очистить поля";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonclearlist
            // 
            this.buttonclearlist.Location = new System.Drawing.Point(510, 621);
            this.buttonclearlist.Name = "buttonclearlist";
            this.buttonclearlist.Size = new System.Drawing.Size(120, 59);
            this.buttonclearlist.TabIndex = 23;
            this.buttonclearlist.Text = "Очистить список";
            this.buttonclearlist.UseVisualStyleBackColor = true;
            this.buttonclearlist.Click += new System.EventHandler(this.buttonclearlist_Click);
            // 
            // buttonaddcoursework
            // 
            this.buttonaddcoursework.Location = new System.Drawing.Point(636, 621);
            this.buttonaddcoursework.Name = "buttonaddcoursework";
            this.buttonaddcoursework.Size = new System.Drawing.Size(214, 59);
            this.buttonaddcoursework.TabIndex = 24;
            this.buttonaddcoursework.Text = "Добавить список курсовых работ студенту";
            this.buttonaddcoursework.UseVisualStyleBackColor = true;
            this.buttonaddcoursework.Click += new System.EventHandler(this.buttonaddcoursework_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(1418, 607);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(113, 59);
            this.buttonexit.TabIndex = 25;
            this.buttonexit.Text = "Выйти";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(27, 697);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Число Студентов";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(773, 300);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ShowAll});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1018);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1543, 32);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 25);
            this.StatusLabel.Visible = false;
            // 
            // ShowAll
            // 
            this.ShowAll.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAll.IsLink = true;
            this.ShowAll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(85, 25);
            this.ShowAll.Text = "ShowAll";
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(866, 706);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(605, 300);
            this.treeView1.TabIndex = 28;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(856, 621);
            this.progressBar1.Maximum = 6;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 45);
            this.progressBar1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(185, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // buttonaddphoto
            // 
            this.buttonaddphoto.Location = new System.Drawing.Point(21, 509);
            this.buttonaddphoto.Name = "buttonaddphoto";
            this.buttonaddphoto.Size = new System.Drawing.Size(127, 53);
            this.buttonaddphoto.TabIndex = 31;
            this.buttonaddphoto.Text = "Добавить фото";
            this.buttonaddphoto.UseVisualStyleBackColor = true;
            this.buttonaddphoto.Click += new System.EventHandler(this.buttonaddphoto_Click);
            // 
            // buttonshowinfo
            // 
            this.buttonshowinfo.Location = new System.Drawing.Point(1218, 609);
            this.buttonshowinfo.Name = "buttonshowinfo";
            this.buttonshowinfo.Size = new System.Drawing.Size(194, 55);
            this.buttonshowinfo.TabIndex = 32;
            this.buttonshowinfo.Text = "Вывести информацию о студентах";
            this.buttonshowinfo.UseVisualStyleBackColor = true;
            this.buttonshowinfo.Click += new System.EventHandler(this.buttonshowinfo_Click);
            // 
            // ФИОColumn
            // 
            this.ФИОColumn.DataPropertyName = "ФИО";
            this.ФИОColumn.FilteringEnabled = false;
            this.ФИОColumn.HeaderText = "ФИО";
            this.ФИОColumn.MinimumWidth = 8;
            this.ФИОColumn.Name = "ФИОColumn";
            this.ФИОColumn.ReadOnly = true;
            this.ФИОColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ФИОColumn.Width = 83;
            // 
            // ДатаРожденияColumn
            // 
            this.ДатаРожденияColumn.DataPropertyName = "ДатаРождения";
            this.ДатаРожденияColumn.FilteringEnabled = false;
            this.ДатаРожденияColumn.HeaderText = "ДатаРождения";
            this.ДатаРожденияColumn.MinimumWidth = 8;
            this.ДатаРожденияColumn.Name = "ДатаРожденияColumn";
            this.ДатаРожденияColumn.ReadOnly = true;
            this.ДатаРожденияColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ДатаРожденияColumn.Width = 161;
            // 
            // ПочтаColumn
            // 
            this.ПочтаColumn.DataPropertyName = "Почта";
            this.ПочтаColumn.FilteringEnabled = false;
            this.ПочтаColumn.HeaderText = "Почта";
            this.ПочтаColumn.MinimumWidth = 8;
            this.ПочтаColumn.Name = "ПочтаColumn";
            this.ПочтаColumn.ReadOnly = true;
            this.ПочтаColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ПочтаColumn.Width = 93;
            // 
            // СтранаColumn
            // 
            this.СтранаColumn.DataPropertyName = "Страна";
            this.СтранаColumn.FilteringEnabled = false;
            this.СтранаColumn.HeaderText = "Страна";
            this.СтранаColumn.MinimumWidth = 8;
            this.СтранаColumn.Name = "СтранаColumn";
            this.СтранаColumn.ReadOnly = true;
            this.СтранаColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.СтранаColumn.Width = 101;
            // 
            // ГородColumn
            // 
            this.ГородColumn.DataPropertyName = "Город";
            this.ГородColumn.FilteringEnabled = false;
            this.ГородColumn.HeaderText = "Город";
            this.ГородColumn.MinimumWidth = 8;
            this.ГородColumn.Name = "ГородColumn";
            this.ГородColumn.ReadOnly = true;
            this.ГородColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ГородColumn.Width = 92;
            // 
            // ГруппаColumn
            // 
            this.ГруппаColumn.DataPropertyName = "Группа";
            this.ГруппаColumn.FilteringEnabled = false;
            this.ГруппаColumn.HeaderText = "Группа";
            this.ГруппаColumn.MinimumWidth = 8;
            this.ГруппаColumn.Name = "ГруппаColumn";
            this.ГруппаColumn.ReadOnly = true;
            this.ГруппаColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ГруппаColumn.Width = 97;
            // 
            // ФормаОбученияColumn
            // 
            this.ФормаОбученияColumn.DataPropertyName = "ДневнаяФормаОбучения";
            this.ФормаОбученияColumn.FilteringEnabled = false;
            this.ФормаОбученияColumn.HeaderText = "ДневнаяФормаОбучения";
            this.ФормаОбученияColumn.MinimumWidth = 8;
            this.ФормаОбученияColumn.Name = "ФормаОбученияColumn";
            this.ФормаОбученияColumn.ReadOnly = true;
            this.ФормаОбученияColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ФормаОбученияColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ФормаОбученияColumn.Width = 207;
            // 
            // СпециализацияColumn
            // 
            this.СпециализацияColumn.DataPropertyName = "Специализация";
            this.СпециализацияColumn.FilteringEnabled = false;
            this.СпециализацияColumn.HeaderText = "Специализация";
            this.СпециализацияColumn.MinimumWidth = 8;
            this.СпециализацияColumn.Name = "СпециализацияColumn";
            this.СпециализацияColumn.ReadOnly = true;
            this.СпециализацияColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.СпециализацияColumn.Width = 164;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Class_Student_Teacher.Student);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1543, 1050);
            this.Controls.Add(this.buttonshowinfo);
            this.Controls.Add(this.buttonaddphoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonaddcoursework);
            this.Controls.Add(this.buttonclearlist);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonoutputstudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxkey);
            this.Controls.Add(this.checkBoxform);
            this.Controls.Add(this.comboBoxgroup);
            this.Controls.Add(this.textBoxcity);
            this.Controls.Add(this.textBoxcountry);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxinizial);
            this.Controls.Add(this.labelkey);
            this.Controls.Add(this.labelform);
            this.Controls.Add(this.labelgroup);
            this.Controls.Add(this.labelcity);
            this.Controls.Add(this.labelcountry);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labeldatebirthday);
            this.Controls.Add(this.label1inizial);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.comboBoxlistteacher);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxlistteacher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem1;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Label label1inizial;
        private System.Windows.Forms.Label labeldatebirthday;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelcountry;
        private System.Windows.Forms.Label labelcity;
        private System.Windows.Forms.Label labelgroup;
        private System.Windows.Forms.Label labelform;
        private System.Windows.Forms.Label labelkey;
        private System.Windows.Forms.TextBox textBoxinizial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxcountry;
        private System.Windows.Forms.TextBox textBoxcity;
        private System.Windows.Forms.ComboBox comboBoxgroup;
        private System.Windows.Forms.CheckBox checkBoxform;
        private System.Windows.Forms.ComboBox comboBoxkey;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonoutputstudent;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonclearlist;
        private System.Windows.Forms.Button buttonaddcoursework;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAll;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ФИОColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ДатаРожденияColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ПочтаColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn СтранаColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ГородColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ГруппаColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ФормаОбученияColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn СпециализацияColumn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonaddphoto;
        private System.Windows.Forms.Button buttonshowinfo;
    }
}