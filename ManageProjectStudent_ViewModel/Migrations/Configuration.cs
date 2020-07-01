namespace ManageProjectStudent_ViewModel.Migrations
{
    using ManageProjectStudent_Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManageProjectStudent_ViewModel.DBManageProjectStudentViewModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true ;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ManageProjectStudent_ViewModel.DBManageProjectStudentViewModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //Them thong tin bang student
            //context.StaffModels.AddOrUpdate(p=>p.StrStaffID, new StaffModel()
            //{
            //    StrStaffID = "NV0001",
            //    StrStaffName = "Nguyễn Thị Mai",
            //    StrAddress = "Bình Thạnh, Hồ Chí Minh",
            //    StrCardID = "2451254112",
            //    StrEmail = "Lan@gamil.com",
            //    StrSex = "Nữ",
            //    StrPhone = "0123456789",
            //    BStatus = true,
            //    DtBirthDay = DateTime.Parse("02/03/1989"),
            //    StrFacultyID = "CNTT",
            //    StrStaffTypeID = "GV01"
            //},
            //new StaffModel() 
            //{
            //    StrStaffID = "NV0002",
            //    StrStaffName = "Nguyễn Văn Anh",
            //    StrAddress = "Tân Bình, Hồ Chí Minh",
            //    StrCardID = "2574126541",
            //    StrEmail = "Anh@gamil.com",
            //    StrSex = "Nam",
            //    StrPhone = "0987654321",
            //    BStatus = true,
            //    DtBirthDay = DateTime.Parse("07/10/1979"),
            //    StrFacultyID = "CNTT",
            //    StrStaffTypeID = "GV02"
            //});
            //// Thêm Thông tin loại nhân viên
            //context.StaffTypeModels.AddOrUpdate(p => p.StrStaffTypeID, new StaffTypeModel()
            //{
            //    StrStaffTypeID = "GV01",
            //    StrStaffTypeName = "Giáo Viên",
            //},
            //new StaffTypeModel 
            //{
            //    StrStaffTypeID = "GV02",
            //    StrStaffTypeName = "Tài Vụ",
            //}
            //);
            //// Thêm Thông tin sinh viên  
            //context.StudentModels.AddOrUpdate(p => p.StrStudentID, new StudentModel()
            //{
            //    StrStudentID = "1710001",
            //    StrStudentName = "Trịnh Minh Anh",
            //    StrSex = "Nam",
            //    StrPhone = "0124567885",
            //    StrAddress = "Thủ Đức , Hồ Chí Minh",
            //    StrCardID = "24244511",
            //    StrEmail = "Anh99@gmail.com",
            //    DtBirthDay = DateTime.Parse("10/05/1999"),
            //    DtStartYear = DateTime.Parse("08/09/2017"),
            //    BStatus = true,
            //    StrClassID = "CLA1",
            //    StrFacultyID = "CNTT"
            //}
            //);
        }
        
    }
}
