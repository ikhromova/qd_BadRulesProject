using EntityFrameworkIssues.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkIssues.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
    private SchoolContext db = new SchoolContext();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    public void NPlusOneSelect()
    {
        var students = db.Students;
        foreach (var student in students)
        {
            foreach (var enrollment in student.Enrollments)
            {
                
            }
        }
    }
}