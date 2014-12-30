using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ManejoSistemaArchivos
{
    /// <summary>
    /// Manejo del sistema de archivos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {     
            // Obtiene la ruta a la carpeta de documentos
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            // Crear archivo de prueba en documentos, solo si no existe previamente
            string ruta = Path.Combine(rutaDocumentos, "miarchivo.txt");
            if (File.Exists(ruta))
            {
                File.Create(ruta);
            }

            // Información sobre archivos clases File, FileInfo
            FileInfo fInfo = new FileInfo(ruta);
            Console.WriteLine("Nombre: {0}", fInfo.Name);
            Console.WriteLine("Extensión: {0}", fInfo.Extension);
            Console.WriteLine("Existe? {0}", fInfo.Exists);
            Console.WriteLine("Tamaño: {0} B", fInfo.Length);
            Console.WriteLine("Directorio contenedor: {0}", fInfo.Directory);
            Console.WriteLine("Fecha de creación: {0}", fInfo.CreationTime);

            // Información sobre directorios clases Directory, DirectoryInfo
            Console.WriteLine("\n\nInformación sobre la carpeta Mis Documentos");                                   
            DirectoryInfo dInfo = new DirectoryInfo(rutaDocumentos);
            Console.WriteLine("Ruta: {0}", dInfo.FullName);
            // Mostrar todos los archivos dentro de este directorio
            Console.WriteLine("\nArchivos");
            foreach (var file in dInfo.GetFiles())
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine("\nDirectorios");
            // Mostrar todos los subdirectorios dentro de este directorio
            foreach (var dir in dInfo.GetDirectories())
            {
                Console.WriteLine(dir.Name);
            }
        }
    }
}
