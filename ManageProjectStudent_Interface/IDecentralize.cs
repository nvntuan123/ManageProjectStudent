using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IDecentralize
    {
        BindingList<DecentralizeModel> loadDecentralize();
        bool addNewDecentralize(DecentralizeModel Decentralize);
        bool updateCurrentDecentralizef(DecentralizeModel Decentralize);
        bool deleteCurrentDecentralize(DecentralizeModel Decentralize);
        DecentralizeModel getDecentralizeStaffSelected(string StrStaffType);
        List<DecentralizeModel> getListDecentralizeStaff(string StrStaffType);
        List<string> getListDecentralizeStaffID(string StrStaffType);


    }
}
