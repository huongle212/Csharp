using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_Project.view.User_control
{
    public partial class UcRoom : UserControl
    {
        private string oldRoomNo = "";
        private int selectedRowIndex = -1;
        private SqlDataAdapter adapter = null;
        private DataSet dataSet = null;

        public UcRoom()
        {
            InitializeComponent();
            this.cbFilterRoom.SelectedIndex = 2;
            btnNext.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatAppearance.BorderSize = 0;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from Room",FrmHome.Strconn);
            dataSet = new DataSet();          
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//use SqlCommandBuilder to insert, update, delete data
            adapter.Fill(dataSet, "Room");
            this.roomTypeTableAdapter.Fill(this.pRN292_HotelDBDataSet.RoomType);
            ViewAllRoom(this.dgvRoom);
            ViewAllRoomType(this.dgvRoomType);
            setDislayButton(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String rNo = txtRoomNo.Text;
            try
            {
                if (rNo.Length == 0) throw new Exception("Room No is empty!");
                if (checkRoomNoExists(rNo)) throw new Exception($"Room {rNo} already exists!");
                DataRow dr = dataSet.Tables[0].NewRow();
                dr[0] = rNo; // set data for new row
                if (cbxRoomType.SelectedIndex == -1) throw new Exception("You doesn't choose room type!");
                dr[1] = cbxRoomType.SelectedValue.ToString();
                dr[2] = cbVacant.Checked;
                dataSet.Tables[0].Rows.Add(dr);
                int kq = adapter.Update(dataSet,"Room"); //update adapter
                ViewAllRoom(dgvRoom);
                setDislayButton(false);
                ViewAllRoomType(dgvRoomType);
                MessageBox.Show("Add new room successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add new room fail! \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (oldRoomNo.Length > 0)
            {
                try
                {
                    string newRoomNo = txtRoomNo.Text;
                    if (newRoomNo.Length == 0)
                    {
                        DialogResult cf = MessageBox.Show($"Room number is empty.\nDo you want to keep the old room number?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cf == DialogResult.No) return;
                        else txtRoomNo.Text = oldRoomNo;
                    }
                    if (!checkRoomNoExists(oldRoomNo)) throw new Exception($"Room {oldRoomNo} doesn't exist!");
                    if(!newRoomNo.Equals(oldRoomNo) && checkRoomNoExists(newRoomNo)) throw new Exception($"Room {newRoomNo} alreadey exist!");
                    DialogResult confirmed = MessageBox.Show($"Do you want to update room {oldRoomNo}?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmed == DialogResult.Yes)
                    {
                        DataRow dr = dataSet.Tables[0].Select($"roomNo={oldRoomNo}")[0];
                        dr.BeginEdit(); //update row
                        dr["RoomNo"] = txtRoomNo.Text;
                        dr["type"] = cbxRoomType.SelectedValue.ToString();
                        dr["isVacant"] = cbVacant.Checked;
                        dr.EndEdit();
                        int kq = adapter.Update(dataSet, dataSet.Tables[0].TableName); //update adapter
                        dgvRoom.DataSource = dataSet.Tables[0];
                        if (kq > 0)
                        {
                            oldRoomNo = newRoomNo;
                            ViewAllRoomType(dgvRoomType);
                            MessageBox.Show("Update successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Update fail! \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                }
                ViewAllRoom(dgvRoom);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (oldRoomNo.Length > 0)
            {
                try
                {
                    if (!checkRoomNoExists(oldRoomNo)) throw new Exception($"Room {oldRoomNo} doesn't exist!");
                    DialogResult confirmed = MessageBox.Show($"Do you want to remove room {oldRoomNo}?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmed == DialogResult.Yes)
                    {

                        DataRow dr = dataSet.Tables[0].Select($"roomNo={oldRoomNo}")[0];
                        dr.Delete();
                        adapter.Update(dataSet, dataSet.Tables[0].TableName);
                        dgvRoom.DataSource = dataSet.Tables[0];
                        setDislayButton(false);
                        ViewAllRoomType(dgvRoomType);
                        MessageBox.Show("Delete successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Delete fail! \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setDislayButton(false);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex > -1 && selectedRowIndex < dgvRoom.Rows.Count - 2)
            {
                selectedRowIndex++;
                dgvRoom.ClearSelection();
                dgvRoom.Rows[selectedRowIndex].Selected = true;
                dgvRoom_CellClick(null, null);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex > 0 && selectedRowIndex < dgvRoom.Rows.Count - 1)
            {
                selectedRowIndex--;
                dgvRoom.ClearSelection();
                dgvRoom.Rows[selectedRowIndex].Selected = true;
                dgvRoom_CellClick(null, null);
            }
        }
        
        private void txtRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        
        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchRoom.Text;
            searchRoom(dgvRoom, keyword, cbFilterRoom.SelectedIndex);
            selectedRowIndex = 0;
        }

        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchRoomType.Text;
            searchRoomType(dgvRoomType, keyword);
        }

        private void cbFilterRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchRoom_TextChanged(null, null);
        }

        //===================================== Data Grid View event ==================================
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = dgvRoom.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvRoom.Rows[selectedRowIndex];
            if (selectedRowIndex > -1 && selectedRowIndex < dgvRoom.Rows.Count)
            {
                txtRoomNo.Text = row.Cells[0].Value.ToString();
                
                cbVacant.Checked = (row.Cells[2].Value.ToString().Equals("True"));
                oldRoomNo = txtRoomNo.Text;
                if (selectedRowIndex >= dgvRoom.Rows.Count-1)
                {
                    setDislayButton(false);
                }else
                {
                    cbxRoomType.SelectedValue = row.Cells[1].Value.ToString();
                    setDislayButton(true);
                }
                    
            }
        }
        //------------------------------------- .End Data Grid View event ---------------------------

        private void ViewAllRoom(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = dataSet.Tables[0];
                setRoomTableHeader(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchRoom(DataGridView dataGridView, string keyword, int vacant)
        {
            try
            {
                string sql = $"select * from Room where (roomNo like N'%{keyword}%' or type like N'%{keyword}%'" +
                    $" or type in (Select roomTypeId from RoomType where name like N'%{keyword}%'))";
                if (vacant == 0 || vacant == 1)
                    sql += $" and isVacant = {vacant}";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];
                setRoomTableHeader(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool checkRoomNoExists(string roomNo)
        {
            try
            {
                return dataSet.Tables[0].Select($"roomNo={roomNo}").Length > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void ViewAllRoomType(DataGridView dataGridView)
        {
            try
            {
                string sql = "SELECT roomTypeId,[name],roomRate,noOfOccupancy, COUNT(roomNo) as totalRoom,[description]" +
                    "FROM RoomType as rt Left join Room on rt.roomTypeId = Room.[type]" +
                    "GROUP BY roomTypeId, [name],[description], roomRate,noOfOccupancy; ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];
                setRoomTypeTableHeader(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchRoomType(DataGridView dataGridView, String keyword)
        {
            try
            {
                string sql = $"SELECT roomTypeId,[name],roomRate,noOfOccupancy, COUNT(roomNo) as totalRoom,[description]" +
                    $"FROM RoomType as rt Left join Room on rt.roomTypeId = Room.[type] where roomTypeID like N'%{keyword}%'" +
                    $" or name like N'%{keyword}%' or description like N'%{keyword}%'" +
                    "GROUP BY roomTypeId, [name],[description], roomRate,noOfOccupancy;";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];
                setRoomTypeTableHeader(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void setRoomTableHeader(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "RoomNo";
            dataGridView.Columns[1].HeaderText = "Room Type";
            dataGridView.Columns[2].HeaderText = "Vacant";
            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 72;
        }

        public static void setRoomTypeTableHeader(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Name";
            dataGridView.Columns[2].HeaderText = "Room Price (VND)";
            dataGridView.Columns[3].HeaderText = "NoOfOccupancy";
            dataGridView.Columns[4].HeaderText = "Total Room";
            dataGridView.Columns[5].HeaderText = "Description";
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 90;
            dataGridView.Columns[4].Width = 90;
            dataGridView.Columns[5].MinimumWidth = 123;
        }

        private void setDislayButton(bool update)
        {
            btnAdd.Visible = !update;
            btnUpdate.Visible = update;
            btnCancel.Visible = update;
            btnDelete.Visible = update;
            btnPrevious.Visible = update;
            btnNext.Visible = update;
            btnNext.Enabled = selectedRowIndex > dgvRoom.Rows.Count - 3?false:true;
            btnPrevious.Enabled = selectedRowIndex < 1?false:true;
            if (!update)
            {
                txtRoomNo.Text = "";
                cbxRoomType.SelectedIndex = -1;
                cbVacant.Checked = true;
                selectedRowIndex = -1;
                oldRoomNo = "";
            }else
            {
                cbxRoomType.Enabled = cbVacant.Checked;
                btnDelete.Enabled = cbVacant.Checked;
            }
        }

        private void cbxRoomType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
