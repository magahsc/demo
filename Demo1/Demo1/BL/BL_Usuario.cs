using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BL
{
    public class BL_Usuario
    {
        

        public Boolean insertarUsuario(string usuario, string password, string nombre, string apellidos, string direccion, DateTime fecha_nac)
        {
            DAO_Usuario obj_DAO_Usuario = new DAO_Usuario();
          
            
            int resultado = obj_DAO_Usuario.insertarUsuario(usuario, password, nombre, apellidos, direccion, fecha_nac);
            if(resultado==1)
             return true;
            return false;

        }

            
    }
}
