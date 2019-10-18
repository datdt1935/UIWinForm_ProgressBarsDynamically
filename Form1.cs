using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://stackoverflow.com/questions/39181805/accessing-progressbar-in-listview
namespace ProgressBarsDynamically
{
    public partial class Form1 : Form
    {
        const int processbarSizeHeight = 25;
        public Form1()
        {
            InitializeComponent();
        }

        private BackgroundWorker backgroundWorker1 = new BackgroundWorker();
        private List<ProgressBar> bars = new List<ProgressBar>();
        private ProgressBar CurrentBar;

        private void btnRun_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 8; i++)
            {
                this.CreateNewProcessBar(i.ToString(), i);
            }

            backgroundWorker1.RunWorkerAsync();
        }
        private void CreateNewProcessBar(string name,int index)
        {
            ProgressBar item = new ProgressBar();
            item.Location = new System.Drawing.Point(100, index* processbarSizeHeight + index*10 + 10);
            item.Name = String.Format("processBar_{0}",name);
            item.Size = new System.Drawing.Size(400, processbarSizeHeight);
            item.TabIndex = 1;
          
            this.BeginInvoke(new Action(() =>
            {
                this.Controls.Add(item);
              
            }));
            this.bars.Add(item);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (ProgressBar bar in bars)
            {
                CurrentBar = bar;
                bar.Value = 0;
                for (int i = 1; i <= 100; i++)
                {
                    Thread.Sleep(10);
                    backgroundWorker1.ReportProgress(i);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CurrentBar.Value = e.ProgressPercentage;
        }

        private void AddLVItem(string key, string name, int value)
        {
            ListViewItem lvi = new ListViewItem();
            ProgressBar pb = new ProgressBar();

            lvi.SubItems[0].Text = name;
            lvi.SubItems.Add(value.ToString());
            lvi.SubItems.Add("");
            lvi.SubItems.Add(key);            // LV has 3 cols; this wont show
            lv.Items.Add(lvi);

            Rectangle r = lvi.SubItems[2].Bounds;
            pb.SetBounds(r.X, r.Y, r.Width, r.Height);
            pb.Minimum = 1;
            pb.Maximum = 100;
            pb.Value = value;
            pb.Name = key;                   // use the key as the name
            lv.Controls.Add(pb);
        }
        private void UpdateItemValue(string key, int value)
        {
            ListViewItem lvi;
            ProgressBar pb;

            // find the LVI based on the "key" in 
            lvi = lv.Items.Cast<ListViewItem>().FirstOrDefault(q => q.SubItems[3].Text == key);
            if (lvi != null)
                lvi.SubItems[1].Text = value.ToString();

            pb = lv.Controls.OfType<ProgressBar>().FirstOrDefault(q => q.Name == key);
            if (pb != null)
                pb.Value = value;
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            AddLVItem("A", "Worker Zig", 1);
            AddLVItem("B", "Jame Test", 1);
            AddLVItem("C", "Rob Task", 1);
            AddLVItem("D", "Kate HR", 1);
            this.btnCreateList.Enabled = false;
            this.btnChangeListValue.Enabled = true;
        }

        private void btnChangeListValue_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();

            UpdateItemValue("A", randNum.Next(1, 100));
            UpdateItemValue("B", randNum.Next(1, 100));
            UpdateItemValue("C", randNum.Next(1, 100));
            UpdateItemValue("D", randNum.Next(1, 100));
        }
    }
}
