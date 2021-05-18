<?php
include_once 'conexion.php';
?>
<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <!-- <link rel="stylesheet" href="css/stylesr.css">-->
    <link rel="stylesheet" href="css/newdatos.css">
    <title>Registro</title>
</head>
<body>
        
   <!-- <form action="validardatos.php" method="post" class="form-register" onsubmit="return vali();">-->
    <form class="form-register" action="correo_rc.php" method="post">
        <div class="logo">
            <h1>Recuperar Contraseña</h1>
            <h2 class="btn-logo">SCMB</h2>
        </div>
        <div class="contenedor-inputs">
            
            <label for="uname"><b>Correo</b></label>
            <input type="text" name="cusuario" placeholder="Correo electrónico" class="input-100" required>
            
            <input type="submit" value="Enviar" class="btn-enviar" required> 
            
        </div>
    </form>
    <br>    
</body>
</html>