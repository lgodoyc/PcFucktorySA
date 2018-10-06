<%@ Page Title="" Language="C#" MasterPageFile="~/MasterLogin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PCFuctory.web.Login.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section class="hero is-info">
        <div class="hero-body">
            <div class="container">
                <h1 class="title">Bienvenido a PCFucktory</h1>
                <h2 class="subtitle">Para continuar debe ingresar su usuario y contraseña</h2>
            </div>
        </div>
    </section>
    <div class="container">
        <div class="column"></div>
        <div class="column"></div>
        <div class="column"></div>
        <div class="column"></div>
        <div class="column"></div>
        <div class="column"></div>
        <div class="column"></div>
        <div class="column"></div>
            <div class="column is-half is-offset-one-quarter">
                <p class="control has-icon has-text-centered">
                    <span class="tag is-dark">Usuario</span>
                    <asp:TextBox ID="txtUsuario" ClientIDMode="Static" runat="server" CssClass="input is-success is-large"></asp:TextBox>
                </p>
            </div>
            <div class="column is-half is-offset-one-quarter">
                <p class="control has-icon">
                    <span class="tag is-dark">Contraseña</span>
                    <asp:TextBox ID="txtContraseña" ClientIDMode="Static" runat="server" TextMode="Password" CssClass="input is-primary is-large"></asp:TextBox>
                </p>
            </div>
            <div class="column is-half is-offset-one-quarter">
                <p class="control">
                    <asp:Button ID="btnIngresar" ClientIDMode="Static" runat="server" Text="Ingresar" CssClass="button is-info is-large" OnClick="btnIngresar_Click"/>
                    <asp:Label id="lblError" ClientIDMode="Static" runat="server" CssClass="help is-danger"></asp:Label>
                </p>
            </div>
    </div>
</asp:Content>
