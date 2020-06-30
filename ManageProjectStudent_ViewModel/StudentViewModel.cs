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
        private readonly DBManageProjectStudentViewModel _context = new DBManageProjectStudentViewModel();
        public static BindingList<StudentModel> LoadStudent()
        {
            using (var _context = new DBManageProjectStudentViewModel())
            {
                var result = (from x in _context.StudentModels.AsEnumerable()
                              select new StudentModel
                              {
                                  StrStudentID = x.StrStudentID,
                                  StrStudentName = x.StrStudentName,
                                  StrAddress = x.StrAddress,
                                  StrEmail = x.StrEmail,
                                  //StrPhone = x.StrPhone,
                                  //StrSex = x.StrSex,
                                  DtBirthDay = x.DtBirthDay,
                                  BStatus = x.BStatus,
                                  ICardID = x.ICardID,
                                  DtStartYear = x.DtStartYear,
                                  StrFacultyID = x.StrFacultyID,
                                  StrClassID = x.StrClassID
                              }).ToList();
                return new BindingList<StudentModel>(result);
            }
        }
        private ICollection<FacultyModel> _Faculty;
        public ICollection<FacultyModel> FacultyModels
        {
            get
            {
                return
                    new ObservableCollection<FacultyModel>(_context.FacultyModels);
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
                    new ObservableCollection<ClassModel>(_context.ClassModels);
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
        //        //    new ObservableCollection<StudentModel>(_context.StudentModels.Include(e => e.));
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
            _context.StudentModels.Add(student);
            _context.SaveChanges();
        }

        private void UpdateCurrentStudent(StudentModel student)
        {
            var StudentToUpdate = _context.StudentModels.SingleOrDefault
                    (x => x.StrStudentID == student.StrStudentID);
            if (StudentToUpdate != null)
            {
                StudentToUpdate.StrStudentName = student.StrStudentName;
                StudentToUpdate.StrAddress = student.StrAddress;
                StudentToUpdate.StrEmail = student.StrEmail;
                StudentToUpdate.DtBirthDay = student.DtBirthDay;
                StudentToUpdate.DtStartYear = student.DtStartYear;
                StudentToUpdate.ICardID = student.ICardID;
                StudentToUpdate.StrFacultyID = student.StrFacultyID;
                StudentToUpdate.StrClassID = student.StrClassID;
                StudentToUpdate.BStatus = student.BStatus;
               // StudentToUpdate.StrSex = student.StrSex;
            }
            _context.SaveChanges();
        }

        private void DeleteCurrentStudent(StudentModel student)
        {
            var StudentToDelete = _context.StudentModels.SingleOrDefault
                    (x => x.StrStudentID == student.StrStudentID);
            _context.StudentModels.Remove(StudentToDelete);
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
}
