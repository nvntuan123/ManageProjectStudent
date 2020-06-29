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
    public class SubjectViewModel : INotifyPropertyChanged
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

        private ICollection<SubjectModel> _SubjectModels;
        public ICollection<SubjectModel> SubjectModels
        {
            get
            {
                return
                    new ObservableCollection<SubjectModel>(_context.SubjectModels.Include(e => e.FacultyModel));
            }
            set
            {
                _SubjectModels = value;
                OnPropertyChanged("Subject");
            }
        }

        private SubjectModel _currentSelectedSubject;
        public SubjectModel CurrentSelecteSubject
        {
            get
            {
                return _currentSelectedSubject;
            }
            set
            {
                _currentSelectedSubject = value;
                OnPropertyChanged("CurrentSelectedSubject");
            }
        }


        private void AddNewStudent(SubjectModel subject)
        {
            _context.SubjectModels.Add(subject);
            _context.SaveChanges();
        }

        private void UpdateCurrentStudent(SubjectModel subject)
        {
            var SubjectToUpdate = _context.SubjectModels.SingleOrDefault
                    (x => x.StrSubjectID == subject.StrSubjectID);
            if (SubjectToUpdate != null)
            {
                SubjectToUpdate.StrSubjectName = subject.StrSubjectName;
                SubjectToUpdate.DtStartDay = subject.DtStartDay;
                SubjectToUpdate.DtEndDay = subject.DtEndDay;
                SubjectToUpdate.StrFacultyID = subject.StrFacultyID;
            }
            _context.SaveChanges();
        }   

        private void DeleteCurrentSubject(SubjectModel subject)
        {
            var SubjectToDelete = _context.SubjectModels.SingleOrDefault
                    (x => x.StrSubjectID == subject.StrSubjectID);
            _context.SubjectModels.Remove(SubjectToDelete);
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
