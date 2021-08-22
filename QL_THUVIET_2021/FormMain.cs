﻿using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_THUVIET_2021
{
    public partial class FormMain :DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void Closethis()
        {
            TabItem SelectedTab = tabMain.SelectedTab;
            if (MessageBox.Show("Bạn Có muốn tắt: " + SelectedTab.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if(tabMain.SelectedTabIndex!=0)
                tabMain.Tabs.Remove(SelectedTab);
        }
        private void tabMain_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            Closethis();
        }

        private void đóngTrangNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Closethis();
        }

        private void ctmnMain_Opening(object sender, CancelEventArgs e)
        {
            if (tabMain.SelectedTabIndex == 0)
                đóngTrangNàyToolStripMenuItem.Enabled = false;
            else
                đóngTrangNàyToolStripMenuItem.Enabled = true;
        }

        private void đóngTrangKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = tabMain.SelectedTabIndex;
            for (int i = tabMain.Tabs.Count - 1; i > 0; i--)
                if (index != i)
                    tabMain.Tabs.RemoveAt(i);
            tabMain.Refresh();
        }

        private void đóngTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = tabMain.SelectedTabIndex;
            for (int i = tabMain.Tabs.Count - 1; i > 0; i--)
                    tabMain.Tabs.RemoveAt(i);
            tabMain.Refresh();
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar4_ItemClick(object sender, EventArgs e)
        {

        }

        private void ribbonBar3_ItemClick(object sender, EventArgs e)
        {

        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel3_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar2_ItemClick(object sender, EventArgs e)
        {

        }

        private void ribbonPanel4_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar9_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar10_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar5_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnQLSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar6_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar7_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar8_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar11_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar12_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel5_Click(object sender, EventArgs e)
        {

        }

        private void tabHeThong_Click(object sender, EventArgs e)
        {

        }

        private void tabDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void tabQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void tabTroGiup_Click(object sender, EventArgs e)
        {

        }

        private void tabMain_Click(object sender, EventArgs e)
        {

        }

      

        private void tabControlPanel4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Black;
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Blue;
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Silver;
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007VistaGlass;
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2010Black;
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2010Blue;
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2010Silver;
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2013;
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.VisualStudio2010Blue;
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.VisualStudio2012Dark;
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.VisualStudio2012Light;
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Windows7Blue;
        }
    }
}
