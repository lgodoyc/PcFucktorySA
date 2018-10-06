<%@ Page Title="" Language="C#" MasterPageFile="~/Master01.master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="PCFuctory.web.Inventario.Articulo.Crear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="section">
        <div class="container">
            <div class="heading">
                <h1 class="title">Creación artículo</h1>
                <h2 class="subtitle">Mantenedor de artículos</h2>
            </div>
        </div>
        <hr />
    </section>
    <table class="table">
        <thead>
            <tr>
                <th>
                    <label class="label">Artículo ID</label>
                    <asp:TextBox ID="txtArticuloID" ClientIDMode="Static" runat="server" CssClass="control input"></asp:TextBox>
                </th>
                <th>
                    <label class="label">Descripción</label>
                    <asp:TextBox ID="txtDescripcion" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                </th>
                <th>
                    <label class="label">Seleccione Categoria</label>
                    <asp:DropDownList ID="ddlArticulo" runat="server" CssClass="select">
                        <asp:ListItem Value="" Text="Seleccione..."></asp:ListItem>
                    </asp:DropDownList>
                </th>
            </tr>
        </thead>
    </table>
    <table class="table">
        <thead>
            <tr>
                <th>
                    <label class="label">Stock Mínimo</label>
                    <asp:TextBox ID="txtMinimo" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                </th>
                <th>
                    <label class="label">Stock Máximo</label>
                    <asp:TextBox ID="txtMaximo" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                </th>
                <th>
                    <label class="label">Stock Crítico</label>
                    <asp:TextBox ID="txtCritico" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                </th>
            </tr>
        </thead>
    </table>
    <div>
        <asp:Button ID="btnGuardar" runat="server" CssClass="button is-success is-left" ClientIDMode="Static" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>
