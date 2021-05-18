<!DOCTYPE html>
<html lang="en">
<head>

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <!-- Mis estilos CSS -->
    <link rel="stylesheet" href="../css_index/Stilos.css">

     <!-- SCRIPTS-->
     <link rel="stylesheet" href="../css_contacto/estilos_compra.css">
     <link rel="stylesheet" href="../css_contacto/font-awesome.css">
 
     <script src="../jscript/jquery-3.2.1.js"></script>
     <script src="../jscript/script.js"></script>
     
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Pedido Productos</title>
</head>
<body>
    <header class="header">
        <h1 class="titulo text-center my-4">Multiservicios<span>Braalanma</span></h1> 
        <div class="login-box">
            <img class="ilogin" src="../Login/img/Logo.png" alt="Logo de "><br>
        </div>
      
          <nav class="navbar navbar-expand-lg navbar-light justify-content-center">
              <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#nav-principal" 
                  aria-label="NavegacionPrincipal">
                <span class="navbar-toggler-icon"></span>
              </button>
              <div id="nav-principal" class="collapse navbar-collapse">
                  <nav class="navegacion-principal nav justify-content-between container
                  flex-column flex-lg-row text-center">
                      <a href="../Login/index.php" class="nav-link">Regresar</a>
                  </nav>
              </div>
          </nav>  
        </header> <br>
        <h1 class="titulo text-center my-4"> </h1>

        <section class="form_wrap">
          <?php
            $id=$_REQUEST['id'];
            include_once 'conexion.php';
            $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
            $sqlQuery="SELECT * FROM  Producto WHERE Idproducto='$id'";
            $resultado=$mysqlConexion->query($sqlQuery);
            $row=$resultado->fetch_assoc();

          ?>
          <img src="<?php  echo $row["images"];?>" class="nosotros_info2">
          <form action = "enviar_compra.php"  method="POST" class="form_contact">
              <h2> Detalles de tu Pedido</h2>
              <label for="names" >ID Producto</label>

                  <input type="text" name="Idproducto" readonly ="readonly"placeholder="Producto"  value="<?php echo $row['Idproducto']; ?>"> 
  
                  <label for="names" >Nombre</label>
                  <input type="text" name="Nombrep" readonly ="readonly"placeholder="Nombre"  value="<?php echo $row['Nombrep'];?>"> 
                
                  <label for="names" >Precio</label>
                  <input type="text" name="Precio" readonly ="readonly"placeholder="Precio"  value="<?php echo $row['Precio'];?>"> 
  
                  <label for="numero">Cantidad</label>
                  <input type="text" id="cantidad" name="cantidad" required>


                  <center><h5> Ingresa tus datos para poder mandarte tu compra</h5></center >
                  <div class="user_info">
                  <label for="names" >Nombres *</label>
                  <input type="text" id="names" name="nombre" required>
  
                 <label for="names" >Telefono / Celular</label>
                  <input type="text" id="names" name="cel" required>
  
                  <label for="email">Correo electronico *</label>
                  <input type="text" id="email" name="correo" required>
  
                  <label for="mensaje"> Direccion/Domicilio</label>
                  <textarea id="mensaje" name="direccion" required></textarea>
  
                  <input type="submit" value="Comprar" id="btnSend">
              </div>
          </form>
      </section>
</body>

  <footer class="container-fluid footer text-center pt-4 pb-4">
    <p class="copy"> &copy; 2021 Braalanma | Todos los derechos reservados</p>
  </footer>

<!-- Optional JavaScript -->
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</html>