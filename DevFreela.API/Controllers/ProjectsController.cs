using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]//rota base
    public class ProjectsController : ControllerBase//Controller
    {
        private readonly OpeningTimeOption _option;//variável privada
        public ProjectsController(IOptions<OpeningTimeOption> opition, ExampleClass exampleClass)//exemplo de injeção de dependência
        //IOptions<OpeningTimeOption> opition : está passando as configurações para "opition"
        {
            exampleClass.Name = "Update at ProjectsController";

            _option = opition.Value;//obtém o valor
        }

        //URL = api/project?query=net core
        [HttpGet]//rota http
        public IActionResult Get(string query)//Método Action
        {
            //Buscar todos ou filtrar

            return Ok();//Esse método é herdado de ControllerBase
        }

        //URL = api/project/id (1,2 ou ...)
        [HttpGet("{id}")]//consultar apenas um
        public IActionResult GetById(int id)
        {
            //Buscar o projeto

            //return Not Found();

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProjetcModel)
        // corpo da requisição pega um objeto do tipo CreateProjectModel.
        {
            if (createProjetcModel.Title.Length > 50)
            {
                return BadRequest();
            }

            //Cadastrar o projeto

            return CreatedAtAction(nameof(GetById), new { id = createProjetcModel.Id }, createProjetcModel);

            // nome da API que irá obter os detalhes (cadastrou? retorna para a API como ele pode encontrar o objeto que foi cadastrado).
            // objeto anônimo, que terá o parametro que a essa API retorna.
            // objeto cadastrado
        }

        //URL = api/project/id (1,2 ou ...)
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProjectModel)
            // passa o dentificador e o corpo da requisição do obejto que será atualizado
        {
            if (updateProjectModel.Description.Length > 200)
            {
                return BadRequest();
            }

            //Atualizo o objeto

            return NoContent();
        }

        //URL = api/project/id (1,2 ou ...)
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, se não existir, retorna NotFound


            // Remover (aconselhado a não excluir permanentemente, e sim, alterar uma flag de "ativo" para "inativo")

            return NoContent();
        }

        //URL = api/project/id (1,2 ou ...)/comments
        [HttpPost("{id}/comments")]//Cadastrar comentário
        public IActionResult PostComments(int id, [FromBody] CreateCommentModel createCommentModel)
        {
            return NoContent();
        }

        //URL = api/project/id (1,2 ou ...)/start
        [HttpPut("{id}/start")]//Atualização do cadastro
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //URL = api/project/id (1,2 ou ...)/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}
