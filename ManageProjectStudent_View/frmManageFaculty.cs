﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageProjectStudent_Interface;
using Unity;

namespace ManageProjectStudent_View
{
    public partial class frmManageFaculty : Form
    {
        private IManageFaculty IMF = Config.Container.Resolve<IManageFaculty>();
        public frmManageFaculty()
        {
            InitializeComponent();
            txtIDFaculty.KeyPress += new KeyPressEventHandler(IMF.txtIDFaculty_KeyPress);
        }
    }
}
