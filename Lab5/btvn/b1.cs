using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btvn
{
    public partial class b1 : Form
    {
        public b1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get values from form fields
            string customerName = txtCustomerName.Text;
            string dob = dateTimePickerDOB.Value.ToString("dd/MM/yyyy");
            string address = txtAddress.Text;

            string departurePoint = GetSelectedRadioButtonText(groupDeparturePoint);
            string destination = GetSelectedRadioButtonText(groupDestination);

            int totalDays = (dateTimePickerEndDate.Value - dateTimePickerStartDate.Value).Days;

            // Display data in the RichTextBox
            richTextBoxInfo.Text = $"Khách hàng: {customerName}\n" +
                                   $"Ngày sinh: {dob}\n" +
                                   $"Địa chỉ: {address}\n" +
                                   $"Điểm xuất phát: {departurePoint}\n" +
                                   $"Điểm đến: {destination}\n" +
                                   $"Tổng số ngày: {totalDays}";
        }

        private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtCustomerName.Clear();
            txtAddress.Clear();
            dateTimePickerDOB.Value = DateTime.Today;
            dateTimePickerStartDate.Value = DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Today;

            foreach (Control control in groupDeparturePoint.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            foreach (Control control in groupDestination.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            richTextBoxInfo.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}
