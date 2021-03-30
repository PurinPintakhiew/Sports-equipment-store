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
    public partial class company : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bs;
        bool edit;
        int num = 0;

        public company()
        {
            InitializeComponent();
            conn = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=AreanaSport;Integrated Security=True");
            conn.Open();
            comm = new SqlCommand("SELECT * FROM Company", conn);
            da = new SqlDataAdapter(comm);
            ds = new DataSet();
            bs = new BindingSource();
            da.Fill(ds, "Company");
            conn.Close();
            if (ds.Tables["Company"].Rows.Count >= 0)

                setCompany(0);
            enableForm(false);
            bs.DataSource = ds.Tables["Company"];
        }

        public void setCompany(int row)
        {
            txtID.Text = ds.Tables["Company"].Rows[row]["ID_Company"].ToString();
            txtNC.Text = ds.Tables["Company"].Rows[row]["N_Company"].ToString();

        }

        public void setDS(int row)
        {
            ds.Tables["Company"].Rows[row]["ID_Company"] = txtID.Text;
            ds.Tables["Company"].Rows[row]["N_Company"] = txtNC.Text;

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

        private void company_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            edit = true;
            enableForm(true);
            groupManege.Visible = false;
            groupSeve.Visible = true;
            txtNC.Focus();
            SendKeys.Send("{DOWN}");
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
                edit = false;
                enableForm(false);
                groupManege.Visible = true;
                groupSeve.Visible = false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
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
                if (num < ds.Tables["Company"].Rows.Count - 1)
                {
                    num++;
                }
                else
                {
                    if (num != 0) num--; else clearFrom();
                }

                String sql;
                conn.Open();

                sql = "DELETE FROM Company WHERE ID_Company = '" + txtID.Text + "'";

                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql;
            conn.Open();
            if (edit)
            {
                setDS(num);
                sql = "UPDATE Company SET N_Company =  '" + txtNC.Text + "'  WHERE ID_Company = '" + txtID.Text + "'";
            }
            else
            {
                DataRow d = ds.Tables["Company"].NewRow();
                d["ID_Company"] = txtID.Text;
                d["N_Company"] = txtNC.Text;
                
                ds.Tables["Company"].Rows.Add(d);
                sql = "INSERT INTO Company (ID_Company,N_Company) VALUES ('" + txtID.Text + "','" + txtNC.Text + "')";
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

        private void btnBeforeFrist_Click(object sender, EventArgs e)
        {
            setCompany(0);
        }

        private void btnNextLast_Click(object sender, EventArgs e)
        {
            setCompany(ds.Tables["Company"].Rows.Count - 1);
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            if (num > 0) num--;
            setCompany(num);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (num < ds.Tables["Company"].Rows.Count-1) num++;
            setCompany(num);
        }

        private void company_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) SendKeys.Send("{TAB}");
        }
    }
}
