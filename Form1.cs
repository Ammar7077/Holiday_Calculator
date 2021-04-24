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
    public partial class CheckInForm : Form
    {
        public int sum = 0,days=1,av=999,cClicks = 0;
        //
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
        public CheckInForm()
        {
            InitializeComponent();
        }
        private void Holiday_Calculator_Click(object sender, EventArgs e)
        {

        }
        private void Logo_Click(object sender, EventArgs e)
        {

        }
        //LogThis
        private void LogThis(string t)
        {
            listBoxEvents.Items.Add( t + "      " + DateTime.Now.ToLongTimeString());
            listBoxEvents.SelectedIndex = listBoxEvents.Items.Count - 1;
        }
        //*******
        private void BreakFast_Click(object sender, EventArgs e)
        {

        }
        private bool isChecked()
        {
            return !(singleToolStripMenuItem.Checked || doubleToolStripMenuItem.Checked || deluxeToolStripMenuItem.Checked || familyToolStripMenuItem.Checked) || !(yesToolStripMenuItem.Checked || noToolStripMenuItem.Checked) || !(transportToolStripMenuItem.Checked || guideToolStripMenuItem.Checked || insuranceToolStripMenuItem.Checked);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isChecked())
            {
                MessageBox.Show("You have to pick at least one of (Rooms AND BreakFast AND Extras) ", "Wait!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show("Do you want to exit the program ? ", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.ToString() == "Yes")
                {
                    System.Windows.Forms.Application.ExitThread();
                }
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (isChecked())
            {
                MessageBox.Show("You have to pick at least one of (Rooms AND BreakFast AND Extras) ", "Wait!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show("Do you want to exit the program ? ", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.ToString() == "Yes")
                {
                    System.Windows.Forms.Application.ExitThread();
                }
            }
        }
        //---------------------------------
        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (yesToolStripMenuItem.Checked)
            {
                textBoxRate.Text = mSumDays().ToString();
                //
                noToolStripMenuItem.Checked = false;
                radioBtnYes.Checked = true;
            }
            else
            {
                sum -= 50;
                textBoxRate.Text = mSumDays().ToString();
                //
                radioBtnYes.Checked = false;
                LogThis("Yes menu Unchecked");
            }
        }
        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noToolStripMenuItem.Checked)
            {
                if (yesToolStripMenuItem.Checked)
                    sum -= 50;
                textBoxRate.Text = mSumDays().ToString();
                //
                yesToolStripMenuItem.Checked = false;
                radioBtnNo.Checked = true;
            }
            else
            {
                //textBox3.Text = sum.ToString();
                radioBtnNo.Checked = false;
                LogThis("No menu Unchecked");
            }
        }
        //----------------------------------
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (singleToolStripMenuItem.Checked)
            {
                sum -= 10;
            }
            if (doubleToolStripMenuItem.Checked)
            {
                sum -= 20;
            }
            if (deluxeToolStripMenuItem.Checked)
            {
                sum -= 30;
            }
            if (familyToolStripMenuItem.Checked)
            {
                sum -= 40;
            }
            //
            if (listBoxRooms.SelectedItem.ToString()=="Single")
            {
                singleToolStripMenuItem.Checked = true;
                //
                doubleToolStripMenuItem.Checked = false;
                deluxeToolStripMenuItem.Checked = false;
                familyToolStripMenuItem.Checked = false;
                //
                if (singleToolStripMenuItem.Checked)
                {
                    sum += 10;
                    LogThis("Sum Single Item");
                }
                else
                {
                    sum -= 10;
                    //
                    LogThis("Clear Items from (Rooms)");
                    listBoxRooms.ClearSelected();
                }
            }
            else if (listBoxRooms.SelectedItem.ToString() == "Double")
            {
                doubleToolStripMenuItem.Checked = true;
                //
                singleToolStripMenuItem.Checked = false;
                deluxeToolStripMenuItem.Checked = false;
                familyToolStripMenuItem.Checked = false;
                //
                if (doubleToolStripMenuItem.Checked)
                {
                    sum += 20;
                    LogThis("Sum Double Item");
                }
                else
                {
                    sum -= 20;
                    //
                    LogThis("Clear Items from (Rooms)");
                    listBoxRooms.ClearSelected();
                }
                    
            }
            else if (listBoxRooms.SelectedItem.ToString() == "Deluxe")
            {
                deluxeToolStripMenuItem.Checked = true;
                //
                singleToolStripMenuItem.Checked = false;
                doubleToolStripMenuItem.Checked = false;
                familyToolStripMenuItem.Checked = false;
                if (deluxeToolStripMenuItem.Checked)
                {
                    sum += 30;
                    LogThis("Sum Deluxe Item");
                }
                else
                {
                    sum -= 30;
                    //
                    LogThis("Clear Items from (Rooms)");
                    listBoxRooms.ClearSelected();
                }

            }
            else if(listBoxRooms.SelectedItem.ToString() == "Family")
            {
                familyToolStripMenuItem.Checked = true;
                //
                singleToolStripMenuItem.Checked = false;
                doubleToolStripMenuItem.Checked = false;
                deluxeToolStripMenuItem.Checked = false;
                if (familyToolStripMenuItem.Checked)
                {
                    sum += 40;
                    LogThis("Sum Deluxe Item");
                }
                else
                {
                    sum -= 40;
                    //
                    LogThis("Clear Items from (Rooms)");
                    listBoxRooms.SelectedIndex = -1;
                }
            }
            textBoxRate.Text = mSumDays().ToString();
                
        }
        //------------*******--------------
        private void radioBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnYes.Checked)
            {
                LogThis("Break Fast:   YES");
                yesToolStripMenuItem.Checked = true;
                noToolStripMenuItem.Checked = false;
                //
                sum += 50;
                textBoxRate.Text = mSumDays().ToString();
            }
            
        }
        private void radioBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNo.Checked)
            {
                if(yesToolStripMenuItem.Checked)
                    sum -= 50;
                LogThis("Break Fast:   NO");
                noToolStripMenuItem.Checked = true;
                yesToolStripMenuItem.Checked = false;
                
                
                textBoxRate.Text = mSumDays().ToString();
            }
        }
        //----------**********-------------####
        private void Transport_CheckedChanged(object sender, EventArgs e)
        {
            if (Transport.Checked)
            {
                LogThis("Transport:   YES");
                sum += 3;
                transportToolStripMenuItem.Checked = true;
            }
            else
            {
                sum -= 3;
                LogThis("Transport:   NO");
                transportToolStripMenuItem.Checked = false;
            }
            textBoxRate.Text = mSumDays().ToString();
        }
        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transportToolStripMenuItem.Checked)
            {
                Transport.Checked = true;
            }
            else
            {
                Transport.Checked = false;
            }
        }
        private void Guide_CheckedChanged(object sender, EventArgs e)
        {
            if (Guide.Checked)
            {
                sum += 6;
                LogThis("Guide:   YES");
                guideToolStripMenuItem.Checked = true;
            }
            else
            {
                sum -= 6;
                LogThis("Guide:   NO");
                guideToolStripMenuItem.Checked = false;
            }
            textBoxRate.Text = mSumDays().ToString();
        }
        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guideToolStripMenuItem.Checked)
            {
                Guide.Checked = true;
            }
            else
            {
                Guide.Checked = false;
            }
        }
        private void Insurance_CheckedChanged(object sender, EventArgs e)
        {
            if (Insurance.Checked)
            {
                sum += 9;
                LogThis("Insurance:   YES");
                insuranceToolStripMenuItem.Checked = true;
            }
            else
            {
                sum -= 9;
                LogThis("Insurance:   NO");
                insuranceToolStripMenuItem.Checked = false;
            }
            textBoxRate.Text = mSumDays().ToString();
        }
        private void insuranceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (insuranceToolStripMenuItem.Checked)
            {
                Insurance.Checked = true;
            }
            else
            {
                Insurance.Checked = false;
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            TFrom.Text = monthCalendar1.SelectionStart.ToString();
            TTo.Text = monthCalendar1.SelectionEnd.ToString();
            //
            TFrom.Text = monthCalendar1.SelectionStart.ToString();
            LogThis(TFrom.Text);
            //
            TTo.Text = monthCalendar1.SelectionEnd.ToString();
            LogThis(TTo.Text);
            //
            days = (int) monthCalendar1.SelectionRange.End.Date.Subtract(monthCalendar1.SelectionRange.Start.Date).TotalDays+1;
            //
            textBoxRate.Text = mSumDays().ToString();
            daysBox.Text = days.ToString();
        }
        // SUM * DAYS
        private int mSumDays()
        {
            return sum * days;
        }
        //-----------
        private void TFrom_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void TTo_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (singleToolStripMenuItem.Checked)
            {
                LogThis("Checked Single from Menu");
                listBoxRooms.SelectedItem = "Single";
                sum += 10;
                if (doubleToolStripMenuItem.Checked)
                {
                    sum -= 20;
                }
                if (deluxeToolStripMenuItem.Checked)
                {
                    sum -= 30;
                }
                if (familyToolStripMenuItem.Checked)
                {
                    sum -= 40;
                }
                doubleToolStripMenuItem.Checked = false;
                deluxeToolStripMenuItem.Checked = false;
                familyToolStripMenuItem.Checked = false;
            }
            else
            {
                sum -= 10;
                LogThis("Clear Items from (Rooms)");
            }
            textBoxRate.Text = mSumDays().ToString();
        }
        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doubleToolStripMenuItem.Checked)
            {
                LogThis("Checked Double from Menu");
                listBoxRooms.SelectedItem ="Double";
                sum += 20;
                if (singleToolStripMenuItem.Checked)
                {
                    sum -= 10;
                }
                if (deluxeToolStripMenuItem.Checked)
                {
                    sum -= 30;
                }
                if (familyToolStripMenuItem.Checked)
                {
                    sum -= 40;
                }
                singleToolStripMenuItem.Checked = false;
                deluxeToolStripMenuItem.Checked = false;
                familyToolStripMenuItem.Checked = false;
            }
            else
            {
                sum -= 20;
                LogThis("Clear Items from (Rooms)");
            }
            textBoxRate.Text = mSumDays().ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to clear all ?", "Clear!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r.ToString() == "Yes")
            {
                radioBtnYes.Checked = false;
                yesToolStripMenuItem.Checked = false;
                //
                radioBtnNo.Checked = false;
                noToolStripMenuItem.Checked = false;
                //
                singleToolStripMenuItem.Checked = false;
                doubleToolStripMenuItem.Checked = false;
                deluxeToolStripMenuItem.Checked = false;
                familyToolStripMenuItem.Checked = false;
                //
                Transport.Checked = false;
                transportToolStripMenuItem.Checked = false;
                Guide.Checked = false;
                guideToolStripMenuItem.Checked = false;
                Insurance.Checked = false;
                insuranceToolStripMenuItem.Checked = false;
                //
                TFrom.Text = "Cleared";
                TTo.Text = "Cleared";
                txtBoxPID.Text = "Cleared";
                //
                sum = 0;
                days = 1;
                daysBox.Text = days.ToString();
                textBoxRate.Text = sum.ToString();
            }
        }
        private void daysBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.Cyan;
        }
        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.LightBlue;
        }
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.YellowGreen;
        }
        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.LightBlue;
        }
        private void MyID_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString()=="C")
            {
                radioBtnYes.Checked= true;
            }
        }

        private void radioBtnYes_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Rooms_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string rid = SignInForm.txtB;
            int parsedValue;
            if (isChecked() || string.IsNullOrEmpty(txtBoxPID.Text) || !int.TryParse(txtBoxPID.Text, out parsedValue) || string.IsNullOrEmpty(rid))
            {
                MessageBox.Show("(Rooms OR BreakFast OR Extras) OR (personal ID) OR (the number of room) does not exist!, please check your inputs!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Do you want to save changes? ", "Check In?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.ToString() == "Yes")
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "UPDATE [Table] SET isCheck = 1 , IDP = " + txtBoxPID.Text + " WHERE ID = " + rid;
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_MouseEnter(object sender, EventArgs e)
        {
            btnCheckIn.BackColor = Color.LightGray;
        }

        private void btnCheckIn_MouseLeave(object sender, EventArgs e)
        {
            btnCheckIn.BackColor = Color.Turquoise;
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            //txtBoxRoomID.Text= SignInForm.txtB;
            //
            monthCalendar1.MinDate = monthCalendar1.TodayDate;
            monthCalendar1.MaxDate = monthCalendar1.TodayDate.AddMonths(6);
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chHide_CheckedChanged(object sender, EventArgs e)
        {
            if (isChecked()==true)
            {
                this.Hide();
            }
            else
            {
                this.Hide();
            }
        }

        private void btnBacktoSI_Click(object sender, EventArgs e)
        {
            Form SIN = new SignInForm();
            SIN.Show();
            this.Hide();
        }

        //*******

        private void deluxeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deluxeToolStripMenuItem.Checked)
            {
                LogThis("Checked Deluxe from Menu");
                listBoxRooms.SelectedItem ="Deluxe";
                sum += 30*days;
                if (doubleToolStripMenuItem.Checked)
                {
                    sum -= 20;
                }
                if (singleToolStripMenuItem.Checked)
                {
                    sum -= 10;
                }
                if (familyToolStripMenuItem.Checked)
                {
                    sum -= 40;
                }
                doubleToolStripMenuItem.Checked = false;
                singleToolStripMenuItem.Checked = false;
                familyToolStripMenuItem.Checked = false;
            }
            else
            {
                sum -= 30;
                LogThis("Clear Items from (Rooms)");
            }
            textBoxRate.Text = mSumDays().ToString();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Welcome.Left = ((CheckInForm.ActiveForm.Width - Logo.Width) - Welcome.Width) / 2;
        }


        private void familyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (familyToolStripMenuItem.Checked)
            {
                LogThis("Checked Family from Menu");
                listBoxRooms.SelectedItem = "Family";
                sum += 40*days;
                if (doubleToolStripMenuItem.Checked)
                {
                    sum -= 20;
                }
                if (deluxeToolStripMenuItem.Checked)
                {
                    sum -= 30;
                }
                if (singleToolStripMenuItem.Checked)
                {
                    sum -= 10;
                }
                doubleToolStripMenuItem.Checked = false;
                deluxeToolStripMenuItem.Checked = false;
                singleToolStripMenuItem.Checked = false;
            }
            else
            {
                sum -= 40;
                LogThis("Clear Items from (Rooms)");
            }
            textBoxRate.Text = mSumDays().ToString();
        }
    }
}
