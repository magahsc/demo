using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using BE;
namespace Demo_1
{
    public partial class Usuario : System.Web.UI.Page
    {

        BL_Usuario objBL_Usuario = new BL_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["accion"] != null)
                {
                    string accion = (string)Session["accion"];
                    if (accion.Equals("editar"))
                        btnRegistrar.Text = "Guardar";
                }
                if (Session["usuario"] == null)
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
                else
                {
                    string usuarioST = (string)Session["usuario"];
                    BE.DS_Demo1.UsuarioDataTable usuarioDT = new BE.DS_Demo1.UsuarioDataTable();
                    usuarioDT = objBL_Usuario.get_Usuario(usuarioST);
                    txtUsuario.Text = (string)usuarioDT.Rows[0].ItemArray[0];
                    txtContrasenia.Text = (string)usuarioDT.Rows[0].ItemArray[1];
                    txtNombre.Text = (string)usuarioDT.Rows[0].ItemArray[2];
                    txtApellidos.Text = (string)usuarioDT.Rows[0].ItemArray[3];
                    txtDireccion.Text = (string)usuarioDT.Rows[0].ItemArray[5];
                    DateTime dtfecha = (DateTime)usuarioDT.Rows[0].ItemArray[6];
                    ddlDia.SelectedIndex = ddlDia.Items.IndexOf(ddlDia.Items.FindByText(Convert.ToString(dtfecha.Day)));
                    ddlMes.SelectedIndex = ddlMes.Items.IndexOf(ddlMes.Items.FindByValue(Convert.ToString(dtfecha.Month)));
                    txtAnio.Text = Convert.ToString(dtfecha.Year);
                    
                }
            }



        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["accion"] != null)
                {
                    string accion = (string)Session["accion"];
                    if (accion.Equals("editar"))
                    {
                        string usuarioAntiguo = (string)Session["usuario"];

                        BL.BL_Usuario obj_BL_Usuario = new BL_Usuario();
                        DateTime fec = new DateTime(int.Parse(txtAnio.Text), int.Parse(ddlMes.SelectedItem.Value), int.Parse(ddlDia.SelectedItem.Text));

                        obj_BL_Usuario.editar_Usuario(usuarioAntiguo, txtUsuario.Text, txtContrasenia.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, fec);
                        Session.Clear();
                      //obj_BL_Usuario.editar_Usuario(usuarioAntiguo,txtUsuario.Text, txtContrasenia.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, fec);

                    }


                }
                else
                {

                    BL.BL_Usuario obj_BL_Usuario = new BL_Usuario();
                    DateTime fec = new DateTime(int.Parse(txtAnio.Text), int.Parse(ddlMes.SelectedItem.Value), int.Parse(ddlDia.SelectedItem.Text));


                    //Boolean resutlado = obj_BL_Usuario.insertarUsuario(txtUsuario.Text, txtContrasenia.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, fec);
                    Boolean resutlado = obj_BL_Usuario.insertarUsuarioEF(txtUsuario.Text, txtContrasenia.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, fec);

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