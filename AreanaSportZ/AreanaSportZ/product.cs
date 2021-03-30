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
    public partial class Product : Form
    {
       SqlConnection conn;
       SqlCommand comm;
       SqlDataAdapter da;
       DataSet ds;
       BindingSource bs;
       bool edit;
       int num = 0;
       

        public Product()
        {
            InitializeComponent();
            conn = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=AreanaSport;Integrated Security=True");
            conn.Open();
            comm = new SqlCommand("SELECT * FROM ProductAreana", conn);
            da = new SqlDataAdapter(comm);
            ds = new DataSet();
            bs = new BindingSource();
            da.Fill(ds, "ProductAreana");
            comm.CommandText = "SELECT ID_Category,N_Category FROM CategoryAreana";
            da.Fill(ds, "CategoryAreana");
            conn.Close();
            CBXIDCategory.DataSource = ds.Tables["CategoryAreana"];
            CBXIDCategory.DisplayMember = "N_Category";
            CBXIDCategory.ValueMember = "ID_Category";
            if (ds.Tables["ProductAreana"].Rows.Count >= 0)
            
                setProduct(0);
                enableForm(false);
                bs.DataSource = ds.Tables["ProductAreana"];
            
           
        }
        public void setProduct(int row)
        {
            txtIDProduct.Text = ds.Tables["ProductAreana"].Rows[row]["ID_Product"].ToString();
            txtNProduct.Text = ds.Tables["ProductAreana"].Rows[row]["N_Product"].ToString();
            txtPrice.Text = ds.Tables["ProductAreana"].Rows[row]["Price"].ToString();
            txtQTY.Text = ds.Tables["ProductAreana"].Rows[row]["QTY"].ToString();
            CBXIDCategory.SelectedValue= ds.Tables["ProductAreana"].Rows[row]["ID_Category"].ToString();

        }

        public void setDS(int row)
        {
           ds.Tables["ProductAreana"].Rows[row]["ID_Product"] = txtIDProduct.Text;
           ds.Tables["ProductAreana"].Rows[row]["N_Product"] =  txtNProduct.Text ;
           ds.Tables["ProductAreana"].Rows[row]["Price"] = txtPrice.Text ;
           ds.Tables["ProductAreana"].Rows[row]["QTY"] = txtQTY.Text ;
           ds.Tables["ProductAreana"].Rows[row]["ID_Category"]= CBXIDCategory.SelectedValue ;

        }

        public void enableForm(bool enable)
        {
            if (!edit) { txtIDProduct.Enabled = enable; }
            txtNProduct.Enabled = enable;
            txtPrice.Enabled = enable;
            txtQTY.Enabled = enable;
            CBXIDCategory.Enabled = enable;
        }
        public void clearFrom()
        {
            txtIDProduct.Clear();
            txtNProduct.Clear();
            txtPrice.Clear();
            txtQTY.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearFrom();
            enableForm(true);
            groupManege.Visible = false;
            groupSeve.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql;
            conn.Open();
            if (edit)
            {
               setDS(num);
               sql = "UPDATE ProductAreana SET N_Product =  '" + txtNProduct.Text + "',Price = " + txtPrice.Text + ",QTY = " + txtQTY.Text + ",ID_Category = '" + CBXIDCategory.SelectedValue.ToString() + "' WHERE ID_Product = '" + txtIDProduct.Text +"'";
            }
            else
            {
                DataRow d = ds.Tables["ProductAreana"].NewRow();
                d["ID_Product"] = txtIDProduct.Text;
                d["N_Product"] = txtNProduct.Text;
                d["Price"] = txtPrice.Text;
                d["QTY"] = txtQTY.Text;
                d["ID_Category"] = CBXIDCategory.SelectedValue.ToString();
                ds.Tables["ProductAreana"].Rows.Add(d);
                sql = "INSERT INTO ProductAreana (ID_Product,N_Product,Price,QTY,ID_Category) VALUES ('" + txtIDProduct.Text + "','" + txtNProduct.Text + "'," + txtPrice.Text + "," + txtQTY.Text + ",'" + CBXIDCategory.SelectedValue.ToString() + "')";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit = true;
            enableForm(true);
            groupManege.Visible = false;
            groupSeve.Visible = true;
            txtNProduct.Focus();
            SendKeys.Send("{DOWN}");

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
            //setProduct(0);
            bs.MoveFirst();
            setProduct(bs.Position);
        }

        private void btnNextLast_Click(object sender, EventArgs e)
        {
            //setProduct(ds.Tables["ProductAreana"].Rows.Count-1);
            bs.MoveLast();
            setProduct(bs.Position);
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            //if (num > 0) num--;
            //setProduct(num);
            bs.MovePrevious();
            setProduct(bs.Position);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //if (num < ds.Tables["ProductAreana"].Rows.Count-1) num++;
            //setProduct(num);
            bs.MoveNext();
            setProduct(bs.Position);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบหรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bs.RemoveCurrent();
                //ds.Tables["ProductAreana"].Rows[num].Delete();
                if (num < ds.Tables["ProductAreana"].Rows.Count - 1)
                {
                    num++;
                }
                else
                {
                    if (num != 0) num--; else clearFrom();
                }
                
                String sql;
                conn.Open();

                    sql = "DELETE FROM ProductAreana WHERE ID_Product = '" + txtIDProduct.Text + "'";

                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                conn.Close();
   
            }
        }

        private void Product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)SendKeys.Send("{TAB}");
        }
    }
}
