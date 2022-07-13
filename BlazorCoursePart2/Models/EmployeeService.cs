namespace BlazorCoursePart2.Models
{
    public class EmployeeService : IEmployee
    {
        List<Employee> _employees;
        public EmployeeService()
        {

            _employees = new List<Employee> {  new Employee{Name="adil",Department="SE"}
            ,new Employee{Name="hassan",Department="CS" } };



        }
        public List<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
