<h2 align="center"> App MAUI - Jogo da Velha </h2>

<div align="center">
  
![GitHub repo size](https://img.shields.io/github/repo-size/EdielOliveira/MauiAppJogoDaVelha?style=for-the-badge)

[![My Skills](https://skillicons.dev/icons?i=dotnet,cs,visualstudio&theme=dark)](https://skillicons.dev)

</div>

<div align="center">

![image](http://www.unow.com.br/emDesenvolvimento.gif)

<img src="http://img.shields.io/static/v1?label=STATUS&message=%20FINALIZADO&color=YELLOW&style=for-the-badge"/>

</div>

<div align="center">
  
## Índice
  
- [Abrindo o Código](#-abrindo-o-código)
- [Visão Geral](#visão-geral)
- [Objetivo Educacional](#objetivo-educacional)
- [Arquitetura do App](#arquitetura-do-app)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Funcionalidades](#funcionalidades)
- [Desenvolvedor](#-desenvolvedor)

</div>

<h1 align="left">
🚀 Abrindo o Código
</h1>

Este projeto está disponibilizado **exclusivamente para fins educacionais**, com foco na **aprendizagem dos conceitos básicos de desenvolvimento mobile utilizando .NET MAUI**.

- Analisar o **XAML da interface**
- Entender o uso de **Grid**
- Estudar o **code-behind em C#**
- Compreender o controle de estado do jogo

<h1 align="center">
Visão Geral
</h1>

<div align="center">

https://github.com/user-attachments/assets/6cde9458-5102-45ce-859e-2bffa3f40f19

</div>


Este repositório contém um **Aplicativo Mobile de Jogo da Velha**, desenvolvido em **.NET MAUI**, utilizando **C# e XAML**.

O aplicativo implementa o clássico **Jogo da Velha (Tic-Tac-Toe)** em uma interface gráfica simples, permitindo a interação do usuário por meio de botões organizados em uma grade (**Grid**).

O projeto foi desenvolvido como parte de uma **aula do curso técnico em Desenvolvimento de Sistemas**, com foco em:

- Estruturação de layouts com **Grid**
- Manipulação de eventos de botões
- Alternância de estados
- Lógica condicional básica

<h1 align="center">
Objetivo Educacional
</h1>

Este projeto tem como principal objetivo **ensinar conceitos básicos de layout e lógica em .NET MAUI**, sendo considerado um **projeto introdutório**.

📌 Conceitos trabalhados:
- Uso do **Grid** para organização da interface
- Posicionamento de elementos por **linhas e colunas**
- Eventos `Clicked`
- Controle de estado da aplicação
- Alternância entre jogadores (X e O)
- Reinicialização do jogo

Este projeto **não foca em arquitetura avançada**, padrões complexos ou persistência de dados, pois seu propósito é **didático**.

<h1 align="center">
Arquitetura do App
</h1>

O aplicativo segue a arquitetura padrão de projetos **.NET MAUI simples**, utilizando:

- **XAML:** Construção da interface gráfica
- **Code-behind (C#):** Lógica do jogo e controle de eventos
- **Sem uso de banco de dados ou APIs externas**

A lógica do jogo está centralizada no arquivo `MainPage.xaml.cs`, garantindo clareza e fácil entendimento para quem está aprendendo.

<h1 align="center">
Estrutura do Projeto
</h1>

<div align="left">

📁 **MauiAppJogoDaVelha/**  
Projeto principal do aplicativo MAUI

- `App.xaml / App.xaml.cs` – Inicialização global do aplicativo  
- `AppShell.xaml / AppShell.xaml.cs` – Estrutura básica de navegação  
- `MainPage.xaml` – Interface do jogo (layout em Grid)  
- `MainPage.xaml.cs` – Lógica do Jogo da Velha  
- `MauiProgram.cs` – Configuração da aplicação  

📁 **Platforms/**  
Configurações específicas de cada plataforma:

- `Android/` – Configurações e manifest do Android  
- Estrutura preparada para multiplataforma (Android, Windows, etc.)

📄 **MauiAppJogoDaVelha.sln**  
Arquivo de solução do Visual Studio

</div>

<h1 align="center">
Funcionalidades
</h1>

<div align="left">

- Interface construída com **Grid**
- Tabuleiro 3x3 utilizando botões
- Alternância automática entre jogadores (**X** e **O**)
- Bloqueio de botões após jogada
- Verificação de vitória em linhas, colunas e diagonais
- Reinício automático do jogo após vitória ou Empate
- Layout simples com foco educacional
- Aplicação multiplataforma com .NET MAUI

</div>

<h1 align="center">🤝 Desenvolvedor</h1>

<table align="center">
    <td align="center">
      <a href="#">
        <img src="https://avatars.githubusercontent.com/u/113260177?s=400&v=4" width="150px;" alt="Foto do Desenvolvedor"/><br>
        <sub>
          <b>EdielOliveira</b>
        </sub>
      </a>
    </td>   
</table>
