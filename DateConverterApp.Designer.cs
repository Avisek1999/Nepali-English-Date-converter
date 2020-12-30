namespace NepaliDateConverter.Net
{
    partial class DateConverterApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateConverterApp));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblToEnglish = new System.Windows.Forms.Label();
            this.lblToNepali = new System.Windows.Forms.Label();
            this.lblOutputNepaliDate = new System.Windows.Forms.Label();
            this.lblOutputEnglishDate = new System.Windows.Forms.Label();
            this.cbYearBS = new System.Windows.Forms.ComboBox();
            this.cbMonthBS = new System.Windows.Forms.ComboBox();
            this.cbDayBS = new System.Windows.Forms.ComboBox();
            this.cbYearAD = new System.Windows.Forms.ComboBox();
            this.cbMonthAD = new System.Windows.Forms.ComboBox();
            this.cbDayAD = new System.Windows.Forms.ComboBox();
            this.lblYearBS = new System.Windows.Forms.Label();
            this.lblMonthBS = new System.Windows.Forms.Label();
            this.lblDayBS = new System.Windows.Forms.Label();
            this.lblDayAD = new System.Windows.Forms.Label();
            this.lblMonthAD = new System.Windows.Forms.Label();
            this.lblYearAD = new System.Windows.Forms.Label();
            this.btnConvertToAD = new System.Windows.Forms.Button();
            this.btnConvertToBS = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Converter = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.cbChaitra = new System.Windows.Forms.ComboBox();
            this.cbAshwin = new System.Windows.Forms.ComboBox();
            this.cbFalgun = new System.Windows.Forms.ComboBox();
            this.cbBhadra = new System.Windows.Forms.ComboBox();
            this.cbMagh = new System.Windows.Forms.ComboBox();
            this.cbShrawan = new System.Windows.Forms.ComboBox();
            this.cbPoush = new System.Windows.Forms.ComboBox();
            this.cbAshad = new System.Windows.Forms.ComboBox();
            this.cbMangsir = new System.Windows.Forms.ComboBox();
            this.cbJestha = new System.Windows.Forms.ComboBox();
            this.cbKarthik = new System.Windows.Forms.ComboBox();
            this.cbBaishakh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBaisakh = new System.Windows.Forms.Label();
            this.lblAddMonths = new System.Windows.Forms.Label();
            this.lblDateBS = new System.Windows.Forms.Label();
            this.lblAddDateTitle = new System.Windows.Forms.Label();
            this.lblDateToAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Converter.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.Gray;
            this.TitlePanel.Controls.Add(this.lblTitle);
            this.TitlePanel.ForeColor = System.Drawing.Color.DarkRed;
            this.TitlePanel.Location = new System.Drawing.Point(16, 8);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(542, 48);
            this.TitlePanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(108, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nepali Date Converter";
            // 
            // lblToEnglish
            // 
            this.lblToEnglish.AutoSize = true;
            this.lblToEnglish.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToEnglish.ForeColor = System.Drawing.Color.Blue;
            this.lblToEnglish.Location = new System.Drawing.Point(33, 71);
            this.lblToEnglish.Name = "lblToEnglish";
            this.lblToEnglish.Size = new System.Drawing.Size(184, 25);
            this.lblToEnglish.TabIndex = 1;
            this.lblToEnglish.Text = "Convert To A.D.";
            // 
            // lblToNepali
            // 
            this.lblToNepali.AutoSize = true;
            this.lblToNepali.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToNepali.ForeColor = System.Drawing.Color.Blue;
            this.lblToNepali.Location = new System.Drawing.Point(33, 188);
            this.lblToNepali.Name = "lblToNepali";
            this.lblToNepali.Size = new System.Drawing.Size(180, 25);
            this.lblToNepali.TabIndex = 1;
            this.lblToNepali.Text = "Convert To B.S.";
            // 
            // lblOutputNepaliDate
            // 
            this.lblOutputNepaliDate.AutoSize = true;
            this.lblOutputNepaliDate.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputNepaliDate.ForeColor = System.Drawing.Color.Green;
            this.lblOutputNepaliDate.Location = new System.Drawing.Point(175, 166);
            this.lblOutputNepaliDate.Name = "lblOutputNepaliDate";
            this.lblOutputNepaliDate.Size = new System.Drawing.Size(15, 22);
            this.lblOutputNepaliDate.TabIndex = 2;
            this.lblOutputNepaliDate.Text = " ";
            // 
            // lblOutputEnglishDate
            // 
            this.lblOutputEnglishDate.AutoSize = true;
            this.lblOutputEnglishDate.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputEnglishDate.ForeColor = System.Drawing.Color.Green;
            this.lblOutputEnglishDate.Location = new System.Drawing.Point(175, 294);
            this.lblOutputEnglishDate.Name = "lblOutputEnglishDate";
            this.lblOutputEnglishDate.Size = new System.Drawing.Size(15, 22);
            this.lblOutputEnglishDate.TabIndex = 2;
            this.lblOutputEnglishDate.Text = " ";
            // 
            // cbYearBS
            // 
            this.cbYearBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearBS.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYearBS.FormattingEnabled = true;
            this.cbYearBS.Location = new System.Drawing.Point(83, 120);
            this.cbYearBS.Name = "cbYearBS";
            this.cbYearBS.Size = new System.Drawing.Size(63, 28);
            this.cbYearBS.TabIndex = 3;
            this.cbYearBS.SelectedIndexChanged += new System.EventHandler(this.cbYearBS_SelectedIndexChanged);
            // 
            // cbMonthBS
            // 
            this.cbMonthBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthBS.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonthBS.FormattingEnabled = true;
            this.cbMonthBS.Location = new System.Drawing.Point(218, 120);
            this.cbMonthBS.Name = "cbMonthBS";
            this.cbMonthBS.Size = new System.Drawing.Size(100, 28);
            this.cbMonthBS.TabIndex = 3;
            this.cbMonthBS.SelectedIndexChanged += new System.EventHandler(this.cbMonthBS_SelectedIndexChanged);
            // 
            // cbDayBS
            // 
            this.cbDayBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDayBS.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDayBS.FormattingEnabled = true;
            this.cbDayBS.Location = new System.Drawing.Point(381, 120);
            this.cbDayBS.Name = "cbDayBS";
            this.cbDayBS.Size = new System.Drawing.Size(50, 28);
            this.cbDayBS.TabIndex = 3;
            // 
            // cbYearAD
            // 
            this.cbYearAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearAD.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYearAD.FormattingEnabled = true;
            this.cbYearAD.Location = new System.Drawing.Point(82, 253);
            this.cbYearAD.Name = "cbYearAD";
            this.cbYearAD.Size = new System.Drawing.Size(63, 28);
            this.cbYearAD.TabIndex = 3;
            this.cbYearAD.SelectedIndexChanged += new System.EventHandler(this.cbYearAD_SelectedIndexChanged);
            // 
            // cbMonthAD
            // 
            this.cbMonthAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthAD.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonthAD.FormattingEnabled = true;
            this.cbMonthAD.Location = new System.Drawing.Point(217, 253);
            this.cbMonthAD.Name = "cbMonthAD";
            this.cbMonthAD.Size = new System.Drawing.Size(100, 28);
            this.cbMonthAD.TabIndex = 3;
            this.cbMonthAD.SelectedIndexChanged += new System.EventHandler(this.cbMonthAD_SelectedIndexChanged);
            // 
            // cbDayAD
            // 
            this.cbDayAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDayAD.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDayAD.FormattingEnabled = true;
            this.cbDayAD.Location = new System.Drawing.Point(380, 253);
            this.cbDayAD.Name = "cbDayAD";
            this.cbDayAD.Size = new System.Drawing.Size(50, 28);
            this.cbDayAD.TabIndex = 3;
            this.cbDayAD.SelectedIndexChanged += new System.EventHandler(this.cbDayAD_SelectedIndexChanged);
            // 
            // lblYearBS
            // 
            this.lblYearBS.AutoSize = true;
            this.lblYearBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearBS.Location = new System.Drawing.Point(36, 126);
            this.lblYearBS.Name = "lblYearBS";
            this.lblYearBS.Size = new System.Drawing.Size(41, 16);
            this.lblYearBS.TabIndex = 4;
            this.lblYearBS.Text = "Year";
            // 
            // lblMonthBS
            // 
            this.lblMonthBS.AutoSize = true;
            this.lblMonthBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthBS.Location = new System.Drawing.Point(163, 126);
            this.lblMonthBS.Name = "lblMonthBS";
            this.lblMonthBS.Size = new System.Drawing.Size(49, 16);
            this.lblMonthBS.TabIndex = 4;
            this.lblMonthBS.Text = "Month";
            // 
            // lblDayBS
            // 
            this.lblDayBS.AutoSize = true;
            this.lblDayBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayBS.Location = new System.Drawing.Point(339, 126);
            this.lblDayBS.Name = "lblDayBS";
            this.lblDayBS.Size = new System.Drawing.Size(36, 16);
            this.lblDayBS.TabIndex = 4;
            this.lblDayBS.Text = "Day";
            // 
            // lblDayAD
            // 
            this.lblDayAD.AutoSize = true;
            this.lblDayAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayAD.Location = new System.Drawing.Point(338, 259);
            this.lblDayAD.Name = "lblDayAD";
            this.lblDayAD.Size = new System.Drawing.Size(36, 16);
            this.lblDayAD.TabIndex = 4;
            this.lblDayAD.Text = "Day";
            // 
            // lblMonthAD
            // 
            this.lblMonthAD.AutoSize = true;
            this.lblMonthAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthAD.Location = new System.Drawing.Point(162, 259);
            this.lblMonthAD.Name = "lblMonthAD";
            this.lblMonthAD.Size = new System.Drawing.Size(49, 16);
            this.lblMonthAD.TabIndex = 4;
            this.lblMonthAD.Text = "Month";
            // 
            // lblYearAD
            // 
            this.lblYearAD.AutoSize = true;
            this.lblYearAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearAD.Location = new System.Drawing.Point(35, 259);
            this.lblYearAD.Name = "lblYearAD";
            this.lblYearAD.Size = new System.Drawing.Size(41, 16);
            this.lblYearAD.TabIndex = 4;
            this.lblYearAD.Text = "Year";
            // 
            // btnConvertToAD
            // 
            this.btnConvertToAD.BackColor = System.Drawing.Color.Gray;
            this.btnConvertToAD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertToAD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConvertToAD.FlatAppearance.BorderSize = 3;
            this.btnConvertToAD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConvertToAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToAD.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConvertToAD.Location = new System.Drawing.Point(459, 109);
            this.btnConvertToAD.Name = "btnConvertToAD";
            this.btnConvertToAD.Size = new System.Drawing.Size(99, 48);
            this.btnConvertToAD.TabIndex = 5;
            this.btnConvertToAD.Text = "Convert To A.D.";
            this.btnConvertToAD.UseVisualStyleBackColor = false;
            this.btnConvertToAD.Click += new System.EventHandler(this.btnConvertToAD_Click);
            // 
            // btnConvertToBS
            // 
            this.btnConvertToBS.BackColor = System.Drawing.Color.Gray;
            this.btnConvertToBS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertToBS.FlatAppearance.BorderSize = 3;
            this.btnConvertToBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToBS.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConvertToBS.Location = new System.Drawing.Point(458, 242);
            this.btnConvertToBS.Name = "btnConvertToBS";
            this.btnConvertToBS.Size = new System.Drawing.Size(99, 48);
            this.btnConvertToBS.TabIndex = 5;
            this.btnConvertToBS.Text = "Convert To B.S.";
            this.btnConvertToBS.UseVisualStyleBackColor = false;
            this.btnConvertToBS.Click += new System.EventHandler(this.btnConvertToBS_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Converter);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-5, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(584, 372);
            this.tabControl.TabIndex = 6;
            // 
            // Converter
            // 
            this.Converter.BackColor = System.Drawing.Color.Silver;
            this.Converter.Controls.Add(this.label1);
            this.Converter.Controls.Add(this.lblToEnglish);
            this.Converter.Controls.Add(this.btnConvertToBS);
            this.Converter.Controls.Add(this.TitlePanel);
            this.Converter.Controls.Add(this.btnConvertToAD);
            this.Converter.Controls.Add(this.lblToNepali);
            this.Converter.Controls.Add(this.lblYearAD);
            this.Converter.Controls.Add(this.lblOutputNepaliDate);
            this.Converter.Controls.Add(this.lblMonthAD);
            this.Converter.Controls.Add(this.lblOutputEnglishDate);
            this.Converter.Controls.Add(this.lblDayAD);
            this.Converter.Controls.Add(this.cbYearBS);
            this.Converter.Controls.Add(this.lblDayBS);
            this.Converter.Controls.Add(this.cbYearAD);
            this.Converter.Controls.Add(this.lblMonthBS);
            this.Converter.Controls.Add(this.cbMonthBS);
            this.Converter.Controls.Add(this.lblYearBS);
            this.Converter.Controls.Add(this.cbMonthAD);
            this.Converter.Controls.Add(this.cbDayAD);
            this.Converter.Controls.Add(this.cbDayBS);
            this.Converter.Location = new System.Drawing.Point(4, 25);
            this.Converter.Name = "Converter";
            this.Converter.Padding = new System.Windows.Forms.Padding(3);
            this.Converter.Size = new System.Drawing.Size(576, 343);
            this.Converter.TabIndex = 0;
            this.Converter.Text = "Converter";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.btnAddDate);
            this.tabPage2.Controls.Add(this.cbChaitra);
            this.tabPage2.Controls.Add(this.cbAshwin);
            this.tabPage2.Controls.Add(this.cbFalgun);
            this.tabPage2.Controls.Add(this.cbBhadra);
            this.tabPage2.Controls.Add(this.cbMagh);
            this.tabPage2.Controls.Add(this.cbShrawan);
            this.tabPage2.Controls.Add(this.cbPoush);
            this.tabPage2.Controls.Add(this.cbAshad);
            this.tabPage2.Controls.Add(this.cbMangsir);
            this.tabPage2.Controls.Add(this.cbJestha);
            this.tabPage2.Controls.Add(this.cbKarthik);
            this.tabPage2.Controls.Add(this.cbBaishakh);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lblBaisakh);
            this.tabPage2.Controls.Add(this.lblAddMonths);
            this.tabPage2.Controls.Add(this.lblDateBS);
            this.tabPage2.Controls.Add(this.lblAddDateTitle);
            this.tabPage2.Controls.Add(this.lblDateToAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Calendar";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnAddDate
            // 
            this.btnAddDate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDate.Location = new System.Drawing.Point(143, 289);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(108, 41);
            this.btnAddDate.TabIndex = 6;
            this.btnAddDate.Text = "Add Date";
            this.btnAddDate.UseVisualStyleBackColor = false;
            this.btnAddDate.Click += new System.EventHandler(this.btnAddDate_Click);
            // 
            // cbChaitra
            // 
            this.cbChaitra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChaitra.FormattingEnabled = true;
            this.cbChaitra.Location = new System.Drawing.Point(357, 253);
            this.cbChaitra.Name = "cbChaitra";
            this.cbChaitra.Size = new System.Drawing.Size(49, 24);
            this.cbChaitra.TabIndex = 5;
            this.cbChaitra.SelectedIndexChanged += new System.EventHandler(this.cbChaitra_SelectedIndexChanged);
            // 
            // cbAshwin
            // 
            this.cbAshwin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAshwin.FormattingEnabled = true;
            this.cbAshwin.Location = new System.Drawing.Point(167, 253);
            this.cbAshwin.Name = "cbAshwin";
            this.cbAshwin.Size = new System.Drawing.Size(49, 24);
            this.cbAshwin.TabIndex = 5;
            this.cbAshwin.SelectedIndexChanged += new System.EventHandler(this.cbAshwin_SelectedIndexChanged);
            // 
            // cbFalgun
            // 
            this.cbFalgun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFalgun.FormattingEnabled = true;
            this.cbFalgun.Location = new System.Drawing.Point(357, 226);
            this.cbFalgun.Name = "cbFalgun";
            this.cbFalgun.Size = new System.Drawing.Size(49, 24);
            this.cbFalgun.TabIndex = 5;
            this.cbFalgun.SelectedIndexChanged += new System.EventHandler(this.cbFalgun_SelectedIndexChanged);
            // 
            // cbBhadra
            // 
            this.cbBhadra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBhadra.FormattingEnabled = true;
            this.cbBhadra.Location = new System.Drawing.Point(167, 226);
            this.cbBhadra.Name = "cbBhadra";
            this.cbBhadra.Size = new System.Drawing.Size(49, 24);
            this.cbBhadra.TabIndex = 5;
            this.cbBhadra.SelectedIndexChanged += new System.EventHandler(this.cbBhadra_SelectedIndexChanged);
            // 
            // cbMagh
            // 
            this.cbMagh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMagh.FormattingEnabled = true;
            this.cbMagh.Location = new System.Drawing.Point(357, 199);
            this.cbMagh.Name = "cbMagh";
            this.cbMagh.Size = new System.Drawing.Size(49, 24);
            this.cbMagh.TabIndex = 5;
            this.cbMagh.SelectedIndexChanged += new System.EventHandler(this.cbMagh_SelectedIndexChanged);
            // 
            // cbShrawan
            // 
            this.cbShrawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShrawan.FormattingEnabled = true;
            this.cbShrawan.Location = new System.Drawing.Point(167, 199);
            this.cbShrawan.Name = "cbShrawan";
            this.cbShrawan.Size = new System.Drawing.Size(49, 24);
            this.cbShrawan.TabIndex = 5;
            this.cbShrawan.SelectedIndexChanged += new System.EventHandler(this.cbShrawan_SelectedIndexChanged);
            // 
            // cbPoush
            // 
            this.cbPoush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoush.FormattingEnabled = true;
            this.cbPoush.Location = new System.Drawing.Point(357, 172);
            this.cbPoush.Name = "cbPoush";
            this.cbPoush.Size = new System.Drawing.Size(49, 24);
            this.cbPoush.TabIndex = 5;
            this.cbPoush.SelectedIndexChanged += new System.EventHandler(this.cbPoush_SelectedIndexChanged);
            // 
            // cbAshad
            // 
            this.cbAshad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAshad.FormattingEnabled = true;
            this.cbAshad.Location = new System.Drawing.Point(167, 172);
            this.cbAshad.Name = "cbAshad";
            this.cbAshad.Size = new System.Drawing.Size(49, 24);
            this.cbAshad.TabIndex = 5;
            this.cbAshad.SelectedIndexChanged += new System.EventHandler(this.cbAshad_SelectedIndexChanged);
            // 
            // cbMangsir
            // 
            this.cbMangsir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMangsir.FormattingEnabled = true;
            this.cbMangsir.Location = new System.Drawing.Point(357, 145);
            this.cbMangsir.Name = "cbMangsir";
            this.cbMangsir.Size = new System.Drawing.Size(49, 24);
            this.cbMangsir.TabIndex = 5;
            this.cbMangsir.SelectedIndexChanged += new System.EventHandler(this.cbMangsir_SelectedIndexChanged);
            // 
            // cbJestha
            // 
            this.cbJestha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJestha.FormattingEnabled = true;
            this.cbJestha.Location = new System.Drawing.Point(167, 145);
            this.cbJestha.Name = "cbJestha";
            this.cbJestha.Size = new System.Drawing.Size(49, 24);
            this.cbJestha.TabIndex = 5;
            this.cbJestha.SelectedIndexChanged += new System.EventHandler(this.cbJestha_SelectedIndexChanged);
            // 
            // cbKarthik
            // 
            this.cbKarthik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKarthik.FormattingEnabled = true;
            this.cbKarthik.Location = new System.Drawing.Point(357, 118);
            this.cbKarthik.Name = "cbKarthik";
            this.cbKarthik.Size = new System.Drawing.Size(49, 24);
            this.cbKarthik.TabIndex = 5;
            this.cbKarthik.SelectedIndexChanged += new System.EventHandler(this.cbKarthik_SelectedIndexChanged);
            // 
            // cbBaishakh
            // 
            this.cbBaishakh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaishakh.FormattingEnabled = true;
            this.cbBaishakh.Location = new System.Drawing.Point(167, 118);
            this.cbBaishakh.Name = "cbBaishakh";
            this.cbBaishakh.Size = new System.Drawing.Size(49, 24);
            this.cbBaishakh.TabIndex = 5;
            this.cbBaishakh.SelectedIndexChanged += new System.EventHandler(this.cbBaishakh_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(281, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Chaitra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ashwin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(281, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Falgun";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bhadra";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(280, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Magh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shrawan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Poush";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ashad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mangsir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jestha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Karthik";
            // 
            // lblBaisakh
            // 
            this.lblBaisakh.AutoSize = true;
            this.lblBaisakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaisakh.Location = new System.Drawing.Point(84, 119);
            this.lblBaisakh.Name = "lblBaisakh";
            this.lblBaisakh.Size = new System.Drawing.Size(77, 18);
            this.lblBaisakh.TabIndex = 4;
            this.lblBaisakh.Text = "Baishakh";
            // 
            // lblAddMonths
            // 
            this.lblAddMonths.AutoSize = true;
            this.lblAddMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMonths.Location = new System.Drawing.Point(12, 86);
            this.lblAddMonths.Name = "lblAddMonths";
            this.lblAddMonths.Size = new System.Drawing.Size(343, 24);
            this.lblAddMonths.TabIndex = 3;
            this.lblAddMonths.Text = "Add number of days in each month:";
            // 
            // lblDateBS
            // 
            this.lblDateBS.AutoSize = true;
            this.lblDateBS.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDateBS.ForeColor = System.Drawing.Color.Green;
            this.lblDateBS.Location = new System.Drawing.Point(82, 51);
            this.lblDateBS.Name = "lblDateBS";
            this.lblDateBS.Size = new System.Drawing.Size(72, 28);
            this.lblDateBS.TabIndex = 2;
            this.lblDateBS.Text = "label1";
            this.lblDateBS.Click += new System.EventHandler(this.lblDateBS_Click);
            // 
            // lblAddDateTitle
            // 
            this.lblAddDateTitle.AutoSize = true;
            this.lblAddDateTitle.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDateTitle.Location = new System.Drawing.Point(153, 3);
            this.lblAddDateTitle.Name = "lblAddDateTitle";
            this.lblAddDateTitle.Size = new System.Drawing.Size(291, 44);
            this.lblAddDateTitle.TabIndex = 1;
            this.lblAddDateTitle.Text = "Add B.S. Calendar";
            // 
            // lblDateToAdd
            // 
            this.lblDateToAdd.AutoSize = true;
            this.lblDateToAdd.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToAdd.Location = new System.Drawing.Point(13, 51);
            this.lblDateToAdd.Name = "lblDateToAdd";
            this.lblDateToAdd.Size = new System.Drawing.Size(63, 28);
            this.lblDateToAdd.TabIndex = 0;
            this.lblDateToAdd.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Created and Designed by: Abhishek Timilsina";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateConverterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(574, 367);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DateConverterApp";
            this.Text = "Nepali Date Converter";
            this.Load += new System.EventHandler(this.NepaliDateConverterApp_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Converter.ResumeLayout(false);
            this.Converter.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblToEnglish;
        private System.Windows.Forms.Label lblToNepali;
        private System.Windows.Forms.Label lblOutputNepaliDate;
        private System.Windows.Forms.Label lblOutputEnglishDate;
        private System.Windows.Forms.ComboBox cbYearBS;
        private System.Windows.Forms.ComboBox cbMonthBS;
        private System.Windows.Forms.ComboBox cbDayBS;
        private System.Windows.Forms.ComboBox cbYearAD;
        private System.Windows.Forms.ComboBox cbMonthAD;
        private System.Windows.Forms.ComboBox cbDayAD;
        private System.Windows.Forms.Label lblYearBS;
        private System.Windows.Forms.Label lblMonthBS;
        private System.Windows.Forms.Label lblDayBS;
        private System.Windows.Forms.Label lblDayAD;
        private System.Windows.Forms.Label lblMonthAD;
        private System.Windows.Forms.Label lblYearAD;
        private System.Windows.Forms.Button btnConvertToAD;
        private System.Windows.Forms.Button btnConvertToBS;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Converter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.ComboBox cbChaitra;
        private System.Windows.Forms.ComboBox cbAshwin;
        private System.Windows.Forms.ComboBox cbFalgun;
        private System.Windows.Forms.ComboBox cbBhadra;
        private System.Windows.Forms.ComboBox cbMagh;
        private System.Windows.Forms.ComboBox cbShrawan;
        private System.Windows.Forms.ComboBox cbPoush;
        private System.Windows.Forms.ComboBox cbAshad;
        private System.Windows.Forms.ComboBox cbMangsir;
        private System.Windows.Forms.ComboBox cbJestha;
        private System.Windows.Forms.ComboBox cbKarthik;
        private System.Windows.Forms.ComboBox cbBaishakh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBaisakh;
        private System.Windows.Forms.Label lblAddMonths;
        private System.Windows.Forms.Label lblDateBS;
        private System.Windows.Forms.Label lblAddDateTitle;
        private System.Windows.Forms.Label lblDateToAdd;
        private System.Windows.Forms.Label label1;
    }
}