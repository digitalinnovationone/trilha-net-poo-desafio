# 📱 Sistema de Celulares — POO em C# (.NET)

Implementação do desafio **DIO — Trilha .NET POO**, desenvolvido por **Dierry Rosias (Deyyymore)**.  
Este projeto faz parte do meu portfólio e demonstra a aplicação de **abstração, herança, interfaces e polimorfismo** no contexto de smartphones.

---

## ✨ Objetivos do Projeto
- Praticar os conceitos de **Programação Orientada a Objetos** em C#.
- Criar uma abstração de **Smartphone** com propriedades e métodos comuns.
- Implementar **interfaces** para simular papéis:  
  - 🎵 Reprodutor Musical  
  - 📞 Aparelho Telefônico  
  - 🌐 Navegador de Internet
- Permitir que **iPhone, Nokia e Samsung** tenham comportamentos próprios.

---

## 🧱 Arquitetura

### 📂 Estrutura de pastas
```
trilha-net-poo-celulares/
│
├── Models/
│ ├── Smartphone.cs
│ ├── Iphone.cs
│ ├── Nokia.cs
│ ├── Samsung.cs
│ └── Interfaces/
│ ├── IAparelhoTelefonico.cs
│ ├── IReprodutorMusical.cs
│ └── INavegadorInternet.cs
│
├── Program.cs
├── trilha-net-poo-celulares.csproj
└── README.md
```

---

## ▶️ Como Executar

```bash
# Clonar o repositório
git clone https://github.com/Deyyymore/trilha-net-poo-celulares.git
cd trilha-net-poo-celulares

# Compilar
dotnet build

# Executar
dotnet run
O programa abrirá um menu interativo onde você pode:

Selecionar um modelo de celular (iPhone, Nokia, Samsung)

Usar funções de Telefonia, Música e Navegador

🧪 Testes Unitários
Este projeto contém testes básicos com xUnit.
Eles validam a criação dos objetos e chamadas de métodos principais.
```
```bash

# Acesse a pasta de testes
cd TrilhasPOO.Tests

# Rode os testes
dotnet test
```
```
📸 Demonstração (exemplo)
c#
=== Seleção de Aparelho ===
[1] iPhone
[2] Nokia
[3] Samsung
Opção: 1
Número (chip): 9999-0000
IMEI: 123456789012345
Memória (GB): 128
[iPhone] Iniciando...

===== MENU CELULAR =====
[1] Telefonia
[2] Música
[3] Navegador
[4] Trocar de aparelho
[0] Sair
Escolha:0
Fim do programa
```

🧑‍💻 Autor
Dierry Rosias (Deyyymore)

💼 Foco em Full Stack, Testes e Automação

📚 Estudante de Engenharia da Computação e Análise e Desenvolvimento de Sistemas

## 🧭 Referência

Este projeto foi inspirado no desafio oficial da DIO:
👉 [digitalinnovationone](https://github.com/digitalinnovationone/trilha-net-poo-desafio)