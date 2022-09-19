using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        public UsersController(ExampleClass exampleClass)
        {

        }

        //URL = api/users/id(1,2..)
        [HttpGet("{id}")]//Consulta do usuário
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //URL = api/users
        [HttpPost]//Cadastro do usuário
        public IActionResult Post([FromBody] CreateUsersModel createUsersModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUsersModel);
        }

        //URL = api/users/id(1,2..)/login
        [HttpPost("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel loginModel)
        {
            return NoContent();
        }
    }
}
