namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Holiday_Calculator = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TFrom = new System.Windows.Forms.TextBox();
            this.TTo = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.Label();
            this.BreakFast = new System.Windows.Forms.Label();
            this.Extras = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.Transport = new System.Windows.Forms.CheckBox();
            this.Guide = new System.Windows.Forms.CheckBox();
            this.Insurance = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deluxeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakFastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insuranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyName = new System.Windows.Forms.Label();
            this.MyID = new System.Windows.Forms.Label();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.Number_Of_Days = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(845, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(174, 157);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Holiday_Calculator
            // 
            this.Holiday_Calculator.AutoSize = true;
            this.Holiday_Calculator.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Holiday_Calculator.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Holiday_Calculator.Location = new System.Drawing.Point(214, 58);
            this.Holiday_Calculator.Name = "Holiday_Calculator";
            this.Holiday_Calculator.Size = new System.Drawing.Size(380, 44);
            this.Holiday_Calculator.TabIndex = 1;
            this.Holiday_Calculator.Text = "Ammar\'s Hols Calculator";
            this.Holiday_Calculator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Holiday_Calculator.Click += new System.EventHandler(this.Holiday_Calculator_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(570, 139);
            this.monthCalendar1.MaxSelectionCount = 1000;
            this.monthCalendar1.MinDate = new System.DateTime(2020, 12, 20, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.Highlight;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // TFrom
            // 
            this.TFrom.Location = new System.Drawing.Point(601, 356);
            this.TFrom.Name = "TFrom";
            this.TFrom.ReadOnly = true;
            this.TFrom.Size = new System.Drawing.Size(194, 20);
            this.TFrom.TabIndex = 3;
            this.TFrom.TextChanged += new System.EventHandler(this.TFrom_TextChanged);
            // 
            // TTo
            // 
            this.TTo.Location = new System.Drawing.Point(601, 408);
            this.TTo.Name = "TTo";
            this.TTo.ReadOnly = true;
            this.TTo.Size = new System.Drawing.Size(194, 20);
            this.TTo.TabIndex = 4;
            this.TTo.TextChanged += new System.EventHandler(this.TTo_TextChanged);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(565, 359);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(30, 13);
            this.From.TabIndex = 5;
            this.From.Text = "From";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(567, 414);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(20, 13);
            this.To.TabIndex = 6;
            this.To.Text = "To";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate.Location = new System.Drawing.Point(857, 356);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(48, 20);
            this.Rate.TabIndex = 7;
            this.Rate.Text = "Rate";
            // 
            // textBox3
            // 
            this.textBox3.CausesValidation = false;
            this.textBox3.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(827, 383);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(111, 46);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.Location = new System.Drawing.Point(22, 375);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(213, 52);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.BtnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.BtnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // Rooms
            // 
            this.Rooms.AutoSize = true;
            this.Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms.Location = new System.Drawing.Point(19, 177);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(57, 16);
            this.Rooms.TabIndex = 10;
            this.Rooms.Text = "Rooms";
            // 
            // BreakFast
            // 
            this.BreakFast.AutoSize = true;
            this.BreakFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakFast.Location = new System.Drawing.Point(174, 177);
            this.BreakFast.Name = "BreakFast";
            this.BreakFast.Size = new System.Drawing.Size(79, 16);
            this.BreakFast.TabIndex = 11;
            this.BreakFast.Text = "BreakFast";
            this.BreakFast.Click += new System.EventHandler(this.BreakFast_Click);
            // 
            // Extras
            // 
            this.Extras.AutoSize = true;
            this.Extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extras.Location = new System.Drawing.Point(307, 177);
            this.Extras.Name = "Extras";
            this.Extras.Size = new System.Drawing.Size(51, 16);
            this.Extras.TabIndex = 12;
            this.Extras.Text = "Extras";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Deluxe",
            "Family"});
            this.listBox1.Location = new System.Drawing.Point(22, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Location = new System.Drawing.Point(177, 222);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(43, 17);
            this.radioBtnYes.TabIndex = 14;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "Yes";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            this.radioBtnYes.CheckedChanged += new System.EventHandler(this.radioBtnYes_CheckedChanged);
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Location = new System.Drawing.Point(177, 268);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(39, 17);
            this.radioBtnNo.TabIndex = 15;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "No";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            this.radioBtnNo.CheckedChanged += new System.EventHandler(this.radioBtnNo_CheckedChanged);
            // 
            // Transport
            // 
            this.Transport.AutoSize = true;
            this.Transport.Location = new System.Drawing.Point(310, 222);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(71, 17);
            this.Transport.TabIndex = 16;
            this.Transport.Text = "Transport";
            this.Transport.UseVisualStyleBackColor = true;
            this.Transport.CheckedChanged += new System.EventHandler(this.Transport_CheckedChanged);
            // 
            // Guide
            // 
            this.Guide.AutoSize = true;
            this.Guide.Location = new System.Drawing.Point(310, 246);
            this.Guide.Name = "Guide";
            this.Guide.Size = new System.Drawing.Size(54, 17);
            this.Guide.TabIndex = 17;
            this.Guide.Text = "Guide";
            this.Guide.UseVisualStyleBackColor = true;
            this.Guide.CheckedChanged += new System.EventHandler(this.Guide_CheckedChanged);
            // 
            // Insurance
            // 
            this.Insurance.AutoSize = true;
            this.Insurance.Location = new System.Drawing.Point(310, 269);
            this.Insurance.Name = "Insurance";
            this.Insurance.Size = new System.Drawing.Size(73, 17);
            this.Insurance.TabIndex = 18;
            this.Insurance.Text = "Insurance";
            this.Insurance.UseVisualStyleBackColor = true;
            this.Insurance.CheckedChanged += new System.EventHandler(this.Insurance_CheckedChanged);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(0, 446);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1019, 100);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem,
            this.breakFastToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.doubleToolStripMenuItem,
            this.deluxeToolStripMenuItem,
            this.familyToolStripMenuItem});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.CheckOnClick = true;
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.singleToolStripMenuItem.Text = "Single";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.singleToolStripMenuItem_Click);
            // 
            // doubleToolStripMenuItem
            // 
            this.doubleToolStripMenuItem.CheckOnClick = true;
            this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            this.doubleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doubleToolStripMenuItem.Text = "Double";
            this.doubleToolStripMenuItem.Click += new System.EventHandler(this.doubleToolStripMenuItem_Click);
            // 
            // deluxeToolStripMenuItem
            // 
            this.deluxeToolStripMenuItem.CheckOnClick = true;
            this.deluxeToolStripMenuItem.Name = "deluxeToolStripMenuItem";
            this.deluxeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deluxeToolStripMenuItem.Text = "Deluxe";
            this.deluxeToolStripMenuItem.Click += new System.EventHandler(this.deluxeToolStripMenuItem_Click);
            // 
            // familyToolStripMenuItem
            // 
            this.familyToolStripMenuItem.CheckOnClick = true;
            this.familyToolStripMenuItem.Name = "familyToolStripMenuItem";
            this.familyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.familyToolStripMenuItem.Text = "Family";
            this.familyToolStripMenuItem.Click += new System.EventHandler(this.familyToolStripMenuItem_Click);
            // 
            // breakFastToolStripMenuItem
            // 
            this.breakFastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesToolStripMenuItem,
            this.noToolStripMenuItem});
            this.breakFastToolStripMenuItem.Name = "breakFastToolStripMenuItem";
            this.breakFastToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.breakFastToolStripMenuItem.Text = "BreakFast";
            // 
            // yesToolStripMenuItem
            // 
            this.yesToolStripMenuItem.CheckOnClick = true;
            this.yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            this.yesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yesToolStripMenuItem.Text = "Yes";
            this.yesToolStripMenuItem.Click += new System.EventHandler(this.yesToolStripMenuItem_Click);
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.CheckOnClick = true;
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noToolStripMenuItem.Text = "No";
            this.noToolStripMenuItem.Click += new System.EventHandler(this.noToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transportToolStripMenuItem,
            this.guideToolStripMenuItem,
            this.insuranceToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // transportToolStripMenuItem
            // 
            this.transportToolStripMenuItem.CheckOnClick = true;
            this.transportToolStripMenuItem.Name = "transportToolStripMenuItem";
            this.transportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transportToolStripMenuItem.Text = "Transport";
            this.transportToolStripMenuItem.Click += new System.EventHandler(this.transportToolStripMenuItem_Click);
            // 
            // guideToolStripMenuItem
            // 
            this.guideToolStripMenuItem.CheckOnClick = true;
            this.guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            this.guideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guideToolStripMenuItem.Text = "Guide";
            this.guideToolStripMenuItem.Click += new System.EventHandler(this.guideToolStripMenuItem_Click);
            // 
            // insuranceToolStripMenuItem
            // 
            this.insuranceToolStripMenuItem.CheckOnClick = true;
            this.insuranceToolStripMenuItem.Name = "insuranceToolStripMenuItem";
            this.insuranceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insuranceToolStripMenuItem.Text = "Insurance";
            this.insuranceToolStripMenuItem.Click += new System.EventHandler(this.insuranceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyName.Location = new System.Drawing.Point(264, 375);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(149, 18);
            this.MyName.TabIndex = 21;
            this.MyName.Text = "Name: Ammar Omari";
            // 
            // MyID
            // 
            this.MyID.AutoSize = true;
            this.MyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyID.Location = new System.Drawing.Point(264, 409);
            this.MyID.Name = "MyID";
            this.MyID.Size = new System.Drawing.Size(94, 18);
            this.MyID.TabIndex = 22;
            this.MyID.Text = "ID: 20180877";
            // 
            // daysBox
            // 
            this.daysBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysBox.Location = new System.Drawing.Point(827, 275);
            this.daysBox.Name = "daysBox";
            this.daysBox.ReadOnly = true;
            this.daysBox.Size = new System.Drawing.Size(96, 26);
            this.daysBox.TabIndex = 23;
            this.daysBox.TextChanged += new System.EventHandler(this.daysBox_TextChanged);
            // 
            // Number_Of_Days
            // 
            this.Number_Of_Days.AutoSize = true;
            this.Number_Of_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Of_Days.Location = new System.Drawing.Point(824, 259);
            this.Number_Of_Days.Name = "Number_Of_Days";
            this.Number_Of_Days.Size = new System.Drawing.Size(99, 13);
            this.Number_Of_Days.TabIndex = 24;
            this.Number_Of_Days.Text = "Number Of Days";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClear.Location = new System.Drawing.Point(448, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 52);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 550);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Number_Of_Days);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.MyID);
            this.Controls.Add(this.MyName);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Insurance);
            this.Controls.Add(this.Guide);
            this.Controls.Add(this.Transport);
            this.Controls.Add(this.radioBtnNo);
            this.Controls.Add(this.radioBtnYes);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Extras);
            this.Controls.Add(this.BreakFast);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.TTo);
            this.Controls.Add(this.TFrom);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Holiday_Calculator);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1035, 589);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSUT-11207-HW2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Holiday_Calculator;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox TFrom;
        private System.Windows.Forms.TextBox TTo;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label Rooms;
        private System.Windows.Forms.Label BreakFast;
        private System.Windows.Forms.Label Extras;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.CheckBox Transport;
        private System.Windows.Forms.CheckBox Guide;
        private System.Windows.Forms.CheckBox Insurance;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deluxeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakFastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insuranceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.Label MyID;
        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.Label Number_Of_Days;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

