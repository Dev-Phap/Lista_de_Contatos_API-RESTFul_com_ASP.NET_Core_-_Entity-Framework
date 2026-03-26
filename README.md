# 📋 Agenda de Contatos — API RESTful com ASP.NET Core + Entity Framework

Projeto acadêmico desenvolvido como exercício prático durante a **Formação .NET Developer** da DIO.  
O objetivo foi construir uma API RESTful completa do zero, aplicando os conceitos de Controllers, Endpoints CRUD, Entity Framework Core e boas práticas de arquitetura REST.

---

## 🚀 Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core 8
- SQL Server
- Swagger (documentação e testes)

---

## 🧠 O que foi Praticado

- Criação de API RESTful seguindo as convenções REST
- Configuração do `AgendaContext` e string de conexão
- Criação da Entity `Contato` e mapeamento para o banco
- Migrations com Entity Framework Core
- Injeção de dependência via construtor
- CRUD completo com endpoints HTTP
- Retornos HTTP semânticos (`CreatedAtAction`, `Ok`, `NotFound`, `NoContent`)
- Filtro de busca por nome com expressão lambda e `Contains`

---

## ⚙️ Como Rodar o Projeto

### Pré-requisitos
- .NET 8 SDK instalado
- SQL Server instalado e rodando

### Passo a passo

**1. Clone o repositório**
```bash
git clone https://github.com/Dev-Phap/Agenda_de_Contatos_API-RESTFul_com_ASP.NET_Core_-_Entity-Framework
cd Agenda_de_Contatos_API-RESTFul_com_ASP.NET_Core_-_Entity-Framework
```

**2. Configure a string de conexão**  
No arquivo `appsettings.json`, substitua pelos dados do seu ambiente:
```json
"ConnectionStrings": {
  "ConexaoPadrao": "Server=SEU_SERVIDOR;Database=SEU_BANCO;Trusted_Connection=True;"
}
```

**3. Execute as migrations**
```bash
dotnet ef database update
```

**4. Rode o projeto**
```bash
dotnet run
```

**5. Acesse o Swagger**  
Abra no navegador: `https://localhost:{porta}/swagger`

---

## 📡 Documentação dos Endpoints

Base URL: `/api/Contato`

---

### ➕ Criar Contato
| Campo      | Valor           |
|------------|-----------------|
| **Método** | POST            |
| **Rota**   | `/api/Contato`  |

**Body (JSON):**
```json
{
  "nome": "Paulo Henrique",
  "telefone": "11999999999",
  "ativo": true
}
```

**Resposta de sucesso:** `201 Created`
```json
{
  "id": 1,
  "nome": "Paulo Henrique",
  "telefone": "11999999999",
  "ativo": true
}
```

---

### 🔍 Obter Contato por ID
| Campo      | Valor                  |
|------------|------------------------|
| **Método** | GET                    |
| **Rota**   | `/api/Contato/{id}`    |

**Resposta de sucesso:** `200 OK`  
**Não encontrado:** `404 Not Found`

---

### 🔍 Obter Contatos por Nome
| Campo      | Valor                                      |
|------------|--------------------------------------------|
| **Método** | GET                                        |
| **Rota**   | `/api/Contato/ObterPorNome?nome={nome}`    |

> Busca parcial — retorna todos os contatos que contêm o valor informado no nome.

**Resposta de sucesso:** `200 OK` com lista de contatos  
**Não encontrado:** `404 Not Found`

---

### ✏️ Atualizar Contato
| Campo      | Valor                  |
|------------|------------------------|
| **Método** | PUT                    |
| **Rota**   | `/api/Contato/{id}`    |

**Body (JSON):**
```json
{
  "nome": "Paulo Atualizado",
  "telefone": "11988888888",
  "ativo": false
}
```

**Resposta de sucesso:** `200 OK`  
**Não encontrado:** `404 Not Found`

---

### 🗑️ Deletar Contato
| Campo      | Valor                  |
|------------|------------------------|
| **Método** | DELETE                 |
| **Rota**   | `/api/Contato/{id}`    |

**Resposta de sucesso:** `204 No Content`  
**Não encontrado:** `404 Not Found`

---

## 📁 Estrutura do Projeto

```
├── Controllers
│   └── ContatoController.cs
├── Context
│   └── AgendaContext.cs
├── Entities
│   └── Contato.cs
├── Migrations
├── appsettings.json
└── Program.cs
```

---

## 👨‍💻 Autor

**Paulo Henrique — Dev-Phap**  
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/pauloalmeidapinto/)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=flat&logo=github&logoColor=white)](https://github.com/Dev-Phap)
