//EJERCICIO 4
//Escribir un programa que pregunte al usuario los números ganadores de la lotería primitiva, los almacene en una lista y los muestre por pantalla ordenados de menor a mayor.
class Program
{
    static void Main()
    {
        // Creación de la lista para almacenar los números ganadores
        List<int> numerosGanadores = new List<int>();
        int cantidadNumeros = 6;

        Console.WriteLine($"Introduce los {cantidadNumeros} números ganadores de la lotería primitiva (entre 1 y 49):");

        // se utiliza un bucle para pedir los números ganadores
        for (int i = 1; i <= cantidadNumeros; i++)
        {
            int numero;
            while (true)
            {
                Console.Write($"Número {i}: ");
                string input = Console.ReadLine();

                // Se valida que el número sea entero y para que este en el rango permitido
                if (int.TryParse(input, out numero) && numero >= 1 && numero <= 49)
                {
                    if (!numerosGanadores.Contains(numero))
                    {
                        numerosGanadores.Add(numero);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Este número ya fue introducido. Por favor, introduce otro.");
                    }
                }
                else
                {
                    Console.WriteLine("El nuúmero ingresado es invalido. Por favor, introduce un número entre 1 y 49.");
                }
            }
        }

        // Ordenar la lista de números ganadores
        numerosGanadores.Sort();

        // Mostrar los números ordenados
        Console.WriteLine("\nNúmeros ganadores ordenados de menor a mayor:");
        foreach (int numero in numerosGanadores)
        {
            Console.Write(numero + " ");
        }
    }
}
