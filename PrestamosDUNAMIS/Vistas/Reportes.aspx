<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="PrestamosDUNAMIS.Vistas.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Dumanis S.A</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
   <style>

        :root {
            --verde-oscuro: #42ab49;
            --text-color: #2F4F4F;
            
        }

        header {
            
            height: 100px;
            background-color:var(--verde-oscuro);
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

        .btn-group .btn {
            min-width: 200px;
            margin-top: 20px; 
        }

        .table-container {
            display: none;
            margin-top: 20px;
        }

        .table-container.active {
            display: block;
        }

        .generate-button-container {
            text-align: center;
            margin-top: 20px;
        }

        .generate-button {
            background-color: var(--verde-oscuro);
            color: white;
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
  <!-- Header -->
<header>
    <nav class="navbar p-4">
        <div class="container-fluid d-flex justify-content-between">
            <div class="mx-auto text-center">
                <!-- Logo DUNAMIS S.A. -->
                <a class="navbar-brand text-white">
                    <span class="h1">DUNAMIS S.A.</span>
                </a>
    </nav>
</header>
    
            <!-- Main-->
        <div class="container">
        <!-- Título -->
        <h1 class="title">Reportes </h1>
        <div >

        </div>
        <!-- Botones de selección -->
        <div class="d-flex flex-wrap justify-content-center button-group">
            <button class="btn btn-custom" onclick="showTable('aprobados')">Préstamos Aprobados</button>
            <button class="btn btn-custom" onclick="showTable('pendientes')">Préstamos Pendientes</button>
            <button class="btn btn-custom" onclick="showTable('evaluados')">Empleados Evaluados</button>
            <button class="btn btn-custom" onclick="showTable('intereses')">Intereses Calculados</button>
        </div>

        <!-- Tablas -->
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
                <tbody>


                </tbody>
            </table>
            <div class="generate-button-container">
                <button class="btn generate-button">Generar Reporte</button>
            </div>
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
                <tbody>
                </tbody>
            </table>
            <div class="generate-button-container">
                <button class="btn generate-button">Generar Reporte</button>
            </div>
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
                <tbody>
                </tbody>
            </table>
            <div class="generate-button-container">
                <button class="btn generate-button">Generar Reporte</button>
            </div>
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
                <tbody>
                    <tr>
                    </tr>
                </tbody>
            </table>
            <div class="generate-button-container">
                <button class="btn generate-button">Generar Reporte</button>
            </div>
        </div>
    </div>

    <script>
        // Función para mostrar la tabla asociada al botón
        function showTable(tableId) {
            const tables = document.querySelectorAll('.table-container');
            tables.forEach(table => {
                table.classList.remove('active');
            });
            const selectedTable = document.getElementById(tableId);
            selectedTable.classList.add('active');
        }
    </script>


 <!-- Footer -->
    
      <footer class="bg-light text-dark text-center py-3 mt-5 fixed-bottom bg-body-tertiary">
        <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
