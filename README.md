# API de Cadastro de Funcionários com Banco de Dados e Deploy no Azure

## Resumo do Projeto
Este projeto consiste em uma **API RESTful desenvolvida em .NET**, com foco no **cadastro e gerenciamento de funcionários**, totalmente integrada a um **banco de dados SQL Server** e publicada na **nuvem via Azure App Service**. A API permite operações de **CRUD (Create, Read, Update, Delete)** sobre os registros de funcionários e fornece endpoints estruturados para consumo por aplicações front-end ou sistemas integrados.

---

## Funcionalidades Principais
- **Cadastro de Funcionários**: inclusão de novos registros com informações como nome, cargo, departamento, data de contratação, e outros dados relevantes.  
- **Consulta de Funcionários**: busca de registros individuais ou listagem completa de funcionários cadastrados.  
- **Atualização de Dados**: permite modificar informações de funcionários existentes de forma segura.  
- **Exclusão de Registros**: remoção de funcionários da base de dados quando necessário.  
- **Documentação Interativa (Swagger UI)**: endpoints documentados e testáveis diretamente no navegador.

---

## Tecnologias Utilizadas
- **Backend**: .NET 9 (C#) utilizando o padrão **Controller API**.  
- **Banco de Dados**: SQL Server hospedado no **Azure SQL Database**, integrado via Entity Framework Core (DbContext).  
- **Documentação**: Swagger/OpenAPI para testes e visualização de endpoints.  
- **Deploy e Infraestrutura**: Azure App Service para hospedar a API em ambiente de produção, com HTTPS configurado e logs de execução monitorados.  
- **Segurança**: Connection Strings configuradas como variáveis de ambiente no Azure para proteger credenciais do banco.

---

## Arquitetura
1. **Controllers e Endpoints**: gerenciamento de rotas REST, cada operação (GET, POST, PUT, DELETE) possui endpoint dedicado.  
2. **DbContext (Entity Framework Core)**: responsável por mapear as entidades de funcionário para o banco de dados, garantindo persistência e integridade dos dados.  
3. **Middleware**: HTTPS, autorização básica e Swagger configurados para ambiente de produção e desenvolvimento.  
4. **Deploy no Azure**: aplicação publicada no App Service Linux, com logs de streaming habilitados para monitoramento em tempo real.

---

## Diferenciais
- API totalmente funcional, pronta para ser consumida por aplicações web ou mobile.  
- Endpoint raiz (`/`) com resposta rápida indicando que a API está online.  
- Swagger UI acessível para teste de todos os endpoints, garantindo **integração ágil e documentação interativa**.  
- Pronto para escalabilidade no Azure, podendo ser expandido com autenticação, caching e outras integrações futuras.

---

## Como Acessar
- **Endpoint raiz**: `https://desafioapi.azurewebsites.net/` → retorna status da API.  
- **Swagger UI**: `https://desafioapi.azurewebsites.net/swagger/index.html` → documentação interativa dos endpoints.

---

## Resumo Final
Este projeto demonstra competência em **desenvolvimento de APIs, integração com banco de dados, deploy em nuvem e documentação de endpoints**, consolidando habilidades essenciais para projetos corporativos modernos em **.NET e Azure**.

- <img width="1228" height="440" alt="Captura de tela de 2025-09-19 10-56-21" src="https://github.com/user-attachments/assets/6c0b3638-76cf-4bf2-9d93-dfb73eb105f8" />
<img width="1192" height="558" alt="Captura de tela de 2025-09-19 11-04-38" src="https://github.com/user-attachments/assets/8016d0ae-17c6-498b-90ff-cd3930e2998a" />

