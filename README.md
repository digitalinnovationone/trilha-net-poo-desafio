# Sistema de celular - DIO - Trilha .NET
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

## Funcionalidades
 - Criação de um smartphone da marca Iphone ou Nokia;
    - Propriedades:
       * Número;
       * Modelo;
       * Memória;
       * IMEI;
       * Operadora;
       * Carteira.
 - Fazer ligação;
 - Receber ligação;
 - Instalar e desinstalar app;
 - Mostrar detalhes sobre o smartphone;
 - Listar apps instalados;
 - Comprar memória;
 - Mostrar histórico da carteira.

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Tecnologias
 - C#
 - .NET
 - GIT