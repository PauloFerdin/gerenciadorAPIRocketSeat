using Gerenciador.Application.UseCase.Tarefas.Delete;
using Gerenciador.Application.UseCase.Tarefas.GetAll;
using Gerenciador.Application.UseCase.Tarefas.GetById;
using Gerenciador.Application.UseCase.Tarefas.Register;
using Gerenciador.Application.UseCase.Tarefas.Update;
using Gerenciador.Communication.Requests;
using Gerenciador.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GerenciadorController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTarefasJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTarefasJson request)
    {
        var useCase = new RegisterTarefasUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);

    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTarefasJson request)
    {
        var useCase = new UpdateTarefaUseCase();

        useCase.Execute (id, request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseAllTarefaJson>), StatusCodes.Status200OK)]
    public IActionResult GetAll ()
    {
        var useCase = new GetAllTarefaUseCase();
        var response = useCase.Execute();
        if (response.Tarefas.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var useCase = new GetTarefaByIdUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete (int id)
    {
        var useCase = new DeleteTarefaByIdUseCase ();
        useCase.Execute(id);
        return NoContent();
    }

}
