<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvaluacionEmpleado.aspx.cs" Inherits="PrestamosDUNAMIS.Vistas.EvaluacionEmpleado" %>

<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Dumanis S.A</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
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
        <!-- Título principal centrado -->
        <h1 class="text-center mb-4">Evaluación Empleado</h1>

        <!-- Formulario de evaluación -->
        <form runat="server">
          
            <div class="mb-3">
                <asp:DropDownList ID="ddlEmpleado" class="form-label" runat="server" OnSelectedIndexChanged="ddlEmpleado_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <!-- --------------- -->
            <div class="mb-3">
                <label for="fechaEvaluacion" class="form-label">Seleccione una fecha de evaluacion</label>
                <asp:DropDownList ID="ddlEvaluacionFecha" class="form-label" runat="server"  OnSelectedIndexChanged="ddlEvaluacionFecha_SelectedIndexChanged" ></asp:DropDownList>
            </div>


            <!-- Título de Criterios centrado -->
            <h2 class="text-center mt-4 mb-3">Criterios</h2>

            <!-- Criterios -->
            <div class="mb-3">
                <label for="rendimiento" class="form-label">Rendimiento</label>
                <input type="number" class="form-control" id="txt_rendimiento"  runat="server" min="0" max="25" readonly>
            </div>
            
            <div class="mb-3">
                <label for="puntualidad" class="form-label">Puntualidad</label>
                <input type="number" class="form-control" id="txt_puntualidad"  runat="server" min="0" max="25" readonly>
            </div>

            <div class="mb-3">
                <label for="produccion" class="form-label">Producción</label>
                <input type="number" class="form-control" id="txt_produccion" runat="server" min="0" max="25" readonly>
            </div>

            <div class="mb-3">
                <label for="orden" class="form-label">Orden</label>
                <input type="number" class="form-control" id="txt_orden"  runat="server" min="0" max="25" readonly>
            </div>

        </form>
    </div>


    <footer class="bg-light text-dark text-center py-3 mt-5">
        <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
