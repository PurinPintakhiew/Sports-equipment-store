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
    public partial class InputProduct : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bs;
        bool edit;
        int num = 0;

        public InputProduct()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.;Initial Catalog=AreanaSport;Integrated Security=True");
            conn.Open();
            comm = new SqlCommand("SELECT ID_Company,N_Company FROM Company", conn);
            da = new SqlDataAdapter(comm);
            ds = new DataSet();
            bs = new BindingSource();
            da.Fill(ds, "Company");
            cmbCom.DataSource = ds.Tables["Company"];
            cmbCom.DisplayMember = "N_Company";
            cmbCom.ValueMember = "ID_Company";
            conn.Close();
            enableForm(false);
        }

        private void InputProduct_Load(object sender, EventArgs e)
        {
            dateInput.Format = DateTimePickerFormat.Custom;
            dateInput.CustomFormat = "dd/MM/yy";
            dateInput.Value = DateTime.Today;
            conn.Open();
            string sql = "SELECT InputDetails.ID_Product,ProductAreana.N_Product,ProductAreana.Price,ProductAreana.QTY";
            sql += ",InputDetails.InQTY,InputDetails.InQTY+ProductAreana.QTY as totalQTY,InputDetails.InQTY*ProductAreana.Price as totalPrice";
            sql += " FROM InputDetails,ProductAreana WHERE InputDetails.ID_Product = ProductAreana.ID_Product";
            sql += " AND InputDetails.ID_Product is null";
            comm.CommandText = sql;
            //MessageBox.Show(sql);
            da.Fill(ds, "InputProduct");
            dataGridInput.DataSource = ds.Tables["InputProduct"];
            dataGridInput.Columns[0].HeaderText = "รหัสสินค้า";
            dataGridInput.Columns[1].HeaderText = "              รายการสินค้า";
            dataGridInput.Columns[2].HeaderText = "ราคา";
            dataGridInput.Columns[3].HeaderText = "จำนวนปัจจุบัน";
            dataGridInput.Columns[4].HeaderText = "จำนวนเข้า";
            dataGridInput.Columns[5].HeaderText = "รวมจำนวนทั้งหมด";
            dataGridInput.Columns[6].HeaderText = "ราคารวม";
            dataGridInput.Columns[1].Width = 500;

        }

        private void txtIDPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                comm.CommandText = "SELECT * FROM ProductAreana WHERE ID_Product ='" + txtIDPro.Text + "'";
                da.Fill(ds, "ProductAreana");
                conn.Close();
                if (ds.Tables["ProductAreana"].Rows.Count == 0) MessageBox.Show("ไม่มีสินค้าเหล่านี้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    txtNPro.Text = ds.Tables["ProductAreana"].Rows[0]["N_Product"].ToString();
                    txtPrice.Text = ds.Tables["ProductAreana"].Rows[0]["Price"].ToString();
                    txtQTY.Text = ds.Tables["ProductAreana"].Rows[0]["QTY"].ToString();
                    btnINTO.Focus();
                    ds.Tables["ProductAreana"].Clear();
                }
            }
        }

        private void btnINTO_Click(object sender, EventArgs e)
        {


            DataRow d = ds.Tables["InputProduct"].NewRow();
            d["ID_Product"] = txtIDPro.Text;
            d["N_Product"] = txtNPro.Text;
            d["Price"] = txtPrice.Text;
            d["QTY"] = txtQTY.Text;
            d["InQTY"] = txtInQTY.Text;
            d["totalQTY"] = Convert.ToDouble(txtQTY.Text) + Convert.ToDouble(txtInQTY.Text);
            d["totalPrice"] = Convert.ToDouble(txtPrice.Text) + Convert.ToDouble(txtQTY.Text);
            ds.Tables["InputProduct"].Rows.Add(d);
            clearPro();
        }

        public void clearPro()
        {
            txtIDPro.Clear();
            txtNPro.Clear();
            txtPrice.Clear();
            txtQTY.Clear();
            txtInQTY.Clear();
            
        }

        public void clearFrom()
        {
            txtIDInput.Clear();
            while(dataGridInput.Rows.Count > 1)
            {
                dataGridInput.Rows.RemoveAt(0);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql1,sql2,sql3;
            DateTime time = dateInput.Value;
            string format = "yyyy-MM-dd";
            conn.Open();
            sql1 = "INSERT INTO Input_Product (ID_Company,InDate) Values ('" + cmbCom.SelectedValue.ToString() + "','" + time.ToString(format) + "')";
            MessageBox.Show(sql1);
            comm.CommandText = sql1;
            comm.ExecuteNonQuery();

            comm.CommandText = "select top 1 * from Input_Product order by ID_Input desc";
            da.Fill(ds, "Input_Product");
            txtIDInput.Text = ds.Tables["Input_Product"].Rows[0]["ID_Input"].ToString();
            ds.Tables["Input_Product"].Clear();

            for (int i = 0; i < dataGridInput.Rows.Count - 1; i++)
            {
                sql2 = "INSERT INTO InputDetails  VALUES (" + txtIDInput.Text + ",'" + dataGridInput.Rows[i].Cells["ID_Product"].Value + "'," + dataGridInput.Rows[i].Cells["Price"].Value + ",";
                sql2 += " " + dataGridInput.Rows[i].Cells["InQTY"].Value + ") ";
                MessageBox.Show(sql2);
                comm.CommandText = sql2;
                comm.ExecuteNonQuery();

                sql3  = "UPDATE ProductAreana SET QTY =  "+ dataGridInput.Rows[i].Cells["totalQTY"].Value + " WHERE ID_Product = '" + dataGridInput.Rows[i].Cells["ID_Product"].Value + "'";
                MessageBox.Show(sql3);
                comm.CommandText = sql3;
                comm.ExecuteNonQuery();
            }
            conn.Close();
            edit = false;
            enableForm(false);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearFrom();
            enableForm(true);
            
        }

        public void enableForm(bool enable)
        {
            
            txtIDPro.Enabled = enable;
            txtNPro.Enabled = enable;
            txtPrice.Enabled = enable;
            txtQTY.Enabled = enable;
            txtInQTY.Enabled = enable;
            dateInput.Enabled = enable;
            cmbCom.Enabled = enable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x; 
            String sql, sql1,sql2;
            conn.Open();
            if (MessageBox.Show("คุณต้องการลบหรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridInput.Rows.Count - 1;i++)
                {
                    x = Convert.ToInt32(dataGridInput.Rows[i].Cells["totalQTY"].Value) - Convert.ToInt32(dataGridInput.Rows[i].Cells["InQTY"].Value);
                    sql2 = "UPDATE ProductAreana SET QTY = "+ x +" WHERE ID_Product = '"+ dataGridInput.Rows[i].Cells["ID_Product"].Value + "'";
                    MessageBox.Show(sql2);
                    comm.CommandText = sql2;
                    comm.ExecuteNonQuery();
                }

                sql1 = "DELETE FROM InputDetails WHERE ID_Input = '" + txtIDInput.Text + "'";
                comm.CommandText = sql1;
                comm.ExecuteNonQuery();
                sql = "DELETE FROM Input_Product WHERE ID_Input = '" + txtIDInput.Text + "'";
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
                clearFrom();

            }
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            while (dataGridInput.Rows.Count >1) {
                dataGridInput.Rows.RemoveAt(0);
            }
        }
    }
}
