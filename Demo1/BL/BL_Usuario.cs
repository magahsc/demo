using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using BE;
using BE.DS_Demo1TableAdapters;

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
        public BE.DS_Demo1.UsuarioDataTable listaUsuarios()
        {
            DAO_Usuario obj_DAO_Usuario = new DAO_Usuario();

            return obj_DAO_Usuario.listaUsuario();
                       
        }
        /*public Boolean eliminaUsuario(string usuario, string password, string nombre, string apellidos, string direccion, DateTime fecha_nac, int codigo)
        {
            DAO_Usuario obj_DAO_Usuario = new DAO_Usuario();


            int resultado = obj_DAO_Usuario.eliminausu(usuario, password, nombre, apellidos, direccion, fecha_nac,codigo);
            if (resultado == 1)
                return true;
            return false;

        }*/

        public void eliminaUsuario(string usuario)
        {
            adapter.eliminar_usuario(usuario);
        }

        private static UsuarioTableAdapter adapter = new UsuarioTableAdapter();

        public BE.DS_Demo1.UsuarioDataTable get_Usuario(string usuario)
        {

            return adapter.get_Usuario(usuario);

        }

        public void editar_Usuario(string usuarioAntig,string usuario, string password, string nombre, string apellidos, string direccion, DateTime fecha_nac)
        {
            int cod=(int)adapter.get_cod_Usuario(usuarioAntig);
            adapter.actualizar_usuario(usuario, password, nombre, apellidos, direccion, fecha_nac, cod);
            
            

        }
    }
}
