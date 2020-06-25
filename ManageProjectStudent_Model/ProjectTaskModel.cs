using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("ProjectTask")]
    public class ProjectTaskModel
    {
        private string _StrProjectID;
        private string _StrTaskID;
        private string _StrTaskName;
        private DateTime _DtStartDay;
        private DateTime _DtEndDay;

        
        [Key]
        [Column("ProjectID", TypeName = "char", Order = 0)]
        [StringLength(10)]
        public string StrProjectID { get => _StrProjectID; set => _StrProjectID = value; }
        
        [Key]
        [Column("TaskID", TypeName = "char", Order = 1)]
        [StringLength(10)]
        public string StrTaskID { get => _StrTaskID; set => _StrTaskID = value; }
        
        [Column("TaskName", TypeName = "nvarchar", Order = 2)]
        [StringLength(100)]
        public string StrTaskName { get => _StrTaskName; set => _StrTaskName = value; }
        
        [Column("StartDay", TypeName = "Date", Order = 3)]
        public DateTime DtStartDay { get => _DtStartDay; set => _DtStartDay = value; }
       
        [Column("EndDay", TypeName = "Date", Order = 4)]
        public DateTime DtEndDay { get => _DtEndDay; set => _DtEndDay = value; }

        // Khai bao khoa ngoai.
        public virtual ProjectModel ProjectModel { get; set; }

    }
}
