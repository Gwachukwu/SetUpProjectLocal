using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using StringCommands;

namespace StringAPI.Controllers;

[ApiController]
[Route("{controller}/{action}")]
public class StringController : ControllerBase
{
    public string UpperCase([FromQuery] string input)
    {
        StringCommand cmd = new UpperCaseCommand();
        return cmd.Execute(input);
    }
     public string LowerCase([FromQuery] string input)
    {
        StringCommand cmd = new LowerCaseCommand();
        return cmd.Execute(input);
    }
}