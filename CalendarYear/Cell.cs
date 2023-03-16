using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CalendarYear
{
    public partial class Cell : UserControl
    {
        XDocument doc;
        string FilePath;

        public Cell(DateTime date)
        {
            InitializeComponent();

            SendToBack();

            if (date == DateTime.Today)
            {
                BackColor = Color.Aqua;
            }
            else
            {
                BackColor = Color.Yellow;
            }




            FilePath = @"D:\תכנות\c sharp\CalendarYear\CalendarYear\xmlTimes.xml";
            doc = XDocument.Load(FilePath);


            var ListDays = from item in doc.Root.Elements("Day")
                           select new
                           {
                               DateAndTime = item.Attribute("DateAndTime").Value,
                               SunShine = item.Attribute("SunShine").Value,
                               SunSet = item.Attribute("SunSet").Value,
                               Night = item.Attribute("Night").Value,
                           };





            try
            {
                var currentDay = ListDays.Where(a => a.DateAndTime == date.ToShortDateString()).First();
                lblSunShine.Text = currentDay.SunShine;
                lblSunSet.Text = currentDay.SunSet;
                lblNight.Text = currentDay.Night;
                lblError.Visible = false;

            }
            catch (Exception e)
            {
                lblSunShine.Text = string.Empty;
                lblSunSet.Text = string.Empty;
                lblNight.Text = string.Empty;
                label4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                lblError.Text = "אין נתונים במערכת";
            }




            lblCorrentDay.Text = date.ToShortDateString();
            lblDay.Text = ((daysHebrew)Enum.Parse(typeof(daysEnglish), date.DayOfWeek.ToString())).ToString();
        
        }


        public DateTime CurrentDay
        {
            get { return Convert.ToDateTime(lblCorrentDay.Text); }
            set { lblCorrentDay.Text = value.ToShortDateString(); }
        }

        private void Cell_DoubleClick(object sender, EventArgs e)
        {
            frmDay f = new frmDay(CurrentDay);
            f.Show();
        }

        



    }
}
