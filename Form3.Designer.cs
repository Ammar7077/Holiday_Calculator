namespace WindowsFormsApp1
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.noteLabel = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.labelFreeRooms = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtBoxRoomID = new System.Windows.Forms.TextBox();
            this.RoomID = new System.Windows.Forms.Label();
            this.btnLeasing = new System.Windows.Forms.Button();
            this.viewFreeRooms = new System.Windows.Forms.DataGridView();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.BtnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ID2 = new System.Windows.Forms.Label();
            this.Kayed_Obeidat = new System.Windows.Forms.Label();
            this.ID1 = new System.Windows.Forms.Label();
            this.Ammar_Omari = new System.Windows.Forms.Label();
            this.tabAdmin.SuspendLayout();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFreeRooms)).BeginInit();
            this.tabPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.BackColor = System.Drawing.Color.Gray;
            this.tabAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAdmin.BackgroundImage")));
            this.tabAdmin.Controls.Add(this.ID2);
            this.tabAdmin.Controls.Add(this.Kayed_Obeidat);
            this.tabAdmin.Controls.Add(this.ID1);
            this.tabAdmin.Controls.Add(this.Ammar_Omari);
            this.tabAdmin.Controls.Add(this.button1);
            this.tabAdmin.Controls.Add(this.btnSignIn);
            this.tabAdmin.Controls.Add(this.labelusername);
            this.tabAdmin.Controls.Add(this.labelpassword);
            this.tabAdmin.Controls.Add(this.AdminLabel);
            this.tabAdmin.Controls.Add(this.showPass);
            this.tabAdmin.Controls.Add(this.Password);
            this.tabAdmin.Controls.Add(this.UserName);
            this.tabAdmin.Location = new System.Drawing.Point(4, 29);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 55, 3, 3);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(866, 584);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.Text = "Admin";
            this.tabAdmin.Click += new System.EventHandler(this.tabAdmin_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.LightBlue;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Navy;
            this.btnSignIn.Location = new System.Drawing.Point(382, 373);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(141, 50);
            this.btnSignIn.TabIndex = 50;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            this.btnSignIn.MouseEnter += new System.EventHandler(this.btnSignIn_MouseEnter);
            this.btnSignIn.MouseLeave += new System.EventHandler(this.btnSignIn_MouseLeave);
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.BackColor = System.Drawing.Color.Transparent;
            this.labelusername.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelusername.Location = new System.Drawing.Point(258, 193);
            this.labelusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(87, 25);
            this.labelusername.TabIndex = 49;
            this.labelusername.Text = "User name";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.BackColor = System.Drawing.Color.Transparent;
            this.labelpassword.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelpassword.Location = new System.Drawing.Point(265, 274);
            this.labelpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(80, 25);
            this.labelpassword.TabIndex = 48;
            this.labelpassword.Text = "Password";
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminLabel.Location = new System.Drawing.Point(372, 86);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(165, 55);
            this.AdminLabel.TabIndex = 47;
            this.AdminLabel.Text = "Admin";
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.BackColor = System.Drawing.Color.White;
            this.showPass.FlatAppearance.BorderSize = 5;
            this.showPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showPass.Location = new System.Drawing.Point(542, 283);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(13, 12);
            this.showPass.TabIndex = 46;
            this.showPass.UseVisualStyleBackColor = false;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Password.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F);
            this.Password.Location = new System.Drawing.Point(349, 271);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(215, 33);
            this.Password.TabIndex = 44;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F);
            this.UserName.Location = new System.Drawing.Point(349, 190);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(215, 33);
            this.UserName.TabIndex = 43;
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.Color.Gray;
            this.tabUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabUser.BackgroundImage")));
            this.tabUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabUser.Controls.Add(this.BtnExit);
            this.tabUser.Controls.Add(this.noteLabel);
            this.tabUser.Controls.Add(this.btnCheckIn);
            this.tabUser.Controls.Add(this.labelFreeRooms);
            this.tabUser.Controls.Add(this.Welcome);
            this.tabUser.Controls.Add(this.btnCheckOut);
            this.tabUser.Controls.Add(this.txtBoxRoomID);
            this.tabUser.Controls.Add(this.RoomID);
            this.tabUser.Controls.Add(this.btnLeasing);
            this.tabUser.Controls.Add(this.viewFreeRooms);
            this.tabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUser.Location = new System.Drawing.Point(4, 29);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(866, 584);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.Click += new System.EventHandler(this.tabUser_Click);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.ForeColor = System.Drawing.Color.Aqua;
            this.noteLabel.Location = new System.Drawing.Point(437, 419);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(413, 20);
            this.noteLabel.TabIndex = 53;
            this.noteLabel.Text = "Pick number of room to Check-In OR to Check-Out";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.Navy;
            this.btnCheckIn.Location = new System.Drawing.Point(441, 457);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(182, 89);
            this.btnCheckIn.TabIndex = 52;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            this.btnCheckIn.MouseEnter += new System.EventHandler(this.btnCheckIn_MouseEnter);
            this.btnCheckIn.MouseLeave += new System.EventHandler(this.btnCheckIn_MouseLeave);
            // 
            // labelFreeRooms
            // 
            this.labelFreeRooms.AutoSize = true;
            this.labelFreeRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreeRooms.ForeColor = System.Drawing.Color.Aqua;
            this.labelFreeRooms.Location = new System.Drawing.Point(118, 190);
            this.labelFreeRooms.Name = "labelFreeRooms";
            this.labelFreeRooms.Size = new System.Drawing.Size(202, 29);
            this.labelFreeRooms.TabIndex = 51;
            this.labelFreeRooms.Text = "Availabe Rooms";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Welcome.Location = new System.Drawing.Point(110, 49);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(657, 75);
            this.Welcome.TabIndex = 50;
            this.Welcome.Text = "Welcome To HOLIDAY HOTEL";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Navy;
            this.btnCheckOut.Location = new System.Drawing.Point(651, 457);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(182, 89);
            this.btnCheckOut.TabIndex = 49;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            this.btnCheckOut.MouseEnter += new System.EventHandler(this.btnCheckOut_MouseEnter);
            this.btnCheckOut.MouseLeave += new System.EventHandler(this.btnCheckOut_MouseLeave);
            // 
            // txtBoxRoomID
            // 
            this.txtBoxRoomID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRoomID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxRoomID.Location = new System.Drawing.Point(551, 346);
            this.txtBoxRoomID.Name = "txtBoxRoomID";
            this.txtBoxRoomID.Size = new System.Drawing.Size(182, 44);
            this.txtBoxRoomID.TabIndex = 48;
            this.txtBoxRoomID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomID
            // 
            this.RoomID.AutoSize = true;
            this.RoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomID.ForeColor = System.Drawing.Color.Aqua;
            this.RoomID.Location = new System.Drawing.Point(581, 305);
            this.RoomID.Name = "RoomID";
            this.RoomID.Size = new System.Drawing.Size(130, 29);
            this.RoomID.TabIndex = 47;
            this.RoomID.Text = "Room No.";
            // 
            // btnLeasing
            // 
            this.btnLeasing.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLeasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeasing.ForeColor = System.Drawing.Color.Navy;
            this.btnLeasing.Location = new System.Drawing.Point(113, 457);
            this.btnLeasing.Name = "btnLeasing";
            this.btnLeasing.Size = new System.Drawing.Size(210, 89);
            this.btnLeasing.TabIndex = 46;
            this.btnLeasing.Text = "Guest";
            this.btnLeasing.UseVisualStyleBackColor = false;
            this.btnLeasing.Click += new System.EventHandler(this.btnLeasing_Click);
            this.btnLeasing.MouseEnter += new System.EventHandler(this.btnLeasing_MouseEnter);
            this.btnLeasing.MouseLeave += new System.EventHandler(this.btnLeasing_MouseLeave);
            // 
            // viewFreeRooms
            // 
            this.viewFreeRooms.AllowUserToAddRows = false;
            this.viewFreeRooms.AllowUserToDeleteRows = false;
            this.viewFreeRooms.AllowUserToResizeColumns = false;
            this.viewFreeRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFreeRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewFreeRooms.BackgroundColor = System.Drawing.Color.SlateGray;
            this.viewFreeRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewFreeRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewFreeRooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewFreeRooms.GridColor = System.Drawing.Color.Navy;
            this.viewFreeRooms.Location = new System.Drawing.Point(94, 240);
            this.viewFreeRooms.Name = "viewFreeRooms";
            this.viewFreeRooms.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFreeRooms.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.viewFreeRooms.Size = new System.Drawing.Size(244, 163);
            this.viewFreeRooms.TabIndex = 10;
            this.viewFreeRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewFreeRooms_CellContentClick);
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabUser);
            this.tabPages.Controls.Add(this.tabAdmin);
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPages.Location = new System.Drawing.Point(0, 0);
            this.tabPages.Name = "tabPages";
            this.tabPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(874, 617);
            this.tabPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPages.TabIndex = 39;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Red;
            this.BtnExit.Location = new System.Drawing.Point(773, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(93, 54);
            this.BtnExit.TabIndex = 54;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(767, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 55);
            this.button1.TabIndex = 55;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID2
            // 
            this.ID2.AutoSize = true;
            this.ID2.BackColor = System.Drawing.Color.Transparent;
            this.ID2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ID2.Location = new System.Drawing.Point(61, 190);
            this.ID2.Name = "ID2";
            this.ID2.Size = new System.Drawing.Size(65, 20);
            this.ID2.TabIndex = 59;
            this.ID2.Text = "20180943";
            // 
            // Kayed_Obeidat
            // 
            this.Kayed_Obeidat.AutoSize = true;
            this.Kayed_Obeidat.BackColor = System.Drawing.Color.Transparent;
            this.Kayed_Obeidat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kayed_Obeidat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Kayed_Obeidat.Location = new System.Drawing.Point(42, 159);
            this.Kayed_Obeidat.Name = "Kayed_Obeidat";
            this.Kayed_Obeidat.Size = new System.Drawing.Size(99, 20);
            this.Kayed_Obeidat.TabIndex = 58;
            this.Kayed_Obeidat.Text = "Kayed Obeidat";
            // 
            // ID1
            // 
            this.ID1.AutoSize = true;
            this.ID1.BackColor = System.Drawing.Color.Transparent;
            this.ID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ID1.Location = new System.Drawing.Point(54, 86);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(72, 18);
            this.ID1.TabIndex = 57;
            this.ID1.Text = "20180877";
            // 
            // Ammar_Omari
            // 
            this.Ammar_Omari.AutoSize = true;
            this.Ammar_Omari.BackColor = System.Drawing.Color.Transparent;
            this.Ammar_Omari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ammar_Omari.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ammar_Omari.Location = new System.Drawing.Point(42, 56);
            this.Ammar_Omari.Name = "Ammar_Omari";
            this.Ammar_Omari.Size = new System.Drawing.Size(101, 18);
            this.Ammar_Omari.TabIndex = 56;
            this.Ammar_Omari.Text = "Ammar Omari";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(874, 617);
            this.Controls.Add(this.tabPages);
            this.MinimumSize = new System.Drawing.Size(890, 656);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Activated += new System.EventHandler(this.SignInForm_Activated);
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResizeEnd += new System.EventHandler(this.SignInForm_ResizeEnd);
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFreeRooms)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtBoxRoomID;
        private System.Windows.Forms.Label RoomID;
        private System.Windows.Forms.Button btnLeasing;
        private System.Windows.Forms.DataGridView viewFreeRooms;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label labelFreeRooms;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label ID2;
        private System.Windows.Forms.Label Kayed_Obeidat;
        private System.Windows.Forms.Label ID1;
        private System.Windows.Forms.Label Ammar_Omari;
    }
}