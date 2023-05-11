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
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }

        public Venta()
        {
            Comentarios = string.Empty; 

        }
    }
}
