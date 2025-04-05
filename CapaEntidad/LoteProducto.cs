﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class LoteProducto
    {
        public int IdLote { get; set; }
        public int IdProducto { get; set; }
        public string NumeroLote { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Cantidad { get; set; }
    }
}
