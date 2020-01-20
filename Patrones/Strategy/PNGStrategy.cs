﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PNGStrategy : Strategy
    {
        public void Ejecutar(string cTitulo)
        {
            Console.WriteLine($"Se ha guardado la imagen {cTitulo}.PNG");
        }
    }
}
