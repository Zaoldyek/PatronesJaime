using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        Strategy strategy { get; set; }

        public void setStrategy(Strategy _strategy)
        {
            strategy = _strategy;
        }

        public void doSomething(string cTitulo)
        {
            strategy.Ejecutar(cTitulo);
            Console.ReadLine();
        }
    }
}
