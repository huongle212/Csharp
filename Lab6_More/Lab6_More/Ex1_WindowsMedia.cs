using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_More
{
    public partial class Ex1_WindowsMedia : Form
    {
        public Ex1_WindowsMedia()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            String s = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
            s = s + " - Giờ: " + DateTime.Now.ToString("HH:mm:ss"); //HH: 24h, hh: 12h
            sttLblDateTime.Text = s;
            this.Text = this.Text.Substring(1, this.Text.Length - 1) +
            this.Text.Substring(0, 1);
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            //Tạo hộp thoại mở file
            OpenFileDialog dlg = new OpenFileDialog();
            //lọc hiện thị các loại file        
            dlg.Filter = "Video|*.mp4;*.avi;*.mpeg;*.Wav;*.midi|All file|*.*";
            //hiển thị openDialog
            if (dlg.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = dlg.FileName; //Lấy tên file cần mở
        }

        private void Ex1_WindowsMedia_Load(object sender, EventArgs e)
        {
            timer.Interval = (1000); // 1 sencond
            timer.Start();
        }
    }
}
