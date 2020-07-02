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
    public class SubjectViewModel : INotifyPropertyChanged
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public static BindingList<SubjectModel> LoadSubject()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.SubjectModels.AsEnumerable()
                              select new SubjectModel
                              {
                                  StrSubjectID = x.StrSubjectID,
                                  StrSubjectName = x.StrSubjectName,
                                  StrFacultyID = x.StrFacultyID,
                                  DtStartDay = x.DtStartDay,
                                  DtEndDay = x.DtEndDay
                              }).ToList();
                return new BindingList<SubjectModel>(Result);
            }
        }
        public static string GetByIDMaxSubject()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.SubjectModels.OrderByDescending(c => c.StrSubjectID).Select(c => c.StrSubjectID);
                var Result = query.First();
                return Result;
            }
        }

        public static bool AddNewSubject(SubjectModel Subject)
        {
            try
            {
                _Context.SubjectModels.Add(Subject);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateCurrentSubjectf(SubjectModel Subject)
        {
            var SubjectToUpdate = _Context.SubjectModels.SingleOrDefault
                    (x => x.StrSubjectID == Subject.StrSubjectID);
            if (SubjectToUpdate != null)
            {
                SubjectToUpdate.StrSubjectName = Subject.StrSubjectName;
                SubjectToUpdate.StrFacultyID = Subject.StrFacultyID;
                SubjectToUpdate.DtStartDay = Subject.DtStartDay;
                SubjectToUpdate.DtEndDay = Subject.DtEndDay;
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

        public static bool DeleteCurrentSubject(SubjectModel Subject)
        {
            var SubjectToDelete = _Context.SubjectModels.SingleOrDefault
                    (x => x.StrSubjectID == Subject.StrSubjectID);
            try
            {
                _Context.SubjectModels.Remove(SubjectToDelete);
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
