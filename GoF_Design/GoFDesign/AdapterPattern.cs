using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace GoFDesign
//https://www.dotnettricks.com/learn/designpatterns/adapter-design-pattern-dotnet
{
    //Adapter pattern acts as a bridge between two incompatible interfaces.
    // This pattern involves a single class called adapter which is responsible for communication between two independent or incompatible interfaces.
    internal class AdapterPattern
    {

    }
    ///<summary>
    ///The 'Client' class
    ///</summary>
    public class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;
        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }
        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();
            //To Do: Implement your business logic
            Console.WriteLine("######### Employee List ##########");
            foreach (var item in employee) 
            {
                Console.WriteLine(item);
            }
        }
        ///<summary>
        ///The 'ITarget' interface
        ///</summary>
        public interface ITarget
        {
            List<string> GetEmployeeList();
        }

        ///<summary>
        ///The 'Adaptee' class
        ///</summary>
        public class HRSystem
        {
            public string[][] GetEmployees()
            {
                string[][] employees = new string[4][];
                employees[0] = new string[] { "100", "Danny", "Team Leader" };
                employees[1] = new string[] { "101", "Eric", "Technician" };
                employees[2] = new string[] { "102", "Dennis", "Trainer" };
                employees[3] = new string[] { "103", "Sebas", "Local3" };
                return employees;
            }
        }
        ///<summary>
        ///The 'Adapter' class
        ///</summary>
        public class EmployeeAdapter : HRSystem, ITarget
        {
            public List<string> GetEmployeeList() 
            {
                List<string> employeeList = new List<string>();
                string[][] employees = GetEmployees();
                foreach (string[] employee in employees)
                {
                    employeeList.Add(employee[0]);
                    //employeeList.Add(",");
                    employeeList.Add(employee[1]);
                    //employeeList.Add(",");
                    employeeList.Add(employee[2]);
                    employeeList.Add("\n");
                }
                return employeeList;
            }
        }

    }
}
