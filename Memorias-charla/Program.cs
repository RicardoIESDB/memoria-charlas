using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static List<(string termino, string definicion)> listTerminos = new List<(string, string)>();

    static void CargarTerminos()
    {
        listTerminos.Add(("CiberSeguridad", "El conjunto de tecnologías, procesos y prácticas diseñadas para proteger redes, sistemas y datos de ataques cibernéticos."));
        listTerminos.Add(("Datos", "Información que se procesa, almacena y transmite en sistemas computacionales."));
        listTerminos.Add(("Ciberataque", "Un ataque dirigido contra sistemas informáticos con el objetivo de robar, dañar o alterar información."));
        listTerminos.Add(("Redes", "Conjunto de dispositivos interconectados que se comunican entre sí para compartir recursos y datos."));
        listTerminos.Add(("AWS", "Amazon Web Services, una plataforma de servicios en la nube que ofrece una amplia gama de herramientas y servicios."));
        listTerminos.Add(("Google Cloud", "Una plataforma de servicios en la nube ofrecida por Google que proporciona servicios de almacenamiento, cómputo y análisis."));
        listTerminos.Add(("Imagen Personal", "La percepción que los demás tienen de una persona, basada en su apariencia, comportamiento y habilidades de comunicación."));
        listTerminos.Add(("Inteligencia Artificial", "La simulación de procesos de inteligencia humana por parte de máquinas, especialmente sistemas informáticos."));
        listTerminos.Add(("Programación", "El proceso de escribir, probar y mantener el código que instruye a las computadoras para realizar tareas específicas."));
        listTerminos.Add(("Big Data", "Conjunto de datos muy grandes y complejos que son difíciles de procesar con herramientas tradicionales de gestión de datos."));
        listTerminos.Add(("Firewall", "Un sistema de seguridad de red que monitorea y controla el tráfico de red basado en reglas de seguridad predefinidas."));
        listTerminos.Add(("Dark Web", "La parte de Internet que no es indexada por motores de búsqueda y que requiere software especial para acceder a ella."));
        listTerminos.Add(("Pentesting", "La práctica de evaluar la seguridad de un sistema informático al simular ataques cibernéticos."));
        listTerminos.Add(("Algoritmo", "Un conjunto de instrucciones bien definidas y finitas que se utilizan para resolver un problema o realizar una tarea específica."));
        listTerminos.Add(("Automatización", "El uso de tecnologías para realizar tareas sin intervención humana directa."));
        listTerminos.Add(("Desarrollo", "El proceso de crear, diseñar, implementar y mantener software o sistemas."));
        listTerminos.Add(("Marketing", "El conjunto de actividades que se realizan para promover y vender productos o servicios."));
        listTerminos.Add(("Windows Server", "Una línea de sistemas operativos de servidor desarrollados por Microsoft para entornos empresariales."));
        listTerminos.Add(("Máquina Virtual", "Un entorno de software que emula un sistema informático real y que puede ejecutar aplicaciones y sistemas operativos."));
        listTerminos.Add(("Perseverancia", "La capacidad de persistir en la realización de una tarea o meta a pesar de los obstáculos y dificultades."));
    }

    static void AniadirTermino()
    {
        Console.Write("Nuevo término: ");
        string nuevoTermino = Console.ReadLine() ?? "";

        Console.Write("Definición: ");
        string nuevaDefinicion = Console.ReadLine() ?? "";

        listTerminos.Add((nuevoTermino, nuevaDefinicion));
    }


    static void MostrarTerminos()
    {
        if (listTerminos.Count == 0)
            Console.WriteLine("No hay términos para mostrar.\n");
        else
        {
            Console.WriteLine("Lista de términos:\n");
            foreach (var termino in listTerminos)
                Console.WriteLine($"- Término: {termino.termino}, \n Definición: {termino.definicion}\n");
        }
    }

    static void GuardarTerminos()
    {
        File.WriteAllLines("terminos.txt", listTerminos.Select(t => $"{t.termino}|{t.definicion}"));
        Console.WriteLine("Términos guardados correctamente en 'terminos.txt'.\n");
    }

    static void Menu()
    {
        bool salir = true;
        while (salir)
        {
            Console.WriteLine("""
            ----- MENÚ -----
            1. Mostrar términos
            2. Añadir término
            2. Guardar términos en un archivo .txt
            Selecciona una opción: 
            """);
            string opcion = Console.ReadLine()?.Trim() ?? "";
            CargarTerminos();

            switch (opcion)
            {
                case "1":
                    MostrarTerminos();
                    break;
                case "2":
                    AniadirTermino();
                    break;
                case "3":
                    GuardarTerminos();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.\n");
                    break;
            }
            Console.WriteLine("Desea continuar: 'S' = si | Cualquier letra = no");
            char continuar = Char.Parse(Console.ReadLine()?.ToUpper() ?? "N");
            salir = continuar == 'S';
        }
    }

    public static void Main()
    {
        Menu();
    }
}