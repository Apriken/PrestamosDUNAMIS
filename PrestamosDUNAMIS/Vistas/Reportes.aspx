<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="PrestamosDUNAMIS.Vistas.Reportes" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Dunamis S.A</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
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

        .table-container {
            display: none;
            margin-top: 20px;
        }

        .table-container.active {
            display: block;
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
                <div class="container-fluid d-flex justify-content-between">
                    <div class="mx-auto text-center">
                        <a class="navbar-brand text-white">
                            <span class="h1">DUNAMIS S.A.</span>
                        </a>
                    </div>
                </div>
            </nav>
        </header>

        <div class="container">
            <h1 class="title">Reportes</h1>

            <div class="d-flex flex-wrap justify-content-center button-group">
                <button type="button" class="btn btn-custom" onclick="postBack('aprobados')">Préstamos Aprobados</button>
                <button type="button" class="btn btn-custom" onclick="postBack('pendientes')">Préstamos Pendientes</button>
                <button type="button" class="btn btn-custom" onclick="postBack('evaluados')">Empleados Evaluados</button>
                <button type="button" class="btn btn-custom" onclick="postBack('intereses')">Intereses Calculados</button>
            </div>

            <!-- Campo oculto para el tipo de reporte -->
            <input type="hidden" id="hfReportType" name="hfReportType" />
            <asp:Button ID="btnPostBack" runat="server" Style="display:none;" />

            <!-- Contenedores de tablas -->
            <div id="aprobados" class="table-container">
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>ID Préstamo</th>
                            <th>Nombre</th>
                            <th>Monto</th>
                            <th>Fecha de Aprobación</th>
                        </tr>
                    </thead>
                    <tbody id="tableAprobados"></tbody>
                </table>
            </div>

            <div id="pendientes" class="table-container">
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>ID Préstamo</th>
                            <th>Nombre</th>
                            <th>Monto</th>
                            <th>Estado</th>
                        </tr>
                    </thead>
                    <tbody id="tablePendientes"></tbody>
                </table>
            </div>

            <div id="evaluados" class="table-container">
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>ID Empleado</th>
                            <th>Nombre</th>
                            <th>Resultado Evaluación</th>
                            <th>Fecha</th>
                        </tr>
                    </thead>
                    <tbody id="tableEvaluados"></tbody>
                </table>
            </div>

            <div id="intereses" class="table-container">
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>ID Préstamo</th>
                            <th>Nombre</th>
                            <th>Interés Calculado</th>
                            <th>Fecha</th>
                        </tr>
                    </thead>
                    <tbody id="tableIntereses"></tbody>
                </table>
            </div>
        </div>

        <footer class="bg-light text-dark text-center py-3 mt-5 fixed-bottom">
            <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
        </footer>

        <script>
            function postBack(reportType) {
                document.getElementById('hfReportType').value = reportType;
                document.getElementById('<%= btnPostBack.ClientID %>').click();
            }
        </script>
    </form>
</body>

</html>