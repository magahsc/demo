<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Lista_Usuario.aspx.cs" Inherits="Demo_1.Lista_Usuario" %>

<asp:Content ID="BodyContentasdas" runat="server" ContentPlaceHolderID="MainContent">
   
    
   <div id="divRegistro" runat="server">
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" 
           onrowcommand="GridView1_RowCommand" 
           onselectedindexchanged="GridView1_SelectedIndexChanged" >
        <Columns>
            <asp:BoundField DataField="usuario" HeaderText="Usuario" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Center"/>
            <asp:BoundField DataField="password" HeaderText="Password" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Center"/>
            <asp:BoundField DataField="nombre" HeaderText="Nombre" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Center"/>
            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Center"/>
            <asp:BoundField DataField="direccion" HeaderText="Direccion" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Center"/>
            <asp:BoundField DataField="fecha_nacimiento" HeaderText="Fecha nacimiento" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Center"/>
            
            <asp:TemplateField HeaderText="Editar" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkEditar" runat="server" CommandName="cmdEditar" CommandArgument='<%# Eval("usuario") %>'>
                            <img src="img/icoEditar.png" width="16" height="16" alt="Editar" border="0" />
                        </asp:LinkButton>
                      </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Eliminar" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:LinkButton ID="Button1" runat="server" Text="X"  CommandName="cmdEliminar" CommandArgument='<%# Eval("usuario") %>'></asp:LinkButton>
                       
                      </ItemTemplate>
            </asp:TemplateField>
        </Columns>
       </asp:GridView>
       
    </div>

    </asp:Content>