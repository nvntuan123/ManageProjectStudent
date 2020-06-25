using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("ExamResult")]
    public class ExamResultModel
    {
        private string _StrExamTimesID;
        private string _StrTrainingProgramID;
        private string _StrStudentID;
        private string _StrSubjectID;
        private decimal _DGrade;

        [Key]
        [Column("ExamTimesID", TypeName = "char", Order = 0)]
        [StringLength(10)]
        public string StrExamTimesID { get => _StrExamTimesID; set => _StrExamTimesID = value; }

        [Key]
        [Column("TrainingProgramID", TypeName = "char", Order = 1)]
        [StringLength(10)]
        public string StrTrainingProgramID { get => _StrTrainingProgramID; set => _StrTrainingProgramID = value; }

        [Key]
        [Column("StudentID", TypeName = "char", Order = 2)]
        [StringLength(10)]
        public string StrStudentID { get => _StrStudentID; set => _StrStudentID = value; }

        [Key]
        [Column("SubjectID", TypeName = "char", Order = 3)]
        [StringLength(10)]
        public string StrSubjectID { get => _StrSubjectID; set => _StrSubjectID = value; }

        [Column("Grade", TypeName = "Decimal", Order = 4)]
        public decimal DGrade { get => _DGrade; set => _DGrade = value; }

        //Khai bao khoa ngoai
        public virtual SubjectModel SubjectModel { get; set; }
        public virtual StudentModel StudentModel { get; set; }   
        public virtual ExamTimesModel ExamTimesModel { get; set; }
        public virtual TrainingProgramModel TrainingProgramModel { get; set; }

    }
}
