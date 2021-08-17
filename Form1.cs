using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractiseClass
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OJFKR3C\SQLEXPRESS;Initial Catalog=JustPracticeDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Sql Connection
                conn.Open();

                string st_name = txtbName.Text;
                string st_address = txtbAddress.Text;

                //var fie_name = "";
                string file_name = "";
                string path = "";

                if (openFileDialog != null)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        file_name = Path.GetFileName(openFileDialog.FileName);
                        path = Application.StartupPath + "\\UploadedImage\\" + file_name;

                        if(!Directory.Exists(Application.StartupPath + "\\UploadedImage\\"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\UploadedImage\\");
                        }

                        File.Copy(openFileDialog.FileName, path);
                    }
                }

                //save data to database

                //passing parameter method
                String query = "Insert into student_details (Name,Address,Photo_Path) values (@parameter_Name,@parameter_Address,@parameter_Photo_Path)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@parameter_Name",st_name);
                cmd.Parameters.AddWithValue("@parameter_Address", st_address);

                //For Photo: save entire path
                cmd.Parameters.AddWithValue("@parameter_Photo_Path", path);
                //For Photo : save file name only
                //cmd.Parameters.AddWithValue("@parameter_Photo_Path", file_name);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                txtbName.Text = "";
                txtbAddress.Text = "";
                

                /*
                Alternative Way (Direct/normal query method)

                string query = "Insert into student_details (Name,Address) values ("+st_name+","+st_address+")";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                txtbName.Text = "";
                txtbAddress.Text = "";
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //close Sql connection
                conn.Close();
            }

            DisplayData();

            /*
             * previously done when database was not connected
             
            string name = txtbName.Text;
            string address = txtbAddress.Text;

            //creates new row
            //dgvStudentList.Rows.Add();

            //set data to display
            dgvStudentList.Rows.Add(dgvStudentList.Rows.Count + 1, name, address);
            */
        }

        private void DisplayData()
        {
            try
            {
                //Open Sql COnnection
                conn.Open();

                string st_name = txtbName.Text;
                string st_address = txtbAddress.Text;

                string query = "Select * from student_details";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvStudentList.Rows.Clear();

                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    sn++;
                    dgvStudentList.Rows.Add(sn, dataRow["ID"], dataRow["Name"], dataRow["Address"], dataRow["Photo_Path"], "Edit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //close Sql connection
                conn.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //for removimg single row while any cell is selected
            //dgvStudentList.Rows.RemoveAt(dgvStudentList.CurrentRow.Index);

            //for removing row(s) while certain index(s) is/are selected

            try
            {
                conn.Open();

                if (dgvStudentList.SelectedRows.Count > 0)
                {
                    //for revoming single row
                    //dgvStudentList.Rows.RemoveAt(dgvStudentList.SelectedRows[0].Index);

                    //for removing multiple rows
                    foreach (DataGridViewRow row in dgvStudentList.SelectedRows)
                    {

                        int id = Convert.ToInt32(row.Cells["stdID"].Value);

                        String query = "Delete from student_details where ID = @parameter_id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@parameter_id", id);
                        cmd.ExecuteNonQuery();
                        dgvStudentList.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Please select row to remove");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //close Sql connection
                conn.Close();
            }
            DisplayData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        int student_ID;
        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dgvStudentList.Columns["stdAction"].Index)
            {
                string student_name = dgvStudentList.CurrentRow.Cells["stdName"].Value.ToString();
                string student_address = dgvStudentList.CurrentRow.Cells["stdAddress"].Value.ToString();
                student_ID = Convert.ToInt32(dgvStudentList.CurrentRow.Cells["stdID"].Value.ToString());
                string Photo_Path = dgvStudentList.CurrentRow.Cells["stdPhoto_Path"].Value.ToString();


                txtbName.Text = student_name;
                txtbAddress.Text = student_address;

                //for save and get only filename
                string path = Application.StartupPath + "\\UploadedImage\\" + Photo_Path;
                //for full path saved data
                pbPhoto.Image = Image.FromFile(Photo_Path);
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (student_ID != 0)
                {
                    //Open Sql Connection
                    conn.Open();

                    string st_name = txtbName.Text;
                    string st_address = txtbAddress.Text;

                    //save data to database

                    //passing parameter method
                    String query = "Update student_details set Name=@parameter_Name, Address=@parameter_Address where ID=@parameter_ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@parameter_Name", st_name);
                    cmd.Parameters.AddWithValue("@parameter_Address", st_address);
                    cmd.Parameters.AddWithValue("@parameter_ID", student_ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                    txtbName.Text = "";
                    txtbAddress.Text = "";
                    student_ID = 0;

                    /*
                    Alternative Way (Direct/normal query method)

                    string query = "Insert into student_details (Name,Address) values ("+st_name+","+st_address+")";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                    txtbName.Text = "";
                    txtbAddress.Text = "";
                    */
                }
                else
                {
                    MessageBox.Show("Please edit data before updating");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //close Sql connection
                conn.Close();
            }

            DisplayData();

            /*
             * previously done when database was not connected
             
            string name = txtbName.Text;
            string address = txtbAddress.Text;

            //creates new row
            //dgvStudentList.Rows.Add();

            //set data to display
            dgvStudentList.Rows.Add(dgvStudentList.Rows.Count + 1, name, address);
            */
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbName.Text = "";
            txtbAddress.Text = " ";
            student_ID = 0;
            foreach (RadioButton rb in gbGender.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            /*
             * Alternative Method to reset radiobuttons
             
            foreach(Control control in gbGender.Controls)
            {
                if(control is RadioButton)
                {
                    RadioButton rb = control as RadioButton;
                    rb.Checked = false;
                }
            }
            */
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Images only. |*jpeg; |*.jpg; |*.png";
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                pbPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Closed File Dialog");
            }
            /*
            to open another form
            Form1 form1 = new Form1();
            form1.ShowDialog();
            */
        }
    }
}
