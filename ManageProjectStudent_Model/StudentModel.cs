﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Student")]
    public class StudentModel
    {
        private string _StrStudentID;
        private string _StrStudentName;
        private DateTime _DtBirthDay;
        private int _ICardID;
        private string _StrEmail;
        private string _StrPhone;
        private string _StrAddress;
        private DateTime _DtStartYear;
        private bool _BStatus;
        private string _StrFacultyID;
        private string _StrClassID;

        [Key]
        [Column("StudentID", TypeName = "char", Order = 0)]
        [StringLength(10)]
        public string StrStudentID { get => _StrStudentID; set => _StrStudentID = value; }

        [Column("StudentName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrStudentName { get => _StrStudentName; set => _StrStudentName = value; }

        [Column("BirthDay", TypeName = "Date", Order = 2)]
        public DateTime DtBirthDay { get => _DtBirthDay; set => _DtBirthDay = value; }

        [Column("CardID", TypeName = "int", Order = 3)]
        public int ICardID { get => _ICardID; set => _ICardID = value; }

        [Column("Email", TypeName = "varchar", Order = 4)]
        [StringLength(200)]
        public string StrEmail { get => _StrEmail; set => _StrEmail = value; }
      
        [Column("Phone", TypeName = "varchar", Order = 5)]
        [StringLength(30)]
        public string StrPhone { get => _StrPhone; set => _StrPhone = value; }

        [Column("Address", TypeName = "nvarchar", Order = 6)]
        public string StrAddress { get => _StrAddress; set => _StrAddress = value; }

        [Column("StartYear", TypeName = "Date", Order = 7)]
        public DateTime DtStartYear { get => _DtStartYear; set => _DtStartYear = value; }

        [Column("Status", TypeName = "bit", Order = 8)]
        public bool BStatus { get => _BStatus; set => _BStatus = value; }

        [Column("FacultyID", TypeName = "char", Order = 9)]
        [StringLength(10)]
        public string StrFacultyID { get => _StrFacultyID; set => _StrFacultyID = value; }

        [Column("ClassID", TypeName = "char", Order = 10)]
        [StringLength(10)]
        public string StrClassID { get => _StrClassID; set => _StrClassID = value; }

        //Khai bao khoa ngoai
        public virtual FacultyModel FacultyModel { get; set; }
        public virtual ClassModel ClassModel { get; set; }

        //Tao moi lien ket
        public ICollection<ResultProjectModel> ResultProjectModels { get; set; }
        public ICollection<ExamResultModel> ExamResultModels { get; set; }
        public ICollection<TeachAndStudy> TeachAndStudies { get; set; }
        public ICollection<StudentClassGroup> StudentClassGroups { get; set; }

        public StudentModel()
        {
            this.ResultProjectModels = new HashSet<ResultProjectModel>();
            this.ExamResultModels = new HashSet<ExamResultModel>();
            this.TeachAndStudies = new HashSet<TeachAndStudy>();
            this.StudentClassGroups = new HashSet<StudentClassGroup>();
        }
    }
}
