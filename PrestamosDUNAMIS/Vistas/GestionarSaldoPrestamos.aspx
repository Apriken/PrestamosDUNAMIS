<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionarSaldoPrestamos.aspx.cs" Inherits="PrestamosDUNAMIS.Vistas.GestionarSaldoPrestamos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Gestionar Saldo de Préstamos</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

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
            margin-top: 10px;
            margin-bottom: 20px;
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

        <!-- Header -->
        <header>
            <nav class="navbar p-4">
                <div class="container-fluid d-flex justify-content-center">
                    <a class="navbar-brand text-white">
                        <span class="h1">DUNAMIS S.A.</span>
                    </a>
                </div>
                <a class="btn btn-light" style="position: absolute; right: 20px;" href="PaginaPrincipal.aspx">
    Volver al menú principal
</a>

            </nav>
        </header>

        <!-- Main Content -->
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

            <!-- Pagos Realizados Table -->
            <hr />
            <h2 class="text-center mb-4">Pagos Realizados</h2>
            <asp:GridView 
                ID="gvPagos" 
                runat="server" 
                CssClass="table table-bordered mt-4" 
                AutoGenerateColumns="False" 
                DataKeyNames="idPago_Prestamo" 
                OnRowEditing="gvPagos_RowEditing" 
                OnRowCancelingEdit="gvPagos_RowCancelingEdit" 
                OnRowDeleting="gvPagos_RowDeleting" 
                OnRowDataBound="gvPagos_RowDataBound"
                ShowFooter="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                     <asp:BoundField DataField="idPrestamo" HeaderText="ID Préstamo" SortExpression="idPrestamo" />
                    <asp:BoundField DataField="idPago_Prestamo" HeaderText="ID Pago" ReadOnly="True" />
                    <asp:BoundField DataField="Monto_Pago" HeaderText="Monto Pago" DataFormatString="{0:C}" />
                     <asp:BoundField DataField="Fecha_Pago" HeaderText="Fecha Pago" SortExpression="Fecha_Pago" />
                    <asp:BoundField DataField="Saldo_Pendiente" HeaderText="Saldo Pendiente" DataFormatString="{0:C}" />
                             <asp:TemplateField HeaderText="Pago Realizado">
            <ItemTemplate>
                <!-- Usar un Label para mostrar el texto -->
                <asp:Label ID="lblPagoRealizado" runat="server" Text='<%# Eval("Pago_Realizado") == "1" ? "Aprobado" : "Pendiente" %>' />
            </ItemTemplate>
        </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </div>

        <!-- Footer -->
        <footer class="bg-light text-dark text-center py-3 mt-5 fixed-bottom bg-body-tertiary">
            <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
        </footer>

    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
