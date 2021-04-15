using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace PRN292_Lab3_TalkTime
{
    public partial class TalkTime : Form
    {
        private List<string> lines = new List<string>();
        ErrorProvider errorProvider = new ErrorProvider();
        int index = -1;

        public TalkTime()
        {
            InitializeComponent();
            loadTable();
        }

        private static DataTable loadDataTable(List<String> list, int noOfCol)
        {

            DataTable table = new DataTable(); // New table          
            for (int i = 0; i < noOfCol; i++) // Add columns
            {
                table.Columns.Add();
            }
            foreach (string str in list) // Add rows
            {
                string[] temp = str.Split(',');
                table.Rows.Add(temp);
            }
            return table;
        }

        private void updateDataSrc()
        {
            dataEmployee.DataSource = loadDataTable(lines, 7);
            dataEmployee.Columns[0].HeaderText = "Name";
            dataEmployee.Columns[1].HeaderText = "Age";
            dataEmployee.Columns[2].HeaderText = "Address";
            dataEmployee.Columns[3].HeaderText = "Year of Experience";
            dataEmployee.Columns[4].HeaderText = "Phone";
            dataEmployee.Columns[5].HeaderText = "Email";
            dataEmployee.Columns[6].HeaderText = "Date of Joinning";
            index = -1;
        }

        private void loadTable()
        {
            string[] temp = System.IO.File.ReadAllLines(@"Employees.txt");
            foreach (string str in temp)
            {
                lines.Add(str);
            }
            updateDataSrc();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Employees.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
            MessageBox.Show("Save to Employees.txt successfully", "FILE SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLbTalkTime_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://talktime.com");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataEmployee.SelectedCells.Count < 0)
                MessageBox.Show("Please select employees you want to remove!", "Delete Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bool[] deleted = new bool[lines.Count+1];

            foreach (DataGridViewCell oneCell in dataEmployee.SelectedCells)
            {
                if (oneCell.Selected && oneCell.RowIndex < dataEmployee.Rows.Count - 1)
                {
                    int r = oneCell.RowIndex;
                    deleted[r] = true;
                    dataEmployee.Rows.RemoveAt(r);
                    
                }
            } // Loại bỏ các hàng chỉ mục trong các ô được chọn

            for (int i = deleted.Length - 1; i >= 0; i--)
            {
                if (deleted[i]) lines.RemoveAt(i);
            }

            updateDataSrc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                string age = numUDAge.Value.ToString();
                string exp = txtYearExp.Text;
                string joinDate = txtJoinDate.Text;

                validString(name,"Name is empty!");
                validPhone(phone);
                validEmail(email);
                validString(address,"Address is empty!");

                if (joinDate.Trim().Length == 0) joinDate = DateTime.UtcNow.Date.ToString("MM-dd-yyyy");
                else validDate(joinDate);

                lines.Add(name + ',' + age + "," + address + "," + exp + "," + phone + "," + email + "," + joinDate);
                updateDataSrc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataEmployee.SelectedCells[0].RowIndex;
                string name = txtName.Text;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                string age = numUDAge.Value.ToString();
                string exp = txtYearExp.Text;
                string joinDate = txtJoinDate.Text;

                validString(name, "Name is empty!");
                validPhone(phone);
                validEmail(email);
                validString(address, "Address is empty!");
                if (joinDate.Trim().Length == 0) joinDate = DateTime.UtcNow.Date.ToString("MM-dd-yyyy");
                else validDate(joinDate);

                lines[index] = name + ',' + age + "," + address + "," + exp + "," + phone + "," + email + "," + joinDate;
                updateDataSrc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtJoinDate.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            numUDAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtYearExp.Text = "";
            index = -1;
        }

        private void dataEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataEmployee.SelectedCells[0].RowIndex;
            if (index >= lines.Count)
            {
                btnClear_Click(null, null);
                return;
            }
            string[] temp = lines[index].Split(',');
            txtName.Text = temp[0];
            numUDAge.Value = int.Parse(temp[1]);
            txtAddress.Text = temp[2];
            txtYearExp.Text = temp[3];
            txtPhone.Text = temp[4];
            txtEmail.Text = temp[5];
            txtJoinDate.Text = temp[6];
        }

        private void txtYearExp_TextChanged(object sender, EventArgs e)
        {
            Control ctrInt = (Control)sender;
            this.errorProvider.SetError(ctrInt,"");
            string num = ctrInt.Text;
            if (num.Length > 0)
            {
                try
                {
                    int year = int.Parse(num);
                    if (year < 0 || year > 2) throw new Exception("");
                }
                catch (Exception ex)
                {
                    this.errorProvider.SetError(ctrInt, "Year of experience in range [0..2]");
                }
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Control ctrEmail = (Control)sender;
            string email = ctrEmail.Text;
            this.errorProvider.SetError(ctrEmail, "");
            if (email.Length > 0)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if(!match.Success)
                    this.errorProvider.SetError(ctrEmail, "Invalid email!");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Control ctrPhone = (Control)sender;
            string phone = ctrPhone.Text;
            this.errorProvider.SetError(ctrPhone, "");
            if (phone.Length > 0)
            {
                Regex regex = new Regex(@"\d{3}[\-|\.|\s]?\d{6}");
                Match match = regex.Match(phone);
                if (!match.Success)
                    this.errorProvider.SetError(ctrPhone, "Invalid phone!");
            }
        }

        //valid data
        public static void validString(string s, string msg)
        {
            if (s == null || s.Trim().Length == 0) throw new Exception(msg);
        }

        public static void validEmail(string s)
        {
            validString(s,"Email is empty!");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(s);
            if (!match.Success) throw new Exception("Wrong email format!");
        }

        public static void validPhone(string s)
        {
            validString(s,"Phone is empty!");
            Regex regex = new Regex(@"\d{3}[\-|\.|\s]?\d{6}");
            Match match = regex.Match(s);
            if (!match.Success) throw new Exception("Wrong phone format!");
        }

        public static void validDate(string s)
        {
            Regex regex = new Regex(@"(\d{2}\-){2}\d{4}");
            Match match = regex.Match(s);
            if (!match.Success) throw new Exception("Date format: MM-dd-yyyy! Example: 03-05-2021");
            else
                try
                {
                    DateTime date = DateTime.ParseExact(s, "MM-dd-yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    throw new Exception("Invalid Date!");
                }
        }
    }
}
