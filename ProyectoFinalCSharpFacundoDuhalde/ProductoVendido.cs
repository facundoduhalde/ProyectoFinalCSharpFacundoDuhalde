using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCSharpFacundoDuhalde
{
    internal class ProductoVendido
    {
        //Id, IdProducto, Stock, IdVenta 
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }

        public ProductoVendido() 
        { 
        
        }    
    }
}
