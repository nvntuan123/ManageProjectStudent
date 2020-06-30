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
        private readonly DBManageProjectStudentViewModel _context = new DBManageProjectStudentViewModel();

        public static BindingList<StaffModel> LoadStaff()
        {
            using (var _context = new DBManageProjectStudentViewModel())
            {
                var result = (from x in _context.StaffModels.AsEnumerable()
                              select new StaffModel
                              {
                                  StrStaffID = x.StrStaffID,
                                  StrStaffName = x.StrStaffName,
                                  StrEmail = x.StrEmail,
                                  StrAddress = x.StrAddress,
                                  //StrPhone = x.StrPhone,
                                  //StrSex = x.StrSex,
                                  BStatus = x.BStatus,
                                  DtBirthDay = x.DtBirthDay,
                                  StrFacultyID = x.StrFacultyID,
                                  StrStaffTypeID = x.StrStaffTypeID,
                                  ICardID = x.ICardID
                              }).ToList();
                return new BindingList<StaffModel>(result);
            }
        }
        private ICollection<FacultyModel> _FacultyModels;
        public ICollection<FacultyModel> FacultyModels
        {
            get
            {
                return
                    new ObservableCollection<FacultyModel>(_context.FacultyModels);
            }
            set
            {
                _FacultyModels = value;
                OnPropertyChanged("Faculty");
            }
        }
        private ICollection<StaffModel> _staff;
        public ICollection<StaffModel> staff
        {
            get
            {
                return
                    new ObservableCollection<StaffModel>(_context.StaffModels.Include(e => e.FacultyModel));
            }
            set
            {
                _staff = value;
                OnPropertyChanged("Staff");
            }
        }
        private ICollection<StaffTypeModel> _StaffTypeModels;
        public ICollection<StaffTypeModel> StaffTypeModels
        {
            get
            {
                return
                    new ObservableCollection<StaffTypeModel>(_context.StaffTypeModels);
            }
            set
            {
                _StaffTypeModels = value;
                OnPropertyChanged("StaffTypeModel");
            }
        }
        private StaffModel _currentSelectedStaff;
        public StaffModel CurrentSelecteStaff
        {
            get
            {
                return _currentSelectedStaff;
            }
            set
            {
                _currentSelectedStaff = value;
                OnPropertyChanged("CurrentSelectedStaff");
            }
        }

        private void AddNewStaff(StaffModel staff)
        {
            _context.StaffModels.Add(staff);
            _context.SaveChanges();
        }

        private void UpdateCurrentStafff(StaffModel staff)
        {
            var StaffToUpdate = _context.StaffModels.SingleOrDefault
                    (x => x.StrStaffID == staff.StrStaffID);
            if (StaffToUpdate != null)
            {
                StaffToUpdate.StrStaffName = staff.StrStaffName;
                StaffToUpdate.StrAddress = staff.StrAddress;
                StaffToUpdate.StrEmail = staff.StrEmail;
                //StaffToUpdate.StrPhone = staff.StrPhone;
                StaffToUpdate.DtBirthDay = staff.DtBirthDay;
                StaffToUpdate.ICardID = staff.ICardID;
                StaffToUpdate.StrFacultyID = staff.StrFacultyID;
                StaffToUpdate.StrStaffTypeID = staff.StrStaffTypeID;
                StaffToUpdate.BStatus = staff.BStatus;
                //StaffToUpdate.StrSex = staff.StrSex;
            }
            _context.SaveChanges();
        }

        private void DeleteCurrentStaff(StaffModel staff)
        {
            var staffToDelete = _context.StaffModels.SingleOrDefault
                    (x => x.StrStaffID == staff.StrStaffID);
            _context.StaffModels.Remove(staffToDelete);
            _context.SaveChanges();
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
