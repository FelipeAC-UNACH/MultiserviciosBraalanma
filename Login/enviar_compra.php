<?php  

    // Llamando a los campos
    $nombrec = $_POST['nombre'];
    $correo = $_POST['correo'];
    $telefono = $_POST['cel'];
    $direccion = $_POST['direccion'];

    //Datos de Pedido
    $Idproducto=$_POST['Idproducto'];// = $row['IdSilla'];
    $cantidad=$_POST['cantidad'];

    // Datos para el correo
    $destinatario = "ariaxunach@gmail.com";
    $asunto = " SE HA REALIZADO UNA COMPRA";

    $carta = "De: $nombrec \n";
    $carta .= "Correo: $correo \n";
    $carta .= "Telefono: $telefono \n";
    $carta .= "Direccion: $direccion";

    mail($destinatario, $asunto, $carta);

    include_once 'conexion.php';
    $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
    $sqlQuery="Insert into PedidoProducto(Nombrec,Correoc,Telefonoc,Direccionc,Idproducto,Cantidad)Values ('$nombrec','$correo','$telefono','$direccion','$Idproducto','$cantidad')";
    if($resultado=$mysqlConexion->query($sqlQuery))
    {
       header('Location:mensaje_compras.php');
    }
    else
    {
        header("Location:index.php");
    }
?>

    
    