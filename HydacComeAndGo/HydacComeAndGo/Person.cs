using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydacComeAndGo
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int phoneNO;
        public int PhoneNO
        {
            get { return phoneNO; }
            set { phoneNO = value; }
        }

        private string eMail;
        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        private string contactPerson;
        public string ContactPerson
        {
            get { return contactPerson; }
            set { contactPerson = value; }
        }
        private int contactPersonNO;
        public int ContactPersonNO
        {
            get { return contactPersonNO; }
            set { contactPersonNO = value; }
        }
        private List<Log> logs;
        public List<Log> Logs
        {
            get { return logs; }
            set { logs = value; }
        }
        private bool isCheckedIn;
        public bool IsCheckedIn
        {
            get { return isCheckedIn; }
            set { isCheckedIn = value; }

        }
    }
}
