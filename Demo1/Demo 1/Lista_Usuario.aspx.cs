using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
namespace Demo_1
{
    public partial class Usuario : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            BL_Usuario usu = new BL_Usuario();
            GridView1.DataSource = usu.listaUsuarios();
            GridView1.DataBind();

        }

        protected void Boton_elimina_Click(object sender, EventArgs e)
        {
           BE.DS_Demo1.UsuarioDataTable usuario=  GridView1.SelectedRow.DataItem();
           BL_Usuario usu = new BL_Usuario();
           usu.eliminaUsuario(usuario.usuarioColumn.ToString(), usuario.passwordColumn.ToString(), usuario.nombreColumn.ToString(),
                            usuario.apellidosColumn.ToString(), usuario.direccionColumn.ToString(), DateTime.Parse( usuario.fecha_nacimientoColumn.ToString()),
                            int.Parse( usuario.codColumn.ToString()));
        }
    }
}