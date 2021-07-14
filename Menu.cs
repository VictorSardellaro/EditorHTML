using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }

        public static void DrawScreen()
        {

            System.Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            System.Console.Write("+");
            System.Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                System.Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                System.Console.Write("|");
                System.Console.Write("\n");
            }

            System.Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            System.Console.Write("+");
            System.Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            System.Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 3);
            System.Console.Write("===========================");
            Console.SetCursorPosition(3, 4);
            System.Console.Write("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            System.Console.Write("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            System.Console.Write("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            System.Console.Write("0 - Sair");
            Console.SetCursorPosition(3, 10);
            System.Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: System.Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }

        }
    }


}

