using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_Lab7_More
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            // Check if the form exists or not
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("FrmInfor"))
                {
                    f.Activate(); // if already exists => ativite
                    return;
                }

            }
            //if none exists => create new form
            FrmInfor frmInfor = new FrmInfor();
            frmInfor.MdiParent = this; // Set the Parent Form of the Child window.
            frmInfor.Show(); // Display the new form.
        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("FrmSinhVien"))
                {
                    f.Activate();
                    return;
                }
            }
            FrmSinhVien frmSinhVien = new FrmSinhVien();
            frmSinhVien.MdiParent = this;
            frmSinhVien.Show();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("FrmKhoa"))
                {
                    f.Activate();
                    return;
                }

            }
            FrmKhoa frmKhoa = new FrmKhoa();
            frmKhoa.MdiParent = this;
            frmKhoa.Show();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("FrmMonHoc"))
                {
                    f.Activate();
                    return;
                }

            }
            FrmMonHoc frmMonHoc = new FrmMonHoc();
            frmMonHoc.MdiParent = this;
            frmMonHoc.Show();
        }

        private void btnNhapdiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("FrmNhapDiem"))
                {
                    f.Activate();
                    return;
                }
            }
            FrmNhapDiem frmNhapDiem = new FrmNhapDiem();
            frmNhapDiem.MdiParent = this;
            frmNhapDiem.Show();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.Name.Equals("FrmXemDiem"))
                {
                    f.Activate();
                    return;
                }
            }
            FrmXemDiem frmXemDiem = new FrmXemDiem();
            frmXemDiem.MdiParent = this;
            frmXemDiem.Show();
        }

        private void btnThongkeKhoa_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.Name.Equals("FrmThongkeKhoa"))
                {
                    f.Activate();
                    return;
                }
            }
            FrmThongkeKhoa frmThongkeKhoa = new FrmThongkeKhoa();
            frmThongkeKhoa.MdiParent = this;
            frmThongkeKhoa.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
