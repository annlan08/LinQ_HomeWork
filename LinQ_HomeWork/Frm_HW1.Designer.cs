
namespace LinQ_HomeWork
{
    partial class Frm_HW1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxQuestion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDOWNPage = new System.Windows.Forms.Button();
            this.buttonUPPage = new System.Windows.Forms.Button();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.buttonAllOrder = new System.Windows.Forms.Button();
            this.buttonYearOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_log = new System.Windows.Forms.Button();
            this.button_yearCreated = new System.Windows.Forms.Button();
            this.button_BigSize = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewUP = new System.Windows.Forms.DataGridView();
            this.dataGridViewBUTT = new System.Windows.Forms.DataGridView();
            this.nwDataSet1 = new LinQ_HomeWork.NWDataSet();
            this.order_DetailsTableAdapter1 = new LinQ_HomeWork.NWDataSetTableAdapters.Order_DetailsTableAdapter();
            this.ordersTableAdapter1 = new LinQ_HomeWork.NWDataSetTableAdapters.OrdersTableAdapter();
            this.productsTableAdapter1 = new LinQ_HomeWork.NWDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBUTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxQuestion);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDOWNPage);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUPPage);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPage);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxYear);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAllOrder);
            this.splitContainer1.Panel1.Controls.Add(this.buttonYearOrder);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.button_log);
            this.splitContainer1.Panel1.Controls.Add(this.button_yearCreated);
            this.splitContainer1.Panel1.Controls.Add(this.button_BigSize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1096, 624);
            this.splitContainer1.SplitterDistance = 433;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 146;
            this.label2.Text = "學生成績功能列";
            // 
            // comboBoxQuestion
            // 
            this.comboBoxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQuestion.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxQuestion.FormattingEnabled = true;
            this.comboBoxQuestion.Location = new System.Drawing.Point(28, 539);
            this.comboBoxQuestion.Name = "comboBoxQuestion";
            this.comboBoxQuestion.Size = new System.Drawing.Size(372, 32);
            this.comboBoxQuestion.TabIndex = 145;
            this.comboBoxQuestion.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(27, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 14);
            this.label3.TabIndex = 143;
            this.label3.Text = "LINQ to Northwind DataSet - Products";
            // 
            // buttonDOWNPage
            // 
            this.buttonDOWNPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDOWNPage.ForeColor = System.Drawing.Color.Black;
            this.buttonDOWNPage.Location = new System.Drawing.Point(177, 455);
            this.buttonDOWNPage.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDOWNPage.Name = "buttonDOWNPage";
            this.buttonDOWNPage.Size = new System.Drawing.Size(137, 42);
            this.buttonDOWNPage.TabIndex = 139;
            this.buttonDOWNPage.Text = "下一頁";
            this.buttonDOWNPage.UseVisualStyleBackColor = false;
            this.buttonDOWNPage.Click += new System.EventHandler(this.buttonDOWNPage_Click);
            // 
            // buttonUPPage
            // 
            this.buttonUPPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonUPPage.ForeColor = System.Drawing.Color.Black;
            this.buttonUPPage.Location = new System.Drawing.Point(30, 455);
            this.buttonUPPage.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUPPage.Name = "buttonUPPage";
            this.buttonUPPage.Size = new System.Drawing.Size(137, 42);
            this.buttonUPPage.TabIndex = 140;
            this.buttonUPPage.Text = "上一頁";
            this.buttonUPPage.UseVisualStyleBackColor = false;
            this.buttonUPPage.Click += new System.EventHandler(this.buttonUPPage_Click);
            // 
            // textBoxPage
            // 
            this.textBoxPage.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxPage.Location = new System.Drawing.Point(28, 422);
            this.textBoxPage.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(180, 23);
            this.textBoxPage.TabIndex = 141;
            this.textBoxPage.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-127, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 142;
            this.label1.Text = "一頁幾筆";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(173, 359);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 14);
            this.label9.TabIndex = 138;
            this.label9.Text = "年:";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(225, 355);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(176, 21);
            this.comboBoxYear.TabIndex = 137;
            // 
            // buttonAllOrder
            // 
            this.buttonAllOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAllOrder.Location = new System.Drawing.Point(29, 250);
            this.buttonAllOrder.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAllOrder.Name = "buttonAllOrder";
            this.buttonAllOrder.Size = new System.Drawing.Size(372, 42);
            this.buttonAllOrder.TabIndex = 136;
            this.buttonAllOrder.Text = "All 訂單 ";
            this.buttonAllOrder.UseVisualStyleBackColor = false;
            this.buttonAllOrder.Click += new System.EventHandler(this.buttonAllOrder_Click);
            // 
            // buttonYearOrder
            // 
            this.buttonYearOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYearOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonYearOrder.Location = new System.Drawing.Point(29, 304);
            this.buttonYearOrder.Margin = new System.Windows.Forms.Padding(5);
            this.buttonYearOrder.Name = "buttonYearOrder";
            this.buttonYearOrder.Size = new System.Drawing.Size(372, 42);
            this.buttonYearOrder.TabIndex = 134;
            this.buttonYearOrder.Text = "     某年訂單 / 訂單明細";
            this.buttonYearOrder.UseVisualStyleBackColor = false;
            this.buttonYearOrder.Click += new System.EventHandler(this.buttonYearOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(26, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 14);
            this.label4.TabIndex = 127;
            this.label4.Text = "LINQ to FileInfo[]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(25, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 14);
            this.label5.TabIndex = 135;
            this.label5.Text = "LINQ to Northwind DataSet - Orders";
            // 
            // button_log
            // 
            this.button_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_log.Location = new System.Drawing.Point(29, 36);
            this.button_log.Margin = new System.Windows.Forms.Padding(5);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(372, 42);
            this.button_log.TabIndex = 125;
            this.button_log.Text = "     FileInfo[]  .Log  擋";
            this.button_log.UseVisualStyleBackColor = false;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // button_yearCreated
            // 
            this.button_yearCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_yearCreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_yearCreated.Location = new System.Drawing.Point(29, 88);
            this.button_yearCreated.Margin = new System.Windows.Forms.Padding(5);
            this.button_yearCreated.Name = "button_yearCreated";
            this.button_yearCreated.Size = new System.Drawing.Size(372, 42);
            this.button_yearCreated.TabIndex = 126;
            this.button_yearCreated.Text = "     FileInfo[]   - 2019 Created - order ";
            this.button_yearCreated.UseVisualStyleBackColor = false;
            this.button_yearCreated.Click += new System.EventHandler(this.button_yearCreated_Click);
            // 
            // button_BigSize
            // 
            this.button_BigSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BigSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_BigSize.Location = new System.Drawing.Point(30, 140);
            this.button_BigSize.Margin = new System.Windows.Forms.Padding(5);
            this.button_BigSize.Name = "button_BigSize";
            this.button_BigSize.Size = new System.Drawing.Size(372, 42);
            this.button_BigSize.TabIndex = 128;
            this.button_BigSize.Text = "     FileInfo[]   - 大檔案";
            this.button_BigSize.UseVisualStyleBackColor = false;
            this.button_BigSize.Click += new System.EventHandler(this.button_BigSize_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewUP);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewBUTT);
            this.splitContainer2.Size = new System.Drawing.Size(659, 624);
            this.splitContainer2.SplitterDistance = 296;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridViewUP
            // 
            this.dataGridViewUP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewUP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUP.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUP.Name = "dataGridViewUP";
            this.dataGridViewUP.RowTemplate.Height = 24;
            this.dataGridViewUP.Size = new System.Drawing.Size(655, 292);
            this.dataGridViewUP.TabIndex = 0;
            // 
            // dataGridViewBUTT
            // 
            this.dataGridViewBUTT.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewBUTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBUTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBUTT.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBUTT.Name = "dataGridViewBUTT";
            this.dataGridViewBUTT.RowTemplate.Height = 24;
            this.dataGridViewBUTT.Size = new System.Drawing.Size(655, 320);
            this.dataGridViewBUTT.TabIndex = 0;
            // 
            // nwDataSet1
            // 
            this.nwDataSet1.DataSetName = "NWDataSet";
            this.nwDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_HW1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 624);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_HW1";
            this.Text = "Frm_HW1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBUTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_yearCreated;
        private System.Windows.Forms.Button button_BigSize;
        private System.Windows.Forms.DataGridView dataGridViewUP;
        private System.Windows.Forms.DataGridView dataGridViewBUTT;
        private NWDataSet nwDataSet1;
        private NWDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private NWDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.Button buttonAllOrder;
        private System.Windows.Forms.Button buttonYearOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDOWNPage;
        private System.Windows.Forms.Button buttonUPPage;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Label label1;
        private NWDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.ComboBox comboBoxQuestion;
        private System.Windows.Forms.Label label2;
    }
}