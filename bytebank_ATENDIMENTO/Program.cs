using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

#region Algoritmo de testes
/*string[] arrayDePalavras = new string[5];

PreencheArray(arrayDePalavras);

Console.Write("Digite a palavra a ser buscada: ");
string buscaPalavra = Console.ReadLine();

BuscaPalavraArray(buscaPalavra, arrayDePalavras);*/


void PrintaPercorreArray(object[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Indice: {i}  Valor: {array[i]}");
    }
}

void BuscaPalavraArray(string palavra, string[] array)
{
    foreach(string elemento in array)
    {
        if(palavra == elemento) 
        {
            Console.WriteLine("PALAVRA ENCONTRADA!");
            break;
        }
    }
}

void PreencheArray(object[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Item {i}:");
        var elementoInserido = Console.ReadLine();
        array[i] = elementoInserido;
    }
}

void CalculaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo de mediana está vazio ou nulo");
    }

    double[] numerosOrdenados = (double[])array.Clone();

    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;

    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                                            (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana é igual a: {mediana}");
}

Array amostra = Array.CreateInstance(typeof(double), 5);

amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//CalculaMediana(amostra);

void TestaArrayContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));

    var contaDoAndre = new ContaCorrente(963);
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("=================");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }
}

//TestaArrayContasCorrentes();

#endregion

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
    new ContaCorrente(95) {Saldo=100},
    new ContaCorrente(95) {Saldo=200},
    new ContaCorrente(94) {Saldo=60}
}; ;

//AtendimentoCliente();

 void AtendimentoCliente()
{
    char opcao = '0';

    while (opcao != '6')
    {
        Console.Clear();
        Console.WriteLine("==============================="); 
        Console.WriteLine("===       Atendimento       ===");
        Console.WriteLine("===1 - Cadastrar Conta      ===");
        Console.WriteLine("===2 - Listar Contas        ===");
        Console.WriteLine("===3 - Remover Conta        ===");
        Console.WriteLine("===4 - Ordenar Contas       ===");
        Console.WriteLine("===5 - Pesquisar Conta      ===");
        Console.WriteLine("===6 - Sair do Sistema      ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];
        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            case '2':
                ListarContas();
                break;
            default:
                Console.WriteLine("Opcao não implementada.");
                break;
        }
    }
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");

    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }

    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}

Generica<int> teste1 = new Generica<int>();
teste1.MostrarMensagem(1);

public class Generica<T>
{
    public void MostrarMensagem(T t)
    {
        Console.WriteLine($"Exibindo {t}");
    }
}
