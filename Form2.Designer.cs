namespace WindowsFormsApp1
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.viewAllRooms = new System.Windows.Forms.DataGridView();
            this.txtBoxNewRID = new System.Windows.Forms.TextBox();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.labelIDRoom = new System.Windows.Forms.Label();
            this.btnBacktoSI = new System.Windows.Forms.Button();
            this.btnVacantRoom = new System.Windows.Forms.Button();
            this.btnKickCustomer = new System.Windows.Forms.Button();
            this.btnValid = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllRooms
            // 
            this.viewAllRooms.AccessibleName = "";
            this.viewAllRooms.AllowUserToAddRows = false;
            this.viewAllRooms.AllowUserToDeleteRows = false;
            this.viewAllRooms.AllowUserToResizeColumns = false;
            this.viewAllRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            this.viewAllRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.viewAllRooms.BackgroundColor = System.Drawing.Color.SlateGray;
            this.viewAllRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewAllRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.viewAllRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewAllRooms.DefaultCellStyle = dataGridViewCellStyle8;
            this.viewAllRooms.GridColor = System.Drawing.Color.Navy;
            this.viewAllRooms.Location = new System.Drawing.Point(196, 12);
            this.viewAllRooms.MultiSelect = false;
            this.viewAllRooms.Name = "viewAllRooms";
            this.viewAllRooms.ReadOnly = true;
            this.viewAllRooms.Size = new System.Drawing.Size(343, 190);
            this.viewAllRooms.TabIndex = 10;
            this.viewAllRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAllRooms_CellContentClick);
            // 
            // txtBoxNewRID
            // 
            this.txtBoxNewRID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBoxNewRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewRID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxNewRID.Location = new System.Drawing.Point(277, 251);
            this.txtBoxNewRID.Name = "txtBoxNewRID";
            this.txtBoxNewRID.Size = new System.Drawing.Size(135, 31);
            this.txtBoxNewRID.TabIndex = 8;
            this.txtBoxNewRID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxNewRID.TextChanged += new System.EventHandler(this.txtBoxNewRID_TextChanged);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteRoom.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.Navy;
            this.btnDeleteRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoom.Image")));
            this.btnDeleteRoom.Location = new System.Drawing.Point(492, 343);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(195, 64);
            this.btnDeleteRoom.TabIndex = 7;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            this.btnDeleteRoom.MouseEnter += new System.EventHandler(this.btnDeleteRoom_MouseEnter);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRoom.Location = new System.Drawing.Point(258, 308);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(182, 103);
            this.btnAddRoom.TabIndex = 6;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            this.btnAddRoom.MouseEnter += new System.EventHandler(this.btnAddRoom_MouseEnter);
            this.btnAddRoom.MouseLeave += new System.EventHandler(this.btnAddRoom_MouseLeave);
            // 
            // labelIDRoom
            // 
            this.labelIDRoom.AutoSize = true;
            this.labelIDRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelIDRoom.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelIDRoom.Location = new System.Drawing.Point(281, 218);
            this.labelIDRoom.Name = "labelIDRoom";
            this.labelIDRoom.Size = new System.Drawing.Size(131, 32);
            this.labelIDRoom.TabIndex = 11;
            this.labelIDRoom.Text = "Room No.";
            // 
            // btnBacktoSI
            // 
            this.btnBacktoSI.BackColor = System.Drawing.Color.White;
            this.btnBacktoSI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBacktoSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoSI.ForeColor = System.Drawing.Color.Navy;
            this.btnBacktoSI.Image = ((System.Drawing.Image)(resources.GetObject("btnBacktoSI.Image")));
            this.btnBacktoSI.Location = new System.Drawing.Point(1, 0);
            this.btnBacktoSI.Name = "btnBacktoSI";
            this.btnBacktoSI.Size = new System.Drawing.Size(89, 54);
            this.btnBacktoSI.TabIndex = 33;
            this.btnBacktoSI.UseVisualStyleBackColor = false;
            this.btnBacktoSI.Click += new System.EventHandler(this.btnBacktoSI_Click);
            // 
            // btnVacantRoom
            // 
            this.btnVacantRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVacantRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacantRoom.ForeColor = System.Drawing.Color.Navy;
            this.btnVacantRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnVacantRoom.Image")));
            this.btnVacantRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVacantRoom.Location = new System.Drawing.Point(32, 343);
            this.btnVacantRoom.Name = "btnVacantRoom";
            this.btnVacantRoom.Size = new System.Drawing.Size(154, 64);
            this.btnVacantRoom.TabIndex = 34;
            this.btnVacantRoom.Text = "Occupied Room";
            this.btnVacantRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVacantRoom.UseVisualStyleBackColor = false;
            this.btnVacantRoom.Click += new System.EventHandler(this.btnVacantRoom_Click);
            // 
            // btnKickCustomer
            // 
            this.btnKickCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKickCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKickCustomer.ForeColor = System.Drawing.Color.Navy;
            this.btnKickCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnKickCustomer.Image")));
            this.btnKickCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKickCustomer.Location = new System.Drawing.Point(483, 247);
            this.btnKickCustomer.Name = "btnKickCustomer";
            this.btnKickCustomer.Size = new System.Drawing.Size(206, 82);
            this.btnKickCustomer.TabIndex = 35;
            this.btnKickCustomer.Text = "Kick Customer";
            this.btnKickCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKickCustomer.UseVisualStyleBackColor = false;
            this.btnKickCustomer.Click += new System.EventHandler(this.btnKickCustomer_Click);
            // 
            // btnValid
            // 
            this.btnValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValid.ForeColor = System.Drawing.Color.Navy;
            this.btnValid.Image = ((System.Drawing.Image)(resources.GetObject("btnValid.Image")));
            this.btnValid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValid.Location = new System.Drawing.Point(52, 251);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(134, 74);
            this.btnValid.TabIndex = 36;
            this.btnValid.Text = "Valid Room";
            this.btnValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValid.UseVisualStyleBackColor = false;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Red;
            this.BtnExit.Location = new System.Drawing.Point(629, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(96, 54);
            this.BtnExit.TabIndex = 37;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.btnKickCustomer);
            this.Controls.Add(this.btnVacantRoom);
            this.Controls.Add(this.btnBacktoSI);
            this.Controls.Add(this.labelIDRoom);
            this.Controls.Add(this.viewAllRooms);
            this.Controls.Add(this.txtBoxNewRID);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MaximumSize = new System.Drawing.Size(740, 489);
            this.MinimumSize = new System.Drawing.Size(740, 489);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Form";
            this.Activated += new System.EventHandler(this.AdminForm_Activated);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAllRooms;
        private System.Windows.Forms.TextBox txtBoxNewRID;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label labelIDRoom;
        private System.Windows.Forms.Button btnBacktoSI;
        private System.Windows.Forms.Button btnVacantRoom;
        private System.Windows.Forms.Button btnKickCustomer;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Button BtnExit;
    }
}