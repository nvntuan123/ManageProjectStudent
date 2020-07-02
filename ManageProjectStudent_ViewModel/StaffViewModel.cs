using ManageProjectStudent_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Data.Entity;


namespace ManageProjectStudent_ViewModel
{
    #region by Phuoc
    public class StaffViewModel : INotifyPropertyChanged
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public static BindingList<StaffModel> LoadStaff()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.StaffModels.AsEnumerable()
                              select new StaffModel
                              {
                                  StrStaffID = x.StrStaffID,
                                  StrStaffName = x.StrStaffName,
                                  StrEmail = x.StrEmail,
                                  StrAddress = x.StrAddress,
                                  StrPhone = x.StrPhone,
                                  StrSex = x.StrSex,
                                  BStatus = x.BStatus,
                                  DtBirthDay = x.DtBirthDay,
                                  StrFacultyID = x.StrFacultyID,
                                  StrStaffTypeID = x.StrStaffTypeID,
                                  StrCardID = x.StrCardID
                              }).ToList();
                return new BindingList<StaffModel>(Result);
            }
        }
        public static string GetByIDMaxLecturer()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.StaffModels.OrderByDescending(c => c.StrStaffID).Select(c => c.StrStaffID);
                var Result = query.First();
                return Result;
            }
        }

        public static bool AddNewStaff(StaffModel staff)
        {
            try
            {
                _Context.StaffModels.Add(staff);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
         
        }

        public static bool UpdateCurrentStafff(StaffModel staff)
        {
            var StaffToUpdate = _Context.StaffModels.SingleOrDefault
                    (x => x.StrStaffID == staff.StrStaffID);
            if (StaffToUpdate != null)
            {
                StaffToUpdate.StrStaffName = staff.StrStaffName;
                StaffToUpdate.StrAddress = staff.StrAddress;
                StaffToUpdate.StrEmail = staff.StrEmail;
                StaffToUpdate.StrPhone = staff.StrPhone;
                StaffToUpdate.DtBirthDay = staff.DtBirthDay;
                StaffToUpdate.StrCardID = staff.StrCardID;
                StaffToUpdate.StrFacultyID = staff.StrFacultyID;
                StaffToUpdate.StrStaffTypeID = staff.StrStaffTypeID;
                StaffToUpdate.BStatus = staff.BStatus;
                StaffToUpdate.StrSex = staff.StrSex;
            }
            try
            {
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteCurrentStaff(StaffModel staff)
        {
            var staffToDelete = _Context.StaffModels.SingleOrDefault
                    (x => x.StrStaffID == staff.StrStaffID);
            try
            {
                _Context.StaffModels.Remove(staffToDelete);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    #endregion
}
