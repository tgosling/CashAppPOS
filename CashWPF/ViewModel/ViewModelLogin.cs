using CashWPF.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace CashWPF.ViewModel
{
    class ViewModelLogin
    {
        public List<Employee> empList { get; set; }
        public int loggedInUser { get; set; }

        //Checks to see if the employee is valid in list of employees
        public bool checkLogin(string userN, string passW)
        {
            int count = 0;
            foreach (Employee hold in empList)
            {
                if (hold.empUsrName == userN && hold.empUsrName == passW)
                {
                    loggedInUser = count;
                    return true;
                }
                count++;
            }
            return false;
        }



        public void loadUsers()
        {
            try
            {
                if (File.Exists("users.json"))
                {
                    string jsonString = File.ReadAllText("users.json");
                    empList = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
