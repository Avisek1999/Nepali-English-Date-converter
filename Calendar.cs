using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace NepaliDateConverter.Net
{
    /// <summary>
    /// Calendar calendar = new Calendar();
    /// </summary>
    public class Calendar : ICalendar
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public static SqlConnection conn = new SqlConnection(connectionString);

        private IDictionary<int, string> WeekNames;
        private IDictionary<int, string> EnglishMonthNames;
        private IDictionary<int, string> NepaliMonthNames;

        /// <summary>
        /// List of BS calendar months in each year
        /// </summary>
        public IDictionary<int, int[]> BSCalendar;

        /// <summary>
        /// Calendar calendar = new Calendar();
        /// </summary>
        public Calendar()
        {
            SetWeekNames();
            SetEnglishMonthNames();
            SetNepaliMonthNames();
            SetBSCalendar();
        }

        /// <summary>
        /// Will return Day of week for given day index
        /// </summary>
        /// <param name="day">1</param>
        /// <returns>Sunday</returns>
        public string GetDayOfWeek(int day)
        {
            if (day < 1 || day > 7)
                day = 1;
            return WeekNames[day];
        }

        /// <summary>
        /// Will return English month name for given month index
        /// </summary>
        /// <param name="month">2</param>
        /// <returns>February</returns>
        public string GetEnglishMonth(int month)
        {
            if (month < 1 || month > 12)
                return EnglishMonthNames[1];
            return EnglishMonthNames[month];
        }

        public int GetEnglishMonthCount()
        {
            return EnglishMonthNames.Count();
        }

        public int GetNepaliMonthCount()
        {
            return NepaliMonthNames.Count();
        }

        public int[] GetDaysInMonthBS(int year)
        {
            int[] days = new int[12];
            conn.Open();
            string sql = "SELECT * FROM tblBS_Calendar where year = '" + year + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dTable = new DataTable();
            dataAdapter.Fill(dTable);
            foreach (DataRow row in dTable.Rows)
            {
                days = row.ItemArray.Select(x => (int)x).ToArray();
            }
            conn.Close();
            return days;
        }

        public int[] GetYearRangeBS()
        {
            int[] value = new int[2];
            conn.Open();
            string sql1 = "SELECT MIN(year) AS max_yearBS from tblBS_Calendar";
            string sql2 = "SELECT MAX(year) AS min_yearBS from tblBS_Calendar";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            value[0] = (int)cmd1.ExecuteScalar();
            value[1] = (int)cmd2.ExecuteScalar();
            conn.Close();

            return value;
        }

        public int[] GetYearRangeAD()
        {
            int[] value = new int[2];
            int[] yearRangeBS = GetYearRangeBS();
            int minYearBS = yearRangeBS[0];
            int maxYearBS = yearRangeBS[1];

            int dateMin = DateConverter.ConvertToEnglish(minYearBS, 1, 1).Year;
            int dateMax = DateConverter.ConvertToEnglish(maxYearBS, 12, 28).Year - 1;

            value[0] = dateMin;
            value[1] = dateMax;

            return value;
        }

        public int GetNofDaysInEnglishMonth_regular(int monthId)
        {
            int nDays = 0;
            conn.Open();
            string sql = "select NoOfDays_regular from tblNoOfDaysInEnglishMonths where Id = '"+monthId+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                nDays = (int)cmd.ExecuteScalar();
                conn.Close();
                return nDays;
            }
            catch(NullReferenceException)
            {
                Debug.WriteLine("null reference exception thrown");
                conn.Close();
            }
            conn.Close();
            return 0;
        }

        public int GetNofDaysInEnglishMonth_leapyear(int monthId)
        {
            int nDays = 0;
            conn.Open();
            string sql = "select NoOfDays_leapyear from tblNoOfDaysInEnglishMonths where Id = '" + monthId + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                nDays = (int)cmd.ExecuteScalar();
                conn.Close();
                return nDays;
            }
            catch (NullReferenceException)
            {
                Debug.WriteLine("null reference exception thrown");
                conn.Close();
            }
            conn.Close();
            return 0;
        }

        /// <summary>
        /// Will return Nepali month name for given month index
        /// </summary>
        /// <param name="month">12</param>
        /// <returns>Chaitra</returns>
        public string GetNepaliMonth(int month)
        {
            if (month < 1 || month > 12)
                return NepaliMonthNames[1];
            return NepaliMonthNames[month];
        }

        /// <summary>
        /// Check if given year is Leap Year or not
        /// </summary>
        /// <param name="year">2016</param>
        /// <returns>True</returns>
        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        /// <summary>
        /// Check if given date is in valid English Date range or not.
        /// Only supports Date range between 1944 To 2033
        /// </summary>
        /// <param name="year">2017</param>
        /// <param name="month">5</param>
        /// <param name="day">8</param>
        /// <returns>True</returns>
        public bool ValidEnglishDate(int year, int month, int day)
        {
            int[] range = GetYearRangeAD();

            if (year < range[0] || year > range[1])
            {
                Debug.WriteLine("Year should be between 1944 - 2033 A.D.");
                return false;
            }

            if (month < 1 || month > 12)
            {
                Debug.WriteLine("Month should be between 1 - 12");
                return false;
            }

            if (day < 1 || day > 31)
            {
                Debug.WriteLine("Day should be between 1 - 31");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if Given date is in Valid Nepali date range or not.
        /// Only supports Date range Between 2000 To 2090
        /// </summary>
        /// <param name="year">2073</param>
        /// <param name="month">1</param>
        /// <param name="day">1</param>
        /// <returns>True</returns>
        public bool ValidNepaliDate(int year, int month, int day)
        {
            int[] range = GetYearRangeBS();

            if (year < range[0] || year > range[1])
            {
                Debug.WriteLine("Year should be between 2000 - 2090 B.S.");
                return false;
            }

            if (month < 1 || month > 12)
            {
                Debug.WriteLine("Month should be between 1 - 12");
                return false;
            }

            if (day < 1 || day > 32)
            {
                Debug.WriteLine("Day should be between 1 - 32");
                return false;
            }

            return true;
        }

        private IDictionary<int, string> SetDataToDictionary(string tableName)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            string sql = "SELECT * FROM " + tableName;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dTable = new DataTable();
            dataAdapter.Fill(dTable);
            foreach (DataRow row in dTable.Rows)
                dict.Add(Convert.ToInt32(row[0]), row[1].ToString());
            conn.Close();
            return dict;
        }

        private void SetWeekNames()
        {
            WeekNames = SetDataToDictionary("tblWeeks");
        }

        private void SetEnglishMonthNames()
        {
            EnglishMonthNames = SetDataToDictionary("tblEnglishMonthNames");
        }

        private void SetNepaliMonthNames()
        {
            NepaliMonthNames = SetDataToDictionary(tableName: "tblNepaliMonthNames");
        }

        public void SetBSCalendar()
        {
            BSCalendar = new Dictionary<int, int[]>();
            Calendar.conn.Open();
            int count = 0;
            string sql = "select * from tblBS_Calendar";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Calendar.conn);
            DataTable dTable = new DataTable();
            dataAdapter.Fill(dTable);

            foreach (DataRow row in dTable.Rows)
            {
                int[] newArray = row.ItemArray.Cast<int>().ToArray();
                BSCalendar.Add(count, newArray);
                count += 1;
            }
            Calendar.conn.Close();
        }
    }
}
