# Simples Gerenciador de Contatos

Um projeto em C# que simula um gerenciador de contatos simples via console.

## Funcionalidades

- Adicionar novos contatos
- Listar todos os contatos
- Buscar um contato específico
- Editar contatos existentes
- Remover contatos
- Salvar contatos

## Como executar

Certifique-se de que você tem o [.NET SDK](https://dotnet.microsoft.com/download) instalado.

### Comandos:

```bash
dotnet build
dotnet run
```

## Estrutura do Projeto

- `Contact_list.csproj` – Arquivo de configuração do projeto
- `Program.cs` – Ponto de entrada do aplicativo
- `ControllerContact/` – Lógica de controle dos contatos
- `Data/` – Armazenamento de dados (ex: lista de contatos)
- `UI/` – Interações com o usuário via terminal
