using Entities;

namespace BusinessLayer
{
    public abstract class FactoryEmployee
    {

        // Factory method with parameter 
        static public Employee CreateEmploye(Employee ContractKind)
        {
            switch (ContractKind.contractTypeName)
            {
                case "HourlySalaryEmployee":
                    return  new EmployeeHourly(ContractKind);
                    
                default :
                    return  new EmployeeMonthly(ContractKind);
             }
        }
    }
}
