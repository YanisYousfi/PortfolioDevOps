using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private static readonly List<string> MyTasks = new()
    {
        "Learning Docker",
        "Master GitHub Actions",
    };

    [HttpGet]
    public IEnumerable<string> Get()
    {
        return MyTasks;
    }
}
