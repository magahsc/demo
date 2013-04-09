using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE.Properties;
using BE.DS_Demo1TableAdapters;
namespace DAO
{
    public class DAO_Usuario
    {
        private static UsuarioTableAdapter adapter = new UsuarioTableAdapter();

        public int insertarUsuario(string usuario,string contrasenia,string nombre,string apellidos,string direccion,DateTime fecha_nac)
        {
            int resutlado=adapter.Insert(usuario, contrasenia, nombre, apellidos, direccion, fecha_nac);
           
            return resutlado;
        }
        public BE.DS_Demo1.UsuarioDataTable listaUsuario()
        {
            return  adapter.GetData();
        }
        public int eliminausu(string usuario,string contrasenia,string nombre,string apellidos,string direccion,DateTime fecha_nac,int codigo) {
            return adapter.Delete(usuario,contrasenia,nombre,apellidos,codigo,direccion,fecha_nac);
        }
           
    }
}
