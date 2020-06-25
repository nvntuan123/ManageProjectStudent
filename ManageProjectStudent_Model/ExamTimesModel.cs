using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("ExamTimes")]
    public class ExamTimesModel
    {
        private string _StrExamTimesID;
        private string _StrTrainingProgramID;
        private string _StrSubjectID;
        private int _ITimes;
        private DateTime _DtExamTime;

        [Key]
        [Column("ExamTimesID", TypeName = "char", Order = 0)]
        [StringLength(10)]
        public string StrExamTimesID { get => _StrExamTimesID; set => _StrExamTimesID = value; }

        [Key]
        [Column("TrainingProgramID", TypeName = "char", Order = 1)]
        [StringLength(10)]
        public string StrTrainingProgramID { get => _StrTrainingProgramID; set => _StrTrainingProgramID = value; }

        [Key]
        [Column("SubjectID", TypeName = "char", Order = 2)]
        [StringLength(10)]
        public string StrSubjectID { get => _StrSubjectID; set => _StrSubjectID = value; }

        [Column("Times", TypeName = "int", Order =3)]
        public int ITimes { get => _ITimes; set => _ITimes = value; }

        [Column("ExamTime" , TypeName ="Date", Order =4)]
        public DateTime DtExamTime { get => _DtExamTime; set => _DtExamTime = value; }

        //Khai bao khoa ngoai
        public virtual SubjectModel SubjectModel { get; set; }
        public virtual TrainingProgramModel TrainingProgramModel { get; set; }

        //Tao moi lien ket
        public ICollection<ExamResultModel> ExamResultModels { get; set; }

        public ExamTimesModel()
        {
            this.ExamResultModels = new HashSet<ExamResultModel>();
        }
    }
}
