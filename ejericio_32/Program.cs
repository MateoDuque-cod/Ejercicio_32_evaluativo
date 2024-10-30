using System;
using ejericio_32;

public class Program
{
    private static void Main(string[] args)
    {
        bool   continuar = true;
        string respuesta;

        do
        {
            Console.Write("ingrese el nombre del estudiante:");
            string nombre = Console.ReadLine();

            Console.Write("ingrese el numero de creditos del estudiante:");
            int creditos = int.Parse(Console.ReadLine());

            Console.Write("ingrese el estrato  del estudiante:");
            int estrato = int.Parse(Console.ReadLine());
            Console.WriteLine();

         Estudiantes estudiantes = new Estudiantes();
            
            estudiantes.Nombre   =  nombre;
            estudiantes.Creditos =  creditos;
            estudiantes.Estrato  =  estrato;
            estudiantes.presentar();

         Valores valores = new Valores();

            double descuneto = valores.descuentos(estudiantes);
            double costo     = valores.creditos(estudiantes);
            int subsidio     = valores.subsidios(estudiantes);
            
            Console.WriteLine($"El costo de la matricula es de: ${costo:N0} pesos");
            Console.WriteLine($"el valor del subsidio por alimentacion y transporte es de: ${subsidio:N0} pesos");
            Console.WriteLine();

            Console.WriteLine("desea calcular la matricula de otro estudiante? (SI/NO)");
            respuesta = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (respuesta != "si")
            {
                 Console.WriteLine("PROGRAMA FINALIZADO!");
                continuar = false;
            }
        }
        while (continuar);
    }
}