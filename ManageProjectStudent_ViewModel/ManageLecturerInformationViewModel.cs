using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ManageProjectStudent_Interface;

namespace ManageProjectStudent_ViewModel
{
    public class ManageLecturerInformationViewModel : IManageLecturerInformation
    {
        #region
        // Thu
        public void btnSave_Click(TextBox txtID, TextBox txtFullName, TextBox txtIDCard, DateEdit dteBirthday, TextBox txtAddress, TextBox txtPhoneNumber, TextBox txtEmail, LookUpEdit lkeFaculty, RadioButton radNam, RadioButton radNu, RadioButton radAvailable, RadioButton radUnavailable)
        {
            if (txtFullName.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập tên Giảng viên";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtIDCard.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Chứng minh nhân dân";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteBirthday.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Ngày sinh";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAddress.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập ĐịaS chỉ";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPhoneNumber.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Số điện thoại";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtEmail.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Email";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeFaculty.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Khoa";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radNam.Checked) && !(radNu.Checked))
            {
                string _STRMesge = "Bạn chưa chọn Giới tính";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radAvailable.Checked) && !(radUnavailable.Checked))
            {
                string _STRMesge = "Bạn chưa chọn Trạng thái";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Thu

        // Thong
        public void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!GarenaViewModel._checkCharacterChar(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự số, chỉ được nhập chữ.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {

            }
        }
        public void radNu_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {

            }
        }
        //thong
        #endregion
    }
}
