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
        --pastel-green: #c7f1c2;
        --blanco: #ffffff;
        --verde-oscuro: #42ab49;
        --text-color: #2F4F4F;
    }

    html, body {
        height: 100%;
        margin: 0;
        padding: 0;
        font-family: 'Arial', sans-serif;
    }

    body {
        display: flex;
        flex-direction: column;
        background-color: var(--blanco);
        color: var(--text-color);
    }

    .container {
        flex-grow: 1;
        display: flex;
        flex-direction: column;

    }
      header {
            
            height: 100px;
            background-color: var(--verde-oscuro);
            color: white;
            flex-shrink: 0;
        }

    .section-title {
        font-size: 2rem;
        font-weight: bold;
        color: var(--verde-oscuro);
        text-align: center;
    }

    .section-content {
        line-height: 1.6;
        color: var(--text-color);
        background-color: var(--pastel-green);
        padding: 1em;
        border-radius: 10px;
        text-align: justify;

    }

    footer {
        background-color: var(--blanco);
        text-align: center;
        color: var(--text-color);
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
        </div>
    </nav>
</header>


        <!-- Main Content -->
    <div class="container my-5">
        <!-- Quiénes somos -->
        <div class="row mb-5">
            <div class="col-12">
                <div class="section-title">¿Quiénes somos?</div>
                <div class="section-content">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum..</p>
                </div>
            </div>
        </div>

        <!-- Visión y Misión -->
        <div class="row mb-5">
            <div class="col-12 col-md-6">
                <div class="section-title">Visión</div>
                <div class="section-content">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum..</p>
                </div>
            </div>
            <div class="col-12 col-md-6">
                <div class="section-title">Misión</div>
                <div class="section-content">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                </div>
            </div>
        </div>

        <!-- Empresa Desarrolladora -->
        <div class="row">
            <div class="col-12">
                <div class="section-title">Empresa Desarrolladora: SoftCare</div>
                <div class="section-content">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum..</p>
                </div>
            </div>
        </div>
    </div>

    <!-- Footer -->
    <footer>
        <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>

