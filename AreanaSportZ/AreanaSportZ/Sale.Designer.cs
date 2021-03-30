namespace AreanaSportZ
{
    partial class Sale
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
            this.dateSale = new System.Windows.Forms.DateTimePicker();
            this.cmbCus = new System.Windows.Forms.ComboBox();
            this.txtSaleNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDPro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNPro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnINTO = new System.Windows.Forms.Button();
            this.dataGridSale = new System.Windows.Forms.DataGridView();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.txtGET = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnCalco = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSale)).BeginInit();
            this.SuspendLayout();
            // 
            // dateSale
            // 
            this.dateSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSale.Location = new System.Drawing.Point(460, 71);
            this.dateSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateSale.Name = "dateSale";
            this.dateSale.Size = new System.Drawing.Size(118, 26);
            this.dateSale.TabIndex = 0;
            // 
            // cmbCus
            // 
            this.cmbCus.FormattingEnabled = true;
            this.cmbCus.Location = new System.Drawing.Point(663, 69);
            this.cmbCus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCus.Name = "cmbCus";
            this.cmbCus.Size = new System.Drawing.Size(210, 28);
            this.cmbCus.TabIndex = 1;
            // 
            // txtSaleNo
            // 
            this.txtSaleNo.Enabled = false;
            this.txtSaleNo.Location = new System.Drawing.Point(216, 71);
            this.txtSaleNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaleNo.Name = "txtSaleNo";
            this.txtSaleNo.Size = new System.Drawing.Size(148, 26);
            this.txtSaleNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "รหัสการขาย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "เวลา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "รหัสลูกค้า";
            // 
            // txtIDPro
            // 
            this.txtIDPro.Location = new System.Drawing.Point(216, 147);
            this.txtIDPro.Name = "txtIDPro";
            this.txtIDPro.Size = new System.Drawing.Size(96, 26);
            this.txtIDPro.TabIndex = 7;
            this.txtIDPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "รหัสสินค้า";
            // 
            // txtNPro
            // 
            this.txtNPro.Location = new System.Drawing.Point(393, 147);
            this.txtNPro.Name = "txtNPro";
            this.txtNPro.Size = new System.Drawing.Size(319, 26);
            this.txtNPro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "สินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "จำนวน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(840, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "ราคา";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(775, 147);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(58, 26);
            this.txtQTY.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(877, 150);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(99, 26);
            this.txtPrice.TabIndex = 14;
            // 
            // btnINTO
            // 
            this.btnINTO.Location = new System.Drawing.Point(746, 109);
            this.btnINTO.Name = "btnINTO";
            this.btnINTO.Size = new System.Drawing.Size(72, 32);
            this.btnINTO.TabIndex = 15;
            this.btnINTO.Text = "เพิ่ม";
            this.btnINTO.UseVisualStyleBackColor = true;
            this.btnINTO.Click += new System.EventHandler(this.btnINTO_Click);
            // 
            // dataGridSale
            // 
            this.dataGridSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSale.Location = new System.Drawing.Point(51, 195);
            this.dataGridSale.Name = "dataGridSale";
            this.dataGridSale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridSale.RowHeadersVisible = false;
            this.dataGridSale.Size = new System.Drawing.Size(902, 322);
            this.dataGridSale.TabIndex = 6;
            this.dataGridSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(402, 543);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(129, 26);
            this.txtSum.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 696);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "ซื้อ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(506, 696);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(347, 696);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ใหม่";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.Location = new System.Drawing.Point(824, 110);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(75, 31);
            this.btnClearGrid.TabIndex = 21;
            this.btnClearGrid.Text = "ล้าง";
            this.btnClearGrid.UseVisualStyleBackColor = true;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // txtGET
            // 
            this.txtGET.Location = new System.Drawing.Point(402, 575);
            this.txtGET.Name = "txtGET";
            this.txtGET.Size = new System.Drawing.Size(129, 26);
            this.txtGET.TabIndex = 22;
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(402, 607);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(129, 26);
            this.txtChange.TabIndex = 23;
            // 
            // btnCalco
            // 
            this.btnCalco.Location = new System.Drawing.Point(425, 639);
            this.btnCalco.Name = "btnCalco";
            this.btnCalco.Size = new System.Drawing.Size(75, 37);
            this.btnCalco.TabIndex = 24;
            this.btnCalco.Text = "คำนวน";
            this.btnCalco.UseVisualStyleBackColor = true;
            this.btnCalco.Click += new System.EventHandler(this.btnCalco_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "ราคารวม :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "รับเงิน :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 610);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "เงินทอน :";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.BackColor = System.Drawing.Color.Yellow;
            this.labelShow.Location = new System.Drawing.Point(1083, 38);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 20);
            this.labelShow.TabIndex = 28;
            this.labelShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1301, 749);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCalco);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtGET);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.btnINTO);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNPro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDPro);
            this.Controls.Add(this.dataGridSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaleNo);
            this.Controls.Add(this.cmbCus);
            this.Controls.Add(this.dateSale);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sale";
            this.Text = "ขายสินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateSale;
        private System.Windows.Forms.ComboBox cmbCus;
        private System.Windows.Forms.TextBox txtSaleNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDPro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNPro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnINTO;
        private System.Windows.Forms.DataGridView dataGridSale;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.TextBox txtGET;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnCalco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelShow;
    }
}