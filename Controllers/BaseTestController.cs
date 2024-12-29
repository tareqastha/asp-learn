using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/test")]
public class BaseTestController : ControllerBase
{


    private readonly ILogger<BaseTestController> _logger;
    public BaseTestController(ILogger<BaseTestController> _service)
    {
        _logger = _service;
    }

    [HttpGet]
    public object GetBaseTest()
    {
        _logger.LogInformation("Getting BaseTest");
        return new BaseTest
        {
            Message = "Hello World from BaseTestController"
        };
    }
}