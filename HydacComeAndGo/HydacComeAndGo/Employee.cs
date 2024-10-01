using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydacComeAndGo
{
    public class Employee : Person
    {
        
        
        private string personelGroupe;
        public string PersonelGroupe
        {
            get { return personelGroupe; }
            set { personelGroupe = value; }
        }
        private List<Guest> responsible;
        public List<Guest> Responsible
        {
            get { return responsible; }
            set { responsible = value; }
        }


    }
}
