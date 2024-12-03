using Gerenciador.Communication.Requests;
using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCase.Tarefas.Register;
public class RegisterTarefasUseCase
{
    public ResponseRegisterTarefasJson Execute(RequestTarefasJson request)
    {
        return new ResponseRegisterTarefasJson
        {
            Id = 7,
            Tarefas = request.Tarefas,
        };
    }
}
