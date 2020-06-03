using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Programa para identificar si es fin de semana");
            Console.WriteLine();
            Console.Write("Escriba el dia");
            var dia = Console.ReadLine();
            dia = dia.ToLower();



            switch (dia)
            {

                case "lunes":
                    Console.WriteLine($"El dia {dia} no pertenece a fin de semana");
                    break;

                case "martes":
                    Console.WriteLine($"El dia {dia} no pertenece a fin de semana");
                    break;

                case "miercoles":
                    Console.WriteLine($"El dia {dia} no pertenece a fin de semana");
                    break;
                case "jueves":
                    Console.WriteLine($"El dia {dia} no pertenece a fin de semana");
                    break;

                case "viernes":
                    Console.WriteLine($"El dia {dia}  pertenece a los dias de  fin de semana");
                    break;

                case "sabado":
                    Console.WriteLine($"El dia {dia}  pertenece a los dias de  fin de semana");
                    break;

                case "domingo":
                    Console.WriteLine($"El dia {dia}  pertenece a los dias de  fin de semana");
                    break;

                default:
                    Console.WriteLine("Dia invalido");
                    break;
            }

            Console.WriteLine("Fin del Programa");
            Console.ReadKey();

        }
    }
}
