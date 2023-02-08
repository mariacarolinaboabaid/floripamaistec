// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int numeroInteiro = 10;
long numeroMaior = 100000999L;
float numeroQuebrado = 6.8f;
double numeroQuebradoMaior = 101.99999999D;
char letra = 'z';
string texto = "Olá";
bool varialBooleana = true;


DateTime data = DateTime.Now; // Data até segundos
DateTime outraData = new DateTime(2023, 01, 31);
Console.WriteLine(data);
Console.WriteLine(outraData);

texto.ToUpper();

string nomeCompleto; // Declaração de variável

Console.Write("Digite o seu nome: ");
nomeCompleto = Console.ReadLine();
Console.WriteLine("O seu nome é " + nomeCompleto);