﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CapacidadPago.aspx.cs" Inherits="PrestamosDUNAMIS.CapacidadPago" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Capacidad de Pago - DUNAMIS S.A.</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <style>
        body {
            background: #f4fdf4;
            font-family: Arial, sans-serif;
        }
        header {
            background-color: #42ab49;
            color: white;
            padding: 2rem 0;
            text-align: center;
        }
        header h1 {
            margin: 0;
            font-size: 2.5rem;
            font-weight: bold;
        }
        header h2 {
            margin: 0;
            font-size: 1.5rem;
            font-weight: 300;
        }
        .container {
            max-width: 600px;
            margin: 2rem auto;
            background: white;
            padding: 2rem;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
        }
        .form-group label {
            font-weight: bold;
            color: #5ac15d;
        }
        .form-group input {
            background: #c7f1c2;
            border: 1px solid #a3b18a;
            border-radius: 5px;
            transition: all 0.3s ease;
        }
        .form-group input:focus {
            outline: none;
            border-color: #5ac15d;
            box-shadow: 0 0 5px #5ac15d;
        }
        .button {
            background: #5ac15d;
            color: white;
            font-weight: bold;
            border: none;
            border-radius: 5px;
            padding: 0.8rem;
            cursor: pointer;
            transition: background 0.3s ease;
        }
        .button:hover {
            background: #42ab49;
        }
        .result {
            margin-top: 1.5rem;
            padding: 1rem;
            background: #f4fdf4;
            border-left: 5px solid #42ab49;
            border-radius: 5px;
        }
        .progress {
            height: 20px;
            background: #e9ecef;
            border-radius: 10px;
            overflow: hidden;
        }
        .progress-bar {
            background: #5ac15d;
            height: 100%;
            line-height: 20px;
            text-align: center;
            color: white;
        }
        footer {
            background-color: #f8f9fa;
            color: #333;
        }
    </style>
</head>
<body>
    <header>
        <h1>DUNAMIS S.A.</h1>
        <h2>Capacidad de Pago</h2>
        <a class="btn btn-light" style="position: absolute; right: 20px;" href="PaginaPrincipal.aspx">
    Volver al menú principal
</a>

    </header>

    <main>
        <div class="container">
            <form id="CapacidadPagoForm" runat="server">
                <div class="form-group mb-3">
                    <label for="SalarioBrutoInput">Salario Bruto:</label>
                    <asp:TextBox ID="SalarioBrutoInput" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
                <div class="form-group mb-3">
                    <label for="DeduccionesInput">Deducciones:</label>
                    <asp:TextBox ID="DeduccionesInput" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
                <asp:Button ID="CalcularCapacidadPago" runat="server" Text="Calcular" CssClass="button w-100" OnClick="CalcularCapacidadPago_Click" />
            </form>
            <asp:Panel ID="ResultadosPanel" runat="server" CssClass="result mt-4" Visible="false">
                <p><strong>Cargas Sociales:</strong> <asp:Label ID="CargasSocialesLabel" runat="server" /></p>
                <p><strong>Rebajo por Deducciones:</strong> <asp:Label ID="DeduccionesRebajoLabel" runat="server" /></p>
                <p><strong>Salario Neto:</strong> <asp:Label ID="SalarioNetoLabel" runat="server" /></p>
                <p><strong>Capacidad de Pago:</strong> <asp:Label ID="CapacidadPagoLabel" runat="server" /></p>
                <div class="progress mt-3">
                    <div id="ProgressBar" class="progress-bar" role="progressbar" style="width: 0%;" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100">0%</div>
                </div>
            </asp:Panel>
        </div>
    </main>
    <footer class="text-center py-3 mt-5">
        <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
    </footer>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+AMxrHkqF4aQ0wPCpJ7euNsFZ6p6k" crossorigin="anonymous"></script>
    <script>
        // Controla la barra de progreso (puede ser manejada desde el servidor también)
        function actualizarProgreso(valor) {
            const progressBar = document.getElementById("ProgressBar");
            progressBar.style.width = valor + "%";
            progressBar.textContent = valor + "%";
        }
    </script>
</body>
</html>