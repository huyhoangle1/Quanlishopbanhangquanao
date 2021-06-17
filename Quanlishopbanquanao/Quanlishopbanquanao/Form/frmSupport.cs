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
using Quanlishopbanquanao.Class;

namespace Quanlishopbanquanao
{
    public partial class frmSupport : Form
    {
        string Status;
        public frmSupport()
        {
            InitializeComponent();

        }

        private void frmSupport_Load(object sender, EventArgs e)
        {
            txtMaSP.Enabled = false;
            txtMaNV.Enabled = false;
            txtTenSP.Enabled = false;
            txtLido.Enabled = false;
            btnSua.Enabled = false;
            dtpNhanHang.Enabled = false;
            dtpTraHang.Enabled = false;
            btnHoantat.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tblSupport;
            string sql;
            sql = "SELECT * from tblSupport";
            tblSupport = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblSupport;
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Ngày bán hàng";
            dataGridView1.Columns[3].HeaderText = "Ngày Trả Hàng";
            dataGridView1.Columns[4].HeaderText = "Lí do";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setControl(string Status)
        {
            switch (Status)
            {
                case "Reset":
                    txtMaSP.Enabled = false;
                    txtMaSP.Text = " ";
                    txtMaNV.Enabled = false;
                    txtMaNV.Text = " ";
                    txtTenSP.Enabled = false;
                    txtTenSP.Text = " ";
                    txtLido.Enabled = false;
                    txtLido.Text = " ";
                    txtTenNV.Enabled = false;
                    txtTenNV.text = " ";
                    btnSua.Enabled = false;
                    dtpNhanHang.Enabled = false;
                    dtpTraHang.Enabled = false;
                    btnXoa.Enabled = false;
                    btnXoa.Focus();
                    btnThem.Enabled = true;
                    break;
                case "Insert":
                    txtMaSP.Enabled = true;
                    txtMaSP.Text = " ";
                    txtMaNV.Enabled = true;
                    txtMaNV.Text = " ";
                    txtTenSP.Enabled = true;
                    txtTenSP.Text = " ";
                    txtLido.Enabled = true;
                    txtLido.Text = " ";
                    btnSua.Enabled = false;
                    dtpNhanHang.Enabled = true;
                    dtpTraHang.Enabled = true;
                    btnXoa.Enabled = false;
                    btnXoa.Focus();
                    btnHoantat.Enabled = true;
                    break;
                case "Update":
                    txtMaSP.Enabled = true;
                    txtMaSP.Text = " ";
                    txtMaNV.Enabled = true;
                    txtMaNV.Text = " ";
                    txtTenSP.Enabled = true;
                    txtTenSP.Text = " ";
                    txtLido.Enabled = true;
                    txtLido.Text = " ";
                    btnSua.Enabled = true;
                    btnSua.Focus();
                    dtpNhanHang.Enabled = true;
                    dtpTraHang.Enabled = true;
                    btnXoa.Enabled = false;
                    btnXoa.Focus();
                    break;
                default:
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Status = "Insert";
            setControl(Status);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Status = "Update";
            setControl(Status);
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {
            String sql;
            string MaSP = txtMaSP.Text.Trim();
            string TenSP = txtTenSP.Text;
            string Ngaynhanhang = Convert.ToDateTime(dtpNhanHang.Value).ToString("yyyy-MM-dd");
            string Ngaytrahang = Convert.ToDateTime(dtpTraHang.Value).ToString("yyyy-MM-dd");
            string Lido = txtLido.Text;
            string MaNV = txtMaNV.Text.Trim();
            if (txtMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            sql = "INSERT INTO tbl(Manhanvien) VALUES (N'" + txtMaNV.Text.Trim() + "')";
            dataGridView1_CellContentClick();
            Functions.RunSQL(sql);
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnHoantat.Enabled = false;
        }

        private void dataGridView1_CellContentClick()
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}

    
