using System;

namespace Registro
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            Options();

            var option = short.Parse(Console.ReadLine());
            MenuOption(option);
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 25; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 50; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 50; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void Options()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Seja bem-vindo a TinkerBell Burger!");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("-----------------------------------");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("O que deseja pedir? Selecione uma opção abaixo.");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Hamburguers");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Porções");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("3 - Bebidas");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 12);
            Console.Write("Opção: ");

        }

        public static void MenuOption(short option)
        {
            var escolha = "";
            switch (option)
            {
                case 1:
                    escolha = MenuBurger();
                    break;
                case 2:
                    MenuPorcao();
                    break;
                case 3:
                    MenuBebidas();
                    break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }

            Console.SetCursorPosition(3, 21);
            Console.WriteLine("Sua escolha foi: ");
            Console.Write("\n");
            Console.SetCursorPosition(3, 22);
            Console.WriteLine(escolha);
        }

        public static string MenuBurger()
        {
            Console.SetCursorPosition(3, 14);
            Console.WriteLine("Hamburguers");
            Console.Write("\n");
            Console.SetCursorPosition(3, 15);
            Console.WriteLine("1 - TB Bacon");
            Console.SetCursorPosition(3, 16);
            Console.WriteLine("2 - TB Salada");
            Console.SetCursorPosition(3, 17);
            Console.WriteLine("3 - TB Tudo");
            Console.SetCursorPosition(3, 19);
            Console.Write("Opção: ");
            var hamburguer = short.Parse(Console.ReadLine());

            var escolha = "";
            switch (hamburguer)
            {
                case 1:
                    escolha = "1 - TB Bacon";
                    break;
                case 2:
                    escolha = "2 - TB Salada";
                    break;
                case 3:
                    escolha = "3 - TB Tudo";
                    break;
                default:
                    escolha = "Pedido inválido";
                    break;
            }

            return escolha;
        }

        public static void MenuPorcao()
        {
            Console.SetCursorPosition(3, 14);
            Console.WriteLine("Porções");
            Console.Write("\n");
            Console.SetCursorPosition(3, 15);
            Console.WriteLine("1 - Batata");
            Console.SetCursorPosition(3, 16);
            Console.WriteLine("2 - Batata completa");
            var porcao = short.Parse(Console.ReadLine());
        }

        public static void MenuBebidas()
        {
            Console.SetCursorPosition(3, 14);
            Console.WriteLine("Bebidas");
            Console.Write("\n");
            Console.SetCursorPosition(3, 15);
            Console.WriteLine("1 - Coca lata");
            Console.SetCursorPosition(3, 16);
            Console.WriteLine("2 - Guaraná lata");
            Console.SetCursorPosition(3, 17);
            Console.WriteLine("3 - Fanta lata");
            var bebidas = short.Parse(Console.ReadLine());
        }
    }
}