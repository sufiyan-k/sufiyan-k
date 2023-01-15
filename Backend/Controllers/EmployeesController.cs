using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using BOL;
using DAL.UsersDataAccess;
namespace EmployeesController;

[ApiController]
[Route("[controller]")]
public class EmployeesController : ControllerBase
{
    
    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [EnableCors()]
    public IEnumerable<Employee> GetAllEmployees()
    {
        List<Employee> emplist=UsersDataAccess.GetAllEmployees();
        return emplist;
        
    }
}
