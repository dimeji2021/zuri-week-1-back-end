using Microsoft.AspNetCore.Mvc;
using zuri_week_1.Model;
using zuri_week_1.Service;

namespace zuri_week_1.Controllers
{
    public class UserController : Controller
    {
        private readonly User User;
        private readonly IArithemeticOperations _arithemetic;

        public UserController(IArithemeticOperations arithemetic)
        {
            User = new User
            {
                SlackUsername = "kehinde-dimeji",
                Age = 31,
                Bio = " am an enthusiastic, highly optimistic agile software engineer," +
                " passionate about technology and known to pick up new skills in no short time.",
                Backend = true,
            };
            _arithemetic = arithemetic;
        }

        [HttpGet("Get-User")]
        public IActionResult Get()
        {
            var user = User;
            return Ok(user);
        }
        [HttpPost("perform-basic-arithmetic-operations")]
        public IActionResult PerformArithmeticOperation(InputDto input)
        {
            var result = _arithemetic.BasicOperation(input);
            return Ok(result);
        }
    }
}
