using System;
using System.Collections.Generic;
using System.Text;

namespace Agroalimentaria
{
    class ProductosRefrigerados : Productos
    {
        public string CodigOrganismo { get; set; }

        public string FechaDeEnvasado { get; set; }

        public string TemperaturaRecomendada { get; set; }
        public string Pais { get; set; }



        public override string ToString()
        {
            return $"Numero de lote: {Numerolote}, Fecha de caducidad{FechaDeCaducidad},Codigo de organismo{CodigOrganismo}" +
                $" ,Fecha de evansado { FechaDeEnvasado} , Temperatura recomendada {TemperaturaRecomendada}, Pais: {Pais}";

        }
    }

}