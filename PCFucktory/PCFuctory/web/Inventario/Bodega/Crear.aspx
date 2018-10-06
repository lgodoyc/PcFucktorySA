<%@ Page Title="" Language="C#" MasterPageFile="~/Master01.master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="PCFuctory.web.Inventario.Bodega.Crear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="section">
        <div class="container">
            <div class="heading">
                <h1 class="title">Crear Bodega
                </h1>
                <h2 class="subtitle">Mantenedor de Bodegas
                </h2>
            </div>
        </div>
        <hr />
    </section>
    <table class="table">
        <thead>
            <tr>
                <th>
                    <label class="label">Bodega ID</label>
                    <asp:TextBox ID="txtBodegaID" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                </th>
                <th>
                    <label class="label">Nombre</label>
                    <asp:TextBox ID="txtNombre" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                </th>
                <th>
                    <label class="label">Ubicación</label>
                    <asp:DropDownList ID="cboUbicacion" ClientIDMode="Static" runat="server" CssClass="select">
                        <asp:ListItem Value="" Text="Selecione..."></asp:ListItem>
                    </asp:DropDownList>
                </th>
            </tr>
        </thead>
    </table>
    <asp:Button ID="btnGuardar" runat="server" CssClass="button is-success is-left" ClientIDMode="Static" Text="Guardar" OnClick="btnGuardar_Click" />
</asp:Content>
