namespace AreanaSportZ
{
    partial class Product
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
            this.lab1 = new System.Windows.Forms.Label();
            this.txtIDProduct = new System.Windows.Forms.TextBox();
            this.txtNProduct = new System.Windows.Forms.TextBox();
            this.lab2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lab3 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.CBXIDCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupSeve = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupManege = new System.Windows.Forms.GroupBox();
            this.btnNextLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnBeforeFrist = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupSeve.SuspendLayout();
            this.groupManege.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(111, 45);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(52, 13);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "รหัสสินค้า";
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.Location = new System.Drawing.Point(170, 41);
            this.txtIDProduct.MaxLength = 10;
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.Size = new System.Drawing.Size(112, 20);
            this.txtIDProduct.TabIndex = 1;
            this.txtIDProduct.TabStop = false;
            // 
            // txtNProduct
            // 
            this.txtNProduct.Location = new System.Drawing.Point(169, 75);
            this.txtNProduct.MaxLength = 60;
            this.txtNProduct.Name = "txtNProduct";
            this.txtNProduct.Size = new System.Drawing.Size(314, 20);
            this.txtNProduct.TabIndex = 8;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(110, 79);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(46, 13);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "ชื่อสินค้า";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(171, 111);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(112, 20);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(112, 115);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(30, 13);
            this.lab3.TabIndex = 4;
            this.lab3.Text = "ราคา";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(170, 146);
            this.txtQTY.MaxLength = 5;
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(112, 20);
            this.txtQTY.TabIndex = 10;
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(111, 150);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(40, 13);
            this.lab4.TabIndex = 6;
            this.lab4.Text = "จำนวน";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(80, 184);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(89, 13);
            this.lab5.TabIndex = 8;
            this.lab5.Text = "รหัสประเภทสินค้า";
            // 
            // CBXIDCategory
            // 
            this.CBXIDCategory.FormattingEnabled = true;
            this.CBXIDCategory.Location = new System.Drawing.Point(172, 182);
            this.CBXIDCategory.Name = "CBXIDCategory";
            this.CBXIDCategory.Size = new System.Drawing.Size(134, 21);
            this.CBXIDCategory.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupSeve
            // 
            this.groupSeve.Controls.Add(this.btnCancel);
            this.groupSeve.Controls.Add(this.btnSave);
            this.groupSeve.Location = new System.Drawing.Point(199, 222);
            this.groupSeve.Name = "groupSeve";
            this.groupSeve.Size = new System.Drawing.Size(315, 59);
            this.groupSeve.TabIndex = 13;
            this.groupSeve.TabStop = false;
            this.groupSeve.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(187, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 34);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupManege
            // 
            this.groupManege.Controls.Add(this.btnNextLast);
            this.groupManege.Controls.Add(this.btnNext);
            this.groupManege.Controls.Add(this.btnBefore);
            this.groupManege.Controls.Add(this.btnBeforeFrist);
            this.groupManege.Controls.Add(this.btnEdit);
            this.groupManege.Controls.Add(this.btnDelete);
            this.groupManege.Controls.Add(this.btnAdd);
            this.groupManege.Location = new System.Drawing.Point(124, 264);
            this.groupManege.Name = "groupManege";
            this.groupManege.Size = new System.Drawing.Size(511, 89);
            this.groupManege.TabIndex = 14;
            this.groupManege.TabStop = false;
            // 
            // btnNextLast
            // 
            this.btnNextLast.Location = new System.Drawing.Point(445, 37);
            this.btnNextLast.Name = "btnNextLast";
            this.btnNextLast.Size = new System.Drawing.Size(59, 30);
            this.btnNextLast.TabIndex = 7;
            this.btnNextLast.Text = ">>|";
            this.btnNextLast.UseVisualStyleBackColor = true;
            this.btnNextLast.Click += new System.EventHandler(this.btnNextLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(378, 36);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 30);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(309, 36);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(60, 30);
            this.btnBefore.TabIndex = 5;
            this.btnBefore.Text = "<<";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnBeforeFrist
            // 
            this.btnBeforeFrist.Location = new System.Drawing.Point(236, 35);
            this.btnBeforeFrist.Name = "btnBeforeFrist";
            this.btnBeforeFrist.Size = new System.Drawing.Size(65, 30);
            this.btnBeforeFrist.TabIndex = 4;
            this.btnBeforeFrist.Text = "|<<";
            this.btnBeforeFrist.UseVisualStyleBackColor = true;
            this.btnBeforeFrist.Click += new System.EventHandler(this.btnBeforeFrist_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(162, 35);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(89, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(743, 372);
            this.Controls.Add(this.groupManege);
            this.Controls.Add(this.groupSeve);
            this.Controls.Add(this.CBXIDCategory);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.txtNProduct);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.txtIDProduct);
            this.Controls.Add(this.lab1);
            this.KeyPreview = true;
            this.Name = "Product";
            this.Text = "จัดการสินค้า";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Product_KeyPress);
            this.groupSeve.ResumeLayout(false);
            this.groupManege.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox txtIDProduct;
        private System.Windows.Forms.TextBox txtNProduct;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.ComboBox CBXIDCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupSeve;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupManege;
        private System.Windows.Forms.Button btnBeforeFrist;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNextLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBefore;
    }
}

