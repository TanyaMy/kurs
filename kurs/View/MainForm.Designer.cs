using System.Windows.Forms;

namespace kurs.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.phoneNumberTBox = new System.Windows.Forms.TextBox();
            this.addressTBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.findbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.servTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nameCheck = new System.Windows.Forms.CheckBox();
            this.numberCheck = new System.Windows.Forms.CheckBox();
            this.addressCheck = new System.Windows.Forms.CheckBox();
            this.workDaysCheck = new System.Windows.Forms.CheckBox();
            this.classCheck = new System.Windows.Forms.CheckBox();
            this.specCheck = new System.Windows.Forms.CheckBox();
            this.servicesCheck = new System.Windows.Forms.CheckBox();
            this.ownCheck = new System.Windows.Forms.CheckBox();
            this.timeCheck = new System.Windows.Forms.CheckBox();
            this.ownershipCBox = new System.Windows.Forms.ComboBox();
            this.specializationCBox = new System.Windows.Forms.ComboBox();
            this.classCBox = new System.Windows.Forms.ComboBox();
            this.workdaysGB = new System.Windows.Forms.GroupBox();
            this.suncb = new System.Windows.Forms.CheckBox();
            this.satcb = new System.Windows.Forms.CheckBox();
            this.fricb = new System.Windows.Forms.CheckBox();
            this.thicb = new System.Windows.Forms.CheckBox();
            this.wedcb = new System.Windows.Forms.CheckBox();
            this.tuecb = new System.Windows.Forms.CheckBox();
            this.moncb = new System.Windows.Forms.CheckBox();
            this.endDTPicker = new System.Windows.Forms.DateTimePicker();
            this.startDTPicker = new System.Windows.Forms.DateTimePicker();
            this.updatepBox = new System.Windows.Forms.PictureBox();
            this.servicesChLB = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.workdaysGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatepBox)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneNumberTBox
            // 
            this.phoneNumberTBox.Enabled = false;
            this.phoneNumberTBox.Location = new System.Drawing.Point(140, 177);
            this.phoneNumberTBox.Name = "phoneNumberTBox";
            this.phoneNumberTBox.Size = new System.Drawing.Size(143, 20);
            this.phoneNumberTBox.TabIndex = 44;
            this.phoneNumberTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addressTBox
            // 
            this.addressTBox.Enabled = false;
            this.addressTBox.Location = new System.Drawing.Point(140, 112);
            this.addressTBox.Name = "addressTBox";
            this.addressTBox.Size = new System.Drawing.Size(143, 20);
            this.addressTBox.TabIndex = 43;
            this.addressTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(36, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Телефон";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(36, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Дни работы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(36, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Часы работы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(36, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(335, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Специализация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(136, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Предприятия бытового обслуживания. Поиск";
            // 
            // findbtn
            // 
            this.findbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.findbtn.Location = new System.Drawing.Point(524, 237);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(113, 23);
            this.findbtn.TabIndex = 35;
            this.findbtn.Text = "Найти";
            this.findbtn.UseVisualStyleBackColor = true;
            this.findbtn.Click += new System.EventHandler(this.findbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(340, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Собственность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(395, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(36, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Разряд";
            // 
            // nameTBox
            // 
            this.nameTBox.Enabled = false;
            this.nameTBox.Location = new System.Drawing.Point(140, 74);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(143, 20);
            this.nameTBox.TabIndex = 28;
            this.nameTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Название";
            // 
            // fileTStrMenu
            // 
            this.fileTStrMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitTStrMenu});
            this.fileTStrMenu.Name = "fileTStrMenu";
            this.fileTStrMenu.Size = new System.Drawing.Size(48, 20);
            this.fileTStrMenu.Text = "Файл";
            // 
            // exitTStrMenu
            // 
            this.exitTStrMenu.Name = "exitTStrMenu";
            this.exitTStrMenu.Size = new System.Drawing.Size(108, 22);
            this.exitTStrMenu.Text = "Выход";
            this.exitTStrMenu.Click += new System.EventHandler(this.exitTStrMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTStrMenu,
            this.helpTStrMenu,
            this.servTStrMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpTStrMenu
            // 
            this.helpTStrMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTStrMenu});
            this.helpTStrMenu.Name = "helpTStrMenu";
            this.helpTStrMenu.Size = new System.Drawing.Size(68, 20);
            this.helpTStrMenu.Text = "Помощь";
            // 
            // aboutTStrMenu
            // 
            this.aboutTStrMenu.Name = "aboutTStrMenu";
            this.aboutTStrMenu.Size = new System.Drawing.Size(149, 22);
            this.aboutTStrMenu.Text = "О программе";
            this.aboutTStrMenu.Click += new System.EventHandler(this.aboutTStrMenu_Click);
            // 
            // servTStrMenu
            // 
            this.servTStrMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTStrMenu});
            this.servTStrMenu.Name = "servTStrMenu";
            this.servTStrMenu.Size = new System.Drawing.Size(92, 20);
            this.servTStrMenu.Text = "Предприятие";
            // 
            // addTStrMenu
            // 
            this.addTStrMenu.Name = "addTStrMenu";
            this.addTStrMenu.Size = new System.Drawing.Size(126, 22);
            this.addTStrMenu.Text = "Добавить";
            this.addTStrMenu.Click += new System.EventHandler(this.addTStrMenu_Click);
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGV.Location = new System.Drawing.Point(15, 314);
            this.dataGV.MultiSelect = false;
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV.Size = new System.Drawing.Size(622, 186);
            this.dataGV.TabIndex = 50;
            this.dataGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Location = new System.Drawing.Point(312, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Конец";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Location = new System.Drawing.Point(159, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Начало";
            // 
            // nameCheck
            // 
            this.nameCheck.AutoSize = true;
            this.nameCheck.Location = new System.Drawing.Point(15, 71);
            this.nameCheck.Name = "nameCheck";
            this.nameCheck.Size = new System.Drawing.Size(15, 14);
            this.nameCheck.TabIndex = 104;
            this.nameCheck.UseVisualStyleBackColor = true;
            this.nameCheck.CheckedChanged += new System.EventHandler(this.nameCheck_CheckedChanged);
            // 
            // numberCheck
            // 
            this.numberCheck.AutoSize = true;
            this.numberCheck.Location = new System.Drawing.Point(15, 183);
            this.numberCheck.Name = "numberCheck";
            this.numberCheck.Size = new System.Drawing.Size(15, 14);
            this.numberCheck.TabIndex = 105;
            this.numberCheck.UseVisualStyleBackColor = true;
            this.numberCheck.CheckedChanged += new System.EventHandler(this.numberCheck_CheckedChanged);
            // 
            // addressCheck
            // 
            this.addressCheck.AutoSize = true;
            this.addressCheck.Location = new System.Drawing.Point(15, 112);
            this.addressCheck.Name = "addressCheck";
            this.addressCheck.Size = new System.Drawing.Size(15, 14);
            this.addressCheck.TabIndex = 105;
            this.addressCheck.UseVisualStyleBackColor = true;
            this.addressCheck.CheckedChanged += new System.EventHandler(this.addressCheck_CheckedChanged);
            // 
            // workDaysCheck
            // 
            this.workDaysCheck.AutoSize = true;
            this.workDaysCheck.Location = new System.Drawing.Point(15, 264);
            this.workDaysCheck.Name = "workDaysCheck";
            this.workDaysCheck.Size = new System.Drawing.Size(15, 14);
            this.workDaysCheck.TabIndex = 106;
            this.workDaysCheck.UseVisualStyleBackColor = true;
            this.workDaysCheck.CheckedChanged += new System.EventHandler(this.workDaysCheck_CheckedChanged);
            // 
            // classCheck
            // 
            this.classCheck.AutoSize = true;
            this.classCheck.Location = new System.Drawing.Point(15, 148);
            this.classCheck.Name = "classCheck";
            this.classCheck.Size = new System.Drawing.Size(15, 14);
            this.classCheck.TabIndex = 106;
            this.classCheck.UseVisualStyleBackColor = true;
            this.classCheck.CheckedChanged += new System.EventHandler(this.classCheck_CheckedChanged);
            // 
            // specCheck
            // 
            this.specCheck.AutoSize = true;
            this.specCheck.Location = new System.Drawing.Point(314, 80);
            this.specCheck.Name = "specCheck";
            this.specCheck.Size = new System.Drawing.Size(15, 14);
            this.specCheck.TabIndex = 107;
            this.specCheck.UseVisualStyleBackColor = true;
            this.specCheck.CheckedChanged += new System.EventHandler(this.specCheck_CheckedChanged);
            // 
            // servicesCheck
            // 
            this.servicesCheck.AutoSize = true;
            this.servicesCheck.Location = new System.Drawing.Point(374, 122);
            this.servicesCheck.Name = "servicesCheck";
            this.servicesCheck.Size = new System.Drawing.Size(15, 14);
            this.servicesCheck.TabIndex = 108;
            this.servicesCheck.UseVisualStyleBackColor = true;
            this.servicesCheck.CheckedChanged += new System.EventHandler(this.servicesCheck_CheckedChanged);
            // 
            // ownCheck
            // 
            this.ownCheck.AutoSize = true;
            this.ownCheck.Location = new System.Drawing.Point(319, 194);
            this.ownCheck.Name = "ownCheck";
            this.ownCheck.Size = new System.Drawing.Size(15, 14);
            this.ownCheck.TabIndex = 109;
            this.ownCheck.UseVisualStyleBackColor = true;
            this.ownCheck.CheckedChanged += new System.EventHandler(this.ownCheck_CheckedChanged);
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(15, 224);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(15, 14);
            this.timeCheck.TabIndex = 110;
            this.timeCheck.UseVisualStyleBackColor = true;
            this.timeCheck.CheckedChanged += new System.EventHandler(this.timeCheck_CheckedChanged);
            // 
            // ownershipCBox
            // 
            this.ownershipCBox.Enabled = false;
            this.ownershipCBox.Items.AddRange(new object[] {
            "Государственная",
            "Частная"});
            this.ownershipCBox.Location = new System.Drawing.Point(458, 191);
            this.ownershipCBox.Name = "ownershipCBox";
            this.ownershipCBox.Size = new System.Drawing.Size(179, 21);
            this.ownershipCBox.TabIndex = 111;
            // 
            // specializationCBox
            // 
            this.specializationCBox.Enabled = false;
            this.specializationCBox.FormattingEnabled = true;
            this.specializationCBox.Items.AddRange(new object[] {
            "отопление",
            "вода",
            "канализация",
            "строительство",
            "электроэнергия"});
            this.specializationCBox.Location = new System.Drawing.Point(458, 77);
            this.specializationCBox.Name = "specializationCBox";
            this.specializationCBox.Size = new System.Drawing.Size(179, 21);
            this.specializationCBox.TabIndex = 112;
            // 
            // classCBox
            // 
            this.classCBox.Enabled = false;
            this.classCBox.FormattingEnabled = true;
            this.classCBox.Items.AddRange(new object[] {
            "Коммунальное"});
            this.classCBox.Location = new System.Drawing.Point(140, 146);
            this.classCBox.Name = "classCBox";
            this.classCBox.Size = new System.Drawing.Size(143, 21);
            this.classCBox.TabIndex = 113;
            // 
            // workdaysGB
            // 
            this.workdaysGB.Controls.Add(this.suncb);
            this.workdaysGB.Controls.Add(this.satcb);
            this.workdaysGB.Controls.Add(this.fricb);
            this.workdaysGB.Controls.Add(this.thicb);
            this.workdaysGB.Controls.Add(this.wedcb);
            this.workdaysGB.Controls.Add(this.tuecb);
            this.workdaysGB.Controls.Add(this.moncb);
            this.workdaysGB.Location = new System.Drawing.Point(130, 261);
            this.workdaysGB.Name = "workdaysGB";
            this.workdaysGB.Size = new System.Drawing.Size(338, 47);
            this.workdaysGB.TabIndex = 141;
            this.workdaysGB.TabStop = false;
            // 
            // suncb
            // 
            this.suncb.AutoSize = true;
            this.suncb.Enabled = false;
            this.suncb.Location = new System.Drawing.Point(283, 19);
            this.suncb.Name = "suncb";
            this.suncb.Size = new System.Drawing.Size(39, 17);
            this.suncb.TabIndex = 144;
            this.suncb.Text = "Вс";
            this.suncb.UseVisualStyleBackColor = true;
            // 
            // satcb
            // 
            this.satcb.AutoSize = true;
            this.satcb.Enabled = false;
            this.satcb.Location = new System.Drawing.Point(237, 19);
            this.satcb.Name = "satcb";
            this.satcb.Size = new System.Drawing.Size(39, 17);
            this.satcb.TabIndex = 143;
            this.satcb.Text = "Сб";
            this.satcb.UseVisualStyleBackColor = true;
            // 
            // fricb
            // 
            this.fricb.AutoSize = true;
            this.fricb.Enabled = false;
            this.fricb.Location = new System.Drawing.Point(191, 19);
            this.fricb.Name = "fricb";
            this.fricb.Size = new System.Drawing.Size(39, 17);
            this.fricb.TabIndex = 142;
            this.fricb.Text = "Пт";
            this.fricb.UseVisualStyleBackColor = true;
            // 
            // thicb
            // 
            this.thicb.AutoSize = true;
            this.thicb.Enabled = false;
            this.thicb.Location = new System.Drawing.Point(145, 19);
            this.thicb.Name = "thicb";
            this.thicb.Size = new System.Drawing.Size(39, 17);
            this.thicb.TabIndex = 141;
            this.thicb.Text = "Чт";
            this.thicb.UseVisualStyleBackColor = true;
            // 
            // wedcb
            // 
            this.wedcb.AutoSize = true;
            this.wedcb.Enabled = false;
            this.wedcb.Location = new System.Drawing.Point(99, 19);
            this.wedcb.Name = "wedcb";
            this.wedcb.Size = new System.Drawing.Size(39, 17);
            this.wedcb.TabIndex = 140;
            this.wedcb.Text = "Ср";
            this.wedcb.UseVisualStyleBackColor = true;
            // 
            // tuecb
            // 
            this.tuecb.AutoSize = true;
            this.tuecb.Enabled = false;
            this.tuecb.Location = new System.Drawing.Point(53, 19);
            this.tuecb.Name = "tuecb";
            this.tuecb.Size = new System.Drawing.Size(38, 17);
            this.tuecb.TabIndex = 139;
            this.tuecb.Text = "Вт";
            this.tuecb.UseVisualStyleBackColor = true;
            // 
            // moncb
            // 
            this.moncb.AutoSize = true;
            this.moncb.Enabled = false;
            this.moncb.Location = new System.Drawing.Point(7, 19);
            this.moncb.Name = "moncb";
            this.moncb.Size = new System.Drawing.Size(40, 17);
            this.moncb.TabIndex = 138;
            this.moncb.Text = "Пн";
            this.moncb.UseVisualStyleBackColor = true;
            // 
            // endDTPicker
            // 
            this.endDTPicker.CustomFormat = "HH:mm";
            this.endDTPicker.Enabled = false;
            this.endDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTPicker.Location = new System.Drawing.Point(356, 218);
            this.endDTPicker.MinDate = new System.DateTime(1800, 1, 1, 0, 1, 0, 0);
            this.endDTPicker.Name = "endDTPicker";
            this.endDTPicker.ShowUpDown = true;
            this.endDTPicker.Size = new System.Drawing.Size(76, 20);
            this.endDTPicker.TabIndex = 102;
            this.endDTPicker.Value = new System.DateTime(1800, 1, 1, 0, 1, 0, 0);
            this.endDTPicker.ValueChanged += new System.EventHandler(this.endDTPicker_ValueChanged);
            // 
            // startDTPicker
            // 
            this.startDTPicker.CustomFormat = "HH:mm";
            this.startDTPicker.Enabled = false;
            this.startDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTPicker.Location = new System.Drawing.Point(209, 218);
            this.startDTPicker.MaxDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.startDTPicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.startDTPicker.Name = "startDTPicker";
            this.startDTPicker.ShowUpDown = true;
            this.startDTPicker.Size = new System.Drawing.Size(76, 20);
            this.startDTPicker.TabIndex = 101;
            this.startDTPicker.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.startDTPicker.ValueChanged += new System.EventHandler(this.startDTPicker_ValueChanged);
            // 
            // updatepBox
            // 
            this.updatepBox.Image = global::kurs.Properties.Resources.refresh_converted;
            this.updatepBox.Location = new System.Drawing.Point(583, 278);
            this.updatepBox.Name = "updatepBox";
            this.updatepBox.Size = new System.Drawing.Size(30, 30);
            this.updatepBox.TabIndex = 143;
            this.updatepBox.TabStop = false;
            this.updatepBox.Click += new System.EventHandler(this.updatepBox_Click);
            // 
            // servicesChLB
            // 
            this.servicesChLB.Enabled = false;
            this.servicesChLB.FormattingEnabled = true;
            this.servicesChLB.Items.AddRange(new object[] {
            "qwer",
            "lol",
            "kek",
            "bogdan",
            "loh",
            "poidr",
            "hey",
            "gey",
            "ritka",
            "tozhe",
            "samoe",
            "vse",
            "oni",
            "lohi",
            "huzhie",
            "laby",
            "skiduvayut",
            "scuko",
            "kefir"});
            this.servicesChLB.Location = new System.Drawing.Point(458, 112);
            this.servicesChLB.Name = "servicesChLB";
            this.servicesChLB.Size = new System.Drawing.Size(165, 64);
            this.servicesChLB.TabIndex = 144;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 512);
            this.Controls.Add(this.servicesChLB);
            this.Controls.Add(this.updatepBox);
            this.Controls.Add(this.workdaysGB);
            this.Controls.Add(this.classCBox);
            this.Controls.Add(this.specializationCBox);
            this.Controls.Add(this.ownershipCBox);
            this.Controls.Add(this.timeCheck);
            this.Controls.Add(this.ownCheck);
            this.Controls.Add(this.servicesCheck);
            this.Controls.Add(this.specCheck);
            this.Controls.Add(this.classCheck);
            this.Controls.Add(this.workDaysCheck);
            this.Controls.Add(this.addressCheck);
            this.Controls.Add(this.numberCheck);
            this.Controls.Add(this.nameCheck);
            this.Controls.Add(this.endDTPicker);
            this.Controls.Add(this.startDTPicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.phoneNumberTBox);
            this.Controls.Add(this.addressTBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.findbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Предприятия";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.workdaysGB.ResumeLayout(false);
            this.workdaysGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatepBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox phoneNumberTBox;
        private System.Windows.Forms.TextBox addressTBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileTStrMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitTStrMenu;
        private System.Windows.Forms.ToolStripMenuItem helpTStrMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutTStrMenu;
        private System.Windows.Forms.ToolStripMenuItem servTStrMenu;
        private System.Windows.Forms.ToolStripMenuItem addTStrMenu;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox nameCheck;
        private System.Windows.Forms.CheckBox numberCheck;
        private System.Windows.Forms.CheckBox addressCheck;
        private System.Windows.Forms.CheckBox workDaysCheck;
        private System.Windows.Forms.CheckBox classCheck;
        private System.Windows.Forms.CheckBox specCheck;
        private System.Windows.Forms.CheckBox servicesCheck;
        private System.Windows.Forms.CheckBox ownCheck;
        private System.Windows.Forms.CheckBox timeCheck;
        private System.Windows.Forms.ComboBox ownershipCBox;
        private System.Windows.Forms.ComboBox specializationCBox;
        private System.Windows.Forms.ComboBox classCBox;
        private GroupBox workdaysGB;
        private CheckBox suncb;
        private CheckBox satcb;
        private CheckBox fricb;
        private CheckBox thicb;
        private CheckBox wedcb;
        private CheckBox tuecb;
        private CheckBox moncb;
        private DateTimePicker endDTPicker;
        private DateTimePicker startDTPicker;
        private PictureBox updatepBox;
        private CheckedListBox servicesChLB;
    }
}