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
    public class ProjectViewModel : INotifyPropertyChanged
    {
        #region by Phuoc
        public static readonly DBManageProjectStudentViewModel _context = new DBManageProjectStudentViewModel();
        public static BindingList<ProjectModel> LoadProject()
        {
            using (var _context = new DBManageProjectStudentViewModel())
            {
                var result = (from x in _context.ProjectModels.AsEnumerable()
                              select new ProjectModel
                              {
                                  StrProjectID = x.StrProjectID,
                                  StrProjectName = x.StrProjectName,
                                  DtStartDay = x.DtStartDay,
                                  DtEndDay = x.DtEndDay,
                                  StrStaffID = x.StrStaffID,
                                  StrSubjectID = x.StrSubjectID
                              }).ToList();
                return new BindingList<ProjectModel>(result);
            }
        }
 
        public static bool AddNewProject(ProjectModel project)
        {
            try
            {
                _context.ProjectModels.Add(project);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateCurrentProject(ProjectModel project)
        {
            var ProjectToUpdate = _context.ProjectModels.SingleOrDefault
                    (x => x.StrProjectID == project.StrProjectID);
            if (ProjectToUpdate != null)
            {
                ProjectToUpdate.StrProjectID = project.StrProjectID;
                ProjectToUpdate.StrProjectName = project.StrProjectName;
                ProjectToUpdate.DtStartDay = project.DtStartDay;
                ProjectToUpdate.DtEndDay = project.DtEndDay;
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

        public static bool DeleteCurrentProject(ProjectModel project)
        {
            var ProjectToDelete = _context.ProjectModels.SingleOrDefault
                    (x => x.StrProjectID == project.StrProjectID);
            try
            {
                _context.ProjectModels.Remove(ProjectToDelete);
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
    #endregion

}
