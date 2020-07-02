using ManageProjectStudent_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();
        public static BindingList<StudentModel> LoadStudent()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.StudentModels.AsEnumerable()
                              select new StudentModel
                              {
                                  StrStudentID = x.StrStudentID,
                                  StrStudentName = x.StrStudentName,
                                  StrAddress = x.StrAddress,
                                  StrEmail = x.StrEmail,
                                  StrPhone = x.StrPhone,
                                  StrSex = x.StrSex,
                                  DtBirthDay = x.DtBirthDay,
                                  BStatus = x.BStatus,
                                  StrCardID = x.StrCardID,
                                  DtStartYear = x.DtStartYear,
                                  StrFacultyID = x.StrFacultyID,
                                  StrClassID = x.StrClassID
                              }).ToList();
                return new BindingList<StudentModel>(Result);
            }
        }
        public static string GetByIDMaxStudent()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.StudentModels.OrderByDescending(c => c.StrStudentID).Select(c=>c.StrStudentID);
                var Result = query.First();
                return Result;
            }
        }
    
        public static bool AddNewStudent(StudentModel student)
        {
            try
            {
                _Context.StudentModels.Add(student);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateCurrentStudent(StudentModel student)
        {
            var StudentToUpdate = _Context.StudentModels.SingleOrDefault
                    (x => x.StrStudentID == student.StrStudentID);
            if (StudentToUpdate != null)
            {
                StudentToUpdate.StrStudentName = student.StrStudentName;
                StudentToUpdate.StrAddress = student.StrAddress;
                StudentToUpdate.StrEmail = student.StrEmail;
                StudentToUpdate.DtBirthDay = student.DtBirthDay;
                StudentToUpdate.DtStartYear = student.DtStartYear;
                StudentToUpdate.StrCardID = student.StrCardID;
                StudentToUpdate.StrFacultyID = student.StrFacultyID;
                StudentToUpdate.StrClassID = student.StrClassID;
                StudentToUpdate.BStatus = student.BStatus;
                StudentToUpdate.StrPhone = student.StrPhone;
                StudentToUpdate.StrSex = student.StrSex;
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

        public static bool DeleteCurrentStudent(StudentModel student)
        {
            var StudentToDelete = _Context.StudentModels.SingleOrDefault
                    (x => x.StrStudentID == student.StrStudentID);
            try
            {
                _Context.StudentModels.Remove(StudentToDelete);
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
}
