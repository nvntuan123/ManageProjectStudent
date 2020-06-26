using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Interface;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManageProjectStudent_ViewModel
{
    public class ManageStudentInformationViewModel : IManageStudentInformation
    {
        #region Event
        // Thong
        public void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
        public void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        // Thong
        // Thu
        public void btnSaveStudent_Click(TextBox txtID, TextBox txtFullName, DateEdit dteBirthday, RadioButton radNam, RadioButton radNu, TextBox txtPhoneNumber, TextBox txtEmail, TextBox txtIDCard, TextBox txtAddress, RadioButton radAvailable, RadioButton radUnavailable, LookUpEdit lkeCourse, LookUpEdit lkeClass, LookUpEdit lkeFaculty)
        {
            if (txtFullName.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập tên Sinh viên";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteBirthday.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Ngày sinh";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radNam.Checked) && !(radNu.Checked))
            {
                string _STRMesge = "Bạn chưa chọn Giới tính";
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
            else if (txtIDCard.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Chứng minh nhân dân";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAddress.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Địa chỉ";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radAvailable.Checked) && !(radUnavailable.Checked))
            {
                string _STRMesge = "Bạn chưa chọn Trạng thái";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeCourse.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Khóa học";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeClass.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Lớp học";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeFaculty.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Khoa";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }
        // Thu
        #endregion
        #region Method
        // Thu
        public void _setStatus(TextBox txtID, TextBox txtFullName, DateEdit dteBirthday, RadioButton radNam, RadioButton radNu, TextBox txtPhoneNumber, TextBox txtEmail, TextBox txtIDCard, TextBox txtAddress, RadioButton radAvailable, RadioButton radUnavailable, LookUpEdit lkeCourse, LookUpEdit lkeClass, LookUpEdit lkeFaculty)
        {
            txtID.ReadOnly = true;
        }
        // Thu
        #endregion
        #region Properties
        // Thu
        int _itatusForm = 0; // 0: view, 1: add, 2: edit.
        // Thu
        #endregion
    }
}
