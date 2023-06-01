namespace DI_demo_api_employee
{
    public class Employee
    {

        public int eId { get; set; }
        public string eName { get; set; }
        public string eDesignation { get; set; }
        public double eSalary { get; set; }
        public bool eIsPermenant { get; set; }

        static List<Employee> eLIst = new List<Employee>()
        {
            new Employee(){ eId=101, eName="Kasish", eDesignation="Sales", eIsPermenant=true, eSalary=5000},
            new Employee(){ eId=102, eName="Kasish", eDesignation="Sales", eIsPermenant=true, eSalary=5000},
            new Employee(){ eId=103, eName="Kasish", eDesignation="Sales", eIsPermenant=true, eSalary=5000},
            new Employee(){ eId=104, eName="Kasish", eDesignation="Sales", eIsPermenant=true, eSalary=5000},
            new Employee(){ eId=105, eName="Kasish", eDesignation="Sales", eIsPermenant=true, eSalary=5000},
            new Employee(){ eId=106, eName="Kasish", eDesignation="Sales", eIsPermenant=true, eSalary=5000}
        };

        public List<Employee> GetEmployees()
        {
            return eLIst;
        }
    }
}
