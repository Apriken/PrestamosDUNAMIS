<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionarPrestamos.aspx.cs" Inherits="Vistas_GestionarPrestamos" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Gesti�n de Pr�stamos</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Gesti�n de Pr�stamos</h2>
        <asp:GridView ID="gridPrestamos" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="IdPrestamo" HeaderText="ID Pr�stamo" />
                <asp:BoundField DataField="IdEmpleado" HeaderText="ID Empleado" />
                <asp:BoundField DataField="Monto" HeaderText="Monto" />
                <asp:BoundField DataField="Plazos" HeaderText="Plazos" />
                <asp:BoundField DataField="Interes" HeaderText="Inter�s" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>

