# 🚗 SSP Vehicles

<div align="center">

# SSP Vehicles

### Vehicle Management Platform

Sistema de Gestão Comercial de Veículos desenvolvido com foco em arquitetura corporativa, segurança, Programação Orientada a Objetos e boas práticas de desenvolvimento.

</div>

---

## 📖 Sobre o Projeto

O SSP Vehicles é uma plataforma web para gerenciamento de compra, avaliação, estoque e venda de veículos.

O projeto foi desenvolvido com o objetivo de aplicar conceitos de desenvolvimento backend, banco de dados, arquitetura de software e Programação Orientada a Objetos, simulando um ambiente corporativo semelhante aos sistemas utilizados por empresas do setor automotivo.

---

## 🎯 Objetivos

- Desenvolver uma aplicação utilizando ASP.NET MVC.
- Desenvolver uma API REST utilizando ASP.NET Web API.
- Implementar autenticação JWT.
- Aplicar conceitos de Programação Orientada a Objetos.
- Utilizar SQL Server como banco de dados principal.
- Trabalhar com Stored Procedures.
- Implementar controle de usuários, perfis e permissões.
- Consumir a API FIPE para avaliação de veículos.
- Desenvolver dashboards e relatórios gerenciais.
- Simular uma arquitetura corporativa em camadas.

---

## 🏗️ Arquitetura

```text
Usuário
    │
    ▼
SSP.Vehicles.Web
    │
    ▼
SSP.Vehicles.Api
    │
    ▼
Services
    │
    ▼
Stores
    │
    ▼
Stored Procedures
    │
    ▼
SQL Server
```

---

## 📂 Estrutura da Solution

```text
SSP.Vehicles.sln
│
├── SSP.Vehicles.Web
│
├── SSP.Vehicles.Api
│
├── SSP.Vehicles.Core
│
├── SSP.Vehicles.Infrastructure
│
├── SSP.Vehicles.Database
│
└── Docs
```

---

## 🔐 Segurança

O sistema utiliza autenticação baseada em JWT (JSON Web Token).

### Funcionalidades

- Login
- Logout
- Controle de Sessão
- Perfis de Acesso
- Permissões por Funcionalidade
- Auditoria de Alterações

### Perfis

- Administrador
- Gerente
- Vendedor
- Financeiro

### Permissões

- USER_MANAGE
- VEHICLE_VIEW
- VEHICLE_CREATE
- VEHICLE_UPDATE
- VEHICLE_DELETE
- CUSTOMER_CREATE
- SALE_CREATE
- SALE_CANCEL
- FINANCIAL_VIEW
- REPORT_VIEW

---

## 🚘 Gestão de Veículos

### Funcionalidades

- Cadastro de Veículos
- Alteração de Veículos
- Exclusão de Veículos
- Controle de Estoque
- Consulta FIPE
- Avaliação de Mercado
- Histórico de Alterações

### Status

- Disponível
- Reservado
- Em Manutenção
- Vendido

---

## 👥 Gestão de Clientes

### Pessoa Física

- CPF
- Nome
- Telefone
- E-mail

### Pessoa Jurídica

- CNPJ
- Razão Social
- Telefone
- E-mail

---

## 💰 Financeiro

### Funcionalidades

- Naturezas Financeiras
- Centro de Custos
- Receitas
- Despesas
- Fluxo de Caixa
- Controle Financeiro

### Naturezas

- Receita
- Despesa

---

## 📊 Relatórios

Todos os relatórios serão gerados através de Stored Procedures.

### Relatórios Disponíveis

- Relatório de Veículos
- Relatório de Clientes
- Relatório de Compras
- Relatório de Vendas
- Relatório Financeiro
- Relatório de Auditoria
- Relatório de Margem por Veículo

---

## 📈 Dashboard

### Indicadores

- Total de Veículos
- Total de Clientes
- Total de Vendas
- Receita Total
- Despesas Totais
- Lucro
- Valor do Estoque
- Valor FIPE da Frota

---

## 🔄 Integração FIPE

### Funcionalidades

- Consulta de Marca
- Consulta de Modelo
- Consulta de Ano
- Consulta de Valor FIPE
- Comparação entre Compra e Mercado
- Histórico de Avaliações

---

## 🧠 Programação Orientada a Objetos

### Conceitos Aplicados

- Encapsulamento
- Herança
- Polimorfismo
- Classes Abstratas
- Interfaces
- Composição
- Agregação
- FIFO

### Exemplo de Herança

```text
Veiculo
│
├── Carro
├── Moto
└── Caminhao
```

```text
Cliente
│
├── PessoaFisica
└── PessoaJuridica
```

```text
Natureza
│
├── Receita
└── Despesa
```

### Interfaces

- ICalculoComissao
- IValorizacaoVeiculo
- IAuditoria
- INotificationService
- IReportService

---

## 🗄️ Banco de Dados

### SQL Server

Estrutura baseada em:

- Stored Procedures
- Views
- Functions
- Migrations
- Auditoria

### Principais Tabelas

#### Segurança

- Users
- Roles
- Permissions
- UserRoles
- RolePermissions

#### Clientes

- Customers
- CustomerTypes

#### Veículos

- Vehicles
- VehicleTypes
- VehicleFipeHistory

#### Vendas

- Sales
- SaleItems

#### Financeiro

- FinancialTransactions
- Naturezas
- CentroCustos

#### Auditoria

- AuditLog

---

## 🛠️ Tecnologias

### Backend

- C#
- ASP.NET MVC
- ASP.NET Web API
- Entity Framework
- JWT Authentication

### Banco de Dados

- SQL Server

### Ferramentas

- Git
- GitHub
- Swagger
- Visual Studio

---

## 🚀 Roadmap

### Sprint 1 — Fundação

- Estrutura da Solution
- Configuração do GitHub
- Banco de Dados
- MVC
- API
- Swagger
- Dependency Injection

### Sprint 2 — Segurança

- Usuários
- Perfis
- Permissões
- JWT
- Login
- Middleware de Autorização

### Sprint 3 — Clientes

- Pessoa Física
- Pessoa Jurídica
- CRUD
- Procedures
- Relatórios

### Sprint 4 — Veículos

- Cadastro de Veículos
- Controle de Estoque
- Herança
- Polimorfismo
- Relatórios

### Sprint 5 — Integração FIPE

- Consumo da API FIPE
- Histórico de Consultas
- Avaliação de Mercado

### Sprint 6 — Compras e Vendas

- Registro de Compra
- Registro de Venda
- Comissão
- Auditoria

### Sprint 7 — Financeiro

- Naturezas
- Centro de Custos
- Fluxo de Caixa
- Relatórios Financeiros

### Sprint 8 — Dashboard

- Indicadores
- KPIs
- Gráficos

### Sprint 9 — Auditoria

- AuditLog
- Histórico de Alterações
- Log de Acessos

### Sprint 10 — Refatoração e Documentação

- SOLID
- UML
- DER
- Documentação Técnica
- Publicação Final

---

## 📚 Objetivo Acadêmico

Este projeto foi criado para consolidar conhecimentos em:

- Desenvolvimento Backend
- Arquitetura de Software
- Banco de Dados
- APIs REST
- Segurança
- Programação Orientada a Objetos
- Boas Práticas de Desenvolvimento

---

## 👩‍💻 Autora

### Sabrina Paschini

Analista de Sustentação Júnior
Graduanda em Análise e Desenvolvimento de Sistemas

---

⭐ Projeto desenvolvido para fins de estudo, evolução profissional e construção de portfólio.
