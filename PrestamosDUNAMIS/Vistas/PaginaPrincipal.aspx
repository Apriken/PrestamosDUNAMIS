<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="PrestamosDUNAMIS.Vistas.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Dumanis S.A</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
   <style>
        .card-custom {
            background-color: #5ac15d;
            color: white;
        }
        .card-custom .btn-light {
            background-color: white;
            color: #5ac15d;
        }
        .card-custom .btn-light:hover {
            background-color: #42ab49;
        }
    </style>
</head>

<body>
<header>
    <nav class="navbar p-4" style="background-color: #42ab49;">
        <div class="container-fluid d-flex justify-content-between">
            <div class="mx-auto">
                <a class="navbar-brand text-white">
                    <span class="h1">DUNAMIS S.A.</span>
                </a>
            </div>
            <button class="btn btn-light" onclick="window.location.href='PantallaLogin.aspx';">Salir</button>
        </div>
    </nav>
</header>
 
    <!-- ----- -->
   <div class="container mt-5">
        <h1 class="text-center mb-4">Pantalla Principal</h1>

        <div class="row row-cols-1 row-cols-md-2 row-cols-lg-3 g-4">
            <!-- Cuadro 1: Evaluar Empleado -->
            <div class="col">
                <div class="card card-custom">
                    <div class="card-body">
                        <h5 class="card-title">Evaluar Empleado</h5>
                        <p class="card-text">Accede al formulario para evaluar el desempeño de los empleados.</p>
                        <a href="evaluar_empleado.html" class="btn btn-light" onclick="window.location.href='EvaluacionEmpleado.aspx'; return false;">Ir a Evaluar</a>
                    </div>
                </div>
            </div>

            <!-- Cuadro 2: Evaluar Solicitud de Préstamos -->
            <div class="col">
                <div class="card card-custom">
                    <div class="card-body">
                        <h5 class="card-title">Evaluar Solicitud de Préstamos</h5>
                        <p class="card-text">Revisa y evalúa las solicitudes de préstamo de los empleados.</p>
                        <a href="evaluar_solicitud.html" class="btn btn-light" onclick="window.location.href='EvaluacionSolicitudPrestamo.aspx'; return false;">Ir a Evaluar</a>
                    </div>
                </div>
            </div>

            <!-- Cuadro 3: Gestionar Saldo de Préstamos -->
            <div class="col">
                <div class="card card-custom">
                    <div class="card-body">
                        <h5 class="card-title">Gestionar Saldo de Préstamos</h5>
                        <p class="card-text">Consulta y gestiona los saldos pendientes de los préstamos.</p>
                        <a href="gestionar_saldo.html" class="btn btn-light" onclick="window.location.href='GestionarSaldoPrestamos.aspx'; return false;">Ir a Gestionar</a>
                    </div>
                </div>
            </div>

            <!-- Cuadro 4: Gestionar Interés de Préstamos -->
            <div class="col">
                <div class="card card-custom">
                    <div class="card-body">
                        <h5 class="card-title">Gestionar Interés de Préstamos</h5>
                        <p class="card-text">Controla y ajusta los intereses de los préstamos otorgados.</p>
                        <a href="gestionar_interes.html" class="btn btn-light" onclick="window.location.href='GestionarInteresPrestamos.aspx'; return false;">Ir a Gestionar</a>
                    </div>
                </div>
            </div>

            <!-- Cuadro 4: Capacidad de Pago -->
            <div class="col">
                <div class="card card-custom">
                    <div class="card-body">
                        <h5 class="card-title">Capacidad de Pago</h5>
                        <p class="card-text">Evalua la capacidad de pago de cada empleado tomando en cuenta su salario bruto.</p>
                        <a href="capacidad_pago.html" class="btn btn-light" onclick="window.location.href='CapacidadPago.aspx'; return false;">Ir a Gestionar</a>
                    </div>
                </div>
            </div>      

            <!-- Cuadro 5: Reportes -->
            <div class="col">
                <div class="card card-custom">
                    <div class="card-body">
                        <h5 class="card-title">Reportes</h5>
                        <p class="card-text">Genera y consulta los reportes detallados de la gestión.</p>
                        <a href="reportes.html" class="btn btn-light" onclick="window.location.href='Reportes.aspx'; return false;">Ir a Reportes</a>
                    </div>
                </div>
            </div>

        </div>
    </div>

     <!-- ------------------>
    
      <footer class="bg-light text-dark text-center py-3 mt-5 fixed-bottom bg-body-tertiary">
        <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
