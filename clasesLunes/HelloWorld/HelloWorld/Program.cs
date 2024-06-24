// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main()
    {
        string continuar;
        Console.WriteLine("Hola, bienvenido a la calculadora Mayaya");

        do
        {
            
            Console.WriteLine("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la operación desea realizar (Suma=1, Resta=2, Multiplicación=3, División=4, Porcentaje=5, Promedio=6):");
            string operacion = Console.ReadLine();

            string signo;
            double resultado = 0;

            switch (operacion)
            {
                case "1":
                    resultado = num1 + num2;
                    signo = "suma";
                    break;
                case "2":
                    resultado = num1 - num2;
                    signo = "resta";
                    break;
                case "3":
                    resultado = num1 * num2;
                    signo = "multiplicación";
                    break;
                case "6":
                    Console.WriteLine("Ingrese un tercer número:");
                    double num3 = double.Parse(Console.ReadLine());
                    resultado = (num1 + num2 + num3) / 3;
                    signo = "promedio";
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        signo = "división";
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                        return;
                    }
                    break;
                case "5":
                    resultado = (num1 * num2) / 100;
                    signo = "porcentaje";
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    return;
            }

            Console.WriteLine("El resultado de " + num1 + " y " + num2 + " (" + signo + ") realizada es: " + resultado);

            Console.WriteLine("¿Desea realizar otra operación? (Si/No)");
            continuar = Console.ReadLine();

        } while (continuar.ToLower() == "si");
    }
}



