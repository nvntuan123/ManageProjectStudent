﻿using ManageProjectStudent_Model;
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
    public class StudentViewModel : INotifyPropertyChanged
    {
        private readonly DBManageProjectStudentViewModel _context = new DBManageProjectStudentViewModel();
        private ICollection<FacultyModel> _Faculty;
        public static List<StudentModel> LoadStudent()
        {
            using (var _context = new DBManageProjectStudentViewModel())
            {
                var student = (from u in _context.StudentModels.AsEnumerable()
                             select new
                             {
                                 ID = u.StrStudentID,
                                 Name = u.StrStudentName,
                                 Address = u.StrAddress,
                                 Birthday = u.DtBirthDay,
                                 CardID = u.ICardID,
                                 Phone = u.StrPhone,
                                 Email = u.StrEmail,
                                 Status = u.BStatus,
                                 StartYear = u.DtStartYear,
                                 FacultyID = u.StrFacultyID,
                                 ClassID = u.StrClassID
                              })
                            .Select(x => new StudentModel
                            {
                                StrStudentID = x.ID,
                                StrStudentName = x.Name,
                                StrEmail = x.Email,
                                DtBirthDay = x.Birthday,
                                ICardID = x.CardID,
                                StrPhone = x.Phone,
                                StrAddress = x.Address,
                                DtStartYear = x.StartYear,
                                StrFacultyID = x.FacultyID,
                                StrClassID =x.ClassID
                            });
                return student.ToList();
            }
        }
      
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
        private ICollection<StudentModel> _StudentModels;
        public ICollection<StudentModel> StudentModels
        {
            get
            {
                return
                    new ObservableCollection<StudentModel>(_context.StudentModels.Include(e =>e.FacultyModel));
            }
            set
            {
                _StudentModels = value;
                OnPropertyChanged("Student");
            }
        }
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
                StudentToUpdate.DtStartYear = student.DtStartYear;
                StudentToUpdate.ICardID = student.ICardID;
                StudentToUpdate.StrFacultyID = student.StrFacultyID;
                StudentToUpdate.StrClassID = student.StrClassID;
                StudentToUpdate.BStatus = student.BStatus;
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
