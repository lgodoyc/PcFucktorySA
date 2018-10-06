<%@ Page Title="" Language="C#" MasterPageFile="~/Master01.master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="PCFuctory.web.Inventario.Ubicacion.Crear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="section">
        <div class="container">
            <div class="heading">
                <h1 class="title">Crear Ubicación
                </h1>
                <h2 class="subtitle">Mantenedor de Ubicaciónes
                </h2>
            </div>
        </div>
    </section>
    <div id="inContent">
        <div>
            <table class="table is-striped is-narrow">
                <thead>
                    <tr>
                        <th>
                            <label class="label">Nombre</label>
                            <asp:TextBox ID="txtNombreUbicacion" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                        </th>
                        <th>
                             <label class="label">Seleccione Comuna</label>
                             <asp:DropDownList ID="ddlComuna" runat="server" CssClass="select">
                             <asp:ListItem Value="" Text="Seleccione..."></asp:ListItem>
                             </asp:DropDownList>
                        </th>
                        <th>
                            <label class="label">Ubicación ID</label>
                            <asp:TextBox ID="txtUbicacionID" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                        </th>
                    </tr>
                </thead>
            </table>
            <table class="table is-striped is-narrow">
                <thead>
                    <tr>
                        <th>
                            <label class="label">Dirección</label>
                            <asp:TextBox ID="txtDireccion" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                        </th>
                        <th>
                            <label class="label">Numero</label>
                            <asp:TextBox ID="txtNumero" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                        </th>
                        <th>
                            <label class="label">Torre/Block</label>
                            <asp:TextBox ID="txtTorreBlock" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                        </th>
                        <th>
                            <label class="label">Depto.</label>
                            <asp:TextBox ID="txtDepto" ClientIDMode="Static" runat="server" CssClass="input"></asp:TextBox>
                        </th>
                    </tr>
                </thead>
            </table>
            <asp:Button ID="btnGuardar" runat="server" CssClass="button is-success is-left" ClientIDMode="Static" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
</asp:Content>
