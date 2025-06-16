using System;

namespace RegistroEstudiantes
{
    // Clase que representa a un estudiante
    class Estudiante
    {
        // Propiedades del estudiante
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; } // Array para almacenar 3 teléfonos

        // Constructor que recibe e inicializa los datos del estudiante
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos ?? new string[0]; // Validación en caso de null
        }

        // Método que imprime la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"\tTeléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un array con tres números de teléfono
            string[] telefonos = { "0989765872", "098756478", "0899857895" };

            // Instanciar un objeto Estudiante con datos de ejemplo
            Estudiante estudiante = new Estudiante(1, "Jonathan", "Cisneros", "Quito", telefonos);

            // Mostrar la información del estudiante
            estudiante.MostrarInformacion();

            // Esperar que el usuario presione una tecla para cerrar la consola
            Console.ReadLine();
        }
    }
}
