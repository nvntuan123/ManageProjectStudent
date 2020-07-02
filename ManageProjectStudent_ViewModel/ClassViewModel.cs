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
    public class ClassViewModel : INotifyPropertyChanged
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public static BindingList<ClassModel> LoadClass()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.ClassModels.AsEnumerable()
                              select new ClassModel
                              {
                                  StrClassID = x.StrClassID,
                                  StrClassName = x.StrClassName,
                                  StrFacultyID = x.StrFacultyID,
                                  
                              }).ToList();
                return new BindingList<ClassModel>(Result);
            }
        }
        public static string GetByIDMaxClass()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.ClassModels.OrderByDescending(c => c.StrClassID).Select(c => c.StrClassID);
                var Result = query.First();
                return Result;
            }
        }

        public static void AddNewClass(ClassModel classModel)
        {
            _Context.ClassModels.Add(classModel);
            _Context.SaveChanges();
        }

        public static void UpdateCurrentClassf(ClassModel classModel)
        {
            var ClassToUpdate = _Context.ClassModels.SingleOrDefault
                    (x => x.StrClassID == classModel.StrClassID);
            if (ClassToUpdate != null)
            {
                ClassToUpdate.StrClassName = classModel.StrClassName;
                ClassToUpdate.StrFacultyID = classModel.StrFacultyID;
            }
            _Context.SaveChanges();
        }

        public static void DeleteCurrentClass(ClassModel classModel)
        {
            var ClassToDelete = _Context.ClassModels.SingleOrDefault
                    (x => x.StrClassID == classModel.StrClassID);
            _Context.ClassModels.Remove(ClassToDelete);
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
    #endregion
}
