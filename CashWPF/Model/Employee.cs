using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashWPF.Model
{
    class Employee
    {
        public string empUsrName { get; set; }
        public string empPassW { get; set; }

        public Employee(string usrName, string passW)
        {
            this.empUsrName = usrName;
            this.empPassW = passW;
        }
    }
}
