namespace AreanaSportZ
{
    partial class company
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupManege = new System.Windows.Forms.GroupBox();
            this.btnNextLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnBeforeFrist = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupSeve = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupManege.SuspendLayout();
            this.groupSeve.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(205, 62);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtNC
            // 
            this.txtNC.Location = new System.Drawing.Point(205, 88);
            this.txtNC.Name = "txtNC";
            this.txtNC.Size = new System.Drawing.Size(100, 20);
            this.txtNC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "รหัสบริษัท";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื่อบริษัท";
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
            this.groupManege.Location = new System.Drawing.Point(58, 171);
            this.groupManege.Name = "groupManege";
            this.groupManege.Size = new System.Drawing.Size(511, 89);
            this.groupManege.TabIndex = 16;
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // groupSeve
            // 
            this.groupSeve.Controls.Add(this.btnCancel);
            this.groupSeve.Controls.Add(this.btnSave);
            this.groupSeve.Location = new System.Drawing.Point(133, 129);
            this.groupSeve.Name = "groupSeve";
            this.groupSeve.Size = new System.Drawing.Size(315, 59);
            this.groupSeve.TabIndex = 15;
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
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
            // company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(626, 284);
            this.Controls.Add(this.groupManege);
            this.Controls.Add(this.groupSeve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNC);
            this.Controls.Add(this.txtID);
            this.Name = "company";
            this.Text = "company";
            this.Load += new System.EventHandler(this.company_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.company_KeyPress_1);
            this.groupManege.ResumeLayout(false);
            this.groupSeve.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupManege;
        private System.Windows.Forms.Button btnNextLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnBeforeFrist;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupSeve;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}