using System;

namespace AlertaEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtqdMaxima,qtdAtual,resultado;
            string nomeProduto;
            Console.Clear();

            Console.WriteLine("Digite o nome do produto");
            nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite a quantidade atual do produto");
            qtdAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade máxima do produto");
            qtqdMaxima = double.Parse(Console.ReadLine());

            resultado = (qtdAtual / qtqdMaxima)*100;

            //O comando ToString("n2") Formata a saída do número que está em resultado
            //com 2 casas decimais. AO final concatenamos com o símbolo de porcentagem 
            Console.WriteLine(resultado.ToString("n2")+"%");

            if(resultado <= 12 )
                Console.WriteLine("Comprar com Urgencia");
            else if(resultado<=20)
                Console.WriteLine("Realizar compra");
            else 
                Console.WriteLine("Ponto de utilização");  
        }
    }
}
