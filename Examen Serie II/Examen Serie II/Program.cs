using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Serie_II
    {
        class Program
        {
            static void Main(string[] args)
            {
            
                Console.WriteLine("Seleccione la operación que desea realizar:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el primer número:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = Sumar(num1, num2);
                        break;
                    case 2:
                        resultado = Restar(num1, num2);
                        break;
                    case 3:
                        resultado = Multiplicar(num1, num2);
                        break;
                    case 4:
                        resultado = Dividir(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine($"Resultado: {resultado}");

                Console.ReadLine();
            }

            static double Sumar(double a, double b)
            {
                return a + b;
            }

            static double Restar(double a, double b)
            {
                return a - b;
            }

            static double Multiplicar(double a, double b)
            {
                return a * b;
            }

            static double Dividir(double a, double b)
            {
                if (b != 0)
                    return a / b;
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                    return double.NaN;
                }

        }

              

        }
            
    }
            

