using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using System.Data.Entity;
namespace DAO
{
    public class DAO_UsuarioEF
    {
        
        
        public void insertarUsuario(Usuario objUsuario)
        {
            try
            {

                var context = new entities();
                context.Usuario.AddObject(objUsuario);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<BE.Usuario> listaUsuario()
        {
            List<Usuario> lis=new List<Usuario>();
            var context = new entities();
            var query= from c in context.Usuario select c;
            lis = context.Usuario.ToList();
            return lis;

        }
        //public int eliminausu(string usuario, string contrasenia, string nombre, string apellidos, string direccion, DateTime fecha_nac, int codigo)
        //{
        //    return adapter.Delete(usuario, contrasenia, nombre, apellidos, codigo, direccion, fecha_nac);
        //}
           
    }
}
