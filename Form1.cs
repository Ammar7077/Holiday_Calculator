using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int sum = 0,days=1,av=999,cClicks = 0;
        

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            listBox2.Items.Add( t + "      " + DateTime.Now.ToLongTimeString());
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
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
                textBox3.Text = mSumDays().ToString();
                //
                noToolStripMenuItem.Checked = false;
                radioBtnYes.Checked = true;
            }
            else
            {
                sum -= 50;
                textBox3.Text = mSumDays().ToString();
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
                textBox3.Text = mSumDays().ToString();
                //
                yesToolStripMenuItem.Checked = false;
                radioBtnNo.Checked = true;
            }
            else
            {
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
            if (listBox1.SelectedItem.ToString()=="Single")
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
                    listBox1.ClearSelected();
                }
                    

            }
            else if (listBox1.SelectedItem.ToString() == "Double")
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
                    listBox1.ClearSelected();
                }
                    
            }
            else if (listBox1.SelectedItem.ToString() == "Deluxe")
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
                    listBox1.ClearSelected();
                }

            }
            else if(listBox1.SelectedItem.ToString() == "Family")
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
                    listBox1.SelectedIndex = -1;
                }
            }
            textBox3.Text = mSumDays().ToString();
                
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
                textBox3.Text = mSumDays().ToString();
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
                
                
                textBox3.Text = mSumDays().ToString();
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
            textBox3.Text = mSumDays().ToString();
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
            textBox3.Text = mSumDays().ToString();
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
            textBox3.Text = mSumDays().ToString();
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

            monthCalendar1.MinDate = monthCalendar1.TodayDate;
            monthCalendar1.MaxDate = monthCalendar1.TodayDate.AddMonths(6);
            //
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

            textBox3.Text = mSumDays().ToString();
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
        //*********
        private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (singleToolStripMenuItem.Checked)
            {
                LogThis("Checked Single from Menu");
                listBox1.SelectedItem = "Single";
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
                
            textBox3.Text = mSumDays().ToString();

        }
        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doubleToolStripMenuItem.Checked)
            {
                LogThis("Checked Double from Menu");
                listBox1.SelectedItem ="Double";
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
                
            textBox3.Text = mSumDays().ToString();
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
                //
                sum = 0;
                days = 1;
                daysBox.Text = days.ToString();
                textBox3.Text = sum.ToString();
            }



        }

        private void daysBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Hover
        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.Cyan;
        }
        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.LightBlue;
        }
        //
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.YellowGreen;
        }
        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.LightBlue;
        }


        //*******



        private void deluxeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deluxeToolStripMenuItem.Checked)
            {
                LogThis("Checked Deluxe from Menu");
                listBox1.SelectedItem ="Deluxe";
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
            textBox3.Text = mSumDays().ToString();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Holiday_Calculator.Left = ((Form1.ActiveForm.Width - Logo.Width) - Holiday_Calculator.Width) / 2;
        }


        private void familyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (familyToolStripMenuItem.Checked)
            {
                LogThis("Checked Family from Menu");
                listBox1.SelectedItem = "Family";
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
            textBox3.Text = mSumDays().ToString();
        }
    }
}
