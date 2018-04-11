namespace Entities
{
    public class EmployeeMonthly : Employee
    {
        public EmployeeMonthly()
        {

        }
        public EmployeeMonthly(Employee objEmployee)
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
        /// Return Salary of Employee with Monthly Contract 
        /// </summary>
        /// <returns></returns>
        public override double AnnualSalary => this.monthlySalary * 12;
    }
}
