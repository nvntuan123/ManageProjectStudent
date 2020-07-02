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
        private static readonly DBManageProjectStudentViewModel _context = new DBManageProjectStudentViewModel();

        public static BindingList<FacultyModel> LoadFaculty()
        {
            using (var _context = new DBManageProjectStudentViewModel())
            {
                var result = (from x in _context.FacultyModels.AsEnumerable()
                              select new FacultyModel
                              {
                                  StrFacultyID = x.StrFacultyID,
                                  StrFacultyName = x.StrFacultyName,
                                  DtFoundedYear = x.DtFoundedYear
                              }).ToList();
                return new BindingList<FacultyModel>(result);
            }
        }
      
        public static bool AddNewFaculty(FacultyModel faculty)
        {
            try
            {
                _context.FacultyModels.Add(faculty);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateCurrentFaculty(FacultyModel faculty)
        {
            var FacultyToUpdate = _context.FacultyModels.SingleOrDefault
                    (x => x.StrFacultyID == faculty.StrFacultyID);
            if (FacultyToUpdate != null)
            {
                FacultyToUpdate.StrFacultyName = faculty.StrFacultyName;
                FacultyToUpdate.DtFoundedYear = faculty.DtFoundedYear;
            }
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false; 
            }
        }

        public static bool DeleteCurrentStudent(StudentModel student)
        {
            var StudentToDelete = _context.StudentModels.SingleOrDefault
                    (x => x.StrStudentID == student.StrStudentID);
            try
            {
                _context.StudentModels.Remove(StudentToDelete);
                _context.SaveChanges();
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
