using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCase.Tarefas.GetAll;
public class GetAllTarefaUseCase
{
    public ResponseAllTarefaJson Execute()
    {
        return new ResponseAllTarefaJson
        {
            Tarefas = new List<ResponseShortTarefaJson>
            {
                new ResponseShortTarefaJson
                {
                    Id = 1,
                    Tarefa = "Comer uma esfirra",
                    Status = Communication.Enums.StatusType.Concluida
                }
            }
        };
    }
}
