namespace kurs.View
{
    partial class CompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            this.Changebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.okbtn = new System.Windows.Forms.Button();
            this.specializationCBox = new System.Windows.Forms.ComboBox();
            this.workdaysGB = new System.Windows.Forms.GroupBox();
            this.suncb = new System.Windows.Forms.CheckBox();
            this.satcb = new System.Windows.Forms.CheckBox();
            this.fricb = new System.Windows.Forms.CheckBox();
            this.thicb = new System.Windows.Forms.CheckBox();
            this.wedcb = new System.Windows.Forms.CheckBox();
            this.tuecb = new System.Windows.Forms.CheckBox();
            this.moncb = new System.Windows.Forms.CheckBox();
            this.servicesChLB = new System.Windows.Forms.CheckedListBox();
            this.kindCBox = new System.Windows.Forms.ComboBox();
            this.ownershipCBox = new System.Windows.Forms.ComboBox();
            this.endDTPicker = new System.Windows.Forms.DateTimePicker();
            this.startDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneNumberTBox = new System.Windows.Forms.TextBox();
            this.addressTBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.workdaysGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Changebtn
            // 
            this.Changebtn.Location = new System.Drawing.Point(37, 319);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(75, 23);
            this.Changebtn.TabIndex = 172;
            this.Changebtn.Text = "Изменить";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(541, 319);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 171;
            this.cancelbtn.Text = "Отмена";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // okbtn
            // 
            this.okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbtn.Location = new System.Drawing.Point(428, 319);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 170;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // specializationCBox
            // 
            this.specializationCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specializationCBox.FormattingEnabled = true;
            this.specializationCBox.Items.AddRange(new object[] {
            "любая",
            "коммунальное",
            "промышленное",
            "производственное",
            "коммерческое",
            "другое"});
            this.specializationCBox.Location = new System.Drawing.Point(450, 54);
            this.specializationCBox.Name = "specializationCBox";
            this.specializationCBox.Size = new System.Drawing.Size(165, 21);
            this.specializationCBox.TabIndex = 213;
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
            this.workdaysGB.Location = new System.Drawing.Point(115, 205);
            this.workdaysGB.Name = "workdaysGB";
            this.workdaysGB.Size = new System.Drawing.Size(324, 47);
            this.workdaysGB.TabIndex = 212;
            this.workdaysGB.TabStop = false;
            // 
            // suncb
            // 
            this.suncb.AutoSize = true;
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
            this.wedcb.Location = new System.Drawing.Point(97, 19);
            this.wedcb.Name = "wedcb";
            this.wedcb.Size = new System.Drawing.Size(39, 17);
            this.wedcb.TabIndex = 140;
            this.wedcb.Text = "Ср";
            this.wedcb.UseVisualStyleBackColor = true;
            // 
            // tuecb
            // 
            this.tuecb.AutoSize = true;
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
            this.moncb.Location = new System.Drawing.Point(7, 19);
            this.moncb.Name = "moncb";
            this.moncb.Size = new System.Drawing.Size(40, 17);
            this.moncb.TabIndex = 138;
            this.moncb.Text = "Пн";
            this.moncb.UseVisualStyleBackColor = true;
            // 
            // servicesChLB
            // 
            this.servicesChLB.FormattingEnabled = true;
            this.servicesChLB.Items.AddRange(new object[] {
            "водоснабжение",
            "газ",
            "гостинницы",
            "обувь",
            "одежда",
            "отопление",
            "парикмахерские",
            "перевозка",
            "питание",
            "почтовые",
            "прачечные",
            "ремонт",
            "ритуальные",
            "строительство",
            "электроэнергия",
            "другое"});
            this.servicesChLB.Location = new System.Drawing.Point(450, 140);
            this.servicesChLB.Name = "servicesChLB";
            this.servicesChLB.Size = new System.Drawing.Size(165, 154);
            this.servicesChLB.TabIndex = 211;
            // 
            // kindCBox
            // 
            this.kindCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kindCBox.FormattingEnabled = true;
            this.kindCBox.Items.AddRange(new object[] {
            "любой",
            "высший",
            "первый",
            "второй"});
            this.kindCBox.Location = new System.Drawing.Point(115, 124);
            this.kindCBox.Name = "kindCBox";
            this.kindCBox.Size = new System.Drawing.Size(143, 21);
            this.kindCBox.TabIndex = 210;
            // 
            // ownershipCBox
            // 
            this.ownershipCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownershipCBox.FormattingEnabled = true;
            this.ownershipCBox.Items.AddRange(new object[] {
            "любая",
            "государственная",
            "муниципальная",
            "частная"});
            this.ownershipCBox.Location = new System.Drawing.Point(450, 91);
            this.ownershipCBox.Name = "ownershipCBox";
            this.ownershipCBox.Size = new System.Drawing.Size(165, 21);
            this.ownershipCBox.TabIndex = 209;
            // 
            // endDTPicker
            // 
            this.endDTPicker.CustomFormat = "HH:mm";
            this.endDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTPicker.Location = new System.Drawing.Point(343, 274);
            this.endDTPicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.endDTPicker.Name = "endDTPicker";
            this.endDTPicker.ShowUpDown = true;
            this.endDTPicker.Size = new System.Drawing.Size(58, 20);
            this.endDTPicker.TabIndex = 206;
            this.endDTPicker.Value = new System.DateTime(1800, 1, 1, 23, 59, 0, 0);
            // 
            // startDTPicker
            // 
            this.startDTPicker.CustomFormat = "HH:mm";
            this.startDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTPicker.Location = new System.Drawing.Point(196, 274);
            this.startDTPicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.startDTPicker.Name = "startDTPicker";
            this.startDTPicker.ShowUpDown = true;
            this.startDTPicker.Size = new System.Drawing.Size(62, 20);
            this.startDTPicker.TabIndex = 205;
            this.startDTPicker.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 208;
            this.label12.Text = "Конец";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 207;
            this.label11.Text = "Начало";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(28, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 204;
            this.label7.Text = "Адрес";
            // 
            // phoneNumberTBox
            // 
            this.phoneNumberTBox.Location = new System.Drawing.Point(115, 163);
            this.phoneNumberTBox.Name = "phoneNumberTBox";
            this.phoneNumberTBox.Size = new System.Drawing.Size(143, 20);
            this.phoneNumberTBox.TabIndex = 203;
            this.phoneNumberTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addressTBox
            // 
            this.addressTBox.Location = new System.Drawing.Point(115, 88);
            this.addressTBox.Name = "addressTBox";
            this.addressTBox.Size = new System.Drawing.Size(143, 20);
            this.addressTBox.TabIndex = 202;
            this.addressTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(28, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 201;
            this.label10.Text = "Телефон";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(28, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 200;
            this.label9.Text = "Дни работы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(28, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 199;
            this.label8.Text = "Часы работы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(325, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 198;
            this.label6.Text = "Специализация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(332, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 197;
            this.label4.Text = "Собственность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(376, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 196;
            this.label3.Text = "Услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 195;
            this.label2.Text = "Разряд";
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(115, 55);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(143, 20);
            this.nameTBox.TabIndex = 194;
            this.nameTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 193;
            this.label1.Text = "Название";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(145, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 20);
            this.label5.TabIndex = 192;
            this.label5.Text = "Предприятия бытового обслуживания.";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(31, 24);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(0, 13);
            this.IDlbl.TabIndex = 214;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(642, 367);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.specializationCBox);
            this.Controls.Add(this.workdaysGB);
            this.Controls.Add(this.servicesChLB);
            this.Controls.Add(this.kindCBox);
            this.Controls.Add(this.ownershipCBox);
            this.Controls.Add(this.endDTPicker);
            this.Controls.Add(this.startDTPicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneNumberTBox);
            this.Controls.Add(this.addressTBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.okbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompanyForm";
            this.Text = "Просмотреть/Изменить";
            this.workdaysGB.ResumeLayout(false);
            this.workdaysGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.ComboBox specializationCBox;
        private System.Windows.Forms.GroupBox workdaysGB;
        private System.Windows.Forms.CheckBox suncb;
        private System.Windows.Forms.CheckBox satcb;
        private System.Windows.Forms.CheckBox fricb;
        private System.Windows.Forms.CheckBox thicb;
        private System.Windows.Forms.CheckBox wedcb;
        private System.Windows.Forms.CheckBox tuecb;
        private System.Windows.Forms.CheckBox moncb;
        private System.Windows.Forms.CheckedListBox servicesChLB;
        private System.Windows.Forms.ComboBox kindCBox;
        private System.Windows.Forms.ComboBox ownershipCBox;
        private System.Windows.Forms.DateTimePicker endDTPicker;
        private System.Windows.Forms.DateTimePicker startDTPicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneNumberTBox;
        private System.Windows.Forms.TextBox addressTBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label IDlbl;
    }
}