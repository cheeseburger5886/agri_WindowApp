using System.Net.Http;
using System.Text.Json;
using agriWinAppTest.Model;
using System.Text;
using System.Collections.Generic;

namespace agriWinAppTest
{
    public partial class frm_MainMenu : Form
    {
        private readonly HttpClient _httpClient;

        public frm_MainMenu()
        {
            InitializeComponent();


            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7270/")
            };

            getDepartmentList();
            getEmployee();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Save image in desired format (e.g., PNG, JPEG)
                return ms.ToArray();
            }
        }

        public void clearDepartment()
        {
            tbDepartmentID.Text = string.Empty;
            tbDepartmentName.Text = string.Empty;
            tbDepartmentAddress.Text = string.Empty;
        }

        public void clearEmployee()
        {
            tbEmployeeID.Text = string.Empty;
            tbEmpDepartmentID.Text = string.Empty;
            tbEmpFirstName.Text = string.Empty;
            tbEmpLastName.Text = string.Empty;
            tbEmpAddress.Text = string.Empty;   
            cbGender.SelectedIndex = 0;
            dtpDateJoined.Value = DateTime.Now;
            dtpDateOfBirth.Value = DateTime.Now;
            picEmployee.Image = Properties.Resources.images;
        }

        private void picEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select an Image";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Filters for allowed image types

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Load the selected image into the PictureBox
                        picEmployee.Image = Image.FromFile(openFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Department datagridview
        public async void getDepartmentList()
        {
            try
            {
                var response = await _httpClient.GetAsync("Department");

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    var department = JsonSerializer.Deserialize<List<Department>>(jsonContent, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    // Bind the employee list to the DataGridView
                    dgvDepartmentList.AutoGenerateColumns = false;
                    dgvDepartmentList.DataSource = department;

                    dgvDepartmentList.Columns["departmentCode"].DataPropertyName = "departmentCode";
                    dgvDepartmentList.Columns["departmentName"].DataPropertyName = "departmentName";
                    dgvDepartmentList.Columns["departmentAddress"].DataPropertyName = "departmentAddress";

                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {

            }
        }

        public async void getEmployee()
        {
            try
            {
                var response = await _httpClient.GetAsync("Employee");

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    var employee = JsonSerializer.Deserialize<List<Employee>>(jsonContent, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    dgvEmployee.AutoGenerateColumns = false;
                    dgvEmployee.DataSource = employee;

                    dgvEmployee.Columns["employeeCode"].DataPropertyName = "employeeCode";
                    dgvEmployee.Columns["empFirstName"].DataPropertyName = "empFirstName";
                    dgvEmployee.Columns["empLastName"].DataPropertyName = "empLastName";
                    dgvEmployee.Columns["empGender"].DataPropertyName = "empGender";
                    dgvEmployee.Columns["empBirthDate"].DataPropertyName = "empBirthDate";
                    dgvEmployee.Columns["empDateJoined"].DataPropertyName = "empDateJoined";
                    dgvEmployee.Columns["empAddress"].DataPropertyName = "empAddress";
                }

                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {

            }
        }

        #region // Department's event
        private async void btnSaveDepartment_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (tbDepartmentID.Text == string.Empty)
                {
                    MessageBox.Show("Please specify Department ID", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbDepartmentID.Focus();

                    return;
                }

                var department = new
                {
                    DepartmentCode = tbDepartmentID.Text,
                    DepartmentName = tbDepartmentName.Text,
                    DepartmentAddress = tbDepartmentAddress.Text

                };

                var jsonContent = JsonSerializer.Serialize(department);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("Department", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Department added successfully!", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getDepartmentList();
                }
                else
                {
                    MessageBox.Show($"Error: {await response.Content.ReadAsStringAsync()}", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    getDepartmentList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteDepartment_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (tbDepartmentID.Text == string.Empty)
                {
                    MessageBox.Show("Please specify Department ID", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbDepartmentID.Focus();

                    return;
                }

                string departmentCode = tbDepartmentID.Text;

                var response = await _httpClient.DeleteAsync($"Department/{departmentCode}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Department deleted successfully!", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getDepartmentList();
                }
                else
                {
                    MessageBox.Show($"Error: {await response.Content.ReadAsStringAsync()}", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    getDepartmentList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDepartmentList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }

                tbDepartmentID.Text = dgvDepartmentList.Rows[e.RowIndex].Cells["departmentCode"].Value.ToString();
                tbDepartmentName.Text = dgvDepartmentList.Rows[e.RowIndex].Cells["departmentName"].Value.ToString();
                tbDepartmentAddress.Text = dgvDepartmentList.Rows[e.RowIndex].Cells["departmentAddress"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepartmentRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                getDepartmentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearDepartment_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                clearDepartment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region // Employee's event

        private void btnClearEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                clearEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSaveEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                if (tbEmployeeID.Text == string.Empty)
                {
                    MessageBox.Show("Please specify Employee ID", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbEmployeeID.Focus();

                    return;
                }

                var employee = new
                {
                    DepartmentCode = tbEmpDepartmentID.Text,
                    EmployeeCode = tbEmployeeID.Text,
                    EmpFirstName = tbEmpFirstName.Text,
                    EmpLastName = tbEmpLastName.Text,
                    EmpGender = cbGender.Text,
                    EmpBirthDate = DateTime.Parse(dtpDateOfBirth.Text),
                    EmpDateJoined = DateTime.Parse(dtpDateJoined.Text),
                    EmpAddress = tbEmpAddress.Text,

                    EmpPhoto = picEmployee.Image != null ? ImageToByteArray(picEmployee.Image) : null
                };

                var jsonContent = JsonSerializer.Serialize(employee);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("Employee", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Employee added successfully!","Program Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getEmployee();
                }
                else
                {
                    MessageBox.Show($"Error: {await response.Content.ReadAsStringAsync()}", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (tbEmployeeID.Text == string.Empty)
                {
                    MessageBox.Show("Please specify Employee ID", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbEmployeeID.Focus();

                    return;
                }

                string employeeCode = tbEmployeeID.Text;

                var response = await _httpClient.DeleteAsync($"Employee/{employeeCode}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Employee deleted successfully!", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getEmployee();
                }
                else
                {
                    MessageBox.Show($"Error: {await response.Content.ReadAsStringAsync()}", "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    getEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                getEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }

                if (dgvEmployee.Rows[e.RowIndex].Cells["employeeCode"].Value.ToString() == string.Empty)
                {
                    return;
                }

                var employeeCode = dgvEmployee.Rows[e.RowIndex].Cells["employeeCode"].Value.ToString();

                var response = await _httpClient.GetAsync($"Employee/{employeeCode}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    var employee = JsonSerializer.Deserialize<List<Employee>>(jsonContent, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (employee.Count > 0)
                    {
                        tbEmpDepartmentID.Text = employee[0].departmentCode;
                        tbEmployeeID.Text = employee[0].employeeCode;
                        tbEmpFirstName.Text = employee[0].empFirstName;
                        tbEmpLastName.Text = employee[0].empLastName;
                        cbGender.Text = employee[0].empGender;
                        tbEmpAddress.Text = employee[0].empAddress;

                        dtpDateJoined.Value = employee[0].empDateJoined;
                        dtpDateOfBirth.Value = employee[0].empBirthDate;

                        if (employee[0].empPhoto != null && employee[0].empPhoto.Length > 0)
                        {
                            using (var ms = new MemoryStream(employee[0].empPhoto))
                            {
                                picEmployee.Image = Image.FromStream(ms);
                                picEmployee.SizeMode = PictureBoxSizeMode.Zoom; // Fit image
                            }
                        }
                        else
                        {
                            picEmployee.Image = Properties.Resources.images; // Set a default image if null
                        }
                    }
                }

                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Program Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}