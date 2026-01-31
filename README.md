<h1 align="center">🛒 Product Catalog API</h1>

<p align="center">
  <img src="https://img.shields.io/badge/status-concluído-brightgreen" alt="Status"/>
  <img src="https://img.shields.io/badge/backend-.NET%208-blue" alt="Backend"/>
  <img src="https://img.shields.io/badge/architecture-Clean%20Architecture-orange" alt="Architecture"/>
  <img src="https://img.shields.io/badge/ui-Razor%20Pages-purple" alt="UI"/>
  <img src="https://img.shields.io/badge/database-SQL%20Server-lightgrey" alt="Database"/>
</p>

<p>
Um <b>projeto inicial em C#</b> para entender e aplicar <b>Clean Architecture</b> de forma prática.<br>
Trata-se de um <b>catálogo de produtos</b>, com exibição via <b>Razor Pages</b> e persistência em <b>SQL Server</b>.<br>
Simples e didático, foi pensado como primeiro passo para compreender <b>separação de responsabilidades</b> e <b>boas práticas</b> na arquitetura.
</p>

<hr>

<h2>👨‍💻 Tecnologias Utilizadas</h2>
<ul>
  <li>C# / .NET 8</li>
  <li>Clean Architecture</li>
  <li>Razor Pages</li>
  <li>Entity Framework Core</li>
  <li>SQL Server (LocalDB via extensões do Visual Studio)</li>
  <li>AutoMapper</li>
</ul>

<hr>

<h2>⚙️ Instalação e Configuração</h2>

<h3>📋 Pré-requisitos</h3>
<ul>
  <li>.NET SDK 8+</li>
  <li>Visual Studio</li>
  <li>SQL Server LocalDB (instalado automaticamente com VS)</li>
</ul>

<h3>📦 Como executar o projeto</h3>
<ol>
  <li>Clone o repositório:
    <pre><code>git clone https://github.com/seuusuario/product-catalog-api.git</code></pre>
  </li>
  <li>Abra a solução no <b>Visual Studio</b>.</li>
  <li>Restaure os pacotes NuGet.</li>
  <li>Execute o projeto <code>CleanArch.MVC</code>.</li>
</ol>

<p>📌 A aplicação será exibida via <b>Razor Pages</b> no navegador:<br> 👉 <a href="https://localhost:7158/" target="_blank">https://localhost:7158/</a></p>

<hr>

<h2>🏗️ Estrutura do Projeto</h2>
<p>O projeto segue os princípios da <b>Clean Architecture</b>, dividido em camadas independentes:</p>
<ul>
  <li><b>Domain</b> → Entidades e regras de negócio (sem dependências externas)</li>
  <li><b>Application</b> → Casos de uso e lógica de aplicação (depende de Domain)</li>
  <li><b>Infra.Data</b> → Persistência e acesso a dados (depende de Domain)</li>
  <li><b>Infra.IoC</b> → Injeção de dependências (depende de Domain, Application e Infra.Data)</li>
  <li><b>MVC</b> → Camada de apresentação com Razor Pages (depende de Infra.IoC)</li>
</ul>

<hr>

<h2>📌 Observações</h2>
<p>
Este projeto foi desenvolvido como parte dos meus <b>primeiros estudos em C#</b>, servindo como introdução prática à <b>Clean Architecture</b>.<br>
👉 Playlist seguida: 
<a href="https://youtube.com/playlist?list=PLJ4k1IC8GhW3GICba2dLmiTZrVPw0SthC&si=EFgDLWtyYQfleQLE" target="_blank">
Clean Architecture em C#
</a>
</p>

<hr>

<hr>

<h2>👨‍💻 Autor</h2>
<ul>
  <li><a href="https://github.com/fcolucasvieira">Lucas Vieira</a> – Desenvolvedor principal</li>
</ul>
