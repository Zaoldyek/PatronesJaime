using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    class Repository
    {
        List<Suscriptor> Suscriptores { get; set; }

        public Repository() {
            Suscriptores = new List<Suscriptor>();
        }

        public void suscribirse(Suscriptor suscriptor) {
            Suscriptores.Add(suscriptor);
        }
        public void alojar(string codigo)
        {
            Console.WriteLine("Se esta subiendo el código");
            notifySuscribers();
        }

        public void notifySuscribers()
        {
            for (int i = 0; i <= Suscriptores.Count-1; i++) {
               Suscriptores[i].actualizar();
            }
        }

    }
   

    public interface Suscriptor
    {
        void actualizar();
    }

    public class EnviadorCorreos : Suscriptor
    {
        public void actualizar()
        {
            Console.WriteLine("Correo Enviado");
        }
    }

    public class AlojadorCodigo : Suscriptor
    {
        public void actualizar()
        {
            Console.WriteLine("Codigo Alojado");
        }
    }
}
