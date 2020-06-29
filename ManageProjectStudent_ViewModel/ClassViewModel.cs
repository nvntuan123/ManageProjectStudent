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
    public class ClassViewModel : INotifyPropertyChanged
    {
        private readonly DBManageProjectStudentViewModel _context = new DBManageProjectStudentViewModel();
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
                    new ObservableCollection<ClassModel>(_context.ClassModels.Include(e => e.FacultyModel));
            }
            set
            {
                _ClassModels = value;
                OnPropertyChanged("Class");
            }
        }

        private SubjectModel _currentSelectedClass;
        public SubjectModel CurrentSelecteClass
        {
            get
            {
                return _currentSelectedClass;
            }
            set
            {
                _currentSelectedClass = value;
                OnPropertyChanged("CurrentSelectedClass");
            }
        }

        private void AddNewClass(ClassModel classModel)
        {
            _context.ClassModels.Add(classModel);
            _context.SaveChanges();
        }

        private void UpdateCurrentClass(ClassModel classModel)
        {
            var ClassToUpdate = _context.ClassModels.SingleOrDefault
                    (x => x.StrClassID == classModel.StrClassID);
            if (ClassToUpdate != null)
            {
                ClassToUpdate.StrClassName = classModel.StrClassName;
                ClassToUpdate.StrFacultyID = classModel.StrFacultyID;
            }
            _context.SaveChanges();
        }

        private void DeleteCurrentClass(ClassModel classModel)
        {
            var ClassToDelete = _context.ClassModels.SingleOrDefault
                    (x => x.StrClassID == classModel.StrClassID);
            _context.ClassModels.Remove(ClassToDelete);
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
