using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class VIP
    {      
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Password_ { get => password_; set => password_ = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string TextTel { get => textTel; set => textTel = value; }
        
        private string name;
        private string password;
        private string password_;
        private string gender;
        private string birthday;
        private string textTel;

        public bool Judgment()
        {
            if(String.Equals(password, password_))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
