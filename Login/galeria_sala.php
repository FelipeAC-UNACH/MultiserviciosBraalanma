<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <!-- Mis estilos CSS -->
    <link rel="stylesheet" href="../css_index/Stilos.css">
    <title>Salas</title>
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
                  <a href="../Login/galeria_productos.php" class="nav-link "> Regresar</a>
              </nav>
          </div>
      </nav>  
    </header> 
    
    <div class="container productos  mt-4">
        <h2 class="text-center">Multiservicios Braalanma Le ofrece una variedad de Salas</h2>
        <div class="row mt-4">
          <div class="col-md-6 mb-4 mb-md-0">
            <div class="info-producto bg-primary text-center text-light">
            <?php
                include_once 'conexion.php';
                $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
                $sqlQuery="SELECT * FROM Producto WHERE Idproducto='11' ";
                $resultado=$mysqlConexion->query($sqlQuery);
                while ($row=$resultado->fetch_assoc()){
              ?>
              <img src="<?php  echo $row["images"];?>" class="img-fluid">
              <h3 class="text-center mb-2"><?php  echo $row["Nombrep"];?> </h3>
              <p>$ <?php  echo $row["Precio"];?></p>
              <p class="recio font-weight-bold"> </p>
              <a class="btn btn-success mb-2 btn-lg text-uppercase font-weight-bold" href="compra_p.php?id=<?php echo $row['Idproducto']; ?>"> Lo Quiero </a>
              <?php
                }
              ?>	
            </div>
          </div>

          <div class="col-md-6 mb-4 mb-md-0">
            <div class="info-producto bg-primary text-center text-light">
            <?php
                include_once 'conexion.php';
                $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
                $sqlQuery="SELECT * FROM Producto WHERE Idproducto='12' ";
                $resultado=$mysqlConexion->query($sqlQuery);
                while ($row=$resultado->fetch_assoc()){
              ?>
              <img src="<?php  echo $row["images"];?>" class="img-fluid">
              <h3 class="text-center mb-2"> $<?php  echo $row["Nombrep"];?> </h3>
              <p>$ <?php  echo $row["Precio"];?></p>
              <p class="recio font-weight-bold">  </p>
              <a class="btn btn-success mb-2 btn-lg text-uppercase font-weight-bold" href="compra_p.php?id=<?php echo $row['Idproducto']; ?>"> Lo Quiero </a>

              <?php
                }
              ?>	
            </div>
          </div>

        </div>

        <div class="row mt-4 justify-content-center">
          <div class="col-md-6 col-lg-4 mb-4 mb-md-4">
            <div class="info-producto bg-primary text-center text-light">
            <?php
                include_once 'conexion.php';
                $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
                $sqlQuery="SELECT * FROM Producto WHERE Idproducto='13' ";
                $resultado=$mysqlConexion->query($sqlQuery);
                while ($row=$resultado->fetch_assoc()){
              ?>
              <img src="<?php  echo $row["images"];?>" class="img-fluid">
              <h3 class="text-center mb-2"><?php  echo $row["Nombrep"];?> </h3>
              <p>$ <?php  echo $row["Precio"];?></p>
              <a class="btn btn-success mb-2 btn-lg text-uppercase font-weight-bold" href="compra_p.php?id=<?php echo $row['Idproducto']; ?>"> Lo Quiero </a>
              <?php
                }
              ?>	
            </div>
          </div>

          <div class="col-md-6 col-lg-4 mb-4 mb-md-4">
            <div class="info-producto bg-primary text-center text-light">
            <?php
                include_once 'conexion.php';
                $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
                $sqlQuery="SELECT * FROM Producto WHERE Idproducto='14' ";
                $resultado=$mysqlConexion->query($sqlQuery);
                while ($row=$resultado->fetch_assoc()){
              ?>
              <img src="<?php  echo $row["images"];?>" class="img-fluid">
              <h3 class="text-center mb-2"><?php  echo $row["Nombrep"];?> </h3>
              <p>$ <?php  echo $row["Precio"];?></p>
              <a  class="btn btn-success mb-2 btn-lg text-uppercase font-weight-bold" href="compra_p.php?id=<?php echo $row['Idproducto']; ?>"> Lo Quiero </a>
              <?php
                }
              ?>	
            </div>
          </div>
          
          <div class="col-md-6 col-lg-4 mb-4 mb-md-4">
            <div class="info-producto bg-primary text-center text-light">
            <?php
                include_once 'conexion.php';
                $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
                $sqlQuery="SELECT * FROM Producto WHERE Idproducto='15' ";
                $resultado=$mysqlConexion->query($sqlQuery);
                while ($row=$resultado->fetch_assoc()){
              ?>
              <img src="<?php  echo $row["images"];?>" class="img-fluid">
              <h3 class="text-center mb-2"><?php  echo $row["Nombrep"];?> </h3>
              <p>$ <?php  echo $row["Precio"];?></p>
              <a  class="btn btn-success mb-2 btn-lg text-uppercase font-weight-bold" href="compra_p.php?id=<?php echo $row['Idproducto']; ?>"> Lo Quiero </a>
              <?php
                }
              ?>	
            </div>
          </div>
    </div>

    <footer class="container-fluid footer text-center pt-4 pb-4">
      <p class="copy"> &copy; 2021 Braalanma | Todos los derechos reservados</p>
    </footer>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>