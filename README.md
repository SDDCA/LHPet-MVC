# Sistema de Controle Interno - LH Pet

---

## Descrição do Projeto
Este projeto é uma aplicação web desenvolvida utilizando o framework .NET com a arquitetura MVC (Model-View-Controller). O objetivo inicial é gerenciar os dados de Clientes e Fornecedores da clínica veterinária LH Pet, exibindo as informações relevantes de forma organizada. Posteriormente, a aplicação será integrada com um banco de dados para armazenamento e persistência.

---

## Arquitetura MVC
- **Model**: Representa as entidades do sistema, incluindo os atributos e comportamentos necessários para manipulação de dados.
- **View**: Responsável por exibir a interface para o usuário, criada pela equipe de front-end.
- **Controller**: Controla as interações entre a View e o Model, implementando a lógica de negócios.

---

## Funcionalidades do Sistema
1. **Listagem de Clientes**:
   - Dados exibidos: ID, Nome, CPF, E-mail e Paciente (Pet).
2. **Listagem de Fornecedores**:
   - Dados exibidos: ID, Nome, CNPJ e E-mail.

---

## Estrutura Inicial
1. **Models**:
   - `Cliente`:
     - Atributos: Id, Nome, CPF, Email, Paciente (Pet).
   - `Fornecedor`:
     - Atributos: Id, Nome, CNPJ, Email.

2. **Controller**:
   - `HomeController`: 
     - Responsável por criar e popular objetos das classes `Cliente` e `Fornecedor`.
     - As listas de objetos são passadas para a View correspondente.

3. **View**:
   - Arquivo `Index.cshtml`: Desenvolvido pela equipe de front-end para exibir as listas de Clientes e Fornecedores.

---

## Como Rodar o Projeto

Requisitos
    .NET 6.0 ou superior.
    Navegador atualizado.

---

1. Certifique-se de ter o **.NET SDK** instalado na sua máquina.
2. Clone o repositório do projeto:
   ```bash
   git clone <(https://github.com/SDDCA/LHPet-MVC.git)>
   
3. Navegue até o diretório do projeto:
   ```bash
   <cd <LHPet>
   
4. Execute o projeto:
   ```bash
    <dotnet run>

6. Acesse a aplicação no navegador pelo endereço:
```bash
<http://localhost:---->



