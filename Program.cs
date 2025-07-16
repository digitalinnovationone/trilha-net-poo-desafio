using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

List<Smartphone> smartphones = new List<Smartphone>();

Console.Write("Quantos smartphones deseja cadastrar? ");
int quantidade = int.Parse(Console.ReadLine());


// Cadatra Smartphone e suas características 
for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"\nCadastro do smartphone #{i + 1}");
    Console.Write("Digite o tipo (Nokia ou iPhone): ");
    string tipo = Console.ReadLine().Trim().ToUpper();

    Console.Write("Digite o número: ");
    string numero = Console.ReadLine();

    Console.Write("Digite o modelo: ");
    string modelo = Console.ReadLine();

    Console.Write("Digite o IMEI: ");
    string imei = Console.ReadLine();

    Console.Write("Digite a memória (em GB): ");
    int memoria = int.Parse(Console.ReadLine());

    Console.Write("Digite a cor do celular: ");
    string cor = Console.ReadLine();

    Console.Write("Digite o ano de fabricação: ");
    int ano = int.Parse(Console.ReadLine());

    Smartphone celular;

    if (tipo == "NOKIA")
    {
        celular = new Nokia(numero, modelo, imei, memoria, cor, ano);
        celular.Ligar();
    }
    else if (tipo == "IPHONE")
    {
        celular = new Iphone(numero, modelo, imei, memoria, cor, ano);
        celular.ReceberLigacao();
    }
    else
    {
        Console.WriteLine("Tipo inválido.");
        continue;
    }

    Console.Write("Digite o nome do aplicativo para instalar: ");
    string app = Console.ReadLine();
    celular.InstalarAplicativo(app);

    smartphones.Add(celular);

    // Exibe resumo
    Console.WriteLine("\nResumo do smartphone cadastrado:");
    Console.WriteLine($"Tipo: {tipo}");
    Console.WriteLine($"Número: {numero}");
    Console.WriteLine($"Modelo: {modelo}");
    Console.WriteLine($"IMEI: {imei}");
    Console.WriteLine($"Memória: {memoria} GB");
    Console.WriteLine($"Cor: {cor}");
    Console.WriteLine($"Ano de fabricação: {ano}");
    Console.WriteLine($"App instalado: {app}");
}
