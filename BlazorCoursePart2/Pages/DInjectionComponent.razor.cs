using BlazorCoursePart2.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorCoursePart2.Pages
{
    public partial class DInjectionComponent
    {
      [Inject]
      IEmployee MyEmployee { get; set; }
    List<Employee> list;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            list = MyEmployee.GetEmployees();
        }
    }
}
