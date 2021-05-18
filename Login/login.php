<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="../Login/css/styleslogin.css">
    <title>Login</title>
</head>
<body>
    <div class="login-box">
        <img class="ilogin" src="../Login/img/Logo.png" alt="Logo de VisuaLook">
            <h1>Inicia sesión en "SCMB"</h1>
        <form action="validar.php" method="POST">
            <label for="uname"><b>Correo/Usuario</b></label>
            <input type="text" placeholder="correo/usuario" name="correo" required>
            <br>
            <label for="uname"><b>Contraseña</b></label>
            <input type="password" placeholder="Contraseña" name="password"  required> 
            <br>
            <input type="submit" value="Iniciar sesión">
            <br>
            <a href="Recup_Pass.php">¿Olvidaste tu cuenta?</a><br><br>
            <center><a href="index.php">Ir a inicio</a><br><br></center>
        </form>
    </div>
</body>
</html>