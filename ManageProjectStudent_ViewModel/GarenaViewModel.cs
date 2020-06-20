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
    public class GarenaViewModel
    {
        public static bool _checkCharacterNumber(char _C)
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
        public static bool _checkCharacterChar(char _C)
        {
            if (((_C >= 65 && _C <= 90) || (_C >= 97 && _C <= 122))
                || ((Keys)_C != Keys.Back) || ((Keys)_C != Keys.Enter))
            {
                return true;
            }
            return false;
            
            
        }
        public static bool checkEmail(string _STR_Email)
        {
            return (_STR_Email.IndexOf("@gmail.com") >= 0);
        }
        public static bool checkIDCard(string _STR_IDCard)
        {
            if ((_STR_IDCard.Length > 9) || (_STR_IDCard.Length <= 10))
                return false;
            return true;
        }
        public static bool checkPhoneNumber(string _STR_PhoneNumber)
        {
            if ((_STR_PhoneNumber.Length < 10) || (_STR_PhoneNumber.Length > 10))
                return false;
            return true;
        }
    }
}
