
<h4 align="center"> 
	📰 Blog 📰
</h4>

<p align="center">
	<img alt="Status Concluído" src="https://img.shields.io/badge/STATUS-CONCLU%C3%8DDO-brightgreen">
</p>

## 💻 Sobre o projeto

Projeto realizado para a fase 2, 3 e 5 da PosTech Arquitetura de Sistemas .NET com Azure, foi criado uma API e um FrontEnd para um Blog, no qual as informações são armazenadas em um Azure SQL Database, a API realiza as alterações nessa base, e os dados são apresentados no FrontEnd da aplicação.


---

## ⚙️ Funcionalidades

- [x] Testes de Unidades
- [x] Teste de Integração

- [x] API:
      
  - [x] BlogNoticias
    - [x] GET
      - /api/BlogNoticias
      - Endpoint para obter todas a notícias presentes na base de dados
      - 
      - /api/BlogNoticias/{id}
      - Endpoint para obter a noticia por Id presente na base de dados
    - [x] DELETE
      - /api/BlogNoticias/{id}
      - Endpoint para excluir uma notícia presente na base de dados
    - [x] PUT
      - /api/BlogNoticias
      - Endpoint para atualizar notícias na base de dados
    - [x] POST
      - /api/BlogNoticias
      - Endpoint para incluir notícias na base de dados
          
  - [x] Seguranca
    - [x] POST
      - /api/Seguranca/token/{chave}
      - Endpoint para gerar o token JWT validando uma chave de segurança


  
- [x] APP:
  - [x] FrontEnd criado para consumir dados de uma API
  - [x] Tela principal apresenta informações de todas("GET") as noticias presentes na base de dados.
  - [x] Há um botão para realizar o Upload(POST) de uma nova noticia ao blog. 
  - [x] Ao selecionar um noticia, o usuário tem a opção de editar(PUT) ou excluir(DELETE) essa noticia.
  
---
## 📽️ Funcionamento na Prática
- [x] Demonstração utilizando o Azure Devops para execução do CI/CD e através de Pipeline realizar a conteinerização dos projetos com o Docker e armazenar a imagem criada em um Azure Container Registry(ACR), e a partir dessa imagem implantar o sistema em um Azure Container Instance(ACI).
  - [Vídeo](https://1drv.ms/v/s!AmNT9RVCAopEvXq9KbDGOROlyZrh?e=15sftU)
    
- [x] Demonstração utilizando o Azure Application Insights para monitorar as aplicações.
  - [Vídeo](https://1drv.ms/v/s!AmNT9RVCAopEvXsZ5IKpjQcCisym?e=kEO82m)

- [x] Apresentação dos projetos publicados em um Azure Kubernetes Service.
  - [Vídeo](https://1drv.ms/v/s!AmNT9RVCAopEvXyU4CwN6dRe9F19?e=nkbUBY)
---
## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

<div style="display: inline_block">
  <img align="center" alt="HTML" src="https://img.shields.io/badge/HTML-239120?style=for-the-badge&logo=html5&logoColor=white" />
  <img align="center" alt="Kubernetes" src="https://img.shields.io/badge/kubernetes-%23326ce5.svg?style=for-the-badge&logo=kubernetes&logoColor=white" />
  <img align="center" alt=".NET" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" />
  <img align="center" alt="Devops" src="https://img.shields.io/badge/Azure_DevOps-0078D7?style=for-the-badge&logo=azure-devops&logoColor=white" />
  <img align="center" alt="C#" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" />
  <img align="center" alt="SQL Server" src="https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white" />
  <img align="center" alt="CSS" src="https://img.shields.io/badge/CSS-239120?&style=for-the-badge&logo=css3&logoColor=white" />
</div><br/>

---

## 🧙‍♂️ Autor
  [Caio Santiago](https://www.linkedin.com/in/caio-santiago-/)

---

## 📝 Licença

<!-- Este projeto esta sobe a licença [MIT](./LICENSE). -->

  [Entre em contato!](https://www.linkedin.com/in/caio-santiago-/)
