<%@ Page Title="" Language="C#" MasterPageFile="~/masterTransfer.master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="PCFuctory.web.Transferencias.Crear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="columns">
            <div class="column is-2">
                <label class="label">Articulo</label>
                <asp:DropDownList ID="ddArticulo" runat="server" CssClass="select">
                    <asp:ListItem Value="" Text="Seleccione"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="column is-2">
                <label class="label">Cantidad</label>
                <asp:TextBox ID="txtCantidad" runat="server" CssClass="input is-black"></asp:TextBox>
            </div>
            <div class="column is-one-third">
                <label class="label">Descripcion</label>
                <asp:Label ID="lblDescripcion" runat="server" Text="aca va la descripcion" CssClass="label"></asp:Label>
            </div>
        </div>
        <div class="columns"></div>
        <div class="columns">
            <div class="column is-2">
                <label class="label">Bodega entrada</label>
                <asp:DropDownList ID="ddBodegaEntrada" runat="server" CssClass="select">
                    <asp:ListItem Value="" Text="Seleccione"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="column is-2">
                <label class="label">Bodega salida</label>
                <asp:DropDownList ID="ddBodegaSalida" runat="server" CssClass="select">
                    <asp:ListItem Value="" Text="Seleccione"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="column">
            <asp:Button ID="btnAgregarTransaccion" runat="server" Text="Agregar" CssClass="button is-info" />
        </div>
        <div class="column">
            <asp:Table ID="Table1" runat="server" CssClass="table is-bordered is-striped is-narrow">
                <asp:TableRow TableSection="TableHeader" CssClass="table">
                    <asp:TableCell>ID</asp:TableCell>
                    <asp:TableCell>Cantidad</asp:TableCell>
                    <asp:TableCell>Bodega IN</asp:TableCell>
                    <asp:TableCell>Bodega OUT</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </div>
</asp:Content>
