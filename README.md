<div align="center">
  <img src="https://archania.com.br/wp-content/uploads/2024/10/archania-solum-favicon-branco.png" width="120"/>
    <h1>🛠 Sistema de Controle Financeiro Empresarial</h1>
  <p>Sistema desenvolvido para controlar receitas e despesas de uma pequena empresa, com categorização de transações e relatórios básicos.</p>

  <a href="https://www.youtube.com/@ArchaniaSolum" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/static/v1?message=Youtube&logo=youtube&label=&color=FF0000&logoColor=white&labelColor=&style=for-the-badge" height="35" alt="youtube logo"/>
  </a>
  <a href="https://www.instagram.com/juanarchangelo/" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/static/v1?message=Instagram&logo=instagram&label=&color=E4405F&logoColor=white&labelColor=&style=for-the-badge" height="35" alt="instagram logo"/>
  </a>
  <a href="https://www.twitch.tv/zudokan_original" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/static/v1?message=Twitch&logo=twitch&label=&color=9146FF&logoColor=white&labelColor=&style=for-the-badge" height="35" alt="twitch logo"/>
  </a>
  <a href="https://www.linkedin.com/in/juan-lucas-archangelo-061035180/" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/static/v1?message=LinkedIn&logo=linkedin&label=&color=0077B5&logoColor=white&labelColor=&style=for-the-badge" height="35" alt="linkedin logo"/>
  </a>
</div>

---

## ✨ Demonstração

<img src="https://archania.com.br/wp-content/uploads/2025/10/swagger.png" width="100%" alt="preview do projeto"/>

---

## 🚀 Tecnologias Utilizadas

<div align="left">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/dot-net/dot-net-original.svg" height="30" alt=".NET logo" />
<img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="30" alt="csharp logo" />
</div>

---

## ⚙️ Pré-requisitos

Antes de rodar o projeto, você precisa ter instalado:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) (ou MariaDB)
- [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio](https://visualstudio.microsoft.com/) (opcional)

---

## 🚀 Como rodar o projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/Juanlucasarchangelo/api-controle-financeiro.git
   cd api-controle-financeiro
   ```

2. Restaure os pacotes:

   ```bash
   dotnet restore
   ```

3. Configure a string de conexão no arquivo `appsettings.json`:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=ControleFinanceiro;Trusted_Connection=True;TrustServerCertificate=True;"
   }
   ```

4. Importação do banco de dados já populado:  
   Na raiz do projeto existe uma pasta chamada **@BD**, que contém um arquivo `.sql` com dados para testes.  

5. Rode as migrations (se estiver usando EF Core):

   ```bash
   dotnet ef database update
   ```

6. Inicie a API:
   ```bash
   dotnet run
   ```

A API rodará em:

```
http://localhost:5069
```

---

## 📂 Endpoints disponíveis

### 🔹 Listar transações

```
GET /api/listar-transacoes
```

### 🔹 Resumo financeiro

```
GET /api/listar-resumo
```

### 🔹 Editar transação

```
PUT /api/transacoes/editar-transacoes/{id}
```

**Body esperado (JSON):**

```json
{
  "id": 2,
  "descricao": "AWS",
  "valor": 12342,
  "data": "2025-09-28T13:32:41.220Z",
  "categoriaId": 3,
  "observacoes": "Teste",
  "dataCriacao": "2025-09-28T13:32:41.220Z",
  "categoria": {
    "id": 0,
    "nome": "string",
    "tipo": "string",
    "ativo": true
  }
}
```

### 🔹 Excluir transação

```
DELETE /api/deletar-transacoes/{id}
```

---

## ✅ Tecnologias utilizadas

- .NET 8 (C#)
- Entity Framework Core
- SQL Server (padrão, mas pode ser adaptado)
- Swagger (opcional para testes)
