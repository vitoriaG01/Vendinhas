# Vendinhas

O Vendinhas é um sistema desktop desenvolvido como trabalho acadêmico para controlar o cadastro de clientes e as dívidas (fiado) de cada um.

Com ele, é possível cadastrar pessoas, atualizar seus dados, lançar novas dívidas, consultar quanto cada cliente está devendo e registrar os pagamentos realizados.

## Tecnologias utilizadas

- C#
- .NET 10
- Windows Forms
- Entity Framework Core
- PostgreSQL

## Funcionalidades do sistema

### Clientes

- Cadastrar novos clientes com nome completo, CPF, data de nascimento e e-mail.
- Listar, editar e excluir clientes.
- Calcular a idade automaticamente com base na data de nascimento.
- Mostrar o valor total das dívidas que cada cliente possui em aberto.

### Dívidas

- Consultar as dívidas vinculadas a um cliente específico.
- Cadastrar novas dívidas.
- Visualizar o valor e a situação de cada dívida (em aberto ou paga).
- Registrar o pagamento de uma dívida e armazenar a data em que ele foi realizado.

## Regras do sistema

Para evitar erros e registros duplicados, o sistema possui algumas regras:

- Não permite cadastrar dois clientes com o mesmo CPF.
- Não permite cadastrar uma nova dívida para um cliente que já possui uma dívida em aberto.
- Não permite registrar novamente o pagamento de uma dívida que já foi paga.

## Banco de Dados

O projeto utiliza PostgreSQL junto com o Entity Framework Core.

Os dados são organizados em duas tabelas principais:

- **Clientes:** armazena as informações dos clientes.
- **Dividas:** armazena as dívidas vinculadas a cada cliente.

O arquivo `script_vendinha.sql` contém os comandos SQL para criar a estrutura das tabelas no banco de dados, sem precisar executar as migrations manualmente.

## Como executar o projeto na sua máquina

1. Instale o PostgreSQL e o .NET SDK 10.
2. Clone este repositório no seu computador.
3. No PostgreSQL, crie um banco de dados vazio com o nome `vendinha`.
4. Execute o arquivo `script_vendinha.sql` nesse banco para criar as tabelas.
5. Crie uma variável de ambiente no Windows com o nome `VENDINHAS_CONNECTION`.
6. Configure o valor da variável utilizando o seguinte formato de conexão:

   ```text
   Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=SUA_SENHA
   ```

   Substitua `SUA_SENHA` pela senha configurada no seu PostgreSQL.

7. Abra o arquivo `Vendinhas.slnx` no Visual Studio.
8. Defina o projeto `Vendinhas.Desktop` como projeto de inicialização.
9. Execute o sistema pelo botão Iniciar ou pressione `F5`.

## Organização do projeto

A solução está dividida em dois projetos principais:

- **Vendinhas:** contém os modelos, os serviços com as regras do sistema, o contexto do banco de dados e as migrations.
- **Vendinhas.Desktop:** contém as telas e toda a parte visual da aplicação, desenvolvida com Windows Forms.