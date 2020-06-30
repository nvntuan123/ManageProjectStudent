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
        private readonly DBManageProjectStudentViewModel _context = new DBManageProjectStudentViewModel();
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
        private ICollection<ResultProjectModel> _ResultProjectModels;
        public ICollection<ResultProjectModel> ResultProjectModels
        {
            get
            {
                return
                    new ObservableCollection<ResultProjectModel>(_context.ResultProjectModels);
            }
            set
            {
                _ResultProjectModels = value;
                OnPropertyChanged("Result");
            }
        }
        private ICollection<ProjectModel> _ProjectModels;
        public ICollection<ProjectModel> ProjectModes

        {
            get
            {
                return
                    new ObservableCollection<ProjectModel>(_context.ProjectModels.Include(e => e.ResultProjectModels));
            }
            set
            {
                _ProjectModels = value;
                OnPropertyChanged("Project");
            }
        }
        private ICollection<ProjectTaskModel> _ProjectTaskModels;
        public ICollection<ProjectTaskModel> ProjectTaskModels
        {
            get
            {
                return
                    new ObservableCollection<ProjectTaskModel>(_context.ProjectTaskModels);
            }
            set
            {
                _ProjectTaskModels = value;
                OnPropertyChanged("ProjectTask");
            }
        }
        private ProjectModel _currentSelectedProject;
        public ProjectModel CurrentSelecteProject
        {
            get
            {
                return _currentSelectedProject;
            }
            set
            {
                _currentSelectedProject = value;
                OnPropertyChanged("CurrentSelectedProject");
            }
        }

        private void AddNewProject(ProjectModel project)
        {
            _context.ProjectModels.Add(project);
            _context.SaveChanges();
        }

        private void UpdateCurrentProject(ProjectModel project)
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
            _context.SaveChanges();
        }

        private void DeleteCurrentProject(ProjectModel project)
        {
            var ProjectToDelete = _context.ProjectModels.SingleOrDefault
                    (x => x.StrProjectID == project.StrProjectID);
            _context.ProjectModels.Remove(ProjectToDelete);
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
    #endregion

}
