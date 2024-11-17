<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaLogin.aspx.cs" Inherits="PrestamosDUNAMIS.Vistas.PantallaLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 

     <title>Login - DUNAMIS S.A.</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <style>
        body {
            background-color: #f8f9fa;
        }
        .login-container {
            max-width: 400px;
            margin: 50px auto;
            padding: 30px;
            background-color: #ffffff;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
        .login-container h3 {
            text-align: center;
            margin-bottom: 20px;
        }
        .btn-custom {
            width: 100%;
            background-color: #42ab49;
            color: white;
            border: none;
        }
        .btn-custom:hover {
            background-color: #3a9d43;
        }
    </style>
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

        
<!-- Formulario de Login -->
<div class="container mt-5">
    <div class="row justify-content-center">
        <div class="col-md-6">
            <div class="card p-4" style="border-radius: 10px; box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.1);">
                <div class="card-body">
                    
                    <h5 class="text-center mb-4">Sistema Gestión de Préstamos</h5>

                    <!-- Formulario de Login -->
                    <form runat="server">
                        <!-- Campo Usuario -->
                        <div class="mb-3">
                            <label for="usuario" class="form-label">Usuario</label>
                            <input type="text" class="form-control form-control-lg" id="txt_correo" placeholder="Ingresa tu correo" runat="server">
                        </div>
                        
                        <!-- Campo Contraseña -->
                        <div class="mb-3">
                            <label for="contrasena" class="form-label">Contraseña</label>
                            <input type="password" class="form-control form-control-lg" id="txt_contrasena" placeholder="Ingresa tu contraseña" runat="server">
                        </div>
                        
                        <!-- Botón Ingresar -->
                        <asp:Button class="btn btn-custom btn-lg w-100" ID="btn_Login" runat="server" Text="Ingresar" OnClick="btn_Login_Click"/>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
    
      <footer class="bg-light text-dark text-center py-3 mt-5 fixed-bottom bg-body-tertiary">
        <p class="mb-0">2024 DUNAMIS S.A. Todos los derechos reservados</p>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
