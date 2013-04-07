<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Demo_1.Usuario" %>

<asp:Content ID="BodyContentasdas" runat="server" ContentPlaceHolderID="MainContent">
   
    
   <div id="divRegistro" runat="server">
    <table runat="server">
        <tbody>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" Width="130px"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtApellidos" runat="server" Width="130px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server" Width="130px"></asp:TextBox>
                </td>
            </tr>


            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtContrasenia" runat="server" TextMode=Password Width="130px"></asp:TextBox>
                </td>
            </tr>


            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Direccion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server" Width="130px"></asp:TextBox>
                </td>
            </tr>


            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Fecha de Nacimiento"></asp:Label>
                </td>
                <td>
                     <asp:DropDownList ID="ddlDia" runat="server">
                        <asp:ListItem Text="1"></asp:ListItem>
                        <asp:ListItem Text="2"></asp:ListItem>
                        <asp:ListItem Text="3"></asp:ListItem>
                        <asp:ListItem Text="4"></asp:ListItem>
                        <asp:ListItem Text="5"></asp:ListItem>
                        <asp:ListItem Text="6"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlMes" runat="server">
                        <asp:ListItem Text="Enero" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Febrero" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Marzo" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Abril" Value="4"></asp:ListItem>
                        <asp:ListItem Text="Mayo" Value="5"></asp:ListItem>
                        <asp:ListItem Text="Junio" Value="6"></asp:ListItem>
                    </asp:DropDownList>

                    <asp:TextBox ID="txtAnio" runat="server" Width="30px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="regexpName" runat="server"     
                                    ErrorMessage="Solo nùmeros." 
                                    ControlToValidate="txtAnio"     
                                    ValidationExpression="[0-9]*" />


                </td>

            </tr>
            
             <tr>
                    <td>
                    <asp:Label ID="lblError" runat="server" Text="Año de nacimiento no valido" Visible=false ForeColor=Red></asp:Label>

                    </td>
                </tr>
         
   
            <tr>
                <td colspan="2" align=right> 
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrarse" 
                        onclick="btnRegistrar_Click" />
                </td>
            </tr>
        </tbody>
    </table>
    </div>

    <div id="divResgitroExitoso" runat="server" visible=false>
        <asp:Label ID="Label7" runat="server" Text="Se registro correctamente el usuario"></asp:Label>
        <asp:Button ID="btnRegistrarNuevo" runat="server" Text="Registrar mas" onclick="btnRegistrarNuevo_Click" 
                         />
    </div>
</asp:Content>