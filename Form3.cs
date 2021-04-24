using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SignInForm : Form
    {
        public string path = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Windows 10 Pro\Desktop\study\الفصل الحالي\c#\PROJECTS\HW2\WindowsFormsApp1\WindowsFormsApp1\Holiday_Calculator\DB1.mdf;Integrated Security=True");
        //
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Windows 10 Pro\Desktop\study\الفصل الحالي\c#\PROJECTS\HW2\WindowsFormsApp1\WindowsFormsApp1\Holiday_Calculator\DB1.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        //
        public string select1 = "SELECT ID as Room_Number,IDP as Personal_ID,isCheck as Vacancy from [Table]";
        public string select2 = "SELECT ID as Room_Number,isCheck as Vacancy from [Table] where isCheck=0";
        public string del = "DELETE from [Table] where ID = ";
        //
        public static string txtB = "";
        // Forms to open
        Form CHIN, admin;
        //
        public SignInForm()
        {
            InitializeComponent();
        }
        private void tabUser_Click(object sender, EventArgs e)
        {

        }
        private void tabAdmin_Click(object sender, EventArgs e)
        {

        }
        private void btnLeasing_Click(object sender, EventArgs e)
        {
            CHIN = new CheckInForm();
            CHIN.Show();
            this.Hide();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrEmpty(txtBoxRoomID.Text)|| !int.TryParse(txtBoxRoomID.Text, out parsedValue))
            {
                MessageBox.Show("WRONG Room number!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Close();
                con.Open();
                com.Connection = con;
                com.CommandText = "UPDATE [Table] SET isCheck = 0 , IDP = NULL WHERE ID = " + txtBoxRoomID.Text;
                com.ExecuteNonQuery();
                dt = new DataTable();
                da.Fill(dt);
                viewFreeRooms.DataSource = dt;
                con.Close();
                //
                DialogResult r = MessageBox.Show("THANKS FOR YOUR VISIT! Do you want to Exit the programme?", ":-)", MessageBoxButtons.YesNo);
                if (r.ToString() == "Yes")
                {
                    System.Windows.Forms.Application.ExitThread();
                }
            }
        }
        private void SignIn_Click_1(object sender, EventArgs e)
        {

        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (UserName.Text=="admin" && Password.Text=="admin")
            {
                con.Open();
                this.Hide();
                admin = new AdminForm();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }
        private void SignInForm_Activated(object sender, EventArgs e)
        {
            da = new SqlDataAdapter(select2, con);
            dt = new DataTable();
            //da.Fill(dt);
            viewFreeRooms.DataSource = dt;
        }
        private void btnShowData_Click(object sender, EventArgs e)
        {

        }
        private void SignInForm_ResizeEnd(object sender, EventArgs e)
        {
            Welcome.Left = (SignInForm.ActiveForm.Width - Welcome.Width) / 2;
            labelFreeRooms.Left = (SignInForm.ActiveForm.Width - labelFreeRooms.Width) / 2-250;
            viewFreeRooms.Left = (SignInForm.ActiveForm.Width - viewFreeRooms.Width) / 2 - 250;
            btnLeasing.Left = (SignInForm.ActiveForm.Width - btnLeasing.Width) / 2 - 250;
            RoomID.Left = (SignInForm.ActiveForm.Width - RoomID.Width) / 2+180;
            txtBoxRoomID.Left = (SignInForm.ActiveForm.Width - txtBoxRoomID.Width) / 2 + 180;
            btnCheckOut.Left = (SignInForm.ActiveForm.Width - btnCheckOut.Width) / 2 + 300;
            btnCheckIn.Left = (SignInForm.ActiveForm.Width - btnCheckIn.Width) / 2 + 90;
            noteLabel.Left = (SignInForm.ActiveForm.Width - noteLabel.Width) / 2 + 180;
            //
            btnSignIn.Left = (SignInForm.ActiveForm.Width - btnSignIn.Width) / 2;
            showPass.Left = (SignInForm.ActiveForm.Width - showPass.Width) / 2+90;
            Password.Left = (SignInForm.ActiveForm.Width - Password.Width) / 2;
            labelpassword.Left = (SignInForm.ActiveForm.Width - labelpassword.Width) / 2-160;
            UserName.Left = (SignInForm.ActiveForm.Width - UserName.Width) / 2;
            labelusername.Left = (SignInForm.ActiveForm.Width - labelusername.Width) / 2-160;
            AdminLabel.Left = (SignInForm.ActiveForm.Width - AdminLabel.Width) / 2;
        }
        private void btnLeasing_MouseEnter(object sender, EventArgs e)
        {
            btnLeasing.BackColor = Color.LightGray;
        }
        private void btnLeasing_MouseLeave(object sender, EventArgs e)
        {
            btnLeasing.BackColor = Color.Cyan;
        }
        private void btnCheckOut_MouseEnter(object sender, EventArgs e)
        {
            btnCheckOut.BackColor = Color.Red;
            btnCheckOut.Text = "We are honored";
        }
        private void btnCheckOut_MouseLeave(object sender, EventArgs e)
        {
            btnCheckOut.BackColor = Color.Cyan;
            btnCheckOut.Text = "Check Out";
        }
        private void viewFreeRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnCheckIn_MouseEnter(object sender, EventArgs e)
        {
            btnCheckIn.BackColor = Color.LightGray;
            btnCheckIn.Text = "Welcome";
        }
        private void btnCheckIn_MouseLeave(object sender, EventArgs e)
        {
            btnCheckIn.BackColor = Color.Cyan;
            btnCheckIn.Text = "Check-In";
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrEmpty(txtBoxRoomID.Text) || !int.TryParse(txtBoxRoomID.Text, out parsedValue))
            {
                MessageBox.Show("WRONG Room number!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtB = txtBoxRoomID.Text;
                CHIN = new CheckInForm();
                CHIN.Show();
                this.Hide();
            }
        }
        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.LightGray;
        }
        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.LightBlue;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit the program ? ", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r.ToString() == "Yes")
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit the program ? ", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r.ToString() == "Yes")
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void MyID_Click(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
