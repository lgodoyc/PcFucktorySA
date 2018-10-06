<%@ Page Title="" Language="C#" MasterPageFile="~/Master01.master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="PCFuctory.web.Inventario.Region.Crear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="section">
        <div class="container">
            <div class="heading">
                <h1 class="title">Regiones</h1>
                <h2 class="subtitle">Mantenedor de Regiones</h2>
            </div>
        </div>
    </section>
    <table class="table is-narrow is-striped">
        <thead>
            <tr>
                <th>
                    <label class="label">Region_ID</label>
                    <asp:TextBox ID="txtID" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                </th>
                <th>
                    <label class="label">Nombre</label>
                    <asp:TextBox ID="txtNombre" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                </th>
            </tr>

        </thead>
    </table>
    <div>
        <asp:Button ID="btnGuardar" runat="server" CssClass="button is-success is-left" ClientIDMode="Static" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>