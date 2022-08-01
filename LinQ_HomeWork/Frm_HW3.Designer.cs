
namespace LinQ_HomeWork
{
    partial class Frm_HW3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonALLDATA = new System.Windows.Forms.Button();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRankMath = new System.Windows.Forms.Button();
            this.buttonCon = new System.Windows.Forms.Button();
            this.buttonRnakEng = new System.Windows.Forms.Button();
            this.buttonRankchi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonOneGuy = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart_ALL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_one = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productPhotoTableAdapter1 = new LinQ_HomeWork.ADDataSetTableAdapters.ProductPhotoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonALLDATA);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxName);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOneGuy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1120, 613);
            this.splitContainer1.SplitterDistance = 533;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonALLDATA
            // 
            this.buttonALLDATA.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonALLDATA.Location = new System.Drawing.Point(33, 14);
            this.buttonALLDATA.Name = "buttonALLDATA";
            this.buttonALLDATA.Size = new System.Drawing.Size(244, 62);
            this.buttonALLDATA.TabIndex = 11;
            this.buttonALLDATA.Text = "顯示所有成績";
            this.buttonALLDATA.UseVisualStyleBackColor = true;
            this.buttonALLDATA.Click += new System.EventHandler(this.buttonALLDATA_Click);
            // 
            // comboBoxName
            // 
            this.comboBoxName.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(172, 98);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(105, 32);
            this.comboBoxName.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonRankMath);
            this.panel2.Controls.Add(this.buttonCon);
            this.panel2.Controls.Add(this.buttonRnakEng);
            this.panel2.Controls.Add(this.buttonRankchi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 158);
            this.panel2.TabIndex = 1;
            // 
            // buttonRankMath
            // 
            this.buttonRankMath.BackColor = System.Drawing.Color.Yellow;
            this.buttonRankMath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRankMath.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRankMath.Location = new System.Drawing.Point(250, 100);
            this.buttonRankMath.Name = "buttonRankMath";
            this.buttonRankMath.Size = new System.Drawing.Size(133, 31);
            this.buttonRankMath.TabIndex = 15;
            this.buttonRankMath.Text = "按數學";
            this.buttonRankMath.UseVisualStyleBackColor = false;
            this.buttonRankMath.Click += new System.EventHandler(this.buttonRankMath_Click);
            // 
            // buttonCon
            // 
            this.buttonCon.BackColor = System.Drawing.Color.Yellow;
            this.buttonCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCon.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCon.Location = new System.Drawing.Point(44, 40);
            this.buttonCon.Name = "buttonCon";
            this.buttonCon.Size = new System.Drawing.Size(133, 62);
            this.buttonCon.TabIndex = 12;
            this.buttonCon.Text = "排名";
            this.buttonCon.UseVisualStyleBackColor = false;
            this.buttonCon.Click += new System.EventHandler(this.buttonCon_Click);
            // 
            // buttonRnakEng
            // 
            this.buttonRnakEng.BackColor = System.Drawing.Color.Yellow;
            this.buttonRnakEng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRnakEng.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRnakEng.Location = new System.Drawing.Point(250, 63);
            this.buttonRnakEng.Name = "buttonRnakEng";
            this.buttonRnakEng.Size = new System.Drawing.Size(133, 31);
            this.buttonRnakEng.TabIndex = 14;
            this.buttonRnakEng.Text = "按英文";
            this.buttonRnakEng.UseVisualStyleBackColor = false;
            this.buttonRnakEng.Click += new System.EventHandler(this.buttonRnakEng_Click);
            // 
            // buttonRankchi
            // 
            this.buttonRankchi.BackColor = System.Drawing.Color.Yellow;
            this.buttonRankchi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRankchi.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRankchi.Location = new System.Drawing.Point(250, 26);
            this.buttonRankchi.Name = "buttonRankchi";
            this.buttonRankchi.Size = new System.Drawing.Size(133, 31);
            this.buttonRankchi.TabIndex = 13;
            this.buttonRankchi.Text = "按國文";
            this.buttonRankchi.UseVisualStyleBackColor = false;
            this.buttonRankchi.Click += new System.EventHandler(this.buttonRankchi_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(338, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "統計";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 298);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(527, 294);
            this.dataGridView2.TabIndex = 0;
            // 
            // buttonOneGuy
            // 
            this.buttonOneGuy.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonOneGuy.Location = new System.Drawing.Point(33, 82);
            this.buttonOneGuy.Name = "buttonOneGuy";
            this.buttonOneGuy.Size = new System.Drawing.Size(133, 62);
            this.buttonOneGuy.TabIndex = 8;
            this.buttonOneGuy.Text = "個別成績";
            this.buttonOneGuy.UseVisualStyleBackColor = true;
            this.buttonOneGuy.Click += new System.EventHandler(this.buttonOneGuy_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chart_ALL);
            this.splitContainer2.Panel1.Controls.Add(this.chart_one);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(583, 613);
            this.splitContainer2.SplitterDistance = 344;
            this.splitContainer2.TabIndex = 0;
            // 
            // chart_ALL
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ALL.ChartAreas.Add(chartArea1);
            this.chart_ALL.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_ALL.Legends.Add(legend1);
            this.chart_ALL.Location = new System.Drawing.Point(0, 0);
            this.chart_ALL.Name = "chart_ALL";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chart_ALL.Series.Add(series1);
            this.chart_ALL.Series.Add(series2);
            this.chart_ALL.Series.Add(series3);
            this.chart_ALL.Size = new System.Drawing.Size(581, 342);
            this.chart_ALL.TabIndex = 1;
            this.chart_ALL.Text = "chart1";
            // 
            // chart_one
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_one.ChartAreas.Add(chartArea2);
            this.chart_one.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_one.Legends.Add(legend2);
            this.chart_one.Location = new System.Drawing.Point(0, 0);
            this.chart_one.Name = "chart_one";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_one.Series.Add(series4);
            this.chart_one.Size = new System.Drawing.Size(581, 342);
            this.chart_one.TabIndex = 0;
            this.chart_one.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // productPhotoTableAdapter1
            // 
            this.productPhotoTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_HW3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1120, 613);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_HW3";
            this.Text = "Frm_HW3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ADDataSetTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter1;
        private System.Windows.Forms.Button buttonALLDATA;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRankMath;
        private System.Windows.Forms.Button buttonCon;
        private System.Windows.Forms.Button buttonRnakEng;
        private System.Windows.Forms.Button buttonRankchi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonOneGuy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_one;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ALL;
    }
}