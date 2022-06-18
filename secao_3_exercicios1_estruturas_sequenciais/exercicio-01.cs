namespace secao_3_exercicios1_estruturas_sequenciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.WriteLine("Digite o primeiro valor inteiro: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor inteiro: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"SOMA = {valor1 + valor2}");
        }
    }
}