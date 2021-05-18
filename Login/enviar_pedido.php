<?php  
   // Llamando a los campos
   $nombrec = $_POST['nombre'];
   $correo = $_POST['correo'];
   $telefono = $_POST['cel'];
   $direccion = $_POST['direccion'];

   $Idproducto=$_POST['Idproducto'];// = $row['IdSilla'];
   $cantidad=$_POST['cantidad'];

    include_once 'conexion.php';
    $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
    $sqlQuery="Insert into Pedido(Nombrec,Correoc,Telefonoc,Direccionc,Idproducto,Nombrep,Precio,Cantidad)Values ('$nombrec','$correo','$telefono','$direccion','$Idproducto','$cantidad')";
    if($resultado=$mysqlConexion->query($sqlQuery))
    {
       // header("Location:index.php");
    }
    else
    {
         /*header("Location:login.php");*/
       // echo $resultado;
    }
?>