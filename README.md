🚀 # gerenciadorAPIRocketSeat

Este projeto é uma API RESTful para um sistema de Gerenciamento de Tarefas, criada com base em princípios de arquitetura em camadas. A API permite aos usuários gerenciar suas tarefas com eficiência, suportando operações básicas de criação, visualização, edição e exclusão.

🎯 Requisitos e Funcionalidades

 - Arquitetura em Camadas

        * Camada de Comunicação: Responsável por expor os endpoints da API e tratar as requisições e respostas.

        * Camada de Regras de Negócio: Processa as lógicas específicas da aplicação e validações.

        * Camada de Dados: Gerencia a persistência e recuperação de dados no banco.

 - Campos das Tarefas

        * Id: Identificador único da tarefa.

        * Nome: Nome descritivo da tarefa.

        * Descrição: Texto explicativo sobre o objetivo ou detalhes da tarefa.

        * Prioridade: Define a importância da tarefa (Ex.: Alta, Média, Baixa).

        * Data Limite: Data em que a tarefa deve ser concluída.

        * Status: Estado atual da tarefa (Ex.: Não Iniciada, Em Andamento, Aguardando, Concluída, Atrasada).

- Endpoints

        * POST /tarefas: Cria uma nova tarefa.

        * GET /tarefas: Lista todas as tarefas.

        * GET /tarefas/{id}: Retorna os detalhes de uma tarefa específica.

        * PUT /tarefas/{id}: Atualiza as informações de uma tarefa.

        * DELETE /tarefas/{id}: Remove uma tarefa.

💡 Tecnologias Utilizadas

   * Linguagem: C# com .NET Core

   * Framework: ASP.NET Core


-------------------------------------------------------------

   Exemplo de JSON para criação de tarefa

{
  "nome": "Finalizar documentação",
  "descricao": "Completar o README do projeto",
  "prioridade": "Alta",
  "dataLimite": "2024-12-05",
  "status": "NaoIniciada"
}
