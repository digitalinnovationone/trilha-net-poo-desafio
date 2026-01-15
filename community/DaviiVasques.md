📱 Desafio POO – Modelagem de Smartphones (.NET)

Projeto desenvolvido como parte do Desafio de Programação Orientada a Objetos da Trilha .NET da DIO (Digital Innovation One).

🧠 Descrição do Desafio

O objetivo deste desafio é aplicar os conceitos de Programação Orientada a Objetos (POO) utilizando C# e .NET, por meio da modelagem de um sistema que trabalha com celulares de diferentes marcas.

Foi proposta a criação de uma classe abstrata que represente um smartphone genérico e classes específicas para marcas diferentes, permitindo reutilização de código e comportamentos personalizados.

🏗️ Estrutura do Projeto

O sistema é composto pelas seguintes classes:

🔹 Smartphone (Classe Abstrata)

Classe base que define as propriedades e comportamentos comuns a todos os smartphones.

Propriedades:

Numero (string)

Modelo (string)

IMEI (string)

Memoria (int)

Métodos:

Ligar()

ReceberLigacao()

InstalarAplicativo(string nome) → método abstrato

🔹 Nokia (Classe Concreta)

Classe filha de Smartphone, responsável por implementar sua própria forma de instalar aplicativos.

🔹 iPhone (Classe Concreta)

Classe filha de Smartphone, também com implementação específica do método de instalação de aplicativos.

📐 Diagrama de Classes

O projeto segue o diagrama abaixo:

Smartphone (abstract)
│
├── Nokia
│   └── InstalarAplicativo()
│
└── iPhone
    └── InstalarAplicativo()

✅ Regras Implementadas

✔️ A classe Smartphone é abstrata e não pode ser instanciada.

✔️ As classes Nokia e iPhone herdam de Smartphone.

✔️ O método InstalarAplicativo é sobrescrito em cada classe filha.

✔️ Aplicação do conceito de polimorfismo.

✔️ Projeto desenvolvido como aplicação Console em .NET.

🚀 Tecnologias Utilizadas

C#

.NET

Programação Orientada a Objetos (POO)

Console Application

▶️ Como Executar o Projeto

Clone o repositório:

git clone https://github.com/seu-usuario/nome-do-repositorio.git


Abra o projeto no Visual Studio ou VS Code.

Execute a aplicação pelo terminal ou pela IDE.

📌 Exemplo de Uso

Ao executar o programa, é possível criar instâncias de Nokia e iPhone, realizar chamadas e instalar aplicativos, cada um respeitando seu comportamento específico.

📚 Aprendizados

Este projeto reforça conceitos importantes como:

Abstração

Herança

Polimorfismo

Sobrescrita de métodos

Organização de código orientado a objetos

🏁 Conclusão

Desafio essencial para consolidar os fundamentos de POO em .NET, proporcionando uma base sólida para projetos mais complexos no futuro.