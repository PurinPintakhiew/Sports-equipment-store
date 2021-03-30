namespace AreanaSportZ
{
    partial class Munu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Munu));
            this.btnSale = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSale.Location = new System.Drawing.Point(263, 89);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(94, 23);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "หน้าขาย";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.Color.Yellow;
            this.btnPro.Location = new System.Drawing.Point(263, 128);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(94, 23);
            this.btnPro.TabIndex = 1;
            this.btnPro.Text = "ข้อมูลสินค้า";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Red;
            this.btnCategory.Location = new System.Drawing.Point(263, 168);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(94, 23);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "ประเภทสินค้า";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCompany.Location = new System.Drawing.Point(263, 207);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(94, 23);
            this.btnCompany.TabIndex = 3;
            this.btnCompany.Text = "ข้อมูลบริษัทผู้ค้า";
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCustomer.Location = new System.Drawing.Point(263, 245);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(94, 23);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "ข้อมูลลูกค้า";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.Fuchsia;
            this.btnInput.Location = new System.Drawing.Point(263, 286);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(94, 23);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "นำเข้าสินค้า";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // Munu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 384);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.btnSale);
            this.Name = "Munu";
            this.Text = "Munu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnInput;
    }
}