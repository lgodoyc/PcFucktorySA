<%@ Page Title="" Language="C#" MasterPageFile="~/Master01.master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="PCFuctory.web.Inventario.Comuna.Crear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="section">
        <div class="container">
            <div class="heading">
                <h1 class="title">Creación Comunas</h1>
                <h2 class="subtitle">Mantenedor de Comunas</h2>
            </div>
        </div>
        <hr />
    </section>
    <table class="table">
        <thead>
            <tr>
                <th>
                    <label class="label">Comuna ID</label>
                    <asp:TextBox ID="txtComunaID" ClientIDMode="Static" runat="server" CssClass="control input"></asp:TextBox>
                </th>
                <th>
                    <label class="label">Nombre</label>
                    <asp:TextBox ID="txtNombre" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                </th>
                <th>
                    <label class="label">Seleccione Region</label>
                    <asp:DropDownList ID="ddlComuna" runat="server" CssClass="select">
                        <asp:ListItem Value="" Text="Seleccione..."></asp:ListItem>
                    </asp:DropDownList>
                </th>
            </tr>
        </thead>
    </table>
    <div>
        <asp:Button ID="btnGuardar" runat="server" CssClass="button is-success is-left" ClientIDMode="Static" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>
