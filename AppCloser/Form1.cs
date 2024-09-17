using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AppCloser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRunningProcesses();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach (Process proc in listBox1.SelectedItems)
            {
                proc.Kill();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadRunningProcesses();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();
            foreach (Process proc in listBox1.Items)
            {
                if (proc.ProcessName.ToLower().Contains(searchText))
                {
                    listBox1.SelectedItem = proc;
                    break;
                }
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            int duration;
            if (int.TryParse(textBoxDuration.Text, out duration))
            {
                timerSearch.Interval = duration * 1000; // Convert seconds to milliseconds
                timerSearch.Start();
            }
            else
            {
                MessageBox.Show("يرجى إدخال مدة صحيحة.");
            }
        }

        private void timerSearch_Tick(object sender, EventArgs e)
        {
            LoadRunningProcesses();
        }

        private void buttonStartSearch_Click(object sender, EventArgs e)
        {
            LoadRunningProcesses();
        }

        private void LoadRunningProcesses()
        {
            listBox1.Items.Clear(); // تفريغ العناصر الحالية في ListBox
            try
            {
                Process[] processes = Process.GetProcesses(); // الحصول على جميع العمليات
                foreach (Process proc in processes)
                {
                    listBox1.Items.Add(proc.ProcessName); // إضافة اسم العملية إلى ListBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل العمليات: " + ex.Message); // عرض رسالة خطأ إذا حدثت مشكلة
            }

        }
    }
}
