using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AreanaSportZ
{
    public partial class Category : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bs;
        bool edit;
        int num = 0;
    
        public Category()
        {
            InitializeComponent();
            conn = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=AreanaSport;Integrated Security=True");
            conn.Open();
            comm = new SqlCommand("SELECT * FROM CategoryAreana", conn);
            da = new SqlDataAdapter(comm);
            ds = new DataSet();
            bs = new BindingSource();
            da.Fill(ds, "CategoryAreana");
            conn.Close();
            if (ds.Tables["CategoryAreana"].Rows.Count >= 0)

                setCategory(0);
                enableForm(false);
                bs.DataSource = ds.Tables["CategoryAreana"];
        }

        public void setCategory(int row)
        {
            txtID.Text = ds.Tables["CategoryAreana"].Rows[row]["ID_Category"].ToString();
            txtNC.Text = ds.Tables["CategoryAreana"].Rows[row]["N_Category"].ToString();
        }

        public void setDS(int row)
        {
            ds.Tables["CategoryAreana"].Rows[row]["ID_Category"] = txtID.Text;
            ds.Tables["CategoryAreana"].Rows[row]["N_Category"] = txtNC.Text;

        }

        public void enableForm(bool enable)
        {
            if (!edit) { txtID.Enabled = enable; }
            txtNC.Enabled = enable;
        }

        public void clearFrom()
        {
            txtID.Clear();
            txtNC.Clear();
        }


        private void Category_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) SendKeys.Send("{TAB}");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearFrom();
            enableForm(true);
            groupManege.Visible = false;
            groupSeve.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบหรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bs.RemoveCurrent();
                //ds.Tables["ProductAreana"].Rows[num].Delete();
                if (num < ds.Tables["CategoryAreana"].Rows.Count - 1)
                {
                    num++;
                }
                else
                {
                    if (num != 0) num--; else clearFrom();
                }

                String sql;
                conn.Open();

                sql = "DELETE FROM CategoryAreana WHERE ID_Category = '" + txtID.Text + "'";

                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit = true;
            enableForm(true);
            groupManege.Visible = false;
            groupSeve.Visible = true;
            txtNC.Focus();
            SendKeys.Send("{DOWN}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql;
            conn.Open();
            if (edit)
            {
                setDS(num);
                sql = "UPDATE CategoryAreana SET N_Category =  '" + txtNC.Text + "'  WHERE ID_Category = '" + txtID.Text + "'";
            }
            else
            {
                DataRow d = ds.Tables["CategoryAreana"].NewRow();
                d["ID_Category"] = txtID.Text;
                d["N_Category"] = txtNC.Text;

                ds.Tables["CategoryAreana"].Rows.Add(d);
                sql = "INSERT INTO CategoryAreana (ID_Category,N_Category) VALUES ('" + txtID.Text + "','" + txtNC.Text + "')";
            }
            //comm.Connection = conn;
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            conn.Close();
            edit = false;
            enableForm(false);
            groupManege.Visible = true;
            groupSeve.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            edit = false;
            enableForm(false);
            groupManege.Visible = true;
            groupSeve.Visible = false;

        }

        private void btnBeforeFrist_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            setCategory(bs.Position);
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            setCategory(bs.Position);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            setCategory(bs.Position);
        }

        private void btnNextLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            setCategory(bs.Position);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Category_Load(object sender, EventArgs e)
        {

        }
    }
}
