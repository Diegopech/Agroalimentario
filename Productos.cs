using System;
using System.Collections.Generic;
using System.Text;

namespace Agroalimentaria
{
    public class Productos
    {

        public string Numerolote { get; set; }
        public string FechaDeCaducidad { get; set; }

        public override string ToString()
        {
            return $"Numero de Lote: { Numerolote}, Fecha: { FechaDeCaducidad}";
          
        }

    }
  

    }
