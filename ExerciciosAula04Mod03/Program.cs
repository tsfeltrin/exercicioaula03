using System;

namespace ExerciciosAula04Mod03
{
    internal class Program
    {
        static void Main(string[] args)
        {
          void Fatorial()
            {
                int resultado = 1;
                Console.WriteLine("Digite um numero");
                int numero = int.Parse(Console.ReadLine());

                for (int i = numero; i > 1; i--)
                {
                    resultado *= i;
                    Console.WriteLine(resultado);
                }
                Console.WriteLine("O resultado do fatorial é: " + resultado);
                Console.ReadKey();
            }
            //Fatorial();

            void Imc()
            {
                Console.WriteLine("digite seu peso");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("digite sua altura");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("resultado");
                double resultado = peso / (altura * altura);//ou peso / Math.Pow(altura, 2);

                Console.WriteLine(resultado);
                if (resultado < 18.5)
                {
                    Console.WriteLine("Abaixo do Peso");
                }
                else if (resultado <= 24.9)
                {
                    Console.WriteLine("normal");
                }
                else if (resultado < 29.9)
                {
                    Console.WriteLine("sobrepeso");
                }
                else if (resultado < 34.9)
                {
                    Console.WriteLine("obesidade grau I");
                }
                else if (resultado < 39.9)
                {
                    Console.WriteLine("obesidade grau II");
                }
                else 
                {
                    Console.WriteLine("obesidade grau II");
                }
            }
            //Imc();

            void CalculadoraSimples()
            {
                Console.WriteLine("Digite o 1º numero:");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2º numero:");
                int numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o operador:");
                string op = Console.ReadLine();

                if (op == "+")
                {
                    Console.WriteLine("A soma é: " + (numero1 + numero2));
                }
                else if (op == "-")
                {
                    Console.WriteLine("A subtração é: " + (numero1 - numero2));
                }
                if (op == "/")
                {
                    Console.WriteLine("A divisão é: " + (numero1 / numero2));
                }
                if (op == "*")
                {
                    Console.WriteLine("A multiplicação é: " + (numero1 * numero2));
                }
                Console.ReadKey();
            }
            //CalculadoraSimples();

            void DerrapagemNaFrenagem()
            {
                Console.WriteLine("Digite a velocidade");
                double velocidade = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a aceleraçao");
                double aceleraçao = double.Parse(Console.ReadLine());

                double distancia = -(Math.Pow(velocidade, 2)) / (2 * aceleraçao);
                Console.WriteLine("A distancia percorrida é: " + distancia);

                Console.ReadKey();
            }
            DerrapagemNaFrenagem();
        }
    }
}
