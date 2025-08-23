﻿using TrilhasPOO.Models;
using TrilhasPOO.Models.Interfaces;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Smartphone celular = SelecionarModelo();

bool executando = true;
while (executando)
{
    Console.WriteLine();
    Console.WriteLine("===== MENU CELULAR =====");
    Console.WriteLine("[1] Telefonia");
    Console.WriteLine("[2] Música");
    Console.WriteLine("[3] Navegador");
    Console.WriteLine("[4] Trocar de aparelho");
    Console.WriteLine("[0] Sair");
    Console.Write("Escolha: ");
    string? op = Console.ReadLine();

    switch (op)
    {
        case "1": MenuTelefonia(celular); break;
        case "2": MenuMusica(celular); break;
        case "3": MenuNavegador(celular); break;
        case "4": celular = SelecionarModelo(); break;
        case "0": executando = false; break;
        default: Console.WriteLine("Opção inválida."); break;
    }
}

static Smartphone SelecionarModelo()
{
    Console.WriteLine();
    Console.WriteLine("=== Seleção de Aparelho ===");
    Console.WriteLine("[1] iPhone");
    Console.WriteLine("[2] Nokia");
    Console.WriteLine("[3] Samsung");
    Console.Write("Opção: ");
    string? m = Console.ReadLine();

    Console.Write("Número (chip): ");
    string numero = Console.ReadLine() ?? "0000-0000";
    Console.Write("IMEI: ");
    string imei = Console.ReadLine() ?? Guid.NewGuid().ToString("N")[..15];
    Console.Write("Memória (GB): ");
    int.TryParse(Console.ReadLine(), out int memoria);
    memoria = memoria > 0 ? memoria : 64;

    Smartphone s = m switch
    {
        "1" => new Iphone(numero, imei, memoria),
        "2" => new Nokia(numero, imei, memoria),
        "3" => new Samsung(numero, imei, memoria),
        _   => new Nokia(numero, imei, memoria)
    };

    s.LigarAparelho();
    return s;
}

static void MenuTelefonia(Smartphone s)
{
    var tel = (IAparelhoTelefonico)s;
    Console.WriteLine();
    Console.WriteLine("— Telefonia —");
    Console.WriteLine("[1] Ligar");
    Console.WriteLine("[2] Atender");
    Console.WriteLine("[3] Correio de voz");
    Console.Write("Escolha: ");
    string? op = Console.ReadLine();

    if (op == "1")
    {
        Console.Write("Número para ligar: ");
        string numero = Console.ReadLine() ?? "";
        tel.Ligar(numero);
    }
    else if (op == "2") tel.Atender();
    else if (op == "3") tel.IniciarCorreioVoz();
    else Console.WriteLine("Opção inválida.");
}

static void MenuMusica(Smartphone s)
{
    var mus = (IReprodutorMusical)s;
    Console.WriteLine();
    Console.WriteLine("— Música —");
    Console.WriteLine("[1] Selecionar música");
    Console.WriteLine("[2] Tocar");
    Console.WriteLine("[3] Pausar");
    Console.Write("Escolha: ");
    string? op = Console.ReadLine();

    if (op == "1")
    {
        Console.Write("Nome da música: ");
        string nome = Console.ReadLine() ?? "";
        mus.SelecionarMusica(nome);
    }
    else if (op == "2") mus.Tocar();
    else if (op == "3") mus.Pausar();
    else Console.WriteLine("Opção inválida.");
}

static void MenuNavegador(Smartphone s)
{
    var nav = (INavegadorInternet)s;
    Console.WriteLine();
    Console.WriteLine("— Navegador —");
    Console.WriteLine("[1] Exibir página");
    Console.WriteLine("[2] Nova aba");
    Console.WriteLine("[3] Atualizar");
    Console.Write("Escolha: ");
    string? op = Console.ReadLine();

    if (op == "1")
    {
        Console.Write("URL: ");
        string url = Console.ReadLine() ?? "https://www.dio.me";
        nav.ExibirPagina(url);
    }
    else if (op == "2") nav.AdicionarNovaAba();
    else if (op == "3") nav.AtualizarPagina();
    else Console.WriteLine("Opção inválida.");
}
