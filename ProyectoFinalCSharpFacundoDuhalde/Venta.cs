using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCSharpFacundoDuhalde
{
    internal class Venta
    {
        // Id, Comentarios, IdUsuario
        private int Id { get; set; }
        private string Comentarios { get; set; }
        private int IdUsuario { get; set; }

        public Venta()
        {
            Comentarios = string.Empty; 

        }
    }
}
