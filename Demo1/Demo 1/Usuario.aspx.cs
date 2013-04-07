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

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                BL.BL_Usuario obj_BL_Usuario = new BL_Usuario();

                DateTime fec = new DateTime(int.Parse(txtAnio.Text), int.Parse(ddlMes.SelectedItem.Value), int.Parse(ddlDia.SelectedItem.Text));


                Boolean resutlado = obj_BL_Usuario.insertarUsuario(txtUsuario.Text, txtContrasenia.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, fec);

                if (resutlado)
                {
                    divResgitroExitoso.Visible = true;
                    divRegistro.Visible = false;

                    txtAnio.Text = string.Empty;

                    txtUsuario.Text = string.Empty;
                    txtContrasenia.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                    txtApellidos.Text = string.Empty;
                    txtDireccion.Text = string.Empty;
                    lblError.Visible = false;
                }
            }
            catch (Exception ex)
            {
                if(ex.Message.Equals("SqlDateTime overflow. Must be between 1/1/1753 12:00:00 AM and 12/31/9999 11:59:59 PM."))

                {
                    lblError.Visible=true;
                }
            }
                

        }

        protected void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
            divResgitroExitoso.Visible = false;
            divRegistro.Visible = true;

            txtAnio.Text = string.Empty;

            txtUsuario.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            lblError.Visible = false;

        }
    }
}