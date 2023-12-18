using System.Diagnostics;

namespace CSharpType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var choices = GameData.Snippets;
            var rng = new Random();
            while (true)
            {
                Console.Clear();
                var target = choices[rng.Next(0, choices.Count)];
                //target = GameData.GenerateSentence();
                var inputPhrase = "";
                var index = 0;
                Console.Write(target);
                Console.CursorLeft = index;
                while (inputPhrase != target)
                {
                    var input = Console.ReadKey();
                    if (input.Key == ConsoleKey.Enter)
                    {
                        break;
                    }

                    if (input.Key == ConsoleKey.Backspace)
                    {
                        if (index != 0)
                        {
                            index--;
                            inputPhrase = inputPhrase.Remove(inputPhrase.Length - 1);
                        }

                        Console.CursorLeft = index;
                        if (index > target.Length - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(target[index]);
                        }

                        Console.CursorLeft = index;
                        continue;
                    }

                    Console.CursorLeft = index;
                    inputPhrase += input.KeyChar;
                    if (index > target.Length - 1)
                    {
                        WriteCharWithColor(input.KeyChar, ConsoleColor.Red);
                        index++;
                    }
                    else if (input.KeyChar != target[index])
                    {
                        WriteCharWithColor(target[index], ConsoleColor.Red);
                        index++;
                    }
                    else
                    {
                        WriteCharWithColor(input.KeyChar, ConsoleColor.Green);
                        index++;
                    }
                }
            }
        }

        private static void WriteCharWithColor(char character, ConsoleColor color)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(character);
            Console.ForegroundColor = originalColor;
        }
    }
}