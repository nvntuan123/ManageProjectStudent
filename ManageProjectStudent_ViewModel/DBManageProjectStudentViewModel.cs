using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model; 

namespace ManageProjectStudent_ViewModel
{
    public class DBManageProjectStudentViewModel : DbContext
    {
        public DBManageProjectStudentViewModel() : base("DBManageProjectStudent")
        {
            //var _InitIalizer = new MigrateDatabaseToLatestVersion<DBManageProjectStudentViewModel, Migrations.Configuration>();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBManageProjectStudentViewModel, Migrations.Configuration>());
        }

        public DbSet<StudentModel> StudentModels { get; set; }
        public DbSet<ProjectModel> ProjectModels { get; set; }




    }
}
