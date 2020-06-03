/*Pedir al usuario el precio de un producto y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta
 pedir el numero de tarjeta (12 digitos). Ojo, validar que el valor ingresado en el sea positivo. */
using System;

namespace ConsoleApp2
{
    class programII
    {
        static void Main(string[] args)
        {
            double precio;
            string sel;
            Console.WriteLine("Pago de articulos de supermercado");

            Console.Write("Bienvenido ,Digite el precio del articulo: ");
            precio = Convert.ToDouble(Console.ReadLine());

            while (precio < 0)
            {
                Console.WriteLine("Error, Precio invalido");
                Console.WriteLine();

                Console.Write("Digite un precio un valido: ");
                precio = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"El precio del articulo es  ${precio} ");


            Console.WriteLine("Digite su  forma de pago");
            Console.Write("1-Efectivo 2-Tarjeta: ");
            sel = Console.ReadLine();

            while (sel == "1" && sel == "2" && sel == "3")
            {
                Console.WriteLine("Digite una seleccion valida");
                Console.Write("1-Efectivo 2-Tarjeta: ");
                sel = Console.ReadLine();

            }




            switch (sel)
            {
                case "1":
                    {
                        Console.WriteLine("Consulte el pago con el empleado");
                        break;
                    }
                case "2":
                    {
                        string ntarjeta;
                        Console.WriteLine("Usted selecciono el metodo de tarjeta");
                        Console.WriteLine();

                        Console.Write("Digite el numero de tarjeta: ");
                        ntarjeta = Console.ReadLine();
                        int cantN = ntarjeta.Length;

                        if (cantN == 12)
                        {
                            Console.WriteLine("El pago se ha realizado correctamente");
                            break;

                        }
                        else
                        {
                            while (cantN < 12 || cantN > 12)
                            {
                                Console.WriteLine("Error , Tarjeta invalida, debe contener 12 caracteres");

                                Console.Write("Digite el numero de tarjeta correctamente: ");
                                ntarjeta = Console.ReadLine();
                                cantN = ntarjeta.Length;

                                if (cantN == 12)
                                {
                                    Console.WriteLine("El pago se ha realizado correctamente");
                                }
                            }
                            break;
                        }

                    }
                case "3":
                    {
                        Console.WriteLine("Se ha cancelado el pago");
                        break;
                    }



            }
        }

    }
}

