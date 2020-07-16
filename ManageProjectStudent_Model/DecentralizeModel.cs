﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Decentralize")]
    public class DecentralizeModel
    {
        private string _StrFrmID;
        private string _StrStaffTypeID;
        private bool _BFullFuncion;
        private bool _BAdd;
        private bool _BEdit;
        private bool _BDelete;
        private bool _BAccess;

        [Key]
        [Column("FormID" ,TypeName ="varchar", Order =0)]
        [StringLength(100)]
        public string StrFrmID { get => _StrFrmID; set => _StrFrmID = value; }

        [Key]
        [Column("StaffTypeID", TypeName = "varchar", Order = 1)]
        [StringLength(10)]
        public string StrStaffTypeID { get => _StrStaffTypeID; set => _StrStaffTypeID = value; }

        [Column("Full Function", Order = 2)]
        public bool BFullFuncion { get => _BFullFuncion; set => _BFullFuncion = value; }

        [Column("Add", Order = 3)]
        public bool BAdd { get => _BAdd; set => _BAdd = value; }

        [Column("Edit", Order = 4)]
        public bool BEdit { get => _BEdit; set => _BEdit = value; }

        [Column("Delete", Order = 5)]
        public bool BDelete { get => _BDelete; set => _BDelete = value; }

        [Column("Access", Order = 6)]
        public bool BAccess { get => _BAccess; set => _BAccess = value; }

        public virtual StaffTypeModel StaffTypeModel { get; set; }
    }
}
