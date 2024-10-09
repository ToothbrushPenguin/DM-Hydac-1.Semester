using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace HydacComeAndGo
{
    public class Menu
    {
        public Choice DisplayAddPerson()
        {
            return Choice;
        }

        private Type getPerson;
        public Type GetPerson()
        {
            get { return getPerson; }
        }

        private Company getCompanyName;
        public Company GetCompanyName()
        {
            get { return getCompanyName; }
        }

        private PersonelGroup getPersonalGroup;
        public PersonelGroup GetPersonalGroup()
        {
            get { return getPersonalGroup; }
        }

        private Name getPersonName;
        public Name GetPersonName()
        {
            get { return getPersonName; }
        }

        private PhoneNO getPersonNumber;
        public PhoneNO GetPersonNumber()
        {
            get { return getPersonNumber; }
        }

        private Email getPersonEmail;
        public Email GetPersonEmail()
        {
           get { return getPersonalEmail; }
        }

        private GetContactPerson getContactPerson;
        public GetContactPerson GetContactPerson()
        {
            get { return getContactPerson; }
        }



        private contactPersonNO getContactPersonNO;
        public ContactPersonNO GetContactPersonNO()
        {
            get { return getContactPersonNO; }
        }

        public string EnterEmail()
        {
            return EnterEmail;
        }

        public Email GetEmail()
        {
            get { return Email; }
        }

        public List AllPersonListShown()
        {
            return List;
        }

        public NoAccess()
        {
            return;
        }
    }   
}
