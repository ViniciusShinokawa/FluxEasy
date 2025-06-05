
# 📦 FluxEasy

Sistema de controle de estoque de adesivos desenvolvido para a empresa **Intercol**, com foco na organização, rastreabilidade e controle de validade dos produtos.

---

## 🚀 Tecnologias Utilizadas

- [.NET 8 / ASP.NET Core](https://dotnet.microsoft.com/)
- Razor Pages (View Engine)
- ASP.NET Identity (autenticação e controle de usuários)
- MySQL (banco de dados relacional)
- C#
- HTML/CSS

---

## 📋 Funcionalidades

- ✅ Cadastro e login de usuários com segurança (Identity)
- 📊 Visualização e controle de estoque de dois tipos de adesivo:
  - **PVA (PVCol)** – Frasco, Galão, Barrica (10kg/50kg)
  - **Hotmelt (Thermocol)** – Sachê, Granulado, Bastão, Bloquinho
- ➕ Entrada e ➖ saída de produtos com lote, data de fabricação e responsável
- ⏳ Controle de validade:
  - **PVA**: 6 meses
  - **Hotmelt**: 12 meses
- 🕓 Histórico de movimentações
- 🔍 Pesquisa e atualização de dados
- 🧾 Estrutura pronta para relatórios e melhorias futuras

---

## 🏗️ Estrutura do Projeto

```
FluxEasy/
├── Areas/Identity/Pages         # Login, cadastro e gerenciamento de conta
├── Controllers/                 # Lógica de requisições HTTP (se houver)
├── Models/                      # Classes de domínio (produtos, usuários, etc.)
├── Views/                       # Páginas Razor (.cshtml)
├── appsettings.json             # Configurações do projeto
├── Program.cs                   # Ponto de entrada da aplicação
├── FluxEasy.csproj              # Arquivo do projeto .NET
```

---

## 🛠️ Como Executar

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/seu-usuario/FluxEasy.git
   ```

2. **Configure a string de conexão no `appsettings.json`:**

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=Fluxize;User=root;Password=sua_senha;"
   }
   ```

3. **Crie o banco de dados usando o script:**

   - Arquivo: `SQLQuery1.sql`

4. **Execute o projeto:**

   ```bash
   dotnet run
   ```

5. Acesse no navegador:

   ```
   http://localhost:5000
   ```

---

## 🔒 Segurança

- Gerenciamento de contas e autenticação com **ASP.NET Identity**
- Páginas protegidas por login

---

## 📌 Requisitos

- [.NET SDK 8+](https://dotnet.microsoft.com/download)
- MySQL Server
- Visual Studio ou VS Code com extensões C#

---

## 🤝 Autores

- João (Desenvolvedor e Idealizador)
- Vinícius (desenvolvedor)


---

## 🏢 Projeto desenvolvido para:
**Intercol Indústria de Adesivos**
