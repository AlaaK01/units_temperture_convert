
//program för att konvertera mellan temperaturenhet
using System;

namespace _3
{
    class Program
    {
        static double CtoF(double x)
        {
            return ((x * 9 / 5) + 32);
        }
        static double CtoK(double x)
        {
            return (x + 273);
        }
        static double FtoC(double x)
        {
            return (x - 32) * 5 / 9;
        }
        static double FtoK(double x)
        {
            return ((x - 32) * 5 / 9) + 273;
        }
        static double KtoC(double x)
        {
            return (x - 273);
        }
        static double KtoF(double x)
        {
            return ((x - 273) * 9 / 5) + 32;
        }

        static void Main(string[] args)
        {
            double T = 0;
            char inputSelection = '0';
            char outputSelection = '0';
            bool isValid = true;
            while (isValid)
            {
                //ask user för temperture deggree
                while (isValid)
                {
                    Console.Write("\nskriv in temperatur: ");
                    string str1 = Console.ReadLine();
                    if (double.TryParse(str1, out T)) break;
                }
                //display menu selection for input temperature unit
                while (isValid)
                {
                    Console.WriteLine("välj den ingångstemperaturenhet som du ska börja med:");
                    Console.Write("\n\ttryck 'c' för degrees\n\ttryck 'f' för Fahrenheit\n\ttryck 'k' för Kelvin\n\nVälj enheten: ");
                    string str2 = Console.ReadLine();
                    if (char.TryParse(str2, out inputSelection))
                    {
                        if (inputSelection == 'c' || inputSelection == 'C' || inputSelection == 'f' || inputSelection == 'F'
                            || inputSelection == 'k' || inputSelection == 'K') break;

                    }
                }//display menu selection for output unit
                while (isValid)
                {
                    Console.WriteLine("välj den utgångstemperaturenhet som du ska omvandla till:");
                    Console.Write("\n\ttryck 'c' för degrees\n\ttryck 'f' för Fahrenheit\n\ttryck 'k' för Kelvin\n\ttryck 'b' för de andra enheter\n\nVälj enheten: ");
                    string str2 = Console.ReadLine();
                    if (char.TryParse(str2, out outputSelection))
                    {
                        if (outputSelection == 'c' || outputSelection == 'C' || outputSelection == 'f' || outputSelection == 'F'
                            || outputSelection == 'k' || outputSelection == 'K' || outputSelection == 'b' || outputSelection == 'B') break;

                    }
                }
                //input unit is Celesius
                if (inputSelection == 'c' || inputSelection == 'C')
                {
                    if (outputSelection == 'f' || outputSelection == 'F')
                    {
                        Console.WriteLine($"Temperatur är:\n\t\t{T} Celsius\n\t\t{CtoF(T)} Fahrenheit");
                    }
                    else if (outputSelection == 'k' || outputSelection == 'K')
                    {
                        Console.WriteLine($"Temperatur är:\n\t\t{T} Celsius\n\t\t{CtoK(T)} Kelvin");
                    }
                    else if (outputSelection == 'b' || outputSelection == 'B')
                    {
                        Console.WriteLine($"Temperatur är:\n\t\t{T} Celsius\n\t\t{CtoF(T)} Fahrenheit\n\t\t{CtoK(T)} Kelvin");
                    }
                    else if (outputSelection == 'c' || outputSelection == 'C') continue;


                }//input unit is Fahrenheit
                else if (inputSelection == 'f' || inputSelection == 'F')
                {
                    if (outputSelection == 'c' || outputSelection == 'C')
                    {
                        Console.WriteLine($"Temperatur är:\n\t\t{T} Fahrenheit\n\t\t{FtoC(T)} Celsius.");
                    }
                    else if (outputSelection == 'k' || outputSelection == 'K')
                    {
                        Console.WriteLine($"Temperatur är:\n\t\t{T} Fahrenheit\n\t\t{FtoK(T)} Kelvin.");
                    }
                    else if (outputSelection == 'b' || outputSelection == 'B')
                    {
                        Console.WriteLine($"Temperatur är:\n\t\t{T} Fahrenheit\n\t\t{FtoC(T)} Celsius\n\t\t{FtoK(T)} Kelvin.");
                    }
                    else if (outputSelection == 'f' || outputSelection == 'F') continue;
                }
                else //input unit is Kelvin
                {
                    if (outputSelection == 'c' || outputSelection == 'C')
                    {
                        Console.WriteLine($"Temperatur är:\n\t\t{T} Kelvin\n\t\t{KtoC(T)} Celsuis.");
                    }
                    else if (outputSelection == 'f' || outputSelection == 'F')
                    {
                        Console.WriteLine($"Temperatur är:\n\t\t{T} Kelvin\n\t\t{KtoF(T)} Fahrenheit.");
                    }
                    else if (outputSelection == 'b' || outputSelection == 'B')
                    {
                        Console.WriteLine($"Temperatur är:\n\t\t{T} Kelvin\n\t\t{KtoC(T)} Celsuis\n\t\t{KtoF(T)} Fahrenheit.");
                    }
                    else if (outputSelection == 'k' || outputSelection == 'K') continue;
                }  //aske user if he want to countinue using program or finish it.
                Console.Write("vill du köra igen....(Y , N)");
                string str3 = Console.ReadLine();
                if (str3 == "N" || str3 == "n")
                {
                    Console.WriteLine("Völkommen åter");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
