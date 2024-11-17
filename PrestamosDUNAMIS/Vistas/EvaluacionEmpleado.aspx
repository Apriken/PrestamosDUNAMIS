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
        <form>
            <!-- Campos de evaluación -->
            <div class="mb-3">
                <label for="idEvaluacion" class="form-label">Id Evaluación</label>
                <input type="text" class="form-control" id="idEvaluacion" placeholder="Ingrese el ID de evaluación">
            </div>

            <div class="mb-3">
                <label for="nombreEmpleado" class="form-label">Nombre del Empleado</label>
                <input type="text" class="form-control" id="nombreEmpleado" placeholder="Ingrese el nombre del empleado">
            </div>

            <div class="mb-3">
                <label for="idEmpleado" class="form-label">Id Empleado</label>
                <input type="text" class="form-control" id="idEmpleado" placeholder="Ingrese el ID del empleado">
            </div>

            <div class="mb-3">
                <label for="fechaEvaluacion" class="form-label">Fecha de Evaluación</label>
                <input type="date" class="form-control" id="fechaEvaluacion">
            </div>

            <div class="mb-3">
                <label for="rendimiento" class="form-label">Rendimiento</label>
                <input type="text" class="form-control" id="rendimiento" placeholder="Ingrese el rendimiento del empleado">
            </div>

            <!-- Título de Criterios centrado -->
            <h2 class="text-center mt-4 mb-3">Criterios</h2>

            <!-- Criterios -->
            <div class="mb-3">
                <label for="puntualidad" class="form-label">Puntualidad</label>
                <input type="number" class="form-control" id="puntualidad" placeholder="Calificación de puntualidad (1-10)">
            </div>

            <div class="mb-3">
                <label for="produccion" class="form-label">Producción</label>
                <input type="number" class="form-control" id="produccion" placeholder="Calificación de producción (1-10)">
            </div>

            <div class="mb-3">
                <label for="orden" class="form-label">Orden</label>
                <input type="number" class="form-control" id="orden" placeholder="Calificación de orden (1-10)">
            </div>

            <!-- Botón para enviar el formulario -->
            <button type="submit" class="btn btn-primary">Enviar Evaluación</button>
        </form>
    </div>


      <footer class="bg-light text-dark text-center py-3 mt-5">
        <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
