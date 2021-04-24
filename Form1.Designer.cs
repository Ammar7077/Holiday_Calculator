namespace WindowsFormsApp1
{
    partial class CheckInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInForm));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Welcome = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TFrom = new System.Windows.Forms.TextBox();
            this.TTo = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.Label();
            this.BreakFast = new System.Windows.Forms.Label();
            this.Extras = new System.Windows.Forms.Label();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.Transport = new System.Windows.Forms.CheckBox();
            this.Guide = new System.Windows.Forms.CheckBox();
            this.Insurance = new System.Windows.Forms.CheckBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
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
            this.Ammar_Omari = new System.Windows.Forms.Label();
            this.ID1 = new System.Windows.Forms.Label();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.Number_Of_Days = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.Kayed_Obeidat = new System.Windows.Forms.Label();
            this.ID2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBoxPID = new System.Windows.Forms.TextBox();
            this.labelPD = new System.Windows.Forms.Label();
            this.btnBacktoSI = new System.Windows.Forms.Button();
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
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.Red;
            this.Welcome.Location = new System.Drawing.Point(229, 55);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(423, 45);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "WELCOME TO THE HOTEL";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Welcome.Click += new System.EventHandler(this.Holiday_Calculator_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(408, 164);
            this.monthCalendar1.MaxSelectionCount = 1000;
            this.monthCalendar1.MinDate = new System.DateTime(2020, 12, 20, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.Highlight;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // TFrom
            // 
            this.TFrom.Location = new System.Drawing.Point(661, 250);
            this.TFrom.Name = "TFrom";
            this.TFrom.ReadOnly = true;
            this.TFrom.Size = new System.Drawing.Size(194, 20);
            this.TFrom.TabIndex = 3;
            this.TFrom.TextChanged += new System.EventHandler(this.TFrom_TextChanged);
            // 
            // TTo
            // 
            this.TTo.Location = new System.Drawing.Point(661, 301);
            this.TTo.Name = "TTo";
            this.TTo.ReadOnly = true;
            this.TTo.Size = new System.Drawing.Size(194, 20);
            this.TTo.TabIndex = 4;
            this.TTo.TextChanged += new System.EventHandler(this.TTo_TextChanged);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.BackColor = System.Drawing.Color.Transparent;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.ForeColor = System.Drawing.Color.Red;
            this.From.Location = new System.Drawing.Point(658, 228);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(48, 18);
            this.From.TabIndex = 5;
            this.From.Text = "From";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.BackColor = System.Drawing.Color.Transparent;
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.ForeColor = System.Drawing.Color.Red;
            this.To.Location = new System.Drawing.Point(658, 285);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(27, 16);
            this.To.TabIndex = 6;
            this.To.Text = "To";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.totalPrice.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.ForeColor = System.Drawing.Color.Red;
            this.totalPrice.Location = new System.Drawing.Point(869, 166);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(130, 28);
            this.totalPrice.TabIndex = 7;
            this.totalPrice.Text = "Total Price";
            // 
            // textBoxRate
            // 
            this.textBoxRate.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRate.CausesValidation = false;
            this.textBoxRate.Font = new System.Drawing.Font("MingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxRate.Location = new System.Drawing.Point(873, 197);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.ReadOnly = true;
            this.textBoxRate.Size = new System.Drawing.Size(126, 36);
            this.textBoxRate.TabIndex = 8;
            this.textBoxRate.Text = "RATE";
            this.textBoxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Red;
            this.BtnExit.Location = new System.Drawing.Point(874, 363);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(125, 62);
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
            this.Rooms.BackColor = System.Drawing.Color.Transparent;
            this.Rooms.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms.ForeColor = System.Drawing.Color.Red;
            this.Rooms.Location = new System.Drawing.Point(30, 161);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(80, 29);
            this.Rooms.TabIndex = 10;
            this.Rooms.Text = "Rooms";
            this.Rooms.Click += new System.EventHandler(this.Rooms_Click);
            // 
            // BreakFast
            // 
            this.BreakFast.AutoSize = true;
            this.BreakFast.BackColor = System.Drawing.Color.Transparent;
            this.BreakFast.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakFast.ForeColor = System.Drawing.Color.Red;
            this.BreakFast.Location = new System.Drawing.Point(157, 163);
            this.BreakFast.Name = "BreakFast";
            this.BreakFast.Size = new System.Drawing.Size(99, 26);
            this.BreakFast.TabIndex = 11;
            this.BreakFast.Text = "BreakFast";
            this.BreakFast.Click += new System.EventHandler(this.BreakFast_Click);
            // 
            // Extras
            // 
            this.Extras.AutoSize = true;
            this.Extras.BackColor = System.Drawing.Color.Transparent;
            this.Extras.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extras.ForeColor = System.Drawing.Color.Red;
            this.Extras.Location = new System.Drawing.Point(288, 163);
            this.Extras.Name = "Extras";
            this.Extras.Size = new System.Drawing.Size(65, 26);
            this.Extras.TabIndex = 12;
            this.Extras.Text = "Extras";
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRooms.ForeColor = System.Drawing.Color.Maroon;
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.ItemHeight = 18;
            this.listBoxRooms.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Deluxe",
            "Family"});
            this.listBoxRooms.Location = new System.Drawing.Point(22, 197);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(120, 94);
            this.listBoxRooms.TabIndex = 13;
            this.listBoxRooms.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBoxRooms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnYes.ForeColor = System.Drawing.Color.DarkRed;
            this.radioBtnYes.Location = new System.Drawing.Point(174, 211);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(58, 24);
            this.radioBtnYes.TabIndex = 14;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "Yes";
            this.radioBtnYes.UseVisualStyleBackColor = false;
            this.radioBtnYes.CheckedChanged += new System.EventHandler(this.radioBtnYes_CheckedChanged);
            this.radioBtnYes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radioBtnYes_KeyDown);
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNo.ForeColor = System.Drawing.Color.DarkRed;
            this.radioBtnNo.Location = new System.Drawing.Point(174, 250);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(49, 24);
            this.radioBtnNo.TabIndex = 15;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "No";
            this.radioBtnNo.UseVisualStyleBackColor = false;
            this.radioBtnNo.CheckedChanged += new System.EventHandler(this.radioBtnNo_CheckedChanged);
            // 
            // Transport
            // 
            this.Transport.AutoSize = true;
            this.Transport.BackColor = System.Drawing.Color.Transparent;
            this.Transport.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transport.ForeColor = System.Drawing.Color.DarkRed;
            this.Transport.Location = new System.Drawing.Point(274, 213);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(97, 24);
            this.Transport.TabIndex = 16;
            this.Transport.Text = "Transport";
            this.Transport.UseVisualStyleBackColor = false;
            this.Transport.CheckedChanged += new System.EventHandler(this.Transport_CheckedChanged);
            // 
            // Guide
            // 
            this.Guide.AutoSize = true;
            this.Guide.BackColor = System.Drawing.Color.Transparent;
            this.Guide.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guide.ForeColor = System.Drawing.Color.DarkRed;
            this.Guide.Location = new System.Drawing.Point(274, 251);
            this.Guide.Name = "Guide";
            this.Guide.Size = new System.Drawing.Size(68, 20);
            this.Guide.TabIndex = 17;
            this.Guide.Text = "Guide";
            this.Guide.UseVisualStyleBackColor = false;
            this.Guide.CheckedChanged += new System.EventHandler(this.Guide_CheckedChanged);
            // 
            // Insurance
            // 
            this.Insurance.AutoSize = true;
            this.Insurance.BackColor = System.Drawing.Color.Transparent;
            this.Insurance.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insurance.ForeColor = System.Drawing.Color.DarkRed;
            this.Insurance.Location = new System.Drawing.Point(274, 290);
            this.Insurance.Name = "Insurance";
            this.Insurance.Size = new System.Drawing.Size(105, 22);
            this.Insurance.TabIndex = 18;
            this.Insurance.Text = "Insurance";
            this.Insurance.UseVisualStyleBackColor = false;
            this.Insurance.CheckedChanged += new System.EventHandler(this.Insurance_CheckedChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(0, 446);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(1019, 100);
            this.listBoxEvents.TabIndex = 4;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem,
            this.breakFastToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1019, 28);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.doubleToolStripMenuItem,
            this.deluxeToolStripMenuItem,
            this.familyToolStripMenuItem});
            this.roomsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.CheckOnClick = true;
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.singleToolStripMenuItem.Text = "Single";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.singleToolStripMenuItem_Click);
            // 
            // doubleToolStripMenuItem
            // 
            this.doubleToolStripMenuItem.CheckOnClick = true;
            this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            this.doubleToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.doubleToolStripMenuItem.Text = "Double";
            this.doubleToolStripMenuItem.Click += new System.EventHandler(this.doubleToolStripMenuItem_Click);
            // 
            // deluxeToolStripMenuItem
            // 
            this.deluxeToolStripMenuItem.CheckOnClick = true;
            this.deluxeToolStripMenuItem.Name = "deluxeToolStripMenuItem";
            this.deluxeToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deluxeToolStripMenuItem.Text = "Deluxe";
            this.deluxeToolStripMenuItem.Click += new System.EventHandler(this.deluxeToolStripMenuItem_Click);
            // 
            // familyToolStripMenuItem
            // 
            this.familyToolStripMenuItem.CheckOnClick = true;
            this.familyToolStripMenuItem.Name = "familyToolStripMenuItem";
            this.familyToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.familyToolStripMenuItem.Text = "Family";
            this.familyToolStripMenuItem.Click += new System.EventHandler(this.familyToolStripMenuItem_Click);
            // 
            // breakFastToolStripMenuItem
            // 
            this.breakFastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesToolStripMenuItem,
            this.noToolStripMenuItem});
            this.breakFastToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakFastToolStripMenuItem.Name = "breakFastToolStripMenuItem";
            this.breakFastToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.breakFastToolStripMenuItem.Text = "BreakFast";
            // 
            // yesToolStripMenuItem
            // 
            this.yesToolStripMenuItem.CheckOnClick = true;
            this.yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            this.yesToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.yesToolStripMenuItem.Text = "Yes";
            this.yesToolStripMenuItem.Click += new System.EventHandler(this.yesToolStripMenuItem_Click);
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.CheckOnClick = true;
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.noToolStripMenuItem.Text = "No";
            this.noToolStripMenuItem.Click += new System.EventHandler(this.noToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transportToolStripMenuItem,
            this.guideToolStripMenuItem,
            this.insuranceToolStripMenuItem});
            this.extrasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // transportToolStripMenuItem
            // 
            this.transportToolStripMenuItem.CheckOnClick = true;
            this.transportToolStripMenuItem.Name = "transportToolStripMenuItem";
            this.transportToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.transportToolStripMenuItem.Text = "Transport";
            this.transportToolStripMenuItem.Click += new System.EventHandler(this.transportToolStripMenuItem_Click);
            // 
            // guideToolStripMenuItem
            // 
            this.guideToolStripMenuItem.CheckOnClick = true;
            this.guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            this.guideToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.guideToolStripMenuItem.Text = "Guide";
            this.guideToolStripMenuItem.Click += new System.EventHandler(this.guideToolStripMenuItem_Click);
            // 
            // insuranceToolStripMenuItem
            // 
            this.insuranceToolStripMenuItem.CheckOnClick = true;
            this.insuranceToolStripMenuItem.Name = "insuranceToolStripMenuItem";
            this.insuranceToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.insuranceToolStripMenuItem.Text = "Insurance";
            this.insuranceToolStripMenuItem.Click += new System.EventHandler(this.insuranceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Ammar_Omari
            // 
            this.Ammar_Omari.AutoSize = true;
            this.Ammar_Omari.BackColor = System.Drawing.Color.Transparent;
            this.Ammar_Omari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ammar_Omari.Location = new System.Drawing.Point(24, 378);
            this.Ammar_Omari.Name = "Ammar_Omari";
            this.Ammar_Omari.Size = new System.Drawing.Size(101, 18);
            this.Ammar_Omari.TabIndex = 21;
            this.Ammar_Omari.Text = "Ammar Omari";
            // 
            // ID1
            // 
            this.ID1.AutoSize = true;
            this.ID1.BackColor = System.Drawing.Color.Transparent;
            this.ID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID1.Location = new System.Drawing.Point(38, 396);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(72, 18);
            this.ID1.TabIndex = 22;
            this.ID1.Text = "20180877";
            this.ID1.Click += new System.EventHandler(this.MyID_Click);
            // 
            // daysBox
            // 
            this.daysBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysBox.Location = new System.Drawing.Point(661, 184);
            this.daysBox.Name = "daysBox";
            this.daysBox.ReadOnly = true;
            this.daysBox.Size = new System.Drawing.Size(96, 26);
            this.daysBox.TabIndex = 23;
            this.daysBox.TextChanged += new System.EventHandler(this.daysBox_TextChanged);
            // 
            // Number_Of_Days
            // 
            this.Number_Of_Days.AutoSize = true;
            this.Number_Of_Days.BackColor = System.Drawing.Color.Transparent;
            this.Number_Of_Days.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Of_Days.ForeColor = System.Drawing.Color.Red;
            this.Number_Of_Days.Location = new System.Drawing.Point(661, 164);
            this.Number_Of_Days.Name = "Number_Of_Days";
            this.Number_Of_Days.Size = new System.Drawing.Size(92, 17);
            this.Number_Of_Days.TabIndex = 24;
            this.Number_Of_Days.Text = "Number Of Days";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Navy;
            this.btnClear.Location = new System.Drawing.Point(889, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 62);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Turquoise;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.Navy;
            this.btnCheckIn.Location = new System.Drawing.Point(661, 363);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(194, 64);
            this.btnCheckIn.TabIndex = 26;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            this.btnCheckIn.MouseEnter += new System.EventHandler(this.btnCheckIn_MouseEnter);
            this.btnCheckIn.MouseLeave += new System.EventHandler(this.btnCheckIn_MouseLeave);
            // 
            // Kayed_Obeidat
            // 
            this.Kayed_Obeidat.AutoSize = true;
            this.Kayed_Obeidat.BackColor = System.Drawing.Color.Transparent;
            this.Kayed_Obeidat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kayed_Obeidat.Location = new System.Drawing.Point(173, 376);
            this.Kayed_Obeidat.Name = "Kayed_Obeidat";
            this.Kayed_Obeidat.Size = new System.Drawing.Size(99, 20);
            this.Kayed_Obeidat.TabIndex = 28;
            this.Kayed_Obeidat.Text = "Kayed Obeidat";
            // 
            // ID2
            // 
            this.ID2.AutoSize = true;
            this.ID2.BackColor = System.Drawing.Color.Transparent;
            this.ID2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID2.Location = new System.Drawing.Point(191, 396);
            this.ID2.Name = "ID2";
            this.ID2.Size = new System.Drawing.Size(65, 20);
            this.ID2.TabIndex = 29;
            this.ID2.Text = "20180943";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBoxPID
            // 
            this.txtBoxPID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBoxPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPID.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPID.Location = new System.Drawing.Point(336, 385);
            this.txtBoxPID.Name = "txtBoxPID";
            this.txtBoxPID.Size = new System.Drawing.Size(289, 42);
            this.txtBoxPID.TabIndex = 30;
            this.txtBoxPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPD
            // 
            this.labelPD.AutoSize = true;
            this.labelPD.BackColor = System.Drawing.Color.Transparent;
            this.labelPD.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPD.ForeColor = System.Drawing.Color.Red;
            this.labelPD.Location = new System.Drawing.Point(331, 356);
            this.labelPD.Name = "labelPD";
            this.labelPD.Size = new System.Drawing.Size(304, 26);
            this.labelPD.TabIndex = 31;
            this.labelPD.Text = "Enter your personal ID to Check In";
            // 
            // btnBacktoSI
            // 
            this.btnBacktoSI.BackColor = System.Drawing.Color.White;
            this.btnBacktoSI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBacktoSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoSI.ForeColor = System.Drawing.Color.Navy;
            this.btnBacktoSI.Image = ((System.Drawing.Image)(resources.GetObject("btnBacktoSI.Image")));
            this.btnBacktoSI.Location = new System.Drawing.Point(22, 55);
            this.btnBacktoSI.Name = "btnBacktoSI";
            this.btnBacktoSI.Size = new System.Drawing.Size(76, 54);
            this.btnBacktoSI.TabIndex = 32;
            this.btnBacktoSI.UseVisualStyleBackColor = false;
            this.btnBacktoSI.Click += new System.EventHandler(this.btnBacktoSI_Click);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 550);
            this.Controls.Add(this.btnBacktoSI);
            this.Controls.Add(this.labelPD);
            this.Controls.Add(this.txtBoxPID);
            this.Controls.Add(this.ID2);
            this.Controls.Add(this.Kayed_Obeidat);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Number_Of_Days);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.ID1);
            this.Controls.Add(this.Ammar_Omari);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.Insurance);
            this.Controls.Add(this.Guide);
            this.Controls.Add(this.Transport);
            this.Controls.Add(this.radioBtnNo);
            this.Controls.Add(this.radioBtnYes);
            this.Controls.Add(this.listBoxRooms);
            this.Controls.Add(this.Extras);
            this.Controls.Add(this.BreakFast);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.TTo);
            this.Controls.Add(this.TFrom);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1035, 589);
            this.Name = "CheckInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.CheckInForm_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox TFrom;
        private System.Windows.Forms.TextBox TTo;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label Rooms;
        private System.Windows.Forms.Label BreakFast;
        private System.Windows.Forms.Label Extras;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.CheckBox Transport;
        private System.Windows.Forms.CheckBox Guide;
        private System.Windows.Forms.CheckBox Insurance;
        private System.Windows.Forms.ListBox listBoxEvents;
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
        private System.Windows.Forms.Label Ammar_Omari;
        private System.Windows.Forms.Label ID1;
        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.Label Number_Of_Days;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label Kayed_Obeidat;
        private System.Windows.Forms.Label ID2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBoxPID;
        private System.Windows.Forms.Label labelPD;
        private System.Windows.Forms.Button btnBacktoSI;
    }
}

