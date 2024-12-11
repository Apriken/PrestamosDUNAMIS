<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionarSaldoPrestamos.aspx.cs" Inherits="PrestamosDUNAMIS.Vistas.GestionarSaldoPrestamos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Gestionar Saldo de Préstamos</title>

    <style>
        :root {
            --verde-oscuro: #42ab49;
            --text-color: #2F4F4F;
        }

        header {
            height: 100px;
            background-color: var(--verde-oscuro);
            margin-bottom: 20px;
        }

        .title {
            color: var(--verde-oscuro);
            text-align: center;
            font-weight: bold;
            margin-top: 20px;
            margin-bottom: 30px;
        }

        .buttons-container {
            text-align: center;
            margin-top: 30px;
            margin-bottom: 30px;
        }

        .btn-custom {
            background-color: #c7f1c2;
            color: var(--text-color);
            border: 1px solid #42ab49;
            font-weight: bold;
            transition: background-color 0.3s ease;
        }

        .btn-custom:hover {
            background-color: #b2e5ae;
            color: var(--text-color);
        }

        .form-container {
            margin-top: 30px;
            margin-bottom: 30px;
        }

        footer {
            flex-shrink: 0;
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <nav class="navbar p-4">
                <div class="container-fluid d-flex justify-content-center">
                    <a class="navbar-brand text-white">
                        <span class="h1">DUNAMIS S.A.</span>
                    </a>
                </div>
            </nav>
        </header>

        <div class="container">
            <h1 class="title">Gestionar Saldo de Préstamos</h1>
            
            <asp:Label ID="lblMessage" runat="server" CssClass="text-success"></asp:Label>

            <div class="form-container">
                <div class="mb-3">
                    <label for="txtMonto" class="form-label">Monto</label>
                    <asp:TextBox ID="txtMonto" runat="server" CssClass="form-control" />
                </div>

                <div class="mb-3">
                    <label for="txtFechaPago" class="form-label">Fecha de Pago</label>
                    <asp:TextBox ID="txtFechaPago" runat="server" CssClass="form-control" TextMode="Date" />
                </div>

                <div class="mb-3">
                    <label for="ddlPrestamo" class="form-label">Préstamo</label>
                    <asp:DropDownList ID="ddlPrestamo" runat="server" CssClass="form-select"></asp:DropDownList>
                </div>

                <div class="mb-3">
                    <label for="txtSaldoPendiente" class="form-label">Saldo Pendiente</label>
                    <asp:TextBox ID="txtSaldoPendiente" runat="server" CssClass="form-control" />
                </div>

                <div class="mb-3">
                    <label for="chkPagoRealizado" class="form-label">Pago Realizado</label>
                    <asp:CheckBox ID="chkPagoRealizado" runat="server" CssClass="form-check-input" />
                </div>

                <div class="buttons-container">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success btn-custom" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-secondary btn-custom" OnClick="btnLimpiar_Click" />
                </div>
            </div>

            <!-- GridView -->
            <hr />
            <h2 class="text-center mb-4">Pagos Realizados</h2>

            <asp:GridView ID="gvPagos" runat="server" CssClass="table table-bordered mt-4" AutoGenerateColumns="False" DataKeyNames="idPago_Prestamo" OnRowEditing="gvPagos_RowEditing" OnRowCancelingEdit="gvPagos_RowCancelingEdit" OnRowDeleting="gvPagos_RowDeleting" OnDataBound="gvPagos_DataBound">
                <Columns>
                    <asp:BoundField DataField="idPago_Prestamo" HeaderText="ID Pago" ReadOnly="True" />
                    <asp:BoundField DataField="Monto_Pago" HeaderText="Monto Pago" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Saldo_Pendiente" HeaderText="Saldo Pendiente" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Abono" HeaderText="Abono" DataFormatString="{0:C}" />
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="#f2f2f2" Font-Bold="True" />
                <FooterTemplate>
                    <asp:Label ID="lblTotalSaldo" runat="server" Text="₡0.00" />
                </FooterTemplate>
            </asp:GridView>
        </div>

        <footer class="bg-light text-dark text-center py-3 mt-5 fixed-bottom bg-body-tertiary">
            <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
        </footer>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
