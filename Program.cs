using Domain;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeParcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* En nuestra empresa hemos guardado y recuperado las bitácoras de nuestros sistemas en bases de datos
               relacionales y de archivos durante años. Para ello un diseñador de antaño ha creado una interfaz llamada
               ILogger en la cual se han definidos los siguientes métodos: Store(Log) y GetAll() : List<Log>. Tenemos algunas
               clases concretas como SqlLogger y FileLogger que implementan dicha interfaz. (La clase Log tiene dos
               atributos: string message y enum Severity)
               Un nuevo cliente nos ha pedido que es sus desarrollos utilicemos una clase que ya posee para estos fines
               llamada Logger (Recibe en el constructor un parámetro de tipo enum: File o SQL y otro parámetro de tipo
               string con el path/connString), la misma posee los métodos Write (string) y ReadAll(): string[] (El parámetro
               string sería el equivalente a nuestro string message de la clase Log y el cliente no desea determinar severidades
               para sus bitácoras, ya que toda la gestión es manejada con cadenas formateadas para tal fin).
               A pesar de que utilizaremos su clase para guardar las bitácoras, queremos seguir utilizando la interfaz ILogger
               para no apartarnos de nuestro estándar. 
               

            Log --- string message, enum severity
            
             */


            ILogger logger = new LoggerAdapter(LoggerType.File, "connectionstring");

            Log log = new Log();
            log.message = "No se si esto funciona";
            log.severity = Log.Severity.strong;

            logger.Store(log);

           
            var logs = logger.GetAll();

            foreach(var item in logs)
            {
                Console.WriteLine("\nMensaje: " + item.message);
                Console.WriteLine("Severity: " + item.severity);

            }

            

            Console.ReadKey();

        }
    }
}
