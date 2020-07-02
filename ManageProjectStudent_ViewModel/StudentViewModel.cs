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
        private readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();
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
        public string GetByIDMaxStudent()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.StudentModels.OrderByDescending(c => c.StrStudentID).Select(c=>c.StrStudentID);
                var Result = query.First();
                return Result;
            }
        }
        private ICollection<FacultyModel> _Faculty;
        public ICollection<FacultyModel> FacultyModels
        {
            get
            {
                return
                    new ObservableCollection<FacultyModel>(_Context.FacultyModels);
            }
            set
            {
                _Faculty = value;
                OnPropertyChanged("Faculty");
            }
        }

        private ICollection<ClassModel> _ClassModels;
        public ICollection<ClassModel> ClassModels
        {
            get
            {
                return
                    new ObservableCollection<ClassModel>(_Context.ClassModels);
            }
            set
            {
                _ClassModels = value;
                OnPropertyChanged("Class");
            }
        }
        private ICollection<StudentModel> _Student;
        //public ICollection<StudentModel> StudentModels
        //{
        //    get
        //    {
        //        //return
        //        //    new ObservableCollection<StudentModel>(_Context.StudentModels.Include(e => e.));
        //    }
        //    set
        //    {
        //        _Student = value;
        //        OnPropertyChanged("Student");
        //    }
        //}
        private StudentModel _currentSelectedStudent;
        public StudentModel CurrentSelecteStudent
        {
            get
            {
                return _currentSelectedStudent;
            }
            set
            {
                _currentSelectedStudent = value;
                OnPropertyChanged("CurrentSelectedStudent");
            }
        }

        private void AddNewStudent(StudentModel student)
        {
            _Context.StudentModels.Add(student);
            _Context.SaveChanges();
        }

        private void UpdateCurrentStudent(StudentModel student)
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
            _Context.SaveChanges();
        }

        private void DeleteCurrentStudent(StudentModel student)
        {
            var StudentToDelete = _Context.StudentModels.SingleOrDefault
                    (x => x.StrStudentID == student.StrStudentID);
            _Context.StudentModels.Remove(StudentToDelete);
            _Context.SaveChanges();
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
