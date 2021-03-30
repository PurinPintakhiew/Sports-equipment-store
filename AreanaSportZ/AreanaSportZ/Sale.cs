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
    public partial class Sale : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter da;
        DataSet ds;
        bool edit;
        int num = 0;

        public Sale()
        {
            InitializeComponent();
            conn = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=AreanaSport;Integrated Security=True");
            conn.Open();
            comm = new SqlCommand("SELECT ID_Customer,Name FROM Custormer", conn);
            da = new SqlDataAdapter(comm);
            ds = new DataSet();
            da.Fill(ds, "Custormer");
            cmbCus.DataSource = ds.Tables["Custormer"];
            cmbCus.DisplayMember = "Name";
            cmbCus.ValueMember = "ID_Customer";
            conn.Close();
            enableForm(false);
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            dateSale.Format = DateTimePickerFormat.Custom;
            dateSale.CustomFormat = "dd/MM/yy";
            dateSale.Value = DateTime.Today;
            conn.Open();
            string sql = "SELECT TransectionDetails.ID_Product,ProductAreana.N_Product,ProductAreana.Price";
            sql += ",TransectionDetails.SaleAmount,TransectionDetails.SaleAmount*ProductAreana.Price as total";
            sql += " FROM TransectionDetails,ProductAreana WHERE TransectionDetails.ID_Product = ProductAreana.ID_Product";
            sql += " AND TransectionDetails.ID_Product is null";
            comm.CommandText = sql;
           // MessageBox.Show(sql);
            da.Fill(ds, "Sale");
            dataGridSale.DataSource = ds.Tables["Sale"];
            dataGridSale.Columns[0].HeaderText = "รหัสสินค้า";
            dataGridSale.Columns[1].HeaderText = "              รายการสินค้า";
            dataGridSale.Columns[2].HeaderText = "ราคา";
            dataGridSale.Columns[3].HeaderText = "จำนวน";
            dataGridSale.Columns[4].HeaderText = "ราคารวม";
            dataGridSale.Columns[1].Width = 500; 
        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIDPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                //conn.Open();
                comm.CommandText = "SELECT ID_Product,N_Product,Price FROM ProductAreana WHERE ID_Product ='"+ txtIDPro.Text +"'";
                da.Fill(ds, "ProductAreana");
                conn.Close();
                if (ds.Tables["ProductAreana"].Rows.Count == 0) MessageBox.Show("ไม่มีสินค้าเหล่านี้", "แจ้งเตือน",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    txtNPro.Text = ds.Tables["ProductAreana"].Rows[0]["N_Product"].ToString();
                    txtPrice.Text = ds.Tables["ProductAreana"].Rows[0]["Price"].ToString();
                    btnINTO.Focus();
                    ds.Tables["ProductAreana"].Clear();
                }
            }
        }

        private void btnINTO_Click(object sender, EventArgs e)
        {

                DataRow d = ds.Tables["Sale"].NewRow();
                d["ID_Product"] = txtIDPro.Text;
                d["N_Product"] = txtNPro.Text;
                d["Price"] = txtPrice.Text;
                d["SaleAmount"] = txtQTY.Text;
                d["total"] = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQTY.Text);
                ds.Tables["Sale"].Rows.Add(d);
                clearPro();
                getTotal();
            
        }

        public void getTotal()
        {
            int SumPrice = 0;
            for(int i=0;i< dataGridSale.Rows.Count; i++)
            {
                SumPrice = SumPrice + Convert.ToInt32(dataGridSale.Rows[i].Cells["total"].Value);
            }
            txtSum.Text = SumPrice.ToString();
            labelShow.Text = SumPrice.ToString();
            labelShow.Font = new Font(labelShow.Font.FontFamily,48);
        }

        public void clearPro()
        {
            txtIDPro.Clear();
            txtNPro.Clear();
            txtPrice.Clear();
            txtQTY.Clear();

        }

        public void clearFrom()
        {
            txtSaleNo.Clear();
            txtGET.Clear();
            txtChange.Clear();
            txtSum.Clear();
            while (dataGridSale.Rows.Count > 1)
            {
                dataGridSale.Rows.RemoveAt(0);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql1,sql2;
            conn.Open();
            DateTime time = dateSale.Value;
            string format = "yyyy-MM-dd";
 
            sql1 = "INSERT INTO Transection (ID_Customer,OrderDate) Values ('" + cmbCus.SelectedValue.ToString() + "','" + time.ToString(format) + "')";
            //MessageBox.Show(sql1);
            comm.CommandText = sql1;
            comm.ExecuteNonQuery();


            comm.CommandText = "select top 1 * from Transection order by ID_Transection desc";
            da.Fill(ds, "Transection");
                txtSaleNo.Text = ds.Tables["Transection"].Rows[0]["ID_Transection"].ToString();
                txtIDPro.Focus();
                ds.Tables["Transection"].Clear();


                for (int i = 0; i < dataGridSale.Rows.Count - 1; i++)
            {
                sql2 = "INSERT INTO TransectionDetails  VALUES (" + txtSaleNo.Text + ",'" + dataGridSale.Rows[i].Cells["ID_Product"].Value + "'," + dataGridSale.Rows[i].Cells["Price"].Value + ",";
                sql2 += " " + dataGridSale.Rows[i].Cells["SaleAmount"].Value + ") ";
               // MessageBox.Show(sql2);
                comm.CommandText = sql2;
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
            txtSum.Enabled = enable;
            dateSale.Enabled = enable;
            cmbCus.Enabled = enable;
            
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {

            while (dataGridSale.Rows.Count > 1)
            {
                dataGridSale.Rows.RemoveAt(0);
            }
            txtGET.Clear();
            txtChange.Clear();
            txtSum.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sql, sql1;
            conn.Open();
            if (MessageBox.Show("คุณต้องการลบหรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql1 = "DELETE FROM TransectionDetails WHERE ID_Transection = '" + txtSaleNo.Text + "'";
                comm.CommandText = sql1;
                comm.ExecuteNonQuery();
                sql = "DELETE FROM Transection WHERE ID_Transection = '" + txtSaleNo.Text + "'";
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
                clearFrom();
            }
        }

        private void btnCalco_Click(object sender, EventArgs e)
        {
            txtChange.Text = (Convert.ToDouble(txtGET.Text) - Convert.ToDouble(txtSum.Text)).ToString();
        }

        private void btnBeforeFrist_Click(object sender, EventArgs e)
        {

        }
    }
}
