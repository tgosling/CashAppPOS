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

       protected void OnStartup(StartupEventArgs e)
        {
            empList = new List<Employee>();
            loadEmployees();
        }

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



        public void loadEmployees()
        {
            try
            {
                if (File.Exists("employees.json"))
                {
                    string jsonString = File.ReadAllText("employees.json");
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
