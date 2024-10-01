using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HydacComeAndGo
{
    internal class Log
    {
        private DateTime arrival;
        public DateTime Arrival
        {
            get { return arrival; }
            set { arrival = value; }
        }

        private DateTime departuer;
        public DateTime Departuer
        {
            get { return departuer; }
            set { departuer = value; }
        }

        private string room;
        public string  Room
        {
            get { return room; }
            set { room = value; }
        }


    }
}
