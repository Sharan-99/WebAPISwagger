using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSwagger.Controllers
{
    [Route("api/emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id=101,Name="Sharan",Location="Chennai",Salary=26000 },
            new Employee(){Id=102,Name="Naveen",Location="Coimbatore",Salary=30000},
            new Employee(){Id=103,Name="Tharun",Location="Hyderabad",Salary=50000},
            new Employee(){Id=104,Name="Gokul",Location="Bengaluru",Salary=80000}
        };

        [HttpGet]
        public IEnumerable<Employee> get()
        {
            return employees;
        }

    }
}
