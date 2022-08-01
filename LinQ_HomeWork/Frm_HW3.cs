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
    public partial class Frm_HW3 : Form
    {
        public Frm_HW3()
        {
            InitializeComponent();
            StudentList = MakesList();
            MakeComName();
        }

        List<Student> StudentList;
        Random ran = new Random();




        private List<Student> MakesList()
        {
            List<Student> list = new List<Student>();
            Student student = new Student();
            int count = student.StudentCount;

            for (int i = 0; i < count; i++)
            {
                list.Add(new Student(i, ran));
            }

            return list;
        }


        private void MakeComName()
        {
            foreach (Student student in StudentList)
            {
                comboBoxName.Items.Add(student.Name);
            }
        }

        private void buttonALLDATA_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = StudentList.Select(s => new
            {
                編號 = s.ID,
                姓名 = s.Name,
                國文 = s.Chinese,
                英文 = s.English,
                數學 = s.Math,
                總分 = s.Sum,
                平均 = s.Avg,
                最高 = s.Max,
                最低 = s.Min,
            }).ToList();

        }

        private void buttonOneGuy_Click(object sender, EventArgs e)
        {
            if (comboBoxName.Text == "") { return; }

            var q = StudentList.Where(s => s.Name == comboBoxName.Text);
            List<OneGuyGrade> G = new List<OneGuyGrade>();

            foreach (Student s in q)
            {
                G.Add(new OneGuyGrade("國文", s.Chinese) { });
                G.Add(new OneGuyGrade("英文", s.English) { });
                G.Add(new OneGuyGrade("數學", s.Math) { });
            }

            dataGridView1.DataSource = G;
            this.chart_ALL.Visible = false;
            this.chart_one.Visible = true;
            this.chart_one.DataSource = G;
            this.chart_one.Series[0].XValueMember = "name";
            this.chart_one.Series[0].YValueMembers = "value";
            this.chart_one.ChartAreas[0].AxisY.Maximum = 100;
            this.chart_one.ChartAreas[0].AxisY.Minimum = 0;
            this.chart_one.Series[0].Name = $"{comboBoxName.Text}成績";
            this.chart_one.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private class OneGuyGrade
        {
            public OneGuyGrade(string name, int value)
            {
                this.name = name;
                this.value = value;
            }

            public string name { get; set; }
            public int value { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<StudentRank> Ranks = new List<StudentRank>()
            {
                new StudentRank() { Rank="不及格"},
                new StudentRank() { Rank="D(60~69)"},
                new StudentRank() { Rank="C(70~79)"},
                new StudentRank() { Rank="B(80~89)"},
                new StudentRank() { Rank="A(90~99)"},
                new StudentRank() { Rank="100分"},

            };


            var chi = from s in StudentList
                      group s by FindRank(s.Chinese / 10) into g
                      select new { Rank = g.Key, ChineseCount = g.Count() };

            var eng = from s in StudentList
                      group s by FindRank(s.English / 10) into g
                      select new { Rank = g.Key, EnglishCount = g.Count() };

            var math = from s in StudentList
                       group s by FindRank(s.Math / 10) into g
                       select new { Rank = g.Key, MathCount = g.Count() };

            var L = (from R in Ranks
                     join C in chi on R.Rank equals C.Rank into chiRL
                     join E in eng on R.Rank equals E.Rank into engRL
                     join M in math on R.Rank equals M.Rank into mathRL
                     from RC in chiRL.DefaultIfEmpty()
                     from RE in engRL.DefaultIfEmpty()
                     from RM in mathRL.DefaultIfEmpty()
                     select new
                     {
                         Rank = R.Rank,
                         ChineseCount = RC != null ? RC.ChineseCount : 0,
                         EnglishCount = RE != null ? RE.EnglishCount : 0,
                         MathCount = RM != null ? RM.MathCount : 0,
                     }).ToList();


            this.chart_ALL.Visible = true;
            this.chart_one.Visible = false;
            dataGridView1.DataSource = L.OrderBy(l => l.Rank).ToList();
            this.chart_ALL.DataSource = L.ToList();
            this.chart_ALL.Series[0].XValueMember = "Rank";
            this.chart_ALL.Series[0].YValueMembers = "ChineseCount";
            this.chart_ALL.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart_ALL.Series[0].Name = "國文";
            this.chart_ALL.Series[1].XValueMember = "Rank";
            this.chart_ALL.Series[1].YValueMembers = "EnglishCount";
            this.chart_ALL.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart_ALL.Series[1].Name = "英文";
            this.chart_ALL.Series[2].XValueMember = "Rank";
            this.chart_ALL.Series[2].YValueMembers = "MathCount";
            this.chart_ALL.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart_ALL.Series[2].Name = "數學";
        }

        private class StudentRank
        {
            public string Rank { get; set; }
        }

        private string FindRank(int T)
        {
            if (T > 10 || T < 0) { return "錯誤"; }

            switch (T)
            {
                case 10:
                    return "100分";
                case 9:
                    return "A(90~99)";
                case 8:
                    return "B(80~89)";
                case 7:
                    return "C(70~79)";
                case 6:
                    return "D(60~69)";
                default:
                    return "不及格";
            }
        }

        private void buttonCon_Click(object sender, EventArgs e)
        {
            int i = 0;
            var q = StudentList.OrderByDescending(s => s.Sum).Select(s =>
            new
            {
                名次 = ++i,
                姓名 = s.Name,
                編號 = s.ID,
                國文 = s.Chinese,
                英文 = s.English,
                數學 = s.Math,
                總分 = s.Sum,
            });

            dataGridView1.DataSource = q.ToList();
        }

        private void buttonRankchi_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView1.DataSource = StudentList.OrderByDescending(s => s.Chinese).Select(s =>
                new
                {
                    名次 = ++i,
                    姓名 = s.Name,
                    編號 = s.ID,
                    國文 = s.Chinese,
                }).ToList();
        }

        private void buttonRnakEng_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView1.DataSource = StudentList.OrderByDescending(s => s.English).Select(s =>
            new
            {
                名次 = ++i,
                姓名 = s.Name,
                編號 = s.ID,
                英文 = s.English,
            }).ToList();
        }

        private void buttonRankMath_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView1.DataSource = StudentList.OrderByDescending(s => s.Math).Select(s =>
            new
            {
                名次 = ++i,
                姓名 = s.Name,
                編號 = s.ID,
                數學 = s.Math,
            }).ToList();
        }
    }
}
