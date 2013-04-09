<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Lista_Usuario.aspx.cs" Inherits="Demo_1.Usuario" %>

<asp:Content ID="BodyContentasdas" runat="server" ContentPlaceHolderID="MainContent">
   
    
   <div id="divRegistro" runat="server">
       <asp:GridView ID="GridView1" runat="server" 
           onselectedindexchanged="GridView1_SelectedIndexChanged">
       </asp:GridView>
       <asp:Button ID="Boton_elimina" runat="server" onclick="Boton_elimina_Click" 
           Text="Seleccione para eliminar" />
    </div>

    </asp:Content>