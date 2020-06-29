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
    public class FacultyViewModel : INotifyPropertyChanged
    {
        private readonly DBManageProjectStudentViewModel _context = new DBManageProjectStudentViewModel();

        //public static List<FacultyModel> LoadFaculty()
        //{
        //    BindingList<FacultyModel> lstFaculty = new BindingList<FacultyModel>();
        //    using (var _context = new DBManageProjectStudentViewModel())
        //    {
        //        var Facutly = (from u in _context.FacultyModels.AsEnumerable()
        //                       select new
        //                       {
        //                           ID = u.StrFacultyID,
        //                           Name = u.StrFacultyName,
        //                           FoundedYear = u.DtFoundedYear
        //                       })
        //                    .Select(x => new FacultyModel
        //                    {
        //                        StrFacultyID = x.ID,
        //                        StrFacultyName = x.Name,
        //                        DtFoundedYear = x.FoundedYear
        //                    });
        //        return Faculty.t
        //    }
        //}
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

        
        private StudentModel _currentSelectedFaculty;
        public StudentModel CurrentSelecteFaculty
        {
            get
            {
                return _currentSelectedFaculty;
            }
            set
            {
                _currentSelectedFaculty = value;
                OnPropertyChanged("CurrentSelectedFaculty");
            }
        }

        private void AddNewFaculty(FacultyModel faculty)
         {
            _context.FacultyModels.Add(faculty);
            _context.SaveChanges();
        }

        private void UpdateCurrentFaculty(FacultyModel faculty)
        {
            var FacultyToUpdate = _context.FacultyModels.SingleOrDefault
                    (x => x.StrFacultyID == faculty.StrFacultyID);
            if (FacultyToUpdate != null)
            {
                FacultyToUpdate.StrFacultyName = faculty.StrFacultyName;
                FacultyToUpdate.DtFoundedYear = faculty.DtFoundedYear;
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
