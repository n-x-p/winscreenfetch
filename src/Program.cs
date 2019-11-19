using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WinScreenfetch
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleColor prev = Console.ForegroundColor;
            try
            {

                Console.WriteLine();

                ConsoleColor[] logoColors = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow };
                ConsoleColor labelColor = ConsoleColor.Cyan;
                Settings settings = new Settings();

                List<Settings.Data> data = settings.GetWithLabels();
                List<string[]> logo = LogoManager.Windows();

                int i = 0;
                foreach (string[] line in logo)
                {
                    if (i < (data.Count - 1))
                    {
                        Console.Write("  ");
                        for (int j = 0; j < logoColors.Length; j++)
                        {
                            Console.ForegroundColor = logoColors[j];
                            Console.Write($"{line[j]}");
                        }
                        Console.ForegroundColor = labelColor;
                        if (!string.IsNullOrEmpty(data[i].Label))
                        {
                            Console.Write($"  {data[i].Label}:");
                            Console.ForegroundColor = prev;
                            Console.WriteLine($" {data[i].Value}");
                        }
                        else
                            Console.WriteLine($"  {data[i].Value}");
                    }
                    else
                    {
                        Console.Write("  ");
                        for (int j = 0; j < logoColors.Length; j++)
                        {
                            Console.ForegroundColor = logoColors[j];
                            Console.Write($"{line[j]}");
                        }
                        Console.WriteLine();
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Aaaaaagh, this should have never happened!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = prev;
                if (Debugger.IsAttached)
                    Console.ReadLine();
            }
        }
    }
}