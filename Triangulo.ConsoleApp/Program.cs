using System;

namespace Triangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int result = 0;

            do
            {
                Console.WriteLine("\n====Classificadora de triângulos====");
                Console.ReadLine();

                Console.WriteLine("Insira a medida X");
                string x = Console.ReadLine();

                double valorx = Convert.ToDouble(x);

                Console.WriteLine("Insira a medida Y");
                string y = Console.ReadLine();

                double valory = Convert.ToDouble(y);

                Console.WriteLine("Insira a medida Z");
                string z = Console.ReadLine();

                double valorz = Convert.ToDouble(z);

                ////////////////////////////
                double somaXeY = valorx + valory;
                double somaYeZ = valory + valorz;
                double somaZeX = valorz + valorx;
                ////////////////////////////

                if (valorx == valory && valory == valorz) /////////////Equilatero///////////////
                {
                    Console.WriteLine("Seu triangulo é classificado como um: Eqüilátero");
                    Console.WriteLine("\nInsira 1 para sair, ou 2 para continuar");
                    string resultado = Console.ReadLine();
                    int resulta = Convert.ToInt32(resultado);
                    if (resulta == 1)
                    {
                        result++;
                    }


                }
                else if (valorx == valory && valory != valorz && valorz < somaXeY) /////////////Isósceles///////////////
                {
                    Console.WriteLine("Seu triangulo é classificado como um: Isósceles");
                    Console.WriteLine("\nInsira 1 para sair, ou 2 para continuar");
                    string resultado = Console.ReadLine();
                    int resulta = Convert.ToInt32(resultado);
                    if (resulta == 1)
                    {
                        result++;
                    }
                }
                else if (valorx == valorz && valorz != valory && valory < somaZeX) /////////////Isósceles///////////////
                {
                    Console.WriteLine("Seu triangulo é classificado como um: Isósceles");
                    Console.WriteLine("\nInsira 1 para sair, ou 2 para continuar");
                    string resultado = Console.ReadLine();
                    int resulta = Convert.ToInt32(resultado);
                    if (resulta == 1)
                    {
                        result++;
                    }
                }
                else if (valory == valorz && valorz != valorx && valorx < somaYeZ) /////////////Isósceles///////////////
                {
                    Console.WriteLine("Seu triangulo é classificado como um: Isósceles");
                    Console.WriteLine("\nInsira 1 para sair, ou 2 para continuar");
                    string resultado = Console.ReadLine();
                    int resulta = Convert.ToInt32(resultado);
                    if (resulta == 1)
                    {
                        result++;
                    }
                }
                else if (valory != valorz && valorz != valorx && valorx != valory) ////////////Escaleno///////////////
                {
                    Console.WriteLine("Seu triangulo é classificado como um: Escaleno");
                    Console.WriteLine("\nInsira 1 para sair, ou 2 para continuar");
                    string resultado = Console.ReadLine();
                    int resulta = Convert.ToInt32(resultado);
                    if (resulta == 1)
                    {
                        result++;
                    }
                }
                else if (valorx > somaYeZ) ////////////Invalido///////////////
                {
                    Console.WriteLine("Triângulo invalido, valor X é maior que a soma dos outros dois lados.");
                    Console.WriteLine("\nInsira 1 para sair, ou 2 para continuar");
                    string resultado = Console.ReadLine();
                    int resulta = Convert.ToInt32(resultado);
                    if (resulta == 1)
                    {
                        result++;
                    }
                }
                else if (valory > somaZeX) ////////////Invalido///////////////
                {
                    Console.WriteLine("Triângulo invalido, valor Y é maior que a soma dos outros dois lados.");
                    Console.WriteLine("\nInsira 1 para sair, ou 2 para continuar");
                    string resultado = Console.ReadLine();
                    int resulta = Convert.ToInt32(resultado);
                    if (resulta == 1)
                    {
                        result++;
                    }
                }
                else if (valorz > somaXeY) ////////////Invalido///////////////
                {
                    Console.WriteLine("Triângulo invalido, valor Z é maior que a soma dos outros dois lados.");
                    Console.WriteLine("\nInsira 1 para sair, ou 2 para continuar");
                    string resultado = Console.ReadLine();
                    int resulta = Convert.ToInt32(resultado);
                    if (resulta == 1)
                    {
                        result++;
                    }
                }else
                {
                    Console.WriteLine("Valores invalidos, tente novamente"); ////////////Invalido///////////////
                    Console.WriteLine("\nInsira 1 para sair, ou 2 para continuar");
                    string resultado = Console.ReadLine();
                    int resulta = Convert.ToInt32(resultado);
                    if (resulta == 1)
                    {
                        result++;
                    }
                }
            } while (result < 1);
        }   
    }
}

