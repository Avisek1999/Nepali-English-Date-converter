using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace NepaliDateConverter.Net
{
    public partial class DateConverterApp : Form
    {
        private static int yearAD = new Calendar().GetYearRangeAD()[1];
        private static int yearBS = new Calendar().GetYearRangeBS()[1];
        private int[] noOfDays = new Calendar().GetDaysInMonthBS(yearBS);

        public DateConverterApp()
        {
            InitializeComponent();
        }

        private void AddDataToComboBox()
        {
            Calendar calendar = new Calendar();
            for (int i = 1; i <= calendar.GetEnglishMonthCount(); i++)
                cbMonthAD.Items.Add(calendar.GetEnglishMonth(i));

            for(int i = 1; i <= calendar.GetNepaliMonthCount(); i++)
                cbMonthBS.Items.Add(calendar.GetNepaliMonth(i));

            int[] yearRangeBS = calendar.GetYearRangeBS();

            for (int i = yearRangeBS[0]; i <= yearRangeBS[1]; i++)
                cbYearBS.Items.Add(i);

            int[] yearRangeAD = calendar.GetYearRangeAD();

            for (int i = yearRangeAD[0]; i <= yearRangeAD[1]; i++)
                cbYearAD.Items.Add(i);


            for (int i = 1; i <= 32; i++)
                cbDayBS.Items.Add(i);

            int dayAD = Convert.ToInt32(DateTime.Now.ToString("dd"));
            int monthAD = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int yearAD = Convert.ToInt32(DateTime.Now.ToString("yyyy"));

            var dateBS = DateConverter.ConvertToNepali(yearAD, monthAD, dayAD);

            int dayBS = Convert.ToInt32(dateBS.Day);
            int monthBS = Convert.ToInt32(dateBS.Month);
            int yearBS = Convert.ToInt32(dateBS.Year);

            cbMonthBS.SelectedIndex = monthBS - 1;
            cbMonthAD.SelectedIndex = monthAD - 1;

            cbDayAD.SelectedIndex = dayAD - 1;
            cbDayBS.SelectedIndex = dayBS - 1;

            cbYearBS.SelectedItem = yearBS;
            cbYearAD.SelectedItem = yearAD;
        }

        private void btnConvertToAD_Click(object sender, EventArgs e)
        {
            int nepYear = Convert.ToInt32(cbYearBS.SelectedItem);
            int nepMonth = cbMonthBS.SelectedIndex + 1;
            int nepDay = Convert.ToInt32(cbDayBS.SelectedItem);
            var dt = DateConverter.ConvertToEnglish(nepYear, nepMonth, nepDay);
            string suffix = CheckSuffixForDay(dt.Day);
            lblOutputNepaliDate.Text = $"{dt.Day}{suffix} {dt.MonthName} {dt.Year} A.D, {dt.WeekDayName}";
        }

        private void btnConvertToBS_Click(object sender, EventArgs e)
        {
            int engYear = Convert.ToInt32(cbYearAD.SelectedItem);
            int engMonth = cbMonthAD.SelectedIndex + 1;
            int engDay = Convert.ToInt32(cbDayAD.SelectedItem);
            var dt = DateConverter.ConvertToNepali(engYear, engMonth, engDay);
            string suffix = CheckSuffixForDay(dt.Day);
            lblOutputEnglishDate.Text = $"{dt.Day}{suffix} {dt.MonthName} {dt.Year} B.S, {dt.WeekDayName}";
        }

        private string CheckSuffixForDay(int value)
        {
            if (value == 1)
                return "st";
            else if (value == 2)
                return "nd";
            else if (value == 3)
                return "rd";
            else return "th";
        }

        private void cbYearAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearAD = (int)cbYearAD.SelectedItem;
        }

        private void cbDayAD_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void NepaliDateConverterApp_Load(object sender, EventArgs e)
        {
            AddDataToComboBox();
            AddBSCalendar();
        }

        private void cbMonthAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            int monthID = cbMonthAD.SelectedIndex + 1;
            int noOfDays_regular = calendar.GetNofDaysInEnglishMonth_regular(monthID);
            int noOfDays_leapyear = calendar.GetNofDaysInEnglishMonth_leapyear(monthID);
            bool checkLeap = calendar.IsLeapYear(yearAD);
            if(checkLeap == true)
            {
                cbDayAD.Items.Clear();
                for (int i = 1; i <= noOfDays_leapyear; i++)
                    cbDayAD.Items.Add(i);
            }
            else
            {
                cbDayAD.Items.Clear();
                for (int i = 1; i <= noOfDays_regular; i++)
                    cbDayAD.Items.Add(i);
            }
            cbDayAD.SelectedIndex = cbDayAD.Items.Count - 1;
        }

        private void cbMonthBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int monthID = cbMonthBS.SelectedIndex + 1;
            int noOfDay = noOfDays[monthID];
            cbDayBS.Items.Clear();
            for (int i = 1; i <= noOfDay; i++)
                cbDayBS.Items.Add(i);
            cbDayBS.SelectedIndex = cbDayBS.Items.Count - 1;
        }

        private void cbYearBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearBS = (int)cbYearBS.SelectedItem;
            Calendar calendar = new Calendar();
            calendar.SetBSCalendar();
            noOfDays = calendar.GetDaysInMonthBS(yearBS);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cbJestha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBaishakh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAshad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbShrawan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBhadra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAshwin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbKarthik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMangsir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPoush_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMagh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFalgun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbChaitra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDateBS_Click(object sender, EventArgs e)
        {
            
        }

        private void AddBSCalendar()
        {
            lblDateBS.Text = (new Calendar().GetYearRangeBS()[1] + 1).ToString() + " B.S.";
            for(int i = 28; i <=32; i++)
            {
                cbBaishakh.Items.Add(i);
                cbJestha.Items.Add(i);
                cbAshad.Items.Add(i);
                cbShrawan.Items.Add(i);
                cbBhadra.Items.Add(i);
                cbAshwin.Items.Add(i);
                cbKarthik.Items.Add(i);
                cbMangsir.Items.Add(i);
                cbPoush.Items.Add(i);
                cbMagh.Items.Add(i);
                cbFalgun.Items.Add(i);
                cbChaitra.Items.Add(i);
            }

            cbBaishakh.SelectedIndex = 0;
            cbJestha.SelectedIndex = 0;
            cbAshad.SelectedIndex = 0;
            cbShrawan.SelectedIndex = 0;
            cbBhadra.SelectedIndex = 0;
            cbAshwin.SelectedIndex = 0;
            cbKarthik.SelectedIndex = 0;
            cbMangsir.SelectedIndex = 0;
            cbPoush.SelectedIndex = 0;
            cbMagh.SelectedIndex = 0;
            cbFalgun.SelectedIndex = 0;
            cbChaitra.SelectedIndex = 0;
        }

        private void btnAddDate_Click(object sender, EventArgs e)
        {
            int id = new Calendar().GetYearRangeBS()[1] + 1;

            int nD1 = Convert.ToInt32(cbBaishakh.SelectedItem);
            int nD2 = Convert.ToInt32(cbJestha.SelectedItem);
            int nD3 = Convert.ToInt32(cbAshad.SelectedItem);
            int nD4 = Convert.ToInt32(cbShrawan.SelectedItem);
            int nD5 = Convert.ToInt32(cbBhadra.SelectedItem);
            int nD6 = Convert.ToInt32(cbAshwin.SelectedItem);
            int nD7 = Convert.ToInt32(cbKarthik.SelectedItem);
            int nD8 = Convert.ToInt32(cbMangsir.SelectedItem);
            int nD9 = Convert.ToInt32(cbPoush.SelectedItem);
            int nD10 = Convert.ToInt32(cbMagh.SelectedItem);
            int nD11 = Convert.ToInt32(cbFalgun.SelectedItem);
            int nD12 = Convert.ToInt32(cbChaitra.SelectedItem);

            Calendar.conn.Open();

            string sql = "INSERT INTO tblBS_Calendar VALUES('" + id + "', '" + nD1 + "', '" + nD2 + "', '" + nD3 + "', '" + nD4 + "'," +
                "'" + nD5 + "', '" + nD6 + "', '" + nD7 + "', '" + nD8 + "', '" + nD9 + "', '" + nD10 + "', '" + nD11 + "', " +
                "'" + nD12 + "')";

            SqlCommand cmd = new SqlCommand(sql, Calendar.conn);
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                string message = $"{id} B.S. Calendar Added Successfully";
                string title = "Data Inserted";
                MessageBox.Show(message, title);
                lblDateBS.Text = (new Calendar().GetYearRangeBS()[1] + 1).ToString() + " B.S.";
            }
            Calendar.conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
