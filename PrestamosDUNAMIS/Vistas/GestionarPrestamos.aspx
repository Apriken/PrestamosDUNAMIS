<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionarPrestamos.aspx.cs" Inherits="Vistas_GestionarPrestamos" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Gestión de Préstamos</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Gestión de Préstamos</h2>
        <asp:GridView ID="gridPrestamos" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="IdPrestamo" HeaderText="ID Préstamo" />
                <asp:BoundField DataField="IdEmpleado" HeaderText="ID Empleado" />
                <asp:BoundField DataField="Monto" HeaderText="Monto" />
                <asp:BoundField DataField="Plazos" HeaderText="Plazos" />
                <asp:BoundField DataField="Interes" HeaderText="Interés" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>

