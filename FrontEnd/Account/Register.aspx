<%@ Page Title="Registrarse" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Register.aspx.vb" Inherits="FrontEnd.Register" %>

<%@ Import Namespace="FrontEnd" %>
<%@ Import Namespace="Microsoft.AspNet.Identity" %>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <main aria-labelledby="title">
        <h2 id="title"><%:Title %>.</h2>
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div>
            <h4>Crear una nueva cuenta</h4>
            <hr />
            <asp:ValidationSummary runat="server" CssClass="text-danger" />
       <div class="row">
                <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 col-form-label">Correo electrónico</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                        CssClass="text-danger" ErrorMessage="El campo de correo electrónico es obligatorio." />
                </div>
            </div>
       <div class="row">
                <asp:Label runat="server" AssociatedControlID="Name" CssClass="col-md-2 col-form-label">Nombre Completo</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Name" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" controltoValidate="Name"
                        CssClass="Text-danger" ErrorMessage="El campo del Nombre Completo es obligatorio." />
                </div>
            </div>
       <div class="row">
           <asp:Label runat="server" AssociatedControlID="Phone" CssClass="col-md-2 col-form-label">Numero Telefonico</asp:Label>
           <div class="col-md-10">
               <asp:TextBox runat="server" ID="Phone" TextMode="Phone" CssClass="form-control" />
               <asp:RequiredFieldValidator runat="server" controltoValidate="Phone"
                   CssClass="Text-danger" ErrorMessage="El campo del Numero Telefonico es obligatorio." />
           </div>
       </div>
            <div class="row">
                <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 col-form-label">Contraseña</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                        CssClass="text-danger" ErrorMessage="El campo de contraseña es obligatorio." />
                </div>
            </div>
            <div class="row">
                <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 col-form-label">Confirmar contraseña</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                        CssClass="text-danger" Display="Dynamic" ErrorMessage="El campo de confirmación de contraseña es obligatorio." />
                    <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                        CssClass="text-danger" Display="Dynamic" ErrorMessage="La contraseñas no coinciden." />
                </div>
            </div>
            <div class="row">
                <div class="offset-md-2 col-md-10">
                    <asp:Button runat="server" OnClick="CreateUser_Click" Text="Registrarse" CssClass="btn btn-outline-dark" />
                </div>
            </div>
        </div>
    </main>
</asp:Content>
