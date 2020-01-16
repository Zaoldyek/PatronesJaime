using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            EnviadorCorreos enviadorCorreos = new EnviadorCorreos();
            repository.suscribirse(enviadorCorreos);

            AlojadorCodigo alojadorCodigo = new AlojadorCodigo();
            repository.suscribirse(alojadorCodigo);
            repository.alojar("");
            Console.ReadLine();
        }
    }
}
