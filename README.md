# SuperMarketAPI

O sistema trata-se de um crud basico de produtos, contendo cadastro, leitura, atualização e deleção de produtos.

## Visão Geral

Este projeto consiste em uma API para chamada das funcionalides.

- **API**: A API fornece endpoints para manipular dados e interagir com o backend.

## Tecnologias Utilizadas

### Backend/API

- **Linguagem de programação:** C#
- **Framework:** .NET
- **Banco de dados:** PostgreSQL
- **Outras bibliotecas/utilitários:** EntityFramework

## Endpoints da API

Aqui estão os principais endpoints da API e suas descrições:

1. **`GET /produto`**: Retorna uma lista de todos os protudos.
   - Parâmetros: Nenhum.
   - Resposta: Uma lista de objetos de produtos.
   
2. **`POST /produto`**: Cria um novo produto com os dados fornecidos.
   - Parâmetros: Dados do produto no corpo da solicitação.
   - Resposta: Objeto do produto recém-criado.

4. **`PUT /produto`**: Atualiza os dados de um produto existente com o ID fornecido.
   - Parâmetros: `id` (ID do produto), dados atualizados do produto no corpo da solicitação.
   - Resposta: Objeto do produto atualizado.

5. **`DELETE /produto/{id}`**: Exclui um produto existente com o ID fornecido.
   - Parâmetros: `id` (ID do produto).
   - Resposta: Nenhum conteúdo.

### Como acessar o Swagger

Para acessar a documentação do Swagger, inicie o servidor da API e navegue até `http://localhost:{porta}/swagger`. A página do Swagger exibirá todos os endpoints disponíveis, permitindo que você interaja com cada um deles.

![Swagger API Documentation](https://github.com/TeteuzinTeixeira/SuperMarket/assets/117493672/62b88374-d699-4199-8cb3-a0ea9343ec5c)

A interface do Swagger facilita o entendimento e a utilização da API, oferecendo uma maneira conveniente de testar os endpoints sem a necessidade de ferramentas externas.