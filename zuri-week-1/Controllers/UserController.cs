using Microsoft.AspNetCore.Mvc;

namespace zuri_week_1.Controllers
{
    public class UserController : Controller
    {
        private readonly User User;
        public UserController()
        {
            User = new User
            {
                SlackUsername = "kehinde-dimeji",
                Age = 31,
                Bio = " am an enthusiastic, highly optimistic agile software engineer," +
                " passionate about technology and known to pick up new skills in no short time.",
                Backend = true,
            };
        }

        [HttpGet("Get-User")]
        public IActionResult Get()
        {
            var user = User;
            return Ok(user);
        }
    }
}
