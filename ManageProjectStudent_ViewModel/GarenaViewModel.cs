using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using ManageProjectStudent_Interface;
using System.Runtime.CompilerServices;

namespace ManageProjectStudent_ViewModel
{
    public class GarenaViewModel : INotifyPropertyChanged, IGarena
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool _checkCharacterNumber(char _C)
        {
            //if ((_C >= '0' && _C <= '9') && ((Keys)_C != Keys.Back) && ((Keys)_C != Keys.Enter))
            //{
            //    return true;
            //}
            //return false;
            return ((_C < '0' || _C > '9')
                && ((Keys)_C != Keys.Back)
                && ((Keys)_C != Keys.Enter)
                );
        }
    }
}
