using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IStudent
    {
        BindingList<StudentModel> LoadStudent();
        string GetByIDMaxStudent();
        bool AddNewStudent(StudentModel student);
        bool UpdateCurrentStudent(StudentModel student);
        bool DeleteCurrentStudent(StudentModel student);

        //front-end
        bool _checkCharacterNumberStudent(char _C);
        bool _checkCharacterCharStudent(char _C);
    }
}
