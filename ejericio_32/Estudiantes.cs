using System;
using System.Collections.Generic;

namespace ejericio_32
{
    public class Estudiantes
    {
        //defino mis propiedades
        public string Nombre   { get; set; }
        public int    Estrato  { get; set; }
        public int    Creditos { get; set; }

        // defino metodo
        public void presentar()
        {
            Console.WriteLine($"Nombre:   {Nombre}");
            Console.WriteLine($"Estrato:  {Estrato}");
            Console.WriteLine($"Creditos: {Creditos}");
            Console.WriteLine();
        }
    }
}
