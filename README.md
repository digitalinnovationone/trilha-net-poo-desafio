# Desafio POO - Sistema de Smartphones (.NET) 📱

Projeto desenvolvido como parte da Trilha .NET - Programação Orientada a Objetos da DIO.

## Objetivo 📚

Modelar um sistema simples de smartphones utilizando os principais conceitos de Programação Orientada a Objetos (POO) em C#, aplicando:
- Abstração
- Herança
- Polimorfismo
- Encapsulamento
O sistema simula dois tipos de celulares (Nokia e iPhone) que herdam comportamentos de uma classe base abstrata chamada Smartphone.

 ## Conceitos Aplicados 🧠
### - Abstração
A classe Smartphone é abstrata, servindo como modelo para outras classes. Ela define as propriedades e comportamentos comuns a todos os celulares.

### - Herança
As classes Nokia e Iphone herdam da classe Smartphone, reutilizando seus atributos e métodos.

### - Polimorfismo
O método InstalarAplicativo é abstrato na classe base e sobrescrito nas classes filhas, permitindo que cada marca implemente sua própria forma de instalação.

### - Encapsulamento
As propriedades e comportamentos são organizados dentro das classes, mantendo responsabilidades bem definidas.

 ## Estrutura do Projeto 🏗️
DesafioPOO
│
├── Models
│   ├── Smartphone.cs
│   ├── Nokia.cs
│   └── Iphone.cs
│
└── Program.cs

## Regras do Desafio 📌 
* A classe Smartphone deve ser abstrata.
* As classes Nokia e Iphone devem herdar de Smartphone.
* O método InstalarAplicativo deve ser sobrescrito nas classes filhas.
* O projeto deve ser do tipo Console Application (.NET).

## Exemplo de Execução ▶️
Ao executar o programa, o sistema cria instâncias de Nokia e iPhone e demonstra seus comportamentos:

=== Nokia ===
Ligando...
Recebendo ligação...
Instalando 'WhatsApp' pela Nokia Store...

=== iPhone ===
Ligando...
Recebendo ligação...
Instalando 'Instagram' pela App Store...

 ## Tecnologias Utilizadas 🚀
* C#
* .NET
* Programação Orientada a Objetos
* Git
* GitHub

## Aprendizados 📈
Este projeto reforça a importância de:
- Criar classes bem estruturadas
- Utilizar herança de forma consciente
- Aplicar polimorfismo para permitir comportamentos diferentes com mesma assinatura de método
- Modelar sistemas pensando em reutilização e organização

  
## Autora 👩🏾‍💻
****
Desenvolvido por Talita como parte da evolução na trilha .NET da DIO.
