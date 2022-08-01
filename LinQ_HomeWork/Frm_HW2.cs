using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_HomeWork
{
    public partial class Frm_HW2 : Form
    {
        public Frm_HW2()
        {
            InitializeComponent();
            this.productPhotoTableAdapter1.Fill(this.adDataSet1.ProductPhoto);
            MakeSeasonList();
            MakeYearList();
        }


        private void MakeYearList()
        {
            var q = (this.adDataSet1.ProductPhoto.Select(p => p.ModifiedDate.Year)).Distinct();
            foreach(int item in q)
            {
                comboBoxYear.Items.Add(item);
            }
        }

        private void buttonALL_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.adDataSet1.ProductPhoto.ToList();
        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            DateTime A = dateTimePickerA.Value;
            DateTime B = dateTimePickerB.Value;
            dataGridView1.DataSource = this.adDataSet1.ProductPhoto.Where(p => p.ModifiedDate >= A && p.ModifiedDate <= B).ToList();
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            if (comboBoxYear.Text == "") { return; }
            int T = (int)comboBoxYear.SelectedItem;
            var q = this.adDataSet1.ProductPhoto.Where(p => p.ModifiedDate.Year == T).ToList();
            dataGridView1.DataSource = q;
            labelYear.Text = q.Count().ToString();
        }

        private enum SeasonEnum //Dictionary
        {
            第一季 = 0,
            第二季 = 1,
            第三季 = 2,
            第四季 = 3,
        }

        private void MakeSeasonList()
        {
            foreach (SeasonEnum item in Enum.GetValues(typeof(SeasonEnum)))
            {
                this.comboBoxSeason.Items.Add(item);
            }
        }

        private void buttonSeason_Click(object sender, EventArgs e)
        {
            if (comboBoxSeason.Text == "") { return; }
            int T=(int)(SeasonEnum)this.comboBoxSeason.SelectedItem;
            var q = this.adDataSet1.ProductPhoto.Where(p => (p.ModifiedDate.Month - 1) / 3 == T).ToList();
            dataGridView1.DataSource = q;
            labelSeason.Text = q.Count.ToString();
        }

        private Image ConvertToImage(byte[] picBinary)
        {

            Image image = null;

            using (MemoryStream ms = new MemoryStream(picBinary))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1) { return; }
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            List<byte[]> bytelist = this.adDataSet1.ProductPhoto.Where(p => p.ProductPhotoID == id).Select(p => p.LargePhoto).ToList();
            byte[] pic = bytelist[0];
            pictureBoxA.Image = ConvertToImage(pic);
        }

        //private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
        //    List<byte[]> bytelist = this.adDataSet1.ProductPhoto.Where(p => p.ProductPhotoID == id).Select(p => p.LargePhoto).ToList();
        //    byte[] pic = bytelist[0];
        //    pictureBoxA.Image = ConvertToImage(pic);
        //}
    }
}
