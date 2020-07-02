﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Class")]
    public class ClassModel
    {
        private string _StrClassID;
        private string _StrClassName;
        private string _StrFacultyID;


        [Key]
        [Column("ClassID", TypeName = "char", Order = 0)]
        [StringLength(10)]
        public string StrClassID { get => _StrClassID; set => _StrClassID = value; }

        [Column("ClassName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrClassName { get => _StrClassName; set => _StrClassName = value; }

        // Khai tao khoa ngoai 
        [Column("FacultyID", TypeName = "char", Order = 3)]
        [StringLength(10)]
        public string StrFacultyID { get => _StrFacultyID; set => _StrFacultyID = value; }

        // Khai bao khoa ngoai 
        public virtual FacultyModel FacultyModel { get; set; }

        //Tao moi lien ket
        public ICollection<StudentModel> StudentModels { get; set; }

        public ClassModel()
        {
            this.StudentModels = new HashSet<StudentModel>();

        }
    }
}
