<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Premio.aspx.cs" Inherits="tp_web_equipo_9A.Premio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row row-cols-1 row-cols-md-3 g-4">
         <asp:Repeater runat="server" id="Repetidor">
            <ItemTemplate>
                <div class="col">
                <div class="card">
                    <img src="<%#Eval("Imagen") %>" class="card-img-top img-style" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                        <p class="card-text"><%#Eval("Descripcion") %></p>
                    </div>
                </div>
            </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
