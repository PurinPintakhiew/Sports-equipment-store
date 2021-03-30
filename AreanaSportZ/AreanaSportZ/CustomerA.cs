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
    public partial class CustomerA : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bs;
        bool edit;
        int num = 0;

        public CustomerA()
        {
            InitializeComponent();
            conn = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=AreanaSport;Integrated Security=True");
            conn.Open();
            comm = new SqlCommand("SELECT * FROM Custormer", conn);
            da = new SqlDataAdapter(comm);
            ds = new DataSet();
            bs = new BindingSource();
            da.Fill(ds, "Custormer");
            conn.Close();
            if (ds.Tables["Custormer"].Rows.Count >= 0)

                setCustomer(0);
                enableForm(false);
                bs.DataSource = ds.Tables["Custormer"];

        }

        public void setCustomer(int row)
        {
            txtID.Text = ds.Tables["Custormer"].Rows[row]["ID_Customer"].ToString();
            txtN.Text = ds.Tables["Custormer"].Rows[row]["Name"].ToString();
            txtAddress.Text = ds.Tables["Custormer"].Rows[row]["Address"].ToString();
            txtTel.Text = ds.Tables["Custormer"].Rows[row]["Tell"].ToString();
            txtEmail.Text = ds.Tables["Custormer"].Rows[row]["Email"].ToString();

        }

        public void setDS(int row)
        {
            ds.Tables["Custormer"].Rows[row]["ID_Customer"] = txtID.Text;
            ds.Tables["Custormer"].Rows[row]["Name"] = txtN.Text;
            ds.Tables["Custormer"].Rows[row]["Address"] = txtAddress.Text;
            ds.Tables["Custormer"].Rows[row]["Tell"] = txtTel.Text;
            ds.Tables["Custormer"].Rows[row]["Email"] = txtEmail.Text;
        }

        public void enableForm(bool enable)
        {
            if (!edit) { txtID.Enabled = enable; }
            txtN.Enabled = enable;
            txtAddress.Enabled = enable;
            txtTel.Enabled = enable;
            txtEmail.Enabled = enable;
        }

        public void clearFrom()
        {
            txtID.Clear();
            txtN.Clear();
            txtAddress.Clear();
            txtTel.Clear();
            txtEmail.Clear();
        }

        private void CustomerA_KeyPress(object sender, KeyPressEventArgs e)
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
                if (num < ds.Tables["Custormer"].Rows.Count - 1)
                {
                    num++;
                }
                else
                {
                    if (num != 0) num--; else clearFrom();
                }

                String sql;
                conn.Open();

                sql = "DELETE FROM Custormer WHERE ID_Customer = '" + txtID.Text + "'";

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
            txtN.Focus();
            SendKeys.Send("{DOWN}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql;
            conn.Open();
            if (edit)
            {
                setDS(num);
                sql = "UPDATE Custormer SET Name =  '" + txtN.Text + "',Address = '" + txtAddress.Text + "',Tell = '" + txtTel.Text + "',Email = '" + txtEmail.Text + "' WHERE ID_Customer = '" + txtID.Text + "'";
            }
            else
            {
                DataRow d = ds.Tables["Custormer"].NewRow();
                d["ID_Customer"] = txtID.Text;
                d["Name"] = txtN.Text;
                d["Address"] = txtAddress.Text;
                d["Tell"] = txtTel.Text;
                d["Email"] = txtEmail.Text;
                ds.Tables["Custormer"].Rows.Add(d);
                sql = "INSERT INTO Custormer (ID_Customer,Name,Address,Tell,Email) VALUES ('" + txtID.Text + "','" + txtN.Text + "','" + txtAddress.Text + "','" + txtTel.Text + "','" + txtEmail.Text + "')";
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
            //setCustomer(0);
            bs.MoveFirst();
            setCustomer(bs.Position);
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            /*if (num > 0) num--;
            setCustomer(num);*/
            bs.MovePrevious();
            setCustomer(bs.Position);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            /*if (num < ds.Tables["Custormer"].Rows.Count - 1) num++;
            setCustomer(num);*/
            bs.MoveNext();
            setCustomer(bs.Position);
        }

        private void btnNextLast_Click(object sender, EventArgs e)
        {
            //setCustomer(ds.Tables["Custormer"].Rows.Count - 1);
            bs.MoveLast();
            setCustomer(bs.Position);
        }
    }
}
