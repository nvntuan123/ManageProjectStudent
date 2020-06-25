using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Staff")]
    public class StaffModel
    {
        private string _StrStaffID;
        private string _StrStaffName;
        private int _ICardID;
        private DateTime _DtBirthDay;
        private string _StrEmail;
        private string _StrAddress;
        private string _StrPhone;
        private bool _BStatus;

        [Key]
        [Column("StaffID", TypeName = "char", Order = 0)]
        [StringLength(10)]
        public string StrStaffID { get => _StrStaffID; set => _StrStaffID = value; }
       
        [Column("StaffName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrStaffName { get => _StrStaffName; set => _StrStaffName = value; }
       
        [Column("CardID", TypeName = "int", Order = 2)]
        public int ICardID { get => _ICardID; set => _ICardID = value; }
       
        [Column("BirthDay", TypeName = "Date", Order = 3)]
        public DateTime DtBirthDay { get => _DtBirthDay; set => _DtBirthDay = value; }
       
        [Column("Email", TypeName = "varchar", Order = 4)]
        [StringLength(200)]
        public string StrEmail { get => _StrEmail; set => _StrEmail = value; }
       
        [Column("Address", TypeName = "nvarchar", Order = 5)]
        public string StrAddress { get => _StrAddress; set => _StrAddress = value; }
       
        [Column("Phone", TypeName = "varchar", Order = 6)]
        [StringLength(30)]
        public string StrPhone { get => _StrPhone; set => _StrPhone = value; }
        
        [Column("Status", TypeName = "bit", Order =7)]
        public bool BStatus { get => _BStatus; set => _BStatus = value; }

        // khai bao khoa ngoai
        public virtual StaffTypeModel StaffTypeModel { get; set; }
        public virtual FacultyModel FacultyModel { get; set; }

        // tao moi quan he 1
        public ICollection<ProjectModel> ProjectModels { get; set; }
        public ICollection<ClassGroupOfSubject> ClassGroupOfSubjects { get; set; }
        public ICollection<TeachAndStudy> TeachAndStudies { get; set; }

        public StaffModel()
        {
            this.ProjectModels = new HashSet<ProjectModel>();
            this.ClassGroupOfSubjects = new HashSet<ClassGroupOfSubject>();
            this.TeachAndStudies = new HashSet<TeachAndStudy>();
        }
    }
}
