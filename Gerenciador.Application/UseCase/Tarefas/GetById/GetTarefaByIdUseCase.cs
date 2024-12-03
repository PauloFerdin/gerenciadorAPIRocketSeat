using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCase.Tarefas.GetById;
public class GetTarefaByIdUseCase
{
    public ResponseTarefaJson Execute(int id)
    {
        return new ResponseTarefaJson
        {
            Id = id,
            Tarefa = "Jogar bola",
            Status = Communication.Enums.StatusType.NãoIniciada,
            Prioridade = 0,
        };
    }
}
