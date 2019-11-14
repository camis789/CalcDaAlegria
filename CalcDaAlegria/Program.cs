using System;
using CalcDaAlegria.Model;
using CalcDaAlegria.Sub;
using CalcDaAlegria.Soma;
using CalcDaAlegria.Mult;
using CalcDaAlegria.Div;

namespace CalcDaAlegria
{
    class Program
    {
        static void Main(string[] args)
        {
            modelinho Modelinho = new modelinho();

            Console.WriteLine("CALCULADORA DA ALEGRIA");

            bool continuar = true;

            while (continuar)
            {

                Console.WriteLine("1-Soma");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Divisão");
                Console.WriteLine("4-Multiplicação");
                Console.WriteLine("Escolha uma operação");

                Modelinho.opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
               
                Console.WriteLine("Entre com o numero:");
                Modelinho.valor1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Entre com o outro numero");
                Modelinho.valor2 = Convert.ToDecimal(Console.ReadLine());

                switch (Modelinho.opcao)
                {

                    case 1:
                        soma Soma = new soma(Modelinho.valor1, Modelinho.valor2); ;
                        decimal rSoma = Soma.result();

                        Console.WriteLine("Total: ");
                        Console.WriteLine(rSoma);

                        break;

                    

                    case 2:

                        sub Sub = new sub(Modelinho.valor1, Modelinho.valor2); ;
                        decimal rSub = Sub.result();

                        Console.WriteLine("Total: ");
                        Console.WriteLine(rSub);

                        break;

                    case 3:

                        divisao Div = new divisao(Modelinho.valor1, Modelinho.valor2); ;
                        decimal rDiv = Div.result();

                        Console.WriteLine("Total: ");
                        Console.WriteLine(rDiv);

                        break;

                    case 4:

                        mult Mult = new mult(Modelinho.valor1, Modelinho.valor2); ;
                        decimal rMult = Mult.result();

                        Console.WriteLine("Total: ");
                        Console.WriteLine(rMult);

                        break;


                }


            }
        }
    }
}
