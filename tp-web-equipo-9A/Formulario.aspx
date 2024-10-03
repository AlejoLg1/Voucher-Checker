<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="tp_web_equipo_9A.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row justify-content-center mt-5">
        <div class="col-md-6">
            <h1 class="text-center">Ingrese sus datos</h1>

            <!-- Fila para DNI -->
            <div class="mb-3">
                <label for="txtDni" class="form-label">DNI</label>
                <asp:TextBox ID="txtDni" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtDni_TextChanged" placeholder="00000000" runat="server"></asp:TextBox>
            </div>

            <!-- Fila para Nombre, Apellido y Email -->
            <div class="row mb-3">
                <div class="col">
                    <label for="txtNombre" class="form-label">Nombre</label>
                    <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Ingrese su nombre" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <label for="txtApellido" class="form-label">Apellido</label>
                    <asp:TextBox ID="txtApellido" CssClass="form-control" placeholder="Ingrese su apellido" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <label for="txtEmail" class="form-label">Email</label>
                    <asp:TextBox ID="txtEmail" CssClass="form-control" placeholder="email@email.com" type="email" runat="server"></asp:TextBox>
                </div>
            </div>

            <!-- Fila para Dirección, Ciudad y CP -->
            <div class="row mb-3">
                <div class="col">
                    <label for="txtDireccion" class="form-label">Dirección</label>
                    <asp:TextBox ID="txtDireccion" CssClass="form-control" placeholder="Calle 111" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <label for="txtCiudad" class="form-label">Ciudad</label>
                    <asp:TextBox ID="txtCiudad" CssClass="form-control" placeholder="Ingrese su ciudad" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <label for="txtCp" class="form-label">CP</label>
                    <asp:TextBox ID="txtCp" CssClass="form-control" placeholder="Codigo postal" runat="server"></asp:TextBox>
                </div>
            </div>

            <!-- Checkbox de Términos -->
            <div class="form-check">
                <asp:CheckBox ID="cboxTerminos" runat="server" CssClass="form-check-input" />
                <label class="form-check-label" for="cboxTerminos">Acepto los términos y condiciones.</label>
            </div>

            <!-- Botón de Participar -->
            <asp:Button ID="btnParticipar" CssClass="btn btn-primary btn-block" OnClick="btnParticipar_Click" runat="server" Text="Participar" />

            <asp:Label ID="lblError" runat="server" ForeColor="Red" />

        </div>
    </div>

</asp:Content>
