<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tp_web_equipo_9A.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title text-center">Ingresa tu código de voucher</h5>
                        <form id="voucherForm">
                            <div class="mb-3">
                                <label for="voucherCode" class="form-label">Código de Voucher</label>
                                <input type="text" class="form-control" id="voucherCode" placeholder="Ejemplo: Codigo00" required>
                            </div>
                            <button type="submit" class="btn btn-primary w-100" style="background-color: #28a745;" OnClick="btnValidarVoucher_Click">Validar Voucher</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
