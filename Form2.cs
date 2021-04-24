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
    public partial class AdminForm : Form
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
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter(select1, con);
            da.Fill(dt);
            viewAllRooms.DataSource = dt;
        }
        private void AdminForm_Activated(object sender, EventArgs e)
        {
            
        }
        private void txtBoxNewRID_TextChanged(object sender, EventArgs e)
        {

        }
        private void viewAllRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrEmpty(txtBoxNewRID.Text) || !int.TryParse(txtBoxNewRID.Text, out parsedValue))
            {
                MessageBox.Show("Please enter number of room!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Delete room? ", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.ToString() == "Yes")
                {
                    con.Close();
                    con.Open();
                    com.Connection = con;
                    //
                    com.CommandText = del + txtBoxNewRID.Text + " and isCheck!=1";
                    com.ExecuteNonQuery();
                    //
                    dt = new DataTable();
                    da = new SqlDataAdapter("SELECT ID as Room_Number,IDP as Personal_ID,isCheck as Vacancy from [Table]", con);
                    da.Fill(dt);
                    viewAllRooms.DataSource = dt;
                    con.Close();
                    
                }
            }
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrEmpty(txtBoxNewRID.Text)|| !int.TryParse(txtBoxNewRID.Text, out parsedValue))
            {
                MessageBox.Show("Please enter number of room!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("ADD a new room? ", "Add!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.ToString() == "Yes")
                {
                    con.Close();
                    con.Open();
                    com.Connection = con;
                    string sss= txtBoxNewRID.Text;
                    com.CommandText = "INSERT INTO [Table] VALUES ('" + sss + "', NULL , 0)";
                    com.Parameters.AddWithValue(sss, txtBoxNewRID.Text);
                    com.ExecuteNonQuery();
                    //
                    da = new SqlDataAdapter("SELECT ID as Room_Number,IDP as Personal_ID,isCheck as Vacancy from [Table] where ID='" + txtBoxNewRID.Text+"'", con);
                    da.Fill(dt);
                    viewAllRooms.DataSource = dt;
                    con.Close();
                }
            }
        }
        private void btnAddRoom_MouseEnter(object sender, EventArgs e)
        {
            btnAddRoom.BackColor = Color.Cyan;
        }
        private void btnAddRoom_MouseLeave(object sender, EventArgs e)
        {
            btnAddRoom.BackColor = Color.LightBlue;
        }
        private void btnDeleteRoom_MouseEnter(object sender, EventArgs e)
        {

        }
        private void btnBacktoSI_Click(object sender, EventArgs e)
        {
            Form SIN = new SignInForm();
            SIN.Show();
            this.Hide();
        }
        private void btnVacantRoom_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrEmpty(txtBoxNewRID.Text) || !int.TryParse(txtBoxNewRID.Text, out parsedValue))
            {
                MessageBox.Show("Please enter number of room!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Do you want to save changes? ", "Vacancy Room!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.ToString() == "Yes")
                {
                    con.Close();
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "UPDATE [Table] SET isCheck = 1, IDP = NULL WHERE ID = " + txtBoxNewRID.Text;
                    com.ExecuteNonQuery();
                    dt = new DataTable();
                    da = new SqlDataAdapter("SELECT ID as Room_Number,IDP as Personal_ID,isCheck as Vacancy from [Table]", con);
                    da.Fill(dt);
                    viewAllRooms.DataSource = dt;
                    con.Close();
                }
            }
        }
        private void btnKickCustomer_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrEmpty(txtBoxNewRID.Text) || !int.TryParse(txtBoxNewRID.Text, out parsedValue))
            {
                MessageBox.Show("Please enter number of room!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Do you really want to kick this customer?", "Kick Customer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.ToString() == "Yes")
                {
                    con.Close();
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "UPDATE [Table] SET isCheck = 0, IDP = NULL WHERE ID = " + txtBoxNewRID.Text;
                    com.ExecuteNonQuery();
                    dt = new DataTable();
                    da = new SqlDataAdapter("SELECT ID as Room_Number,IDP as Personal_ID,isCheck as Vacancy from [Table]", con);
                    da.Fill(dt);
                    viewAllRooms.DataSource = dt;
                    con.Close();
                }
            }
        }
        private void btnValid_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrEmpty(txtBoxNewRID.Text) || !int.TryParse(txtBoxNewRID.Text, out parsedValue))
            {
                MessageBox.Show("Please enter number of room!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Do you want to save changes? ", "Valid Room!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.ToString() == "Yes")
                {
                    con.Close();
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "UPDATE [Table] SET isCheck = 0, IDP = NULL WHERE ID = " + txtBoxNewRID.Text;
                    com.ExecuteNonQuery();
                    dt = new DataTable();
                    da = new SqlDataAdapter("SELECT ID as Room_Number,IDP as Personal_ID,isCheck as Vacancy from [Table]", con);
                    da.Fill(dt);
                    viewAllRooms.DataSource = dt;
                    con.Close();
                }
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit the program ? ", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r.ToString() == "Yes")
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void AdminForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void AdminForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar > 1) 
            {
                MessageBox.Show("Do you want to exit the program ? ", "Exit!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            
            if ("Key pressed: "+e.KeyChar == "A")
            {
                MessageBox.Show("Do you want to exit the program ? ", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            */
            
        }
    }
}
