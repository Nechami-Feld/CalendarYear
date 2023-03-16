using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CalendarYear
{
    public partial class Calendar : Form
    {
        int month;
        int year;


        string DateAndTime;
        string SunShine;
        string SunSet;
        string Night;


        XDocument doc;
        string FilePath;


        public Calendar()
        {
            InitializeComponent();

            

            timer1.Start();

            lblTime.Text = DateTime.Now.ToLongTimeString();


            month = DateTime.Today.Month;
            year = DateTime.Today.Year;



            FilePath = @"D:\תכנות\c sharp\CalendarYear\CalendarYear\xmlTimes.xml";
            doc = XDocument.Load(FilePath);



            


            var tmpList = from item in doc.Root.Elements("Day")
                           select new
                           {
                               DateAndTime = item.Attribute("DateAndTime").Value,
                               SunShine = item.Attribute("SunShine").Value,
                               SunSet = item.Attribute("SunSet").Value,
                               Night = item.Attribute("Night").Value,
                           };




            InsertUserControls(month, year);


            DateAndTime = tmpList.First().DateAndTime;
            SunShine = tmpList.First().SunShine;
            SunSet =  tmpList.First().SunSet;
            Night = tmpList.First().Night;
            
            


        }

        private void InsertUserControls(int month, int year)
        {
            pnlUC.Controls.Clear();

            lblCurrentMonth.Text = ((Month)month).ToString();
            int week = 0, day = 1;

            while (day <= DateTime.DaysInMonth(year, month))
            {
                DateTime d = new DateTime(year, month, day);
                Cell UC = new Cell(d);

                UC.Location = new Point(UC.Size.Width * (int)d.DayOfWeek, UC.Size.Height * week);
                UC.CurrentDay = d;
                //UC.add1 += UC_add;
                //UC.update1 += UC_update1;
                //UC.delete1 += UC_delete1;



                pnlUC.Controls.Add(UC);

                day++;

                if (d.DayOfWeek == DayOfWeek.Saturday)
                    week++;
            }

            
        }

        private void btmBefore_Click(object sender, EventArgs e)
        {
            pnlUC.Controls.Clear();
            month--;
            if (month == 1)
            {
                month = 12;
                year--;
            }
            InsertUserControls(month, year);
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            pnlUC.Controls.Clear();
            month++;
            if (month == 12)
            {
                month = 1;
                year++;
            }
            InsertUserControls(month, year);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();


        


            if (DateTime.Now.ToShortTimeString() == SunShine)
            {
                //זריחה
                Console.Beep();
                Label l = new Label();
                l.Location = new Point(400, 400);
                l.AutoSize = false;
                l.Size = new Size(400, 200);
                l.Text = "זריחה";
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Font = new Font("Microsoft Sans Serif", 36);
                l.ForeColor = Color.Red;
            }

            if (DateTime.Now.ToShortTimeString() == SunSet)
            {
                Console.Beep();
                //שקיעה
            }

            if (DateTime.Now.ToShortTimeString() == Night)
            {
                Console.Beep();
                //צאת הכוכבים
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month); i++)
            {
                XElement c = new XElement("Day");
                c.Add(new XAttribute("DateAndTime", new DateTime(DateTime.Today.Year, DateTime.Today.Month,i+1).ToShortDateString()));// הוספת אטריביוט לתגית
                c.Add(new XAttribute("SunShine", DateTime.Today.ToShortTimeString()));// הוספת אטריביוט לתגית
                c.Add(new XAttribute("SunSet", DateTime.Today.ToShortTimeString()));// הוספת אטריביוט לתגית
                c.Add(new XAttribute("Night", DateTime.Today.ToShortTimeString()));// הוספת אטריביוט לתגית

                doc.Root.Add(c);
            }
            

            doc.Save(FilePath);// שמירת הקובץ
        }

     
    }
}
