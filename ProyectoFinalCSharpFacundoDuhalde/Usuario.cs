using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCSharpFacundoDuhalde
{
    internal class Usuario
    {
        //Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string NombreUsuario { get; set; }
        private string Contraseña { get; set; }
        private string Mail { get; set; }
        
        public Usuario() 
        {
            Nombre = string.Empty;
            Apellido = string.Empty;    
            NombreUsuario = string.Empty;
            Contraseña = string.Empty;  
            Mail = string.Empty; 
        }    
    }
}
