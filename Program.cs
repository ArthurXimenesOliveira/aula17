// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Pessoa p = new Pessoa();

// p.Nome = "Gomes";
// p.Sobrenome = "Oliveira";
// p.CPF = 12345678;


// Console.WriteLine($"Olá {p.Nome} {p.Sobrenome} seu CPF é: {p.CPF}");
using System.Collections;

Console.WriteLine("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

Console.WriteLine("Digite seu Data de Nascimento no formato dd/mm/aa: ");
DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento); 

Console.WriteLine("Digite seu CPF sem ponto: ");
int.TryParse(Console.ReadLine(), out int cpf); 

Console.WriteLine("Digite seu peso: ");
decimal.TryParse(Console.ReadLine(), out decimal peso);

Console.WriteLine("Digite seu altura: ");
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa(nome, sobrenome, dataNascimento, cpf, peso, altura);

int idade = p.CalculaIdade();

decimal imc = Math.Round(p.CalculaIMC(),2);

bool sair = false;

while(!sair)
{
    Console.WriteLine("Escolha uma das opções abaixo!");
    Console.WriteLine("0 - Informações dos usuários");
    Console.WriteLine("1 - Calcular IMC");
    Console.WriteLine("2 - Verificar a maioridade do usuário");
    Console.WriteLine("3 - Sair");

    string? opcao = Console.ReadLine();

    switch(opcao)
    {
        case "0":
        Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
        Console.WriteLine($"Data de nascimento: {dataNascimento}");
        Console.WriteLine($"CPF: {cpf}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Peso: {peso}");
        Console.WriteLine($"Idade: {idade}");
        break;

        case "1":
            Console.WriteLine($"Seu imc é: {imc}");
            if (imc <= 18)
            {
                Console.WriteLine("abaixo");
            }
            else if(imc >= 19 && imc <= 25)
            {
                Console.WriteLine("ideal");
            }
             else if(imc >= 26 && imc <= 30)
            {
                Console.WriteLine("levemente acima");
            }
             else if(imc >= 31 && imc <= 35)
            {
                Console.WriteLine("obesidade grau I");
            }
             else if(imc >= 36 && imc <= 39)
            {
                Console.WriteLine("obesidade grau II");
            }
            else if(imc >= 40)
            {
                Console.WriteLine("obesidade grau III");
            }
        break;

        case "2":
            if(idade >= 18)
            {
                Console.WriteLine($"Ola {nome}, parabens você já é Maior de idade por ter {idade}");
            }else 
            Console.WriteLine($"Ola {nome}, você é Menor de idade por ter {idade}");
        break;

        case "3":
        sair = true;
        break;

    }


}