Rodar o programa
- dotnet run
Migração banco de dados
- dotnet ef migrations add NomeDaNovaMigracao
- dotnet ef databa
- se update
EXEMPLO DE REQUISIÇÃO:
- ```{
  "editora": "Editora Exemplo",
  "edicao": 1,
  "anoPublicado": "2023",
  "livroAssuntos": [
    {
      "assuntoId": 1,
      "assunto": {
        "descricao": "Ficção Científica"
      }
    }
  ],
  "livroAutores": [
    {
      "autorId": 1,
      "autor": {
        "nome": "John Doe"
      }
    }
  ]
}
```