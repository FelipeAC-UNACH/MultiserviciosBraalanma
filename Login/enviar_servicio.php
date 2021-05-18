<?php  

    // Llamando a los campos
    $nombrec = $_POST['nombrec'];
    $correo = $_POST['correo'];
    $telefono = $_POST['cel'];
    $direccion = $_POST['direccion'];

    //Datos de Pedido
    $Idservicio=$_POST['Idservicio'];

    // Datos para el correo
    $destinatario = "ariaxunach@gmail.com";
    $asunto = " SE HA REALIZADO UNA COMPRA";

    $carta = "De: $nombre \n";
    $carta .= "Correo: $correo \n";
    $carta .= "Telefono: $telefono \n";
    $carta .= "Direccion: $direccion";

    mail($destinatario, $asunto, $carta);

    include_once 'conexion.php';
    $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
    $sqlQuery="Insert into PedidoServicio(Nombrec,Correoc,Telefonoc,Direccionc,Idservicio)Values ('$nombrec','$correo','$telefono','$direccion','$Idservicio')";
    if($resultado=$mysqlConexion->query($sqlQuery))
    {
       header('Location:mensaje_comprass.php');
    }
    else
    {
        header("Location:index.php");
    }
?>