using System;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string salgado, molho, bebida;
            string op, sair;

            do
            {
                Console.Clear();

                Console.WriteLine("Bem vindo(a) a Toca do gordo!");
                Console.Write("Qual seu nome? ");
                nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write($"Olá {nome}. Qual seu pedido? ");

                salgado = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"- Eu vou querer um(a) {salgado}");
                Console.WriteLine();

                Console.WriteLine($"Lista de Molhos");
                Console.WriteLine("Ketchup: k");
                Console.WriteLine("Mostarda: m");
                Console.WriteLine("Barbecue: b");
                Console.WriteLine("Molho de Alho: a");
                Console.WriteLine("Molho Rose: r");
                Console.WriteLine();

                Console.Write($"Você deseja algum molho para acompanhar com seu(sua) {salgado}: ");
                molho = Console.ReadLine().ToLower();


                if (molho == "k")
                {
                    Console.WriteLine("Aqui está! Seu ketchup");
                    Console.WriteLine();
                }

                else if (molho == "m")
                {
                    Console.WriteLine("Aqui está! Sua mostarda");
                    Console.WriteLine();
                }

                else if (molho == "b")
                {
                    Console.WriteLine("Aqui está! Seu barbecue");
                    Console.WriteLine();
                }

                else if (molho == "a")
                {
                    Console.WriteLine("Aqui está! Seu molho de alho");
                    Console.WriteLine();
                }

                else if (molho == "r")
                {
                    Console.WriteLine("Aqui está! Seu molho rose");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Então aqui está! Seu(sua) {salgado}");
                    Console.WriteLine();

                    Console.Write("Você deseja mais alguma coisa? ");
                    op = Console.ReadLine().ToLower();

                    if (op == "s" && op == "sim")
                    {
                        Console.WriteLine("Lista de Bebidas");
                        Console.WriteLine("Coca Cola: c");
                        Console.WriteLine("Fanta Laranja: l");
                        Console.WriteLine("Fanta Uva: u");
                        Console.WriteLine("Fanta Guarana: g");
                        Console.WriteLine();

                        Console.Write("Você deseja algo para beber? ");
                        bebida = Console.ReadLine().ToLower();

                        if (bebida == "c")
                        {
                            Console.WriteLine("Aqui esta! Sua coca-cola");
                            Console.WriteLine();
                        }

                        if (bebida == "l")
                        {
                            Console.WriteLine("Aqui esta! Sua fanta laranja");
                            Console.WriteLine();
                        }

                        if (bebida == "u")
                        {
                            Console.WriteLine("Aqui esta! Sua fanta uva");
                            Console.WriteLine();
                        }

                        if (bebida == "g")
                        {
                            Console.WriteLine("Aqui esta! Sua fanta guarana");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"Obrigado {nome} e Volte Sempre :)");
                            Environment.Exit(-1);
                        }

                        Console.Write("Você deseja mais alguma coisa? ");
                        sair = Console.ReadLine().ToUpper();
                    }
                    
                }

                Console.WriteLine("Lista de Bebidas");
                Console.WriteLine("Coca Cola: c");
                Console.WriteLine("Fanta Laranja: l");
                Console.WriteLine("Fanta Uva: u");
                Console.WriteLine("Fanta Guarana: g");
                Console.WriteLine();

                Console.Write("Você deseja algo para beber? ");
                bebida = Console.ReadLine().ToLower();

                if (bebida == "c")
                {
                    Console.WriteLine("Aqui esta! Sua coca-cola");
                    Console.WriteLine();
                }

                else if (bebida == "l")
                {
                    Console.WriteLine("Aqui esta! Sua fanta laranja");
                    Console.WriteLine();
                }

                else if (bebida == "u")
                {
                    Console.WriteLine("Aqui esta! Sua fanta uva");
                    Console.WriteLine();
                }

                else if (bebida == "g")
                {
                    Console.WriteLine("Aqui esta! Sua fanta guarana");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Obrigado e volte sempre :)");
                    Environment.Exit(-1);
                }

                Console.Write("Você deseja mais alguma coisa? ");
                sair = Console.ReadLine().ToUpper();
            }
            while (sair != "N" && sair != "NAO");
            {
                Console.WriteLine($"Obrigado {nome} e Volte Sempre :)");
            }
        }
    }
}
