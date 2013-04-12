using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using System.Data.Entity;
namespace Demo_1
{
    public partial class Lista_Usuario : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            BL_Usuario usu = new BL_Usuario();
            List<BE.Usuario> lis = new List<BE.Usuario>();
            lis = usu.listaUsuariosEF();
            GridView1.DataSource = lis;
            GridView1.DataBind();

        }

        protected void Boton_elimina_Click(object sender, EventArgs e)
        {
            /*GridViewRow usuario = GridView1.SelectedRow;
            
           BE.DS_Demo1.UsuarioRow usuario=  GridView1.SelectedRow.DataItem();
           BL_Usuario usu = new BL_Usuario();
           usu.eliminaUsuario(usuario.usuarioColumn.ToString(), usuario.passwordColumn.ToString(), usuario.nombreColumn.ToString(),
                            usuario.apellidosColumn.ToString(), usuario.direccionColumn.ToString(), DateTime.Parse( usuario.fecha_nacimientoColumn.ToString()),
                            int.Parse( usuario.codColumn.ToString()));
             * */
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("cmdEditar"))
            {
                Session.Add("usuario", e.CommandArgument.ToString());
                Session.Add("accion", "editar");
                Response.Redirect("Usuario.aspx");
               
            }

            if (e.CommandName.Equals("cmdEliminar"))
            {

                BL.BL_Usuario obj_BL_Usuario = new BL_Usuario();
                obj_BL_Usuario.eliminaUsuario(e.CommandArgument.ToString());
               // Response.Redirect("Lista_Usuario.aspx");

            }
        }
    }
}