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
    public partial class Frm_HW4 : Form
    {
        public Frm_HW4()
        {
            InitializeComponent();
            ClearData();
        }

        NorthwindEntities dbContext = new NorthwindEntities();

        private void buttonFileSize_Click(object sender, EventArgs e)
        {
            ClearData();
            dataGridView2.DataSource = FindFile();


            var q = from f in FindFile()
                    orderby f.Length descending
                    group f by FileSize(f.Length) into g
                    select new { Key = g.Key, Count = g.Count(), Mygroup = g };

            this.dataGridView1.DataSource = q.Select(n => new { 大小 = n.Key, 數量 = n.Count }).ToList();

            foreach(var group in q)
            {
                TreeNode T0 = this.treeView1.Nodes.Add($"{group.Key}({group.Count})");

                foreach(var item in group.Mygroup)
                {
                    T0.Nodes.Add($"{item}({item.Length})");
                }
            }

            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "Key";
            this.chart1.Series[0].YValueMembers = "Count";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Name = "檔案大小";

        }

        private string FileSize(long L)
        {
            if (L < 1000) { return "<1000"; }
            if (L < 5000) { return "1000~5000"; }
            if (L < 10000) { return "5000~10000"; }
            if (L < 20000) { return "10000~20000"; }
            if (L < 30000) { return "20000~30000"; }
            if (L < 40000) { return "30000~40000"; }
            if (L < 50000) { return "40000~50000"; }
            return ">50000";
        }

        private void buttonFileYear_Click(object sender, EventArgs e)
        {
            ClearData();
            dataGridView2.DataSource = FindFile();

            var q = FindFile().GroupBy(f => f.CreationTime.Year).Select(y =>
                new
                {
                    Year = y.Key,
                    YearCount = y.Count(),
                    Ygroup = y.GroupBy(m => m.CreationTime.Month).Select(m =>
                    new 
                    {
                        Month=m.Key,
                        MonthCount=m.Count(),
                        Mgroup=m,
                    })
                }) ;

            dataGridView1.DataSource = q.Select(n => new { 年分 = n.Year, 數量 = n.YearCount }).ToList();
            this.chart1.DataSource= q.Select(n => new { 年分 = n.Year, 數量 = n.YearCount });
            this.chart1.Series[0].XValueMember = "年分";
            this.chart1.Series[0].YValueMembers = "數量";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Name = "年份檔案數量";

            foreach (var group in q)
            {
                TreeNode T0 = this.treeView1.Nodes.Add($"{group.Year}年({group.YearCount})");

                foreach(var Y in group.Ygroup)
                {
                    TreeNode T1 = T0.Nodes.Add($"{Y.Month}月({Y.MonthCount})");
                    foreach(var m in Y.Mgroup)
                    {
                        T1.Nodes.Add($"{m.Name}({m.Length})");           
                    }
                }
            }

        }

        private System.IO.FileInfo[] FindFile()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            return files;
        }

        private void ClearData()
        {
            this.treeView1.Nodes.Clear();
        }

        private void buttonProductPrice_Click(object sender, EventArgs e)
        {
            ClearData();
            dataGridView2.DataSource = dbContext.Products.ToList();

            var q = from p in dbContext.Products
                    orderby p.UnitPrice
                    select p;
            

            var q2 = from Q in q.AsEnumerable()
                     where (Q.UnitPrice != null)
                     group Q by GroupProductPrice(Q.UnitPrice) into g
                     select new { 價格 = g.Key, 數量 = g.Count(), Mygroup = g };

            dataGridView1.DataSource = q2.Select(n => new { n.價格, n.數量 }).ToList();
            this.chart1.DataSource = q2.ToList();
            this.chart1.Series[0].XValueMember = "價格";
            this.chart1.Series[0].YValueMembers = "數量";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Name = "產品價格";

            foreach(var group in q2)
            {
                TreeNode T0 = this.treeView1.Nodes.Add(group.價格.ToString());
                foreach(var item in group.Mygroup)
                {
                    T0.Nodes.Add($"{item.ProductName} ({item.UnitPrice:c2})");
                }
            }


        }

        private string GroupProductPrice(decimal? d)
        {
            if (d < 10) { return "<10"; }
            if (d < 25) { return "10~25"; }
            if (d < 50) { return "25~50"; }
            if (d < 75) { return "50~75"; }
            if (d < 100) { return "75~100"; }
            return ">100";
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            ClearData();

            var q = from o in dbContext.Order_Details.AsEnumerable()
                    select new { Sum = (decimal)o.UnitPrice * (decimal)o.Quantity * (decimal)(1 - o.Discount) };
            decimal TotalSum = 0;
            foreach (var s in q)
            {
                TotalSum += s.Sum;
            }
            MessageBox.Show($"總金額{TotalSum:c2}");
        }

        private void buttonBestSaler_Click(object sender, EventArgs e)
        {
            ClearData();

            dataGridView2.DataSource = dbContext.Order_Details.GroupBy(Emp => Emp.Order.EmployeeID).ToList();

            var q = dbContext.Order_Details.GroupBy(Emp => Emp.Order.Employee.FirstName).Select(Emp =>
            new
            {
                Name = Emp.Key,
                Sums = Emp.Sum(E => E.Product.UnitPrice * E.Quantity),
            });                    

            this.chart1.DataSource = q.Select(n => new { 編號 = n.Name, 業績 = n.Sums }).OrderBy(n=>n.業績).ToList();
            this.chart1.Series[0].XValueMember = "編號";
            this.chart1.Series[0].YValueMembers = "業績";
            this.chart1.Series[0].Name = "員工業績";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            dataGridView1.DataSource = q.Select(n => new { 編號 = n.Name, 業績 = n.Sums }).OrderByDescending(n => n.業績).Take(5).ToList();

        }

        private void buttonHighUnitPrice_Click(object sender, EventArgs e)
        {
            ClearData();

            var q = from p in dbContext.Products
                    orderby p.UnitPrice descending
                    select p;

            dataGridView2.DataSource = q.ToList();
            dataGridView1.DataSource = q.Take(5).ToList();

            this.chart1.DataSource = q.Select(p => new { 品名 = p.ProductName, 價格 = p.UnitPrice }).Take(5).ToList();
            this.chart1.Series[0].XValueMember = "品名";
            this.chart1.Series[0].YValueMembers = "價格";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Name = "最高價產品";
        }

        private void buttonPriceList_Click(object sender, EventArgs e)
        {
            ClearData();

            dataGridView2.DataSource = dbContext.Products.ToList();

            var q = dbContext.Products.GroupBy(p => p.Category.CategoryName).Select(p =>
                new
                {
                    CategoryName =p.Key,
                    Count = p.Count(),
                    ProductGroup = p,
                }) ;

            dataGridView1.DataSource = q.Select(p => new { 產品類型 = p.CategoryName, 數量 = p.Count }).ToList();
            this.chart1.DataSource = q.Select(p => new { 產品類型 = p.CategoryName, 數量 = p.Count }).ToList();
            this.chart1.Series[0].XValueMember = "產品類型";
            this.chart1.Series[0].YValueMembers = "數量";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Name = "產品數量";

            foreach(var group in q)
            {
                TreeNode T0 = this.treeView1.Nodes.Add($"{group.CategoryName}({group.Count})");

                foreach(var item in group.ProductGroup)
                {
                    T0.Nodes.Add($"{item.ProductName}({item.UnitPrice:c2})");
                }    
            }

        }

        private void buttonYearMonth_Click(object sender, EventArgs e)
        {
            ClearData();
            dataGridView2.DataSource = dbContext.Products.ToList();

            var q = dbContext.Orders.GroupBy(y => y.OrderDate.Value.Year).Select(y =>
            new
            {
                Year = y.Key,
                YearCount = y.Count(),
                Ygroup = y.GroupBy(m=>m.OrderDate.Value.Month).Select(m=>new                 
                { 
                    Month=m.Key,
                    MonthCount=m.Count(),
                    Mgroup=m,
                })
            });

            foreach (var group in q)
            {
                TreeNode T0 = this.treeView1.Nodes.Add($"{group.Year}年({group.YearCount})");

                foreach (var year in group.Ygroup)
                {
                    TreeNode T1 = T0.Nodes.Add($"{year.Month}月({year.MonthCount})");
                    foreach (var month in year.Mgroup)
                    {
                        T1.Nodes.Add($"顧客ID :{month.CustomerID} ({month.OrderDate})");
                    }
                }
            }

            dataGridView1.DataSource = q.Select(y => new { 年分 = y.Year, 數量 = y.YearCount }).ToList();
            this.chart1.DataSource = q.Select(y => new { year = y.Year, Count = y.YearCount }).ToList();
            this.chart1.Series[0].XValueMember = "year";
            this.chart1.Series[0].YValueMembers = "Count";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Name = "每年訂單數";
        }

        private void buttonYearSale_Click(object sender, EventArgs e)
        {
            var q = dbContext.Order_Details.AsEnumerable().GroupBy(o => o.Order.OrderDate.Value.Year).Select(o =>
            new
            {
                Year = o.Key,
                YearSale = o.Sum(p => (decimal)p.Quantity * p.Product.UnitPrice * (decimal)(1 - p.Discount))
            }
            );

            dataGridView1.DataSource = q.Select(s => new { 年 = s.Year, 銷售量 = s.YearSale }).ToList();

            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "Year";
            this.chart1.Series[0].YValueMembers = "YearSale";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Name = "年銷售";
        }

        private void buttonGrowUp_Click(object sender, EventArgs e)
        {

            var q = this.dbContext.Order_Details.OrderBy(d => d.Order.OrderDate).GroupBy(m => m.Order.OrderDate.Value.Month, y => y.Order.OrderDate.Value.Month).Select(o =>
         new
         {
             Season = o.Key,
             //Sales = o.Sum(s=>s.su)
         });


            dataGridView1.DataSource = q.ToList();


        }

    }
}
