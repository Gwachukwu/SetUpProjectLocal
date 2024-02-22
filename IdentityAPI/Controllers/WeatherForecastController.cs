using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using IdentityAPI.Models;
using IdentityAPI.Data;

namespace IdentityAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly AppSecurityContext _dbSec;
    private readonly AppDataContext _dbData;
    private readonly UserManager<AppUser> _uMan;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
    AppSecurityContext dbSec,
    AppDataContext dbData
    , UserManager<AppUser> uMan)
    {
        _logger = logger;
        _dbSec = dbSec;
        _dbData = dbData;
        _uMan = uMan;
    }

    [HttpGet(Name = "GetTestString")]
    public async Task<string> Get(string id)
    {
        var user = await _uMan.FindByNameAsync(User.Identity?.Name ?? String.Empty);
        return user?.Email ?? String.Empty;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

}
