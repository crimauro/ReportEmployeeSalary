using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class EmployeeBL
    {

        public List<Employee> LstEmployees { get; set; }


        public EmployeeBL()
        {
            LstEmployees = new List<Employee>();
        }

        /// <summary>
        /// Return all employeess
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {

            DataLayer.EmployeeDL objEmployeeDL = null;
            try
            {
                objEmployeeDL = new DataLayer.EmployeeDL();
                List<EmployeeData> employeesWebService = objEmployeeDL.GetEmployees();

                foreach (Employee item in employeesWebService)
                {
                    LstEmployees.Add(FactoryEmployee.CreateEmploye(item));
                }
            }
            catch (Exception ex)
            {

            }

            return LstEmployees;
        }



        /// <summary>
        /// Return a single employee 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployees(int id)
        {
            if(LstEmployees.Any())
                return LstEmployees.FirstOrDefault(x => x.id == id);
            else
                return GetEmployees().FirstOrDefault(x => x.id == id);
        }

    }
}
