namespace AreanaSportZ
{
    partial class InputProduct
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
            this.txtIDInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.dataGridInput = new System.Windows.Forms.DataGridView();
            this.txtIDPro = new System.Windows.Forms.TextBox();
            this.txtNPro = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtInQTY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnINTO = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDInput
            // 
            this.txtIDInput.Enabled = false;
            this.txtIDInput.Location = new System.Drawing.Point(184, 57);
            this.txtIDInput.Name = "txtIDInput";
            this.txtIDInput.Size = new System.Drawing.Size(134, 20);
            this.txtIDInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสการนำเข้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "วันเวลา";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(382, 60);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(200, 20);
            this.dateInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "รหัสบริษัท";
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(659, 60);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(121, 21);
            this.cmbCom.TabIndex = 6;
            // 
            // dataGridInput
            // 
            this.dataGridInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInput.Location = new System.Drawing.Point(40, 158);
            this.dataGridInput.Name = "dataGridInput";
            this.dataGridInput.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridInput.RowHeadersVisible = false;
            this.dataGridInput.Size = new System.Drawing.Size(969, 298);
            this.dataGridInput.TabIndex = 7;
            // 
            // txtIDPro
            // 
            this.txtIDPro.Location = new System.Drawing.Point(108, 120);
            this.txtIDPro.Name = "txtIDPro";
            this.txtIDPro.Size = new System.Drawing.Size(70, 20);
            this.txtIDPro.TabIndex = 8;
            this.txtIDPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPro_KeyPress);
            // 
            // txtNPro
            // 
            this.txtNPro.Location = new System.Drawing.Point(234, 120);
            this.txtNPro.Name = "txtNPro";
            this.txtNPro.Size = new System.Drawing.Size(149, 20);
            this.txtNPro.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(425, 120);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(86, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(610, 117);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(70, 20);
            this.txtQTY.TabIndex = 11;
            // 
            // txtInQTY
            // 
            this.txtInQTY.Location = new System.Drawing.Point(756, 116);
            this.txtInQTY.Name = "txtInQTY";
            this.txtInQTY.Size = new System.Drawing.Size(66, 20);
            this.txtInQTY.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "รหัสสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "สินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ราคา";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "จำนวนปัจจุบัน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(694, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "จำนวนเข้า";
            // 
            // btnINTO
            // 
            this.btnINTO.Location = new System.Drawing.Point(843, 110);
            this.btnINTO.Name = "btnINTO";
            this.btnINTO.Size = new System.Drawing.Size(72, 32);
            this.btnINTO.TabIndex = 18;
            this.btnINTO.Text = "เพิ่ม";
            this.btnINTO.UseVisualStyleBackColor = true;
            this.btnINTO.Click += new System.EventHandler(this.btnINTO_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(553, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(631, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(553, 494);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ใหม่";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.Location = new System.Drawing.Point(934, 110);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(75, 31);
            this.btnClearGrid.TabIndex = 20;
            this.btnClearGrid.Text = "ล้าง";
            this.btnClearGrid.UseVisualStyleBackColor = true;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // InputProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnINTO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInQTY);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNPro);
            this.Controls.Add(this.txtIDPro);
            this.Controls.Add(this.dataGridInput);
            this.Controls.Add(this.cmbCom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDInput);
            this.Name = "InputProduct";
            this.Text = "นำเข้าสินค้า";
            this.Load += new System.EventHandler(this.InputProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.DataGridView dataGridInput;
        private System.Windows.Forms.TextBox txtIDPro;
        private System.Windows.Forms.TextBox txtNPro;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtInQTY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnINTO;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearGrid;
    }
}