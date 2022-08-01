using LinQ_HomeWork.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_HomeWork
{
    public partial class Frm_HW1 : Form
    {
        public Frm_HW1()
        {
            InitializeComponent();
            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);
            this.order_DetailsTableAdapter1.Fill(this.nwDataSet1.Order_Details);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            MakeYearList();
            StudentList = MakeStudentList();
            MakeQuestionList();
        }

        Student SFirst = new Student();
        List<Student> StudentList;


        #region

        private void button_log_Click(object sender, EventArgs e)
        {
            dataGridViewUP.DataSource = FindFile().Where(f => f.Extension == ".log").ToList();
        }

        private void button_yearCreated_Click(object sender, EventArgs e)
        {
            dataGridViewUP.DataSource = FindFile().Where(f => f.CreationTime.Year == 2019).ToList();
        }

        private void button_BigSize_Click(object sender, EventArgs e)
        {
            dataGridViewUP.DataSource = FindFile().Where(f => f.Length >= 50000).ToList();
        }

        private System.IO.FileInfo[] FindFile()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            return files;
        }

        #endregion

        #region

        private void buttonAllOrder_Click(object sender, EventArgs e)
        {
            dataGridViewUP.DataSource = this.nwDataSet1.Orders.ToList();
            dataGridViewBUTT.DataSource = this.nwDataSet1.Order_Details.ToList();
        }

        private void buttonYearOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxYear.Text == "") { return; }
            int year = Convert.ToInt32(comboBoxYear.Text);          
            dataGridViewUP.DataSource = this.nwDataSet1.Orders.Where(o => o.OrderDate.Year == year).ToList();
            dataGridViewBUTT.DataSource = this.nwDataSet1.Order_Details.Where(od => od.OrdersRow.OrderDate.Year == year).ToList();
        }

        private void MakeYearList()
        {
            var q = (this.nwDataSet1.Orders.Select(o => o.OrderDate.Year)).Distinct().ToList();
            foreach(int item in q)
            {
                comboBoxYear.Items.Add(item);
            }
        }

        #endregion

        #region
        private int SkipforBUTT = 0; //----->下一頁起始(加)
        private int SkipforUP = 0; //----->上一頁起始(減)
        private int MAX
        {
            get { return this.nwDataSet1.Products.ToList().Count(); }
        }
        private void buttonUPPage_Click(object sender, EventArgs e)
        {
            int T = Convert.ToInt32(textBoxPage.Text);
            SkipforBUTT = SkipforUP;
            SkipforUP = SkipforBUTT - T;
            if (SkipforBUTT <= 0) { SkipforUP = 0; SkipforBUTT = T; }
            Show_DataGrid(SkipforUP, T);
        }

        private void buttonDOWNPage_Click(object sender, EventArgs e)
        {
            int T = Convert.ToInt32(textBoxPage.Text);
            if (SkipforUP + T >= MAX) { return; }
            Show_DataGrid(SkipforBUTT, T);
            SkipforUP = SkipforBUTT;
            SkipforBUTT += T;
        }

        private void Show_DataGrid(int S, int T)
        {
            dataGridViewBUTT.DataSource = this.nwDataSet1.Products.Skip(S).Take(T).ToList();
        }
        #endregion

        #region
        private enum Question
        {
            共幾個學員 = 0,
            找出前面三個的學員所有科目成績 = 1,
            找出後面兩個的學員所有科目成績 = 2,
            找出ABC的學成績 = 3,
            找出學員B的成績 = 4,
            找出除了B學員的學員的所有成績bbb退學 = 5,
            數學不及格是誰 = 6,
            找出ABC學員國文數學兩科科目成績 = 7,
            個人所有科的成績計算 = 8
        }

        private void MakeQuestionList()
        {
            foreach(Question item in Enum.GetValues(typeof(Question)))
            {
                comboBoxQuestion.Items.Add(item);
            }
        }

        private void comboBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int T = (int)(Question)comboBoxQuestion.SelectedItem;
            switch (T)
            {
                case 0:
                    MessageBox.Show($"學生共{StudentList.Count}人");
                    dataGridViewUP.DataSource = StudentList;
                    break;
                case 1:
                    dataGridViewBUTT.DataSource = StudentList.OrderBy(s => s.ID).Take(3).ToList();
                    break;
                case 2:
                    dataGridViewBUTT.DataSource = StudentList.OrderByDescending(s => s.ID).Take(2).ToList();
                    break;
                case 3:
                    dataGridViewBUTT.DataSource = StudentList.Where(s => s.Name.ToUpper()[0] >= 'A' && s.Name.ToUpper()[0] <= 'C').ToList();
                    break;
                case 4:
                    dataGridViewBUTT.DataSource = StudentList.Where(s => s.Name.ToUpper()[0] == 'B').ToList();
                    break;
                case 5:
                    dataGridViewBUTT.DataSource = StudentList.Where(s => s.Name.ToUpper()[0] != 'B').ToList();
                    break;
                case 6:
                    dataGridViewBUTT.DataSource = StudentList.Where(s => s.Math < 60).ToList();
                    break;
                case 7:
                    dataGridViewBUTT.DataSource = StudentList.Where(s => s.Name.ToUpper()[0] >= 'A' && s.Name.ToUpper()[0] <= 'C').Select(s => new { s.ID, s.Name, s.Math, s.Chinese }).ToList();
                    break;
                case 8:
                    dataGridViewBUTT.DataSource = StudentList.Select(s => new { s.ID, s.Name, s.Max, s.Min, s.Sum, s.Avg }).ToList();
                    break;
                default:
                    MessageBox.Show("意外狀況,請通知管理員");
                    break;

            }

            #endregion

        }

        Random ran = new Random();

        private List<Student> MakeStudentList()
        {
            List<Student> T = new List<Student>();
            int StudentCount = SFirst.StudentCount;
            for(int i=0;i<StudentCount;i++)
            {
                T.Add(new Student(i,ran));
            }
            return T;
        }
    }
}
