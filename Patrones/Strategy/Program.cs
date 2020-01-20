using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string cNombre = "";
            Context context = new Context();
            while (cNombre == "") {
                Console.WriteLine("Ingrese el nombre de su imagen");
                cNombre = Console.ReadLine();
            }
            while (context != null) {
                Console.Write("1º) PNG " + "\n" + "2º) JPEG " + "\n" + "3º) BMP " + "\n" + "4º) Salir del Prograna \n ");
                Console.Write("Seleccione una opción: \n");

                switch (Console.Read())
                {
                    case '1':
                        PNGStrategy PNG = new PNGStrategy();
                        context.setStrategy(PNG);
                        context.doSomething(cNombre);
                        break;
                    case '2':
                        JPEGStrategy JPEG = new JPEGStrategy();
                        context.setStrategy(JPEG);
                        context.doSomething(cNombre);
                        break;
                    case '3':
                        BMPtrategy BMP = new BMPtrategy();
                        context.setStrategy(BMP);
                        context.doSomething(cNombre);
                        break;
                    case '4':
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("No es una opcion valida");
                        Console.ReadLine();
                        break;
                }
            }

        }
    }


   

  
    

  
}
