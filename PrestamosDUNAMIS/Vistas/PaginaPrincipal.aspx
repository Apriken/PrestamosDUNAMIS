<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="PrestamosDUNAMIS.Vistas.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Dumanis S.A</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
   <style>
        body {
            margin: 0;
            display: flex;
            flex-direction: column;
            height: 100vh;
        }

        header {
            
            height: 100px;
            background-color: #42ab49;
            
        }

        .main-container {
            display: flex;
            flex: 1;
            overflow: auto;
  
        }

        .sidebar {
            width: 250px;
            background-color: #5ac15d;
            color: white;
            padding: 20px;
            position: fixed;
            top: 100px;
            bottom: 50px;
            overflow-y: auto;
         
            
        }

        .sidebar h2 {
            text-align: center;
        }

        .content {
           margin-left: 250px;
            padding: 0;
            flex: 1;
            background-color: #f8f9fa;
            position: relative;
            overflow: hidden;
           
        }
        .content img {
            width: 100%;
            height: 100%;
            object-fit: cover; 
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
                <!-- Enlace Acerca de o -->
                <div class="mt-1">
                    <a href="AcercaDe.aspx" class="text-white" style="font-size: 16px;">Acerca de</a>
                </div>
            </div>
            <button class="btn btn-light" onclick="window.location.href='PantallaLogin.aspx';">Salir</button>
        </div>
    </nav>
</header>

 
   <!-- Contenedor Principal -->
    <div class="main-container">
        <!-- Menú Lateral -->
        <div class="sidebar">
            <h2>Menú</h2>
            <ul class="nav flex-column">
    <li class="nav-item" id="liEvaluacionSolicitud" runat="server">
        <a href="EvaluacionSolicitudPrestamo.aspx" class="nav-link text-white">
            Gestionar Evaluación de Solicitudes de Préstamos
        </a>
    </li>
    <li class="nav-item" id="liEvaluacionEmpleado" runat="server">
        <a href="EvaluacionEmpleado.aspx" class="nav-link text-white">
            Consulta de Evaluación Empleado
        </a>
    </li>
    <li class="nav-item" id="liCapacidadPago" runat="server">
        <a href="CapacidadPago.aspx" class="nav-link text-white">
            Evaluar Capacidad de Pago
        </a>
    </li>
    <li class="nav-item" id="liGestionarSaldo" runat="server">
        <a href="GestionarSaldoPrestamos.aspx" class="nav-link text-white">
            Gestionar Saldos de Préstamos
        </a>
    </li>
    <li class="nav-item" id="liGestionarInteres" runat="server">
        <a href="GestionarInteresPrestamos.aspx" class="nav-link text-white">
            Gestionar Cobro de Intereses
        </a>
    </li>
    <li class="nav-item" id="liReportes" runat="server">
        <a href="Reportes.aspx" class="nav-link text-white">Reportes</a>
    </li>
</ul>
        </div>

              <!-- Contenido Principal -->
        <div class="content">
            <!-- Imagen en el espacio blanco -->
            <img src="Recursos/clinica.jpg" alt="Imagen principal" class="img-fluid" >
        </div>
    </div>


 <!-- Footer -->
    
      <footer class="bg-light text-dark text-center py-3 mt-5 fixed-bottom bg-body-tertiary">
        <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
