<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionarPrestamos.aspx.cs" Inherits="PrestamosDUNAMIS.Vistas.GestionarPrestamos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Registrar Préstamo</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <header>
        <nav class="navbar p-4" style="background-color: #42ab49;">
            <div class="container-fluid d-flex justify-content-center">
                <a class="navbar-brand text-white">
                    <span class="h1">DUNAMIS S.A.</span>
                </a>
            </div>
        </nav>
    </header>
    <div class="container mt-5">
        <div class="card p-4">
            <h3 class="text-center mb-4">Registrar Préstamo</h3>
            <form id="form1" runat="server">
                <div class="mb-3">
                    <label for="ddlEmpleado" class="form-label">Empleado:</label>
                    <asp:DropDownList ID="ddlEmpleado" runat="server" CssClass="form-select"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="txtMonto" class="form-label">Monto:</label>
                    <asp:TextBox ID="txtMonto" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtPlazos" class="form-label">Plazos:</label>
                    <asp:TextBox ID="txtPlazos" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="d-flex justify-content-between">
                    <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-success" Text="Registrar" OnClick="btnRegistrar_Click" />
                    <asp:Button ID="btnLimpiar" runat="server" CssClass="btn btn-secondary" Text="Limpiar" OnClick="btnLimpiar_Click" />
                </div>
            </form>
        </div>
    </div>
    <footer class="text-center mt-5">
        <p>&copy; 2024 DUNAMIS S.A. Todos los derechos reservados</p>
    </footer>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
