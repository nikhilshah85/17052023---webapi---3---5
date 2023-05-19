namespace employeeAPI.Models
{
    public class employeeDetails
    {

        #region Properties
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        #endregion

        #region Data Store

        static List<employeeDetails> empList = new List<employeeDetails>()
        {
            new employeeDetails(){ empNo=101, empName="Suman", empDesignation="Sales", empIsPermenant=true, empSalary=6000},
            new employeeDetails(){ empNo=102, empName="Kriti", empDesignation="HR", empIsPermenant=true, empSalary=4000},
            new employeeDetails(){ empNo=103, empName="Priya", empDesignation="Sales", empIsPermenant=false, empSalary=16000},
            new employeeDetails(){ empNo=104, empName="Aman", empDesignation="Sales", empIsPermenant=true, empSalary=45000},
            new employeeDetails(){ empNo=105, empName="Mohit", empDesignation="Sales", empIsPermenant=true, empSalary=12000},
            new employeeDetails(){ empNo=106, empName="Sumit", empDesignation="HR", empIsPermenant=false, empSalary=9000},
        };

        #endregion

        #region Get Methods
        public List<employeeDetails> GetAllEmployees()
        {
            return empList;
        }

        public employeeDetails GetEmpById(int id)
        {
            var emp = empList.Find(e => e.empNo == id);
            if (emp != null)
            {
                return emp;
            }
            throw new Exception("Employee Not found");
        }

        public int TotalEmployees()
        {
            var count = empList.Count;
            return count;
        }

        #endregion

        #region CRUD
        public string AddnewEmployee(employeeDetails newEmpObj)
        {
            if (newEmpObj.empName.Length < 3)
            {
                throw new Exception("Name should be more than 3 characters");
            }
            empList.Add(newEmpObj);
            return "Employee Added Successfully";
        }
        public string DeleteEmployee(int id)
        {
            var emp = empList.First(e => e.empNo == id);
            if (emp != null)
            {
                empList.Remove(emp);
                return "Employee Deleted succssfully";
            }
            throw new Exception("Employee Not found");
        }
        public string EditEmployee(employeeDetails empObj)
        {
            var emp = empList.First(e => e.empNo == empObj.empNo);
            if (emp != null)
            {
                emp.empName = empObj.empName;
                emp.empDesignation = empObj.empDesignation;
                emp.empSalary = empObj.empSalary;
                return "Employee Edited Successfully";
            }
            throw new Exception("Employee Not found");
        }

        #endregion


    }
}
