namespace ProyectoFinalCSharpFacundoDuhalde
{
    public class Producto
    {
        //Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario
        private int Id { get; set; }
        private string Descripcion { get; set; }
        private double Costo { get; set; }
        private double PrecioVenta { get; set; }
        private int Stock { get; set; }
        private int IdUsuario { get; set; }

        public Producto() 
        { 
            Descripcion = string.Empty;  
        }
    }
}