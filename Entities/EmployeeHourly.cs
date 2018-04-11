namespace Entities
{
    public class EmployeeHourly :  Employee
    {
        public EmployeeHourly()
        {

        }
        public EmployeeHourly(Employee objEmployee)
        {
            this.id = objEmployee.id;
            this.contractTypeName = objEmployee.contractTypeName;
            this.hourlySalary = objEmployee.hourlySalary;
            this.monthlySalary = objEmployee.monthlySalary;
            this.roleDescription = objEmployee.roleDescription;
            this.roleId = objEmployee.roleId;
            this.roleName = objEmployee.roleName;
            this.name = objEmployee.name;
        }



        /// <summary>
        /// Return Salary of Employee with Hourly Contract 
        /// </summary>
        /// <returns></returns>
        public override double AnnualSalary => 120 * this.hourlySalary * 12;


    }
}
