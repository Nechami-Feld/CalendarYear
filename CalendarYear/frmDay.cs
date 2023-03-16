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
    public partial class frmDay : Form
    {

        XDocument doc;
        string FilePath;


        public frmDay()
        {
            InitializeComponent();

        }


        public frmDay(DateTime date)
        {
            InitializeComponent();

            timer1.Start();


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



            //dataGridView1.DataSource = ListDays.Where(a => a.DateAndTime == date.ToShortDateString()).ToList();
              var currentDay = ListDays.Where(a => a.DateAndTime == date.ToShortDateString()).First();
          


            lblDate.Text = date.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDay.Text  = ((daysHebrew)Enum.Parse(typeof(daysEnglish), date.DayOfWeek.ToString())).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
                MessageBox.Show("בחר משימה");
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtTask.Text);
            txtTask.Text = string.Empty;
        }

        private void btnReadTask_Click(object sender, EventArgs e)
        {
            frmTask f = new frmTask();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

      
    }
}
