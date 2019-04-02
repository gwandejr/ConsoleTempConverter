using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string progBegEndInput = "";

            do
            {
                Console.Write("Start the temperature conversion program: to continue type 'Y', " +
                    "to exit type 'N'. ");
                progBegEndInput = Console.ReadLine();

                if (progBegEndInput != "Y")
                {
                    break;
                }
                else
                {
                    string tempValueInput = "";
                    string tempTypeInput = "";

                    try
                    {
                        Console.Write("Please input a temperature value. ");
                        tempValueInput = Console.ReadLine();
                        int tempValueTest = Int32.Parse(tempValueInput);
                    }
                    catch (FormatException fEx)
                    {
                        Console.WriteLine("Must input a number. Start over below");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        continue;
                    }

                    Console.Write("Please input the temperature value type: for Celsius type 'C', " +
                        "for Fahrenheit type 'F'. ");
                    tempTypeInput = Console.ReadLine();

                    try
                    {
                        if ((tempTypeInput != "C") && (tempTypeInput != "F"))
                        {
                            throw new Exception();
                        }

                        else if (tempTypeInput == "C")
                        {
                            double tempF = (double.Parse(tempValueInput) * 9 / 5) + 32;
                            Console.WriteLine(tempValueInput + " Degrees Celsius = " +
                                Math.Round(tempF, MidpointRounding.AwayFromZero) + " Degrees Fahrenheit");
                        }

                        else if (tempTypeInput == "F")
                        {
                            double tempC = (double.Parse(tempValueInput) - 32) * 5 / 9;
                            Console.WriteLine(tempValueInput + " Degrees Fahrenheit = " +
                                Math.Round(tempC, MidpointRounding.AwayFromZero) + " Degrees Celsius");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Must input a 'C' for Celsius or an 'F' for Fahrenheit. Start over below.");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("");

                }

            } while (progBegEndInput == "Y");
        }
    }
}
