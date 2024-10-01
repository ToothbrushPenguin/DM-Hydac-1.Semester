using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydacComeAndGo
{
    public class Employee
    {
        private string personelGroupe;
        private List<Guest> responsible;
        public string PersonelGroupe
        {
            get { return personelGroupe; }
            set { personelGroupe = value; }
        }
    }
}
