﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_THUVIET_2021.Class;

namespace QL_THUVIET_2021
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BPN90P8;Initial Catalog=QLY_ThuVien_DH;Persist Security Info=True;User ID=sa;Password=05112002@VANG");
        

        private string getID()
        {
            string id = "";
            try
            {
                conn.Open();
                SqlCommand cmm = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenTK = N'" + txtTenDangNhap.Text+ "' AND MatKhau = N'" +txtMatKhau.Text+ "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt != null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        id = dr["TenTK"].ToString();
                    }    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi do kết nối cơ sở dữ liệu hoặc truy vấn dữ liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }
        public static string ID_Name = "";
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            getID();
            ID_Name = getID();
            conn.Open();
            SqlCommand cmm = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenTK = N'" + txtTenDangNhap.Text + "' AND MatKhau = N'" + txtMatKhau.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (ID_Name != "")
            {
                FormMain fm = new FormMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btDangNhap.PerformClick();
            }    
        }

        private void lbthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
